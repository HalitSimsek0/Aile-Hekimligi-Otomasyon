namespace UI
{
    partial class XtraForm2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            textBox1 = new TextBox();
            labelControl4 = new DevExpress.XtraEditors.LabelControl();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(labelControl3, 0, 3);
            tableLayoutPanel1.Controls.Add(labelControl2, 0, 1);
            tableLayoutPanel1.Controls.Add(labelControl1, 0, 0);
            tableLayoutPanel1.Controls.Add(textBox1, 0, 2);
            tableLayoutPanel1.Controls.Add(labelControl4, 0, 4);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 22.8388062F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 22.8388119F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 13.2125244F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 22.8388119F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 18.2710476F));
            tableLayoutPanel1.Size = new Size(1918, 1048);
            tableLayoutPanel1.TabIndex = 0;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // labelControl3
            // 
            labelControl3.Appearance.Font = new Font("Tahoma", 48F, FontStyle.Bold, GraphicsUnit.Point, 162);
            labelControl3.Appearance.Options.UseFont = true;
            labelControl3.Appearance.Options.UseTextOptions = true;
            labelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            labelControl3.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            labelControl3.Location = new Point(3, 619);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new Size(1912, 212);
            labelControl3.TabIndex = 3;
            labelControl3.Text = "Lütfen Sıranızı ALdıktan Sonra Ekranda\r\n İsminiz Görünmesini Bekleyiniz";
            // 
            // labelControl2
            // 
            labelControl2.Appearance.Font = new Font("Tahoma", 48F, FontStyle.Bold, GraphicsUnit.Point, 162);
            labelControl2.Appearance.Options.UseFont = true;
            labelControl2.Appearance.Options.UseTextOptions = true;
            labelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            labelControl2.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            labelControl2.Location = new Point(3, 242);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new Size(1912, 212);
            labelControl2.TabIndex = 2;
            labelControl2.Text = "Lütfen Tc Giriniz";
            // 
            // labelControl1
            // 
            labelControl1.Appearance.Font = new Font("Tahoma", 48F, FontStyle.Bold, GraphicsUnit.Point, 162);
            labelControl1.Appearance.Options.UseFont = true;
            labelControl1.Appearance.Options.UseTextOptions = true;
            labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            labelControl1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            labelControl1.Location = new Point(3, 3);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(1912, 212);
            labelControl1.TabIndex = 0;
            labelControl1.Text = "labelControl1";
            labelControl1.Click += labelControl1_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.InactiveCaption;
            textBox1.Font = new Font("Tahoma", 72F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 162);
            textBox1.Location = new Point(3, 481);
            textBox1.MaxLength = 11;
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(1912, 132);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // labelControl4
            // 
            labelControl4.Appearance.Font = new Font("Tahoma", 48F, FontStyle.Bold, GraphicsUnit.Point, 162);
            labelControl4.Appearance.Options.UseFont = true;
            labelControl4.Appearance.Options.UseTextOptions = true;
            labelControl4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            labelControl4.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            labelControl4.Location = new Point(3, 858);
            labelControl4.Name = "labelControl4";
            labelControl4.Size = new Size(1912, 170);
            labelControl4.TabIndex = 4;
            labelControl4.Text = "İyi Günler Dileriz";
            labelControl4.Click += labelControl4_Click;
            // 
            // XtraForm2
            // 
            Appearance.BackColor = SystemColors.ActiveCaption;
            Appearance.Options.UseBackColor = true;
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1918, 1048);
            Controls.Add(tableLayoutPanel1);
            Name = "XtraForm2";
            Text = "XtraForm2";
            Load += XtraForm2_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private TextBox textBox1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
    }
}