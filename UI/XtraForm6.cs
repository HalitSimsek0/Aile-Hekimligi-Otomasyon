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
    public partial class XtraForm6 : DevExpress.XtraEditors.XtraForm
    {
        private readonly HttpClient _httpClient = new HttpClient
        {
            BaseAddress = new Uri("https://localhost:7006/api/") 
        };

        public XtraForm6()
        {
            InitializeComponent();
        }

        private async void XtraForm6_Load(object sender, EventArgs e)
        {
            dateTimePicker1.MaxDate = DateTime.Today;

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
                    MessageBox.Show("Doktor listesi alınamadı.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }

        private async void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                
                var tc = textBox1.Text.Trim();
                var tel = textBox8.Text.Trim();

               
                var resp = await _httpClient.GetAsync("KayitliKisiListe");
                if (resp.IsSuccessStatusCode)
                {
                    var liste = JsonConvert
                        .DeserializeObject<List<KayitliKisiListeDto>>(await resp.Content.ReadAsStringAsync());

                    
                    if (liste.Any(x => x.Tc == tc))
                    {
                        MessageBox.Show("Bu TC ile daha önce kayıt yapılmış.");
                        return;
                    }
                  
                    if (liste.Any(x => x.Telefon == tel))
                    {
                        MessageBox.Show("Bu telefon numarası ile daha önce kayıt yapılmış.");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Mevcut kayıtlar kontrol edilirken hata oluştu.");
                    return;
                }

                var seciliDoktor = comboBox1.SelectedItem as DoktorKayitDto;
                var kisi = new KayitliKisiListeDto
                {
                    Tc = tc,
                    Ad = textBox2.Text,
                    Soyad = textBox3.Text,
                    Dogumtarih = dateTimePicker1.Value,
                    AnneAd = textBox5.Text,
                    Yas = int.Parse(textBox6.Text),
                    BabaAd = textBox7.Text,
                    Telefon = tel,
                    HekimId = seciliDoktor.HekimId,
                    Hekim = textBox4.Text
                };

                var json = JsonConvert.SerializeObject(kisi);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                var response = await _httpClient.PostAsync("KayitliKisiListe", content);

                if (response.IsSuccessStatusCode)
                    MessageBox.Show("Kayıtlı kişi başarıyla eklendi.");
                else
                {
                    var err = await response.Content.ReadAsStringAsync();
                    MessageBox.Show($"Eklenemedi: {response.StatusCode}\n{err}");
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

            textBox6.Text = yas.ToString();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem is DoktorKayitDto selectedDoktor)
            {
                textBox4.Text = selectedDoktor.Ad + " " + selectedDoktor.Soyad;
            }
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
    }
}
