using Core.DTO;
using DevExpress.XtraCharts.Design;
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
    public partial class XtraForm7 : DevExpress.XtraEditors.XtraForm
    {

        private readonly HttpClient _httpClient = new HttpClient
        {
            BaseAddress = new Uri("https://localhost:7006/api/") 
        };

        public XtraForm7()
        {
            InitializeComponent();


        }

        private async void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void XtraForm7_Load(object sender, EventArgs e)
        {
            timeEdit1.Properties.Mask.EditMask = "HH:mm";

            dateTimePicker1.MinDate = DateTime.Today;

            dateTimePicker1.Value = DateTime.Today;


            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync("DoktorKayit");
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    var doktorlar = JsonConvert.DeserializeObject<List<DoktorKayitDto>>(json);

                    comboBox1.DisplayMember = "Ad";
                    comboBox1.ValueMember = "HekimId";
                    comboBox1.DataSource = doktorlar;
                }
                else
                {
                    MessageBox.Show("Doktor listesi yüklenemedi.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }
        private async void simpleButton1_Click(object sender, EventArgs e)
        {


            {

                var seciliDoktor = comboBox1.SelectedItem as DoktorKayitDto;



                var kayit = new MhrsKayitDto

                {

                    Ad = textBox1.Text,

                    Soyad = textBox2.Text,

                    Tc = textBox6.Text,

                    Tarih = dateTimePicker1.Value.Date,

                    Saat = ((DateTime)timeEdit1.EditValue).TimeOfDay,

                    HekimId = seciliDoktor.HekimId,

                    Hekim = textBox3.Text





                };

                var json = JsonConvert.SerializeObject(kayit);
                MessageBox.Show(json);

                var content = new StringContent(json, Encoding.UTF8, "application/json");

                try
                {
                    HttpResponseMessage response = await _httpClient.PostAsync("MhrsKayit", content);
                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Kayıtlı kişi başarıyla eklendi.");
                    }
                    else
                    {
                        var errorContent = await response.Content.ReadAsStringAsync();
                        MessageBox.Show("Kayıt eklenemedi.\n" + response.StatusCode + "\n" + errorContent);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata oluştu: " + ex.Message);
                }
            }
        }
        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelControl7_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem is DoktorKayitDto selectedDoktor)
            {
                textBox3.Text = selectedDoktor.Ad + " " + selectedDoktor.Soyad;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}