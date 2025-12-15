namespace UI
{
    partial class XtraForm9
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
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            tableLayoutPanel2 = new TableLayoutPanel();
            textBox1 = new TextBox();
            simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            dataGridView1 = new DataGridView();
            simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(550, 340);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(labelControl1, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Controls.Add(dataGridView1, 0, 2);
            tableLayoutPanel1.Controls.Add(simpleButton2, 0, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 28.32F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 18.87F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 32.76F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20.05F));
            tableLayoutPanel1.Size = new Size(550, 340);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // labelControl1
            // 
            labelControl1.Appearance.BackColor = SystemColors.ActiveCaption;
            labelControl1.Appearance.Font = new Font("Tahoma", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            labelControl1.Appearance.Options.UseBackColor = true;
            labelControl1.Appearance.Options.UseFont = true;
            labelControl1.Appearance.Options.UseTextOptions = true;
            labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            labelControl1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            labelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            labelControl1.Dock = DockStyle.Fill;
            labelControl1.Location = new Point(3, 3);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(544, 90);
            labelControl1.TabIndex = 0;
            labelControl1.Text = "ARANACAK KELİMEYİ GİRİNİZ";
            labelControl1.Click += labelControl1_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65.27681F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34.7231865F));
            tableLayoutPanel2.Controls.Add(textBox1, 0, 0);
            tableLayoutPanel2.Controls.Add(simpleButton1, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 99);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(544, 58);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Fill;
            textBox1.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            textBox1.Location = new Point(3, 3);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(349, 52);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // simpleButton1
            // 
            simpleButton1.Appearance.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            simpleButton1.Appearance.Options.UseFont = true;
            simpleButton1.Location = new Point(358, 3);
            simpleButton1.Name = "simpleButton1";
            simpleButton1.Size = new Size(183, 52);
            simpleButton1.TabIndex = 1;
            simpleButton1.Text = "ARA";
            simpleButton1.Click += simpleButton1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.AliceBlue;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 163);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(544, 105);
            dataGridView1.TabIndex = 2;
            // 
            // simpleButton2
            // 
            simpleButton2.Appearance.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            simpleButton2.Appearance.ForeColor = Color.Red;
            simpleButton2.Appearance.Options.UseFont = true;
            simpleButton2.Appearance.Options.UseForeColor = true;
            simpleButton2.Location = new Point(3, 274);
            simpleButton2.Name = "simpleButton2";
            simpleButton2.Size = new Size(544, 63);
            simpleButton2.TabIndex = 3;
            simpleButton2.Text = "VERİTABANINDA SİL";
            simpleButton2.Click += simpleButton2_Click;
            // 
            // XtraForm9
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(550, 340);
            Controls.Add(panel1);
            Name = "XtraForm9";
            Text = "XtraForm9";
            Load += XtraForm9_Load;
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private TableLayoutPanel tableLayoutPanel2;
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}