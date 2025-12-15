using Core.DTO;
using DevExpress.CodeParser;
using DevExpress.XtraEditors;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
namespace UI
{
    public partial class XtraForm1 : DevExpress.XtraEditors.XtraForm

    {
        private readonly HttpClient _httpClient = new HttpClient
        {
            BaseAddress = new Uri("https://localhost:7006/api/")

        };



        public XtraForm1()
        {
            InitializeComponent();




        }
        private void Grid_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {

            if (e.Column.DataPropertyName == "HekimId"
                 || e.Column.DataPropertyName == "CinsiyetId")
            {
                e.Column.Visible = false;
            }
            if (e.Column.DataPropertyName == "HekimId"
                 || e.Column.DataPropertyName == "CinsiyetId"
                 || (sender == dataGridView2 && e.Column.DataPropertyName == "TamamlanmaDurumu"))
            {
                e.Column.Visible = false;
            }
        }
        private void DataGridView2_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            if (e.Column.DataPropertyName == "HekimId"
          || e.Column.DataPropertyName == "OncelikliMi"
          || e.Column.DataPropertyName == "TamamlanmaDurumu")
            {
                e.Column.Visible = false;
            }
        }
        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void XtraForm1_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            await YukleKayitliKisiListe();
            await YukleMhrsKayit();
            await YukleKabulListe();
            await YukleDoktorKabulDurumu();
            await YukleDoktorKayit();
            await YukleMisafirListe();
            await YukleKabulListe();
        }

        private async Task YukleKayitliKisiListe()
        {
            try
            {
                var response = await _httpClient.GetAsync("KayitliKisiListe");
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    var data = JsonConvert.DeserializeObject<List<KayitliKisiListeDto>>(json);


                    dataGridView1.DataSource = data;
                    dataGridView1.AutoGenerateColumns = true;
                    dataGridView1.Columns["HekimId"].Visible = false;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("KayitliKisiListe yüklenemedi: " + ex.Message);
            }
        }
        private async Task YukleDoktorKayit()
        {
            try
            {
                var response = await _httpClient.GetAsync("DoktorKayit");
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    var data = JsonConvert.DeserializeObject<List<DoktorKayitDto>>(json);
                    dataGridView4.DataSource = data;
                    dataGridView4.AutoGenerateColumns = true;
                    dataGridView2.AutoGenerateColumns = true;
                    dataGridView2.DataSource = data;
                    if (dataGridView2.Columns.Contains("CinsiyetId"))
                        dataGridView2.Columns["CinsiyetId"].Visible = false;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("DoktorKabulDurumu yüklenemedi: " + ex.Message);
            }
        }

        private async Task YukleDoktorKabulDurumu()
        {
            try
            {
                var response = await _httpClient.GetAsync("DoktorKabulDurumu");
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    var data = JsonConvert.DeserializeObject<List<DoktorKabulDurumuDto>>(json);
                    dataGridView4.DataSource = data;
                    dataGridView4.AutoGenerateColumns = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("DoktorKabulDurumu yüklenemedi: " + ex.Message);
            }
        }

        private async Task YukleMhrsKayit()
        {
            try
            {
                var response = await _httpClient.GetAsync("MhrsKayit");
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    var data = JsonConvert.DeserializeObject<List<MhrsKayitDto>>(json);
                    dataGridView3.DataSource = data;
                    dataGridView3.AutoGenerateColumns = true;
                    dataGridView3.Columns["HekimId"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MhrsKayit yüklenemedi: " + ex.Message);
            }
        }


        private async Task YukleKabulListe()
        {
            try
            {
                var response = await _httpClient.GetAsync("KabulListe");
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    var data = JsonConvert
                        .DeserializeObject<List<KabulListeDto>>(json);


                    var tekil = data
                        .Select((item, idx) => new { item, idx })
                        .GroupBy(x => x.item.Tc)
                        .Select(g => g.OrderBy(x => x.idx).Last())
                        .OrderBy(x => x.idx)
                        .Select(x => x.item)
                        .ToList();

                    dataGridView2.DataSource = tekil;
                    dataGridView2.AutoGenerateColumns = true;
                    if (dataGridView2.Columns.Contains("TamamlanmaDurumu"))
                        dataGridView2.Columns["TamamlanmaDurumu"].Visible = false;
                    if (dataGridView2.Columns.Contains("OncelikliMi"))
                        dataGridView2.Columns["OncelikliMi"].Visible = false;
                    if (dataGridView2.Columns.Contains("HekimId"))
                        dataGridView2.Columns["HekimId"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("KabulListe yüklenemedi: " + ex.Message);
            }
        }
        private async Task YukleMisafirListe()
        {
            try
            {
                var response = await _httpClient.GetAsync("Misafir");
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    var data = JsonConvert.DeserializeObject<List<MisafirDto>>(json);
                    dataGridView5.DataSource = data;
                    dataGridView5.AutoGenerateColumns = true;
                    if (dataGridView5.Columns.Contains("HekimId"))
                        dataGridView5.Columns["HekimId"].Visible = false;


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MisafirListe yüklenemedi: " + ex.Message);
            }
        }




        private void GridleriTemizle()
        {
            dataGridView1.DataSource = null;
            dataGridView2.DataSource = null;
            dataGridView3.DataSource = null;
            dataGridView4.DataSource = null;
            dataGridView5.DataSource = null;

        }



        private void erş_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GridleriTemizle();


        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var form5 = new XtraForm5();
            form5.Show();

        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var form6 = new XtraForm6();
            form6.Show();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var form3 = new XtraForm3();
            form3.Show();
        }



        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var form2 = new XtraForm2();
            form2.Show();
        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var form7 = new XtraForm7();
            form7.Show();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {


        }

        private void labelControl5_Click(object sender, EventArgs e)
        {

        }

        private void labelControl4_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraForm9 form9 = new XtraForm9();
            form9.Show();

        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView4_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}