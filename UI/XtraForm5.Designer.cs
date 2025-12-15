namespace UI
{
    partial class XtraForm5
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
            textBox2 = new TextBox();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            textBox1 = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(textBox2, 2, 2);
            tableLayoutPanel1.Controls.Add(labelControl3, 0, 2);
            tableLayoutPanel1.Controls.Add(labelControl2, 0, 1);
            tableLayoutPanel1.Controls.Add(simpleButton1, 1, 3);
            tableLayoutPanel1.Controls.Add(labelControl1, 1, 0);
            tableLayoutPanel1.Controls.Add(textBox1, 2, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Size = new Size(391, 473);
            tableLayoutPanel1.TabIndex = 1;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // textBox2
            // 
            tableLayoutPanel1.SetColumnSpan(textBox2, 2);
            textBox2.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            textBox2.Location = new Point(197, 239);
            textBox2.MaxLength = 11;
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(191, 44);
            textBox2.TabIndex = 8;
            textBox2.KeyPress += textBox2_KeyPress;
            // 
            // labelControl3
            // 
            labelControl3.Appearance.Font = new Font("Tahoma", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            labelControl3.Appearance.ForeColor = SystemColors.ActiveCaptionText;
            labelControl3.Appearance.Options.UseFont = true;
            labelControl3.Appearance.Options.UseForeColor = true;
            labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            tableLayoutPanel1.SetColumnSpan(labelControl3, 2);
            labelControl3.Location = new Point(3, 239);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new Size(141, 59);
            labelControl3.TabIndex = 3;
            labelControl3.Text = "Tc Kimlik No:";
            // 
            // labelControl2
            // 
            labelControl2.Appearance.Font = new Font("Tahoma", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            labelControl2.Appearance.ForeColor = SystemColors.ActiveCaptionText;
            labelControl2.Appearance.Options.UseFont = true;
            labelControl2.Appearance.Options.UseForeColor = true;
            labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            tableLayoutPanel1.SetColumnSpan(labelControl2, 2);
            labelControl2.Location = new Point(3, 121);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new Size(141, 59);
            labelControl2.TabIndex = 2;
            labelControl2.Text = "Ad:";
            // 
            // simpleButton1
            // 
            simpleButton1.Appearance.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            simpleButton1.Appearance.Options.UseFont = true;
            tableLayoutPanel1.SetColumnSpan(simpleButton1, 2);
            simpleButton1.Location = new Point(100, 357);
            simpleButton1.Name = "simpleButton1";
            simpleButton1.Size = new Size(188, 78);
            simpleButton1.TabIndex = 6;
            simpleButton1.Text = "Giriş";
            simpleButton1.Click += simpleButton1_Click;
            // 
            // labelControl1
            // 
            labelControl1.Appearance.Font = new Font("Tahoma", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            labelControl1.Appearance.ForeColor = SystemColors.ActiveCaptionText;
            labelControl1.Appearance.Options.UseFont = true;
            labelControl1.Appearance.Options.UseForeColor = true;
            labelControl1.Appearance.Options.UseTextOptions = true;
            labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            labelControl1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            tableLayoutPanel1.SetColumnSpan(labelControl1, 2);
            labelControl1.Location = new Point(100, 3);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(170, 105);
            labelControl1.TabIndex = 1;
            labelControl1.Text = "Doktor Giriş \r\n\r\n";
            // 
            // textBox1
            // 
            tableLayoutPanel1.SetColumnSpan(textBox1, 2);
            textBox1.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            textBox1.Location = new Point(197, 121);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(191, 44);
            textBox1.TabIndex = 7;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // XtraForm5
            // 
            Appearance.BackColor = Color.FromArgb(255, 192, 192);
            Appearance.Options.UseBackColor = true;
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(391, 473);
            Controls.Add(tableLayoutPanel1);
            Name = "XtraForm5";
            Text = "XtraForm5";
            Load += XtraForm5_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private TextBox textBox2;
        private TextBox textBox1;
    }
}