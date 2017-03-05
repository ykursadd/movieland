namespace Movieland
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.btnSirala = new MetroFramework.Controls.MetroButton();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.lblDinamik = new MetroFramework.Controls.MetroLabel();
            this.rdbtnDizi = new MetroFramework.Controls.MetroRadioButton();
            this.rdbtnFilm = new MetroFramework.Controls.MetroRadioButton();
            this.rdbtnTur = new MetroFramework.Controls.MetroRadioButton();
            this.rdbtnAlfabetik = new MetroFramework.Controls.MetroRadioButton();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.lblvizyonTarih = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.lbleserAdi = new MetroFramework.Controls.MetroLabel();
            this.lblTur = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.lblPuan = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblYapimci = new MetroFramework.Controls.MetroLabel();
            this.lblYonetmen = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtKonu = new MetroFramework.Controls.MetroTextBox();
            this.labaelKonu = new MetroFramework.Controls.MetroLabel();
            this.txtOyuncu = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.btnAra = new MetroFramework.Controls.MetroButton();
            this.txteserTur = new MetroFramework.Controls.MetroTextBox();
            this.txteserAdi = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.metroTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.metroTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Controls.Add(this.metroTabPage3);
            this.metroTabControl1.Location = new System.Drawing.Point(23, 63);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 1;
            this.metroTabControl1.Size = new System.Drawing.Size(662, 499);
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.btnSirala);
            this.metroTabPage1.Controls.Add(this.metroGrid1);
            this.metroTabPage1.Controls.Add(this.metroComboBox1);
            this.metroTabPage1.Controls.Add(this.lblDinamik);
            this.metroTabPage1.Controls.Add(this.rdbtnDizi);
            this.metroTabPage1.Controls.Add(this.rdbtnFilm);
            this.metroTabPage1.Controls.Add(this.rdbtnTur);
            this.metroTabPage1.Controls.Add(this.rdbtnAlfabetik);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(654, 457);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Eser Sıralama";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // btnSirala
            // 
            this.btnSirala.Location = new System.Drawing.Point(387, 37);
            this.btnSirala.Name = "btnSirala";
            this.btnSirala.Size = new System.Drawing.Size(75, 23);
            this.btnSirala.TabIndex = 9;
            this.btnSirala.Text = "Sırala";
            this.btnSirala.UseSelectable = true;
            this.btnSirala.Visible = false;
            this.btnSirala.Click += new System.EventHandler(this.btnSirala_Click);
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle5;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(3, 114);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(655, 369);
            this.metroGrid1.TabIndex = 8;
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Items.AddRange(new object[] {
            "Aksiyon",
            "Bilim-Kurgu",
            "Fantastik",
            "Korku"});
            this.metroComboBox1.Location = new System.Drawing.Point(241, 37);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(121, 29);
            this.metroComboBox1.TabIndex = 7;
            this.metroComboBox1.UseSelectable = true;
            this.metroComboBox1.Visible = false;
            // 
            // lblDinamik
            // 
            this.lblDinamik.AutoSize = true;
            this.lblDinamik.Location = new System.Drawing.Point(115, 37);
            this.lblDinamik.Name = "lblDinamik";
            this.lblDinamik.Size = new System.Drawing.Size(109, 19);
            this.lblDinamik.TabIndex = 6;
            this.lblDinamik.Text = "---->Tür Seçiniz :";
            this.lblDinamik.Visible = false;
            // 
            // rdbtnDizi
            // 
            this.rdbtnDizi.AutoSize = true;
            this.rdbtnDizi.Location = new System.Drawing.Point(3, 79);
            this.rdbtnDizi.Name = "rdbtnDizi";
            this.rdbtnDizi.Size = new System.Drawing.Size(73, 15);
            this.rdbtnDizi.TabIndex = 5;
            this.rdbtnDizi.Text = "Dizi Sırala";
            this.rdbtnDizi.UseSelectable = true;
            this.rdbtnDizi.CheckedChanged += new System.EventHandler(this.rdbtnDizi_CheckedChanged);
            // 
            // rdbtnFilm
            // 
            this.rdbtnFilm.AutoSize = true;
            this.rdbtnFilm.Location = new System.Drawing.Point(3, 58);
            this.rdbtnFilm.Name = "rdbtnFilm";
            this.rdbtnFilm.Size = new System.Drawing.Size(77, 15);
            this.rdbtnFilm.TabIndex = 4;
            this.rdbtnFilm.Text = "Film Sırala";
            this.rdbtnFilm.UseSelectable = true;
            this.rdbtnFilm.CheckedChanged += new System.EventHandler(this.rdbtnFilm_CheckedChanged);
            // 
            // rdbtnTur
            // 
            this.rdbtnTur.AutoSize = true;
            this.rdbtnTur.Location = new System.Drawing.Point(3, 37);
            this.rdbtnTur.Name = "rdbtnTur";
            this.rdbtnTur.Size = new System.Drawing.Size(106, 15);
            this.rdbtnTur.TabIndex = 3;
            this.rdbtnTur.Text = "Türe Göre Sırala";
            this.rdbtnTur.UseSelectable = true;
            this.rdbtnTur.CheckedChanged += new System.EventHandler(this.rdbtnTur_CheckedChanged);
            // 
            // rdbtnAlfabetik
            // 
            this.rdbtnAlfabetik.AutoSize = true;
            this.rdbtnAlfabetik.Location = new System.Drawing.Point(3, 16);
            this.rdbtnAlfabetik.Name = "rdbtnAlfabetik";
            this.rdbtnAlfabetik.Size = new System.Drawing.Size(101, 15);
            this.rdbtnAlfabetik.TabIndex = 2;
            this.rdbtnAlfabetik.Text = "Alfabetik Sırala";
            this.rdbtnAlfabetik.UseSelectable = true;
            this.rdbtnAlfabetik.CheckedChanged += new System.EventHandler(this.rdbtnAlfabetik_CheckedChanged);
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.lblvizyonTarih);
            this.metroTabPage2.Controls.Add(this.metroLabel9);
            this.metroTabPage2.Controls.Add(this.lbleserAdi);
            this.metroTabPage2.Controls.Add(this.lblTur);
            this.metroTabPage2.Controls.Add(this.metroLabel3);
            this.metroTabPage2.Controls.Add(this.lblPuan);
            this.metroTabPage2.Controls.Add(this.metroLabel6);
            this.metroTabPage2.Controls.Add(this.pictureBox2);
            this.metroTabPage2.Controls.Add(this.pictureBox3);
            this.metroTabPage2.Controls.Add(this.lblYapimci);
            this.metroTabPage2.Controls.Add(this.lblYonetmen);
            this.metroTabPage2.Controls.Add(this.metroLabel5);
            this.metroTabPage2.Controls.Add(this.metroLabel4);
            this.metroTabPage2.Controls.Add(this.txtKonu);
            this.metroTabPage2.Controls.Add(this.labaelKonu);
            this.metroTabPage2.Controls.Add(this.txtOyuncu);
            this.metroTabPage2.Controls.Add(this.metroLabel7);
            this.metroTabPage2.Controls.Add(this.metroLabel8);
            this.metroTabPage2.Controls.Add(this.btnAra);
            this.metroTabPage2.Controls.Add(this.txteserTur);
            this.metroTabPage2.Controls.Add(this.txteserAdi);
            this.metroTabPage2.Controls.Add(this.metroLabel2);
            this.metroTabPage2.Controls.Add(this.metroLabel1);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(654, 457);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Eser Arama";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // lblvizyonTarih
            // 
            this.lblvizyonTarih.AutoSize = true;
            this.lblvizyonTarih.Location = new System.Drawing.Point(261, 432);
            this.lblvizyonTarih.Name = "lblvizyonTarih";
            this.lblvizyonTarih.Size = new System.Drawing.Size(36, 19);
            this.lblvizyonTarih.TabIndex = 36;
            this.lblvizyonTarih.Text = "Tarih";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(152, 432);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(88, 19);
            this.metroLabel9.TabIndex = 35;
            this.metroLabel9.Text = "Vizyon Tarihi :";
            // 
            // lbleserAdi
            // 
            this.lbleserAdi.AutoSize = true;
            this.lbleserAdi.Location = new System.Drawing.Point(261, 61);
            this.lbleserAdi.Name = "lbleserAdi";
            this.lbleserAdi.Size = new System.Drawing.Size(0, 0);
            this.lbleserAdi.TabIndex = 34;
            // 
            // lblTur
            // 
            this.lblTur.AutoSize = true;
            this.lblTur.Location = new System.Drawing.Point(261, 98);
            this.lblTur.Name = "lblTur";
            this.lblTur.Size = new System.Drawing.Size(0, 0);
            this.lblTur.TabIndex = 33;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(180, 98);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(33, 19);
            this.metroLabel3.TabIndex = 32;
            this.metroLabel3.Text = "Tür :";
            // 
            // lblPuan
            // 
            this.lblPuan.AutoSize = true;
            this.lblPuan.Location = new System.Drawing.Point(105, 355);
            this.lblPuan.Name = "lblPuan";
            this.lblPuan.Size = new System.Drawing.Size(38, 19);
            this.lblPuan.TabIndex = 31;
            this.lblPuan.Text = "Puan";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(40, 355);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(45, 19);
            this.metroLabel6.TabIndex = 30;
            this.metroLabel6.Text = "Puan :";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 355);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 33);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 29;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(3, 66);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(162, 253);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 28;
            this.pictureBox3.TabStop = false;
            // 
            // lblYapimci
            // 
            this.lblYapimci.AutoSize = true;
            this.lblYapimci.Location = new System.Drawing.Point(261, 402);
            this.lblYapimci.Name = "lblYapimci";
            this.lblYapimci.Size = new System.Drawing.Size(0, 0);
            this.lblYapimci.TabIndex = 27;
            // 
            // lblYonetmen
            // 
            this.lblYonetmen.AutoSize = true;
            this.lblYonetmen.Location = new System.Drawing.Point(261, 369);
            this.lblYonetmen.Name = "lblYonetmen";
            this.lblYonetmen.Size = new System.Drawing.Size(0, 0);
            this.lblYonetmen.TabIndex = 26;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(180, 402);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(61, 19);
            this.metroLabel5.TabIndex = 24;
            this.metroLabel5.Text = "Yapımcı :";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(180, 369);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(75, 19);
            this.metroLabel4.TabIndex = 23;
            this.metroLabel4.Text = "Yönetmen :";
            // 
            // txtKonu
            // 
            // 
            // 
            // 
            this.txtKonu.CustomButton.Image = null;
            this.txtKonu.CustomButton.Location = new System.Drawing.Point(230, 1);
            this.txtKonu.CustomButton.Name = "";
            this.txtKonu.CustomButton.Size = new System.Drawing.Size(75, 75);
            this.txtKonu.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtKonu.CustomButton.TabIndex = 1;
            this.txtKonu.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtKonu.CustomButton.UseSelectable = true;
            this.txtKonu.CustomButton.Visible = false;
            this.txtKonu.Lines = new string[0];
            this.txtKonu.Location = new System.Drawing.Point(180, 282);
            this.txtKonu.MaxLength = 32767;
            this.txtKonu.Multiline = true;
            this.txtKonu.Name = "txtKonu";
            this.txtKonu.PasswordChar = '\0';
            this.txtKonu.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtKonu.SelectedText = "";
            this.txtKonu.SelectionLength = 0;
            this.txtKonu.SelectionStart = 0;
            this.txtKonu.Size = new System.Drawing.Size(306, 77);
            this.txtKonu.TabIndex = 21;
            this.txtKonu.UseSelectable = true;
            this.txtKonu.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtKonu.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // labaelKonu
            // 
            this.labaelKonu.AutoSize = true;
            this.labaelKonu.Location = new System.Drawing.Point(180, 260);
            this.labaelKonu.Name = "labaelKonu";
            this.labaelKonu.Size = new System.Drawing.Size(45, 19);
            this.labaelKonu.TabIndex = 20;
            this.labaelKonu.Text = "Konu :";
            // 
            // txtOyuncu
            // 
            // 
            // 
            // 
            this.txtOyuncu.CustomButton.Image = null;
            this.txtOyuncu.CustomButton.Location = new System.Drawing.Point(230, 1);
            this.txtOyuncu.CustomButton.Name = "";
            this.txtOyuncu.CustomButton.Size = new System.Drawing.Size(75, 75);
            this.txtOyuncu.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtOyuncu.CustomButton.TabIndex = 1;
            this.txtOyuncu.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtOyuncu.CustomButton.UseSelectable = true;
            this.txtOyuncu.CustomButton.Visible = false;
            this.txtOyuncu.Lines = new string[0];
            this.txtOyuncu.Location = new System.Drawing.Point(180, 171);
            this.txtOyuncu.MaxLength = 32767;
            this.txtOyuncu.Multiline = true;
            this.txtOyuncu.Name = "txtOyuncu";
            this.txtOyuncu.PasswordChar = '\0';
            this.txtOyuncu.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtOyuncu.SelectedText = "";
            this.txtOyuncu.SelectionLength = 0;
            this.txtOyuncu.SelectionStart = 0;
            this.txtOyuncu.Size = new System.Drawing.Size(306, 77);
            this.txtOyuncu.TabIndex = 19;
            this.txtOyuncu.UseSelectable = true;
            this.txtOyuncu.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtOyuncu.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(180, 137);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(75, 19);
            this.metroLabel7.TabIndex = 18;
            this.metroLabel7.Text = "Oyuncular :";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(180, 61);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(64, 19);
            this.metroLabel8.TabIndex = 16;
            this.metroLabel8.Text = "Eser Adı :";
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(527, 14);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(84, 20);
            this.btnAra.TabIndex = 7;
            this.btnAra.Text = "Ara";
            this.btnAra.UseSelectable = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // txteserTur
            // 
            // 
            // 
            // 
            this.txteserTur.CustomButton.Image = null;
            this.txteserTur.CustomButton.Location = new System.Drawing.Point(149, 2);
            this.txteserTur.CustomButton.Name = "";
            this.txteserTur.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.txteserTur.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txteserTur.CustomButton.TabIndex = 1;
            this.txteserTur.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txteserTur.CustomButton.UseSelectable = true;
            this.txteserTur.CustomButton.Visible = false;
            this.txteserTur.Lines = new string[0];
            this.txteserTur.Location = new System.Drawing.Point(339, 14);
            this.txteserTur.MaxLength = 32767;
            this.txteserTur.Name = "txteserTur";
            this.txteserTur.PasswordChar = '\0';
            this.txteserTur.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txteserTur.SelectedText = "";
            this.txteserTur.SelectionLength = 0;
            this.txteserTur.SelectionStart = 0;
            this.txteserTur.Size = new System.Drawing.Size(167, 20);
            this.txteserTur.TabIndex = 6;
            this.txteserTur.UseSelectable = true;
            this.txteserTur.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txteserTur.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txteserAdi
            // 
            // 
            // 
            // 
            this.txteserAdi.CustomButton.Image = null;
            this.txteserAdi.CustomButton.Location = new System.Drawing.Point(149, 2);
            this.txteserAdi.CustomButton.Name = "";
            this.txteserAdi.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.txteserAdi.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txteserAdi.CustomButton.TabIndex = 1;
            this.txteserAdi.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txteserAdi.CustomButton.UseSelectable = true;
            this.txteserAdi.CustomButton.Visible = false;
            this.txteserAdi.Lines = new string[0];
            this.txteserAdi.Location = new System.Drawing.Point(73, 13);
            this.txteserAdi.MaxLength = 32767;
            this.txteserAdi.Name = "txteserAdi";
            this.txteserAdi.PasswordChar = '\0';
            this.txteserAdi.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txteserAdi.SelectedText = "";
            this.txteserAdi.SelectionLength = 0;
            this.txteserAdi.SelectionStart = 0;
            this.txteserAdi.Size = new System.Drawing.Size(167, 20);
            this.txteserAdi.TabIndex = 5;
            this.txteserAdi.UseSelectable = true;
            this.txteserAdi.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txteserAdi.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(268, 14);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(65, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Eser Tur : ";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(3, 14);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(64, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Eser Adı :";
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.Controls.Add(this.metroLabel14);
            this.metroTabPage3.Controls.Add(this.metroLabel13);
            this.metroTabPage3.Controls.Add(this.metroLabel12);
            this.metroTabPage3.Controls.Add(this.metroLabel11);
            this.metroTabPage3.Controls.Add(this.metroLabel10);
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.HorizontalScrollbarSize = 10;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(654, 457);
            this.metroTabPage3.TabIndex = 2;
            this.metroTabPage3.Text = "Hakkımızda";
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            this.metroTabPage3.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.VerticalScrollbarSize = 10;
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.Location = new System.Drawing.Point(40, 189);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(126, 19);
            this.metroLabel14.TabIndex = 6;
            this.metroLabel14.Text = "Yunus Emre Yıldırım";
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.Location = new System.Drawing.Point(40, 111);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(126, 19);
            this.metroLabel13.TabIndex = 5;
            this.metroLabel13.Text = "Celal Faruk Ercengiz";
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(40, 149);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(316, 19);
            this.metroLabel12.TabIndex = 4;
            this.metroLabel12.Text = "Yasin Kürşad Sürek  Email : ykursadsurek@gmail.com";
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(40, 63);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(223, 19);
            this.metroLabel11.TabIndex = 3;
            this.metroLabel11.Text = "Görüş ve Önerileriniz İçin Bize Ulaşın.";
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(40, 20);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(565, 19);
            this.metroLabel10.TabIndex = 2;
            this.metroLabel10.Text = "MOVIELAND yazılımı Cumhuriyet Üniversitesi Bilgisayar Mühendisliği Bölümü\'nün bir" +
    " ürünüdür !";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(30, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(334, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(477, 586);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(208, 50);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 643);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.metroTabControl1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.metroTabPage3.ResumeLayout(false);
            this.metroTabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnAra;
        public MetroFramework.Controls.MetroTextBox txteserTur;
        public MetroFramework.Controls.MetroTextBox txteserAdi;
        private MetroFramework.Controls.MetroLabel lblPuan;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private MetroFramework.Controls.MetroLabel lblYapimci;
        private MetroFramework.Controls.MetroLabel lblYonetmen;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtKonu;
        private MetroFramework.Controls.MetroLabel labaelKonu;
        private MetroFramework.Controls.MetroTextBox txtOyuncu;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel lblvizyonTarih;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel lbleserAdi;
        private MetroFramework.Controls.MetroLabel lblTur;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private MetroFramework.Controls.MetroLabel lblDinamik;
        private MetroFramework.Controls.MetroRadioButton rdbtnDizi;
        private MetroFramework.Controls.MetroRadioButton rdbtnFilm;
        private MetroFramework.Controls.MetroRadioButton rdbtnTur;
        private MetroFramework.Controls.MetroRadioButton rdbtnAlfabetik;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private MetroFramework.Controls.MetroButton btnSirala;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}

