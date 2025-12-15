using Core.DTO;
using DevExpress.XtraEditors;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;
using System.Collections.Generic;

namespace UI
{
    public partial class XtraForm2 : XtraForm

    {
        private readonly HttpClient _httpClient = new HttpClient
        {
            BaseAddress = new Uri("https://localhost:7006/api/")
        };
        private System.Windows.Forms.Timer _timer;

        public XtraForm2()
        {
            InitializeComponent();
            InitializeDateTimeDisplay();
        }

        private void InitializeDateTimeDisplay()
        {
            _timer = new System.Windows.Forms.Timer { Interval = 1000 };
            _timer.Tick += Timer_Tick;
            _timer.Start();

            labelControl1.Text = DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss");
        }
        private async void textBox1_TextChanged(object sender, EventArgs e)
        {
            var tc = textBox1.Text.Trim();
            if (tc.Length == 11 && long.TryParse(tc, out _))
            {

                var resp = await _httpClient.GetAsync($"KayitliKisiListe/varmi/{tc}");
                bool varMi = false;
                if (resp.IsSuccessStatusCode)
                    varMi = JsonConvert.DeserializeObject<bool>(await resp.Content.ReadAsStringAsync());

                if (varMi)
                {

                    var detResp = await _httpClient.GetAsync($"KayitliKisiListe/detay/{tc}");
                    if (!detResp.IsSuccessStatusCode) return;

                    var kisi = JsonConvert.DeserializeObject<KayitliKisiListeDto>(
                        await detResp.Content.ReadAsStringAsync()
                    );


                    var ekleDto = new { Tc = tc };
                    var json = JsonConvert.SerializeObject(ekleDto);
                    var content = new StringContent(json, Encoding.UTF8, "application/json");

                    var result = await _httpClient.PostAsync("KabulListe", content);
                    if (!result.IsSuccessStatusCode)
                    {
                        var hata = await result.Content.ReadAsStringAsync();
                        MessageBox.Show($"Kabul kaydı başarısız!\n{hata}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string mesaj = $"Hoşgeldiniz {kisi.Ad} {kisi.Soyad}! Doktorunuz: {kisi.Hekim}";
                    var f10 = new XtraForm10(mesaj);
                    f10.Show();
                    this.Hide();
                }



                else
                {
                    var docResp = await _httpClient.GetAsync("DoktorKayit");
                    if (!docResp.IsSuccessStatusCode)
                        return;

                    var doktorlar = JsonConvert.DeserializeObject<List<DoktorKayitDto>>(
                        await docResp.Content.ReadAsStringAsync()
                    );
                    if (doktorlar == null || doktorlar.Count == 0)
                        return;

                 
                    var rnd = new Random();
                    var seciliDoktor = doktorlar[rnd.Next(doktorlar.Count)];

                    var misafirDto = new MisafirDto
                    {
                        Tc = tc,
                        HekimId = seciliDoktor.HekimId,
                        Hekim = seciliDoktor.Ad + " " + seciliDoktor.Soyad
                    };

                    var json = JsonConvert.SerializeObject(misafirDto);
                    var content = new StringContent(json, Encoding.UTF8, "application/json");
                    var result = await _httpClient.PostAsync("Misafir", content);
                    if (!result.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Misafir kaydı başarısız", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string mesaj = $"HOSGELDİNİZ Doktorunuz: {seciliDoktor.Ad} {seciliDoktor.Soyad}";
                    var f10 = new XtraForm10(mesaj);
                    f10.Show();
                    this.Hide();
                }

            }

        }







        private void Timer_Tick(object sender, EventArgs e)
        {
            labelControl1.Text = DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss");
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {
            XtraMessageBox.Show("Saat: " + labelControl1.Text, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void XtraForm2_Load(object sender, EventArgs e)
        {

        }


        private void labelControl4_Click(object sender, EventArgs e)
        {
            XtraForm1 form1 = new XtraForm1();
            form1.Show();
            this.Hide();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
    }
}
