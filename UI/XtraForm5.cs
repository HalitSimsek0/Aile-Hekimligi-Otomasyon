using Core.DTO;
using DevExpress.XtraEditors;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class XtraForm5 : XtraForm
    {
        private readonly HttpClient _httpClient = new HttpClient
        {
            BaseAddress = new Uri("https://localhost:7006/api/")
        };

        public XtraForm5()
        {
            InitializeComponent();
        }

        public async void simpleButton1_Click(object sender, EventArgs e)
        {
            string girilenAd = textBox1.Text.Trim();
            string girilenTc = textBox2.Text.Trim();

            try
            {
                var response = await _httpClient.GetAsync("DoktorKayit");
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    var doktorlar = JsonConvert.DeserializeObject<List<DoktorKayitDto>>(json);

                    bool girisBasarili = doktorlar.Any(d => d.Ad == girilenAd && d.Tc == girilenTc);

                    if (girisBasarili)
                    {
                        var secilenDoktor = doktorlar.FirstOrDefault(d => d.Ad == girilenAd && d.Tc == girilenTc);

                        var form4 = new XtraForm4(secilenDoktor.HekimId);
                        form4.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Giriş başarısız. Lütfen bilgilerinizi kontrol edin.", "Hatalı Giriş", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Sunucu hatası: Doktor verileri alınamadı.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }

        private void XtraForm5_Load(object sender, EventArgs e) { }

        private void textBox1_TextChanged(object sender, EventArgs e) { }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e) { }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
    }
}
