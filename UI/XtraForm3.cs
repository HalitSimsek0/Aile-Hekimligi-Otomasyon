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
    public partial class XtraForm3 : XtraForm
    {
        private readonly HttpClient _httpClient = new HttpClient
        {
            BaseAddress = new Uri("https://localhost:7006/api/") 
        };

        public XtraForm3()
        {
            InitializeComponent();
        }

        private async void XtraForm3_Load(object sender, EventArgs e)
        {



            dateTimePicker1.MaxDate = DateTime.Today;
      
            dateTimePicker1.Value = DateTime.Today;
            await DoktorlariYukle();


            textBox4.ReadOnly = true;


            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox6.Enabled = false;
            dateTimePicker1.Enabled = false;
            simpleButton2.Enabled = false;
            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
            textBox5.Enabled = false;
        }

        private async Task DoktorlariYukle()
        {
            try
            {
                var response = await _httpClient.GetAsync("DoktorKayit");
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    var doktorListesi = JsonConvert.DeserializeObject<List<DoktorKayitDto>>(json);
                    dataGridView1.DataSource = doktorListesi;
                    dataGridView1.AutoGenerateColumns = true;
                    if (dataGridView1.Columns.Contains("HekimId"))
                        dataGridView1.Columns["HekimId"].Visible = false;
                    if (dataGridView1.Columns.Contains("CinsiyetId"))
                        dataGridView1.Columns["CinsiyetId"].Visible = false;
                }
                else
                {
                    MessageBox.Show("Doktorlar yüklenemedi.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }


        private void simpleButton1_Click(object sender, EventArgs e)
        {

            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            textBox6.Enabled = true;
            dateTimePicker1.Enabled = true;
            simpleButton2.Enabled = true;
            radioButton1.Enabled = true;
            radioButton2.Enabled = true;
            textBox5.Enabled = true;

        }

        private async void simpleButton2_Click(object sender, EventArgs e)
        {
            try
            {
                var tc = textBox1.Text.Trim();
                var tel = textBox6.Text.Trim();

                var resp = await _httpClient.GetAsync("DoktorKayit");
                if (resp.IsSuccessStatusCode)
                {
                    var mevcut = JsonConvert
                        .DeserializeObject<List<DoktorKayitDto>>(await resp.Content.ReadAsStringAsync());

                    if (mevcut.Any(d => d.Tc == tc))
                    {
                        MessageBox.Show("Bu TC numarası ile zaten bir doktor kaydı yapılmış.");
                        return;
                    }
                    if (mevcut.Any(d => d.Telefon == tel))
                    {
                        MessageBox.Show("Bu telefon numarası ile zaten bir doktor kaydı yapılmış.");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Doktor kayıtları kontrol edilirken hata oluştu: " + resp.StatusCode);
                    return;
                }

                int cinsiyetId;
                if (radioButton1.Checked)
                    cinsiyetId = 1;
                else if (radioButton2.Checked)
                    cinsiyetId = 2;
                else
                {
                    MessageBox.Show("Lütfen cinsiyet seçiniz.");
                    return;
                }

                var doktor = new DoktorKayitDto
                {
                    Tc = tc,
                    Ad = textBox2.Text,
                    Soyad = textBox3.Text,
                    Dogumtarih = dateTimePicker1.Value,
                    Yas = int.Parse(textBox4.Text),
                    Telefon = tel,
                    Cinsiyet = textBox5.Text,
                    CinsiyetId = cinsiyetId
                };

                var json = JsonConvert.SerializeObject(doktor);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                var result = await _httpClient.PostAsync("DoktorKayit", content);

                if (result.IsSuccessStatusCode)
                {
                    MessageBox.Show("Doktor başarıyla kaydedildi.");
                    await DoktorlariYukle();
                }
                else
                {
                    var responseText = await result.Content.ReadAsStringAsync();
                    MessageBox.Show($"Hata: {result.StatusCode}\n{responseText}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime dogumTarihi = dateTimePicker1.Value;
            DateTime bugun = DateTime.Today;
            int yas = bugun.Year - dogumTarihi.Year;
            if (bugun < dogumTarihi.AddYears(yas))
                yas--;

            textBox4.Text = yas.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) { }
        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e) { }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e) { }
        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e) { }
        private void panelControl4_Paint(object sender, PaintEventArgs e) { }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                textBox5.Text = "Erkek";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
                textBox5.Text = "Kadın";

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
    }
}
