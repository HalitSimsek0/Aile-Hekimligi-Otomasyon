using Core.DTO;
using DevExpress.XtraEditors;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class XtraForm9 : DevExpress.XtraEditors.XtraForm
    {
        private readonly HttpClient _httpClient = new HttpClient
        {
            BaseAddress = new Uri("https://localhost:7006/api/")
        };
        public XtraForm9()
        {
            InitializeComponent();
        }

        private void XtraForm9_Load(object sender, EventArgs e)
        {

        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private async void simpleButton1_Click(object sender, EventArgs e)
        {
            string kelime = textBox1.Text.Trim();
            if (string.IsNullOrEmpty(kelime))
            {
                MessageBox.Show("Lütfen arama kelimesi giriniz.");
                return;
            }

            try
            {
                var response = await _httpClient.GetAsync($"Arama/{kelime}");
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    var data = JsonConvert.DeserializeObject<List<AramaDto>>(json);

                    dataGridView1.DataSource = data;
                }
                else
                {
                    MessageBox.Show("Arama sırasında hata oluştu.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bağlantı hatası: " + ex.Message);
            }
        }

        private async void simpleButton2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen silmek istediğiniz kaydı seçin.");
                return;
            }

            var kaynak = dataGridView1.SelectedRows[0].Cells["Kaynak"].Value?.ToString();
            var tc = dataGridView1.SelectedRows[0].Cells["Tc"].Value?.ToString();

            var confirm = MessageBox.Show($"{tc} numaralı kaydı silmek istediğinize emin misiniz?",
                                           "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                var response = await _httpClient.DeleteAsync($"Arama/{kaynak}/{tc}");
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Kayıt silindi.");
                    simpleButton1.PerformClick(); 
                }
                else
                {
                    MessageBox.Show("Silme işlemi başarısız.");
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}