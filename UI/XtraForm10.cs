using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class XtraForm10 : DevExpress.XtraEditors.XtraForm
    {
        private System.Windows.Forms.Timer closeTimer;
        public XtraForm10(string mesaj)
        {
            InitializeComponent();
            if (labelControl1 != null)
            {
                labelControl1.Text = mesaj;
            }
            else
            {

            }

            InitializeCloseTimer();
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void XtraForm10_Load(object sender, EventArgs e)
        {

        }
        private void InitializeCloseTimer()
        {
            closeTimer = new System.Windows.Forms.Timer();
            closeTimer.Interval = 3000;
            closeTimer.Tick += CloseTimer_Tick;
            closeTimer.Start();
        }
        private void CloseTimer_Tick(object sender, EventArgs e)
        {
            closeTimer.Stop();


            XtraForm8 form8 = new XtraForm8("");
            form8.Show();

            this.Close();
        }
    }
}