using Core.DTO;
using DevExpress.XtraEditors;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace UI
{
    public partial class XtraForm8 : DevExpress.XtraEditors.XtraForm
    {
        private readonly HttpClient _httpClient = new HttpClient
        {
            BaseAddress = new Uri("https://localhost:7006/api/")
        };


        public XtraForm8(string mesaj)
        {
            InitializeComponent();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {



        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void XtraForm8_Load(object sender, EventArgs e)
        {
            try
            {
                var responseKabul = await _httpClient.GetAsync("KabulListe");
                var responseMisafir = await _httpClient.GetAsync("Misafir");

                if (!responseKabul.IsSuccessStatusCode || !responseMisafir.IsSuccessStatusCode)
                {
                    MessageBox.Show("Veriler alınamadı.");
                    return;
                }

                var jsonKabul = await responseKabul.Content.ReadAsStringAsync();
                var jsonMisafir = await responseMisafir.Content.ReadAsStringAsync();

                var kabulListesi = JsonConvert.DeserializeObject<List<KabulListeDto>>(jsonKabul);
                var misafirListesi = JsonConvert.DeserializeObject<List<MisafirDto>>(jsonMisafir);

                var ortakListe = new List<OrtakDto>();

                foreach (var kabul in kabulListesi)
                {
                    ortakListe.Add(new OrtakDto
                    {
                        Tc = kabul.Tc,
                        Ad = string.IsNullOrWhiteSpace(kabul.Ad) ? "Misafir" : kabul.Ad,
                        Soyad = string.IsNullOrWhiteSpace(kabul.Soyad) ? "Misafir" : kabul.Soyad
                    });
                }

                foreach (var misafir in misafirListesi)
                {
                    ortakListe.Add(new OrtakDto
                    {
                        Tc = misafir.Tc,
                        Ad = "Misafir",
                        Soyad = "Misafir"
                    });
                }

                var tekilOrtakListe = ortakListe
          .Select((item, idx) => new { item, idx })
           .GroupBy(x => x.item.Tc)
            .Select(g => g.OrderBy(x => x.idx).Last())
             .OrderBy(x => x.idx)
              .Select(x => x.item)
              .ToList();

                dataGridView1.DataSource = tekilOrtakListe;
                dataGridView1.AutoGenerateColumns = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            var form1 = new XtraForm1();
            form1.Show();
            this.Hide();
        }
    }

}
