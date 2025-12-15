namespace UI
{
    partial class XtraForm7
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
            panelControl1 = new DevExpress.XtraEditors.PanelControl();
            tableLayoutPanel1 = new TableLayoutPanel();
            timeEdit1 = new DevExpress.XtraEditors.TimeEdit();
            labelControl7 = new DevExpress.XtraEditors.LabelControl();
            labelControl5 = new DevExpress.XtraEditors.LabelControl();
            labelControl4 = new DevExpress.XtraEditors.LabelControl();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            dateTimePicker1 = new DateTimePicker();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            labelControl6 = new DevExpress.XtraEditors.LabelControl();
            textBox6 = new TextBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            comboBox1 = new ComboBox();
            textBox3 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)panelControl1).BeginInit();
            panelControl1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)timeEdit1.Properties).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // panelControl1
            // 
            panelControl1.Controls.Add(tableLayoutPanel1);
            panelControl1.Dock = DockStyle.Fill;
            panelControl1.Location = new Point(0, 0);
            panelControl1.Name = "panelControl1";
            panelControl1.Size = new Size(623, 605);
            panelControl1.TabIndex = 0;
            panelControl1.Paint += panelControl1_Paint;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(timeEdit1, 1, 4);
            tableLayoutPanel1.Controls.Add(labelControl7, 0, 0);
            tableLayoutPanel1.Controls.Add(labelControl5, 0, 5);
            tableLayoutPanel1.Controls.Add(labelControl4, 0, 4);
            tableLayoutPanel1.Controls.Add(labelControl2, 0, 2);
            tableLayoutPanel1.Controls.Add(textBox2, 1, 2);
            tableLayoutPanel1.Controls.Add(textBox1, 1, 1);
            tableLayoutPanel1.Controls.Add(labelControl1, 0, 1);
            tableLayoutPanel1.Controls.Add(simpleButton1, 0, 7);
            tableLayoutPanel1.Controls.Add(dateTimePicker1, 1, 5);
            tableLayoutPanel1.Controls.Add(labelControl3, 0, 6);
            tableLayoutPanel1.Controls.Add(labelControl6, 0, 3);
            tableLayoutPanel1.Controls.Add(textBox6, 1, 3);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 6);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(2, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 8;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.Size = new Size(619, 601);
            tableLayoutPanel1.TabIndex = 0;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // timeEdit1
            // 
            timeEdit1.EditValue = new DateTime(2025, 8, 7, 0, 0, 0, 0);
            timeEdit1.Location = new Point(312, 303);
            timeEdit1.Name = "timeEdit1";
            timeEdit1.Properties.Appearance.BackColor = Color.White;
            timeEdit1.Properties.Appearance.Font = new Font("Tahoma", 36F, FontStyle.Regular, GraphicsUnit.Point, 162);
            timeEdit1.Properties.Appearance.Options.UseBackColor = true;
            timeEdit1.Properties.Appearance.Options.UseFont = true;
            timeEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            timeEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            timeEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            timeEdit1.Properties.TimeEditStyle = DevExpress.XtraEditors.Repository.TimeEditStyle.TouchUI;
            timeEdit1.Properties.TouchUIMaxValue = new DateTime(9999, 12, 31, 17, 0, 0, 0);
            timeEdit1.Properties.TouchUIMinuteIncrement = 10;
            timeEdit1.Properties.TouchUIMinValue = new DateTime(2025, 8, 7, 8, 0, 0, 0);
            timeEdit1.Size = new Size(304, 62);
            timeEdit1.TabIndex = 20;
            // 
            // labelControl7
            // 
            labelControl7.Appearance.BackColor = Color.MistyRose;
            labelControl7.Appearance.Font = new Font("Tahoma", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            labelControl7.Appearance.Options.UseBackColor = true;
            labelControl7.Appearance.Options.UseFont = true;
            labelControl7.Appearance.Options.UseTextOptions = true;
            labelControl7.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            labelControl7.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            labelControl7.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            labelControl7.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            tableLayoutPanel1.SetColumnSpan(labelControl7, 2);
            labelControl7.Dock = DockStyle.Fill;
            labelControl7.Location = new Point(3, 3);
            labelControl7.Name = "labelControl7";
            labelControl7.Size = new Size(613, 69);
            labelControl7.TabIndex = 14;
            labelControl7.Text = "Mhrs Kayıt";
            labelControl7.Click += labelControl7_Click;
            // 
            // labelControl5
            // 
            labelControl5.Appearance.BackColor = Color.MistyRose;
            labelControl5.Appearance.Font = new Font("Tahoma", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            labelControl5.Appearance.Options.UseBackColor = true;
            labelControl5.Appearance.Options.UseFont = true;
            labelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            labelControl5.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            labelControl5.Dock = DockStyle.Fill;
            labelControl5.Location = new Point(3, 378);
            labelControl5.Name = "labelControl5";
            labelControl5.Size = new Size(303, 69);
            labelControl5.TabIndex = 4;
            labelControl5.Text = "Tarih--->";
            // 
            // labelControl4
            // 
            labelControl4.Appearance.BackColor = Color.MistyRose;
            labelControl4.Appearance.Font = new Font("Tahoma", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            labelControl4.Appearance.Options.UseBackColor = true;
            labelControl4.Appearance.Options.UseFont = true;
            labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            labelControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            labelControl4.Dock = DockStyle.Fill;
            labelControl4.Location = new Point(3, 303);
            labelControl4.Name = "labelControl4";
            labelControl4.Size = new Size(303, 69);
            labelControl4.TabIndex = 3;
            labelControl4.Text = "Saat--->";
            // 
            // labelControl2
            // 
            labelControl2.Appearance.BackColor = Color.MistyRose;
            labelControl2.Appearance.Font = new Font("Tahoma", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            labelControl2.Appearance.Options.UseBackColor = true;
            labelControl2.Appearance.Options.UseFont = true;
            labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            labelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            labelControl2.Dock = DockStyle.Fill;
            labelControl2.Location = new Point(3, 153);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new Size(303, 69);
            labelControl2.TabIndex = 1;
            labelControl2.Text = "Soyad--->";
            // 
            // textBox2
            // 
            textBox2.Dock = DockStyle.Fill;
            textBox2.Font = new Font("Tahoma", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            textBox2.Location = new Point(312, 153);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(304, 69);
            textBox2.TabIndex = 8;
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Fill;
            textBox1.Font = new Font("Tahoma", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            textBox1.Location = new Point(312, 78);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(304, 69);
            textBox1.TabIndex = 7;
            // 
            // labelControl1
            // 
            labelControl1.Appearance.BackColor = Color.MistyRose;
            labelControl1.Appearance.Font = new Font("Tahoma", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            labelControl1.Appearance.Options.UseBackColor = true;
            labelControl1.Appearance.Options.UseFont = true;
            labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            labelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            labelControl1.Dock = DockStyle.Fill;
            labelControl1.Location = new Point(3, 78);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(303, 69);
            labelControl1.TabIndex = 0;
            labelControl1.Text = "Ad--->";
            // 
            // simpleButton1
            // 
            simpleButton1.Appearance.Font = new Font("Tahoma", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            simpleButton1.Appearance.Options.UseFont = true;
            tableLayoutPanel1.SetColumnSpan(simpleButton1, 2);
            simpleButton1.Dock = DockStyle.Fill;
            simpleButton1.Location = new Point(3, 528);
            simpleButton1.Name = "simpleButton1";
            simpleButton1.Size = new Size(613, 70);
            simpleButton1.TabIndex = 13;
            simpleButton1.Text = "Kaydet";
            simpleButton1.Click += simpleButton1_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Tahoma", 36F, FontStyle.Bold, GraphicsUnit.Point, 162);
            dateTimePicker1.Font = new Font("Tahoma", 36F, FontStyle.Regular, GraphicsUnit.Point, 162);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(312, 378);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(304, 65);
            dateTimePicker1.TabIndex = 16;
            // 
            // labelControl3
            // 
            labelControl3.Appearance.BackColor = Color.MistyRose;
            labelControl3.Appearance.Font = new Font("Tahoma", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            labelControl3.Appearance.Options.UseBackColor = true;
            labelControl3.Appearance.Options.UseFont = true;
            labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            labelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            labelControl3.Dock = DockStyle.Fill;
            labelControl3.Location = new Point(3, 453);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new Size(303, 69);
            labelControl3.TabIndex = 2;
            labelControl3.Text = "Hekim Ad--->";
            // 
            // labelControl6
            // 
            labelControl6.Appearance.BackColor = Color.MistyRose;
            labelControl6.Appearance.Font = new Font("Tahoma", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            labelControl6.Appearance.Options.UseBackColor = true;
            labelControl6.Appearance.Options.UseFont = true;
            labelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            labelControl6.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            labelControl6.Dock = DockStyle.Fill;
            labelControl6.Location = new Point(3, 228);
            labelControl6.Name = "labelControl6";
            labelControl6.Size = new Size(303, 69);
            labelControl6.TabIndex = 5;
            labelControl6.Text = "Tc--->";
            // 
            // textBox6
            // 
            textBox6.Dock = DockStyle.Fill;
            textBox6.Font = new Font("Tahoma", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            textBox6.Location = new Point(312, 228);
            textBox6.MaxLength = 11;
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(304, 69);
            textBox6.TabIndex = 12;
            textBox6.KeyPress += textBox6_KeyPress;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(comboBox1, 0, 0);
            tableLayoutPanel2.Controls.Add(textBox3, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(312, 453);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(304, 69);
            tableLayoutPanel2.TabIndex = 18;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(3, 3);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(298, 31);
            comboBox1.TabIndex = 16;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // textBox3
            // 
            textBox3.Dock = DockStyle.Fill;
            textBox3.Location = new Point(3, 37);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(298, 29);
            textBox3.TabIndex = 17;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // XtraForm7
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(623, 605);
            Controls.Add(panelControl1);
            Name = "XtraForm7";
            Text = "XtraForm7";
            Load += XtraForm7_Load;
            ((System.ComponentModel.ISupportInitialize)panelControl1).EndInit();
            panelControl1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)timeEdit1.Properties).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private TextBox textBox2;
        private TextBox textBox1;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private TextBox textBox6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DateTimePicker dateTimePicker1;
        private TableLayoutPanel tableLayoutPanel2;
        private ComboBox comboBox1;
        private TextBox textBox3;
        private DevExpress.XtraEditors.TimeEdit timeEdit1;
    }
}