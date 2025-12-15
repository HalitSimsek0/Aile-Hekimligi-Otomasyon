using Core.DTO;
using DevExpress.XtraEditors;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class XtraForm4 : XtraForm
    {
        private readonly HttpClient _httpClient = new HttpClient
        {
            BaseAddress = new Uri("https://localhost:7006/api/") 
        };
        private readonly int _hekimId;
        public XtraForm4()
        {
            InitializeComponent();

        }
        public XtraForm4(int hekimId)
        {
            InitializeComponent();
            _hekimId = hekimId;

        }


        private async void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                var response = await _httpClient.GetAsync($"KabulListe/doktor/{_hekimId}");
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    var liste = JsonConvert.DeserializeObject<List<KabulListeDto>>(json);

                    dataGridView1.DataSource = liste;
                    dataGridView1.AutoGenerateColumns = true;
                }
                else
                {
                    MessageBox.Show("Liste alınamadı.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }
        private void simpleButton3_Click(object sender, EventArgs e)
        {
            var form1 = new XtraForm1();
            form1.Show();
            this.Hide();
        }

        private async void simpleButton2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                if (!row.IsNewRow) 
                {
                    row.Cells["TamamlanmaDurumu"].Value = "Tamamlandı";
                }
            }

            MessageBox.Show("Tamamlandı");


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e) { }

        private void windowsuıButtonPanel1_Click(object sender, EventArgs e) { }

        private void XtraForm4_Load(object sender, EventArgs e)
        {
            simpleButton1.PerformClick();

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {



        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}

