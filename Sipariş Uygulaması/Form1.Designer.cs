namespace Sipariş_Uygulaması
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemkb = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemhk = new System.Windows.Forms.ToolStripMenuItem();
            this.groupboxkisiselbilgiler = new System.Windows.Forms.GroupBox();
            this.btnsifirla = new System.Windows.Forms.Button();
            this.btnlistele = new System.Windows.Forms.Button();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.comboboxil = new System.Windows.Forms.ComboBox();
            this.radiobuttonkadın = new System.Windows.Forms.RadioButton();
            this.radiobuttonerkek = new System.Windows.Forms.RadioButton();
            this.textboxadres = new System.Windows.Forms.TextBox();
            this.textboxtc = new System.Windows.Forms.TextBox();
            this.textboxtel = new System.Windows.Forms.TextBox();
            this.textboxadsoyad = new System.Windows.Forms.TextBox();
            this.labelil = new System.Windows.Forms.Label();
            this.labelcinsiyet = new System.Windows.Forms.Label();
            this.labeladres = new System.Windows.Forms.Label();
            this.labeltc = new System.Windows.Forms.Label();
            this.labeltelefon = new System.Windows.Forms.Label();
            this.labeladsoyad = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupboxkisiselbilgiler.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemkb,
            this.toolStripMenuItemhk});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(312, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItemkb
            // 
            this.toolStripMenuItemkb.Name = "toolStripMenuItemkb";
            this.toolStripMenuItemkb.Size = new System.Drawing.Size(90, 20);
            this.toolStripMenuItemkb.Text = "Kişisel Bilgiler";
            this.toolStripMenuItemkb.Click += new System.EventHandler(this.toolStripMenuItemkb_Click);
            // 
            // toolStripMenuItemhk
            // 
            this.toolStripMenuItemhk.Name = "toolStripMenuItemhk";
            this.toolStripMenuItemhk.Size = new System.Drawing.Size(69, 20);
            this.toolStripMenuItemhk.Text = "Hakkında";
            this.toolStripMenuItemhk.Click += new System.EventHandler(this.toolStripMenuItemhk_Click);
            // 
            // groupboxkisiselbilgiler
            // 
            this.groupboxkisiselbilgiler.Controls.Add(this.btnsifirla);
            this.groupboxkisiselbilgiler.Controls.Add(this.btnlistele);
            this.groupboxkisiselbilgiler.Controls.Add(this.btnkaydet);
            this.groupboxkisiselbilgiler.Controls.Add(this.comboboxil);
            this.groupboxkisiselbilgiler.Controls.Add(this.radiobuttonkadın);
            this.groupboxkisiselbilgiler.Controls.Add(this.radiobuttonerkek);
            this.groupboxkisiselbilgiler.Controls.Add(this.textboxadres);
            this.groupboxkisiselbilgiler.Controls.Add(this.textboxtc);
            this.groupboxkisiselbilgiler.Controls.Add(this.textboxtel);
            this.groupboxkisiselbilgiler.Controls.Add(this.textboxadsoyad);
            this.groupboxkisiselbilgiler.Controls.Add(this.labelil);
            this.groupboxkisiselbilgiler.Controls.Add(this.labelcinsiyet);
            this.groupboxkisiselbilgiler.Controls.Add(this.labeladres);
            this.groupboxkisiselbilgiler.Controls.Add(this.labeltc);
            this.groupboxkisiselbilgiler.Controls.Add(this.labeltelefon);
            this.groupboxkisiselbilgiler.Controls.Add(this.labeladsoyad);
            this.groupboxkisiselbilgiler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupboxkisiselbilgiler.Location = new System.Drawing.Point(0, 33);
            this.groupboxkisiselbilgiler.Name = "groupboxkisiselbilgiler";
            this.groupboxkisiselbilgiler.Size = new System.Drawing.Size(300, 357);
            this.groupboxkisiselbilgiler.TabIndex = 1;
            this.groupboxkisiselbilgiler.TabStop = false;
            this.groupboxkisiselbilgiler.Text = "Kişisel Bilgiler";
            this.groupboxkisiselbilgiler.Enter += new System.EventHandler(this.groupboxkisiselbilgiler_Enter);
            // 
            // btnsifirla
            // 
            this.btnsifirla.Location = new System.Drawing.Point(111, 308);
            this.btnsifirla.Name = "btnsifirla";
            this.btnsifirla.Size = new System.Drawing.Size(75, 23);
            this.btnsifirla.TabIndex = 16;
            this.btnsifirla.Text = "Sıfırla";
            this.btnsifirla.UseVisualStyleBackColor = true;
            this.btnsifirla.Click += new System.EventHandler(this.btnsifirla_Click);
            // 
            // btnlistele
            // 
            this.btnlistele.Location = new System.Drawing.Point(219, 308);
            this.btnlistele.Name = "btnlistele";
            this.btnlistele.Size = new System.Drawing.Size(66, 23);
            this.btnlistele.TabIndex = 15;
            this.btnlistele.Text = "Listele";
            this.btnlistele.UseVisualStyleBackColor = true;
            this.btnlistele.Click += new System.EventHandler(this.btnlistele_Click);
            // 
            // btnkaydet
            // 
            this.btnkaydet.Location = new System.Drawing.Point(15, 308);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(75, 23);
            this.btnkaydet.TabIndex = 13;
            this.btnkaydet.Text = "Kaydet";
            this.btnkaydet.UseVisualStyleBackColor = true;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // comboboxil
            // 
            this.comboboxil.FormattingEnabled = true;
            this.comboboxil.Items.AddRange(new object[] {
            "Adana",
            "Adıyaman",
            "Afyonkarahisar",
            "Ağrı",
            "Aksaray",
            "Amasya",
            "Ankara",
            "Antalya",
            "Ardahan",
            "Artvin",
            "Aydın",
            "Balıkesir",
            "Bartın",
            "Batman",
            "Bayburt",
            "Bilecik",
            "Bingöl",
            "Bitlis",
            "Bolu",
            "Burdur",
            "Bursa",
            "Çanakkale",
            "Çankırı",
            "Çorum",
            "Denizli",
            "Diyarbakır",
            "Düzce",
            "Edirne",
            "Elazığ",
            "Erzincan",
            "Erzurum",
            "Eskişehir",
            "Gaziantep",
            "Giresun",
            "Gümüşhane",
            "Hakkâri",
            "Hatay",
            "Iğdır",
            "Isparta",
            "İstanbul",
            "İzmir",
            "Kahramanmaraş",
            "Karabük",
            "Karaman",
            "Kars",
            "Kastamonu",
            "Kayseri",
            "Kilis",
            "Kırıkkale",
            "Kırklareli",
            "Kırşehir",
            "Kocaeli",
            "Konya",
            "Kütahya",
            "Malatya",
            "Manisa",
            "Mardin",
            "Mersin",
            "Muğla",
            "Muş",
            "Nevşehir",
            "Niğde",
            "Ordu",
            "Osmaniye",
            "Rize",
            "Sakarya",
            "Samsun",
            "Şanlıurfa",
            "Siirt",
            "Sinop",
            "Sivas",
            "Şırnak",
            "Tekirdağ",
            "Tokat",
            "Trabzon",
            "Tunceli",
            "Uşak",
            "Van",
            "Yalova",
            "Yozgat",
            "Zonguldak"});
            this.comboboxil.Location = new System.Drawing.Point(91, 256);
            this.comboboxil.Name = "comboboxil";
            this.comboboxil.Size = new System.Drawing.Size(147, 23);
            this.comboboxil.TabIndex = 12;
            // 
            // radiobuttonkadın
            // 
            this.radiobuttonkadın.AutoSize = true;
            this.radiobuttonkadın.Location = new System.Drawing.Point(164, 227);
            this.radiobuttonkadın.Name = "radiobuttonkadın";
            this.radiobuttonkadın.Size = new System.Drawing.Size(57, 19);
            this.radiobuttonkadın.TabIndex = 11;
            this.radiobuttonkadın.TabStop = true;
            this.radiobuttonkadın.Text = "Kadın";
            this.radiobuttonkadın.UseVisualStyleBackColor = true;
            // 
            // radiobuttonerkek
            // 
            this.radiobuttonerkek.AutoSize = true;
            this.radiobuttonerkek.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radiobuttonerkek.Location = new System.Drawing.Point(91, 227);
            this.radiobuttonerkek.Name = "radiobuttonerkek";
            this.radiobuttonerkek.Size = new System.Drawing.Size(56, 19);
            this.radiobuttonerkek.TabIndex = 10;
            this.radiobuttonerkek.TabStop = true;
            this.radiobuttonerkek.Text = "Erkek";
            this.radiobuttonerkek.UseVisualStyleBackColor = true;
            // 
            // textboxadres
            // 
            this.textboxadres.Location = new System.Drawing.Point(91, 136);
            this.textboxadres.Multiline = true;
            this.textboxadres.Name = "textboxadres";
            this.textboxadres.Size = new System.Drawing.Size(147, 70);
            this.textboxadres.TabIndex = 9;
            // 
            // textboxtc
            // 
            this.textboxtc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textboxtc.Location = new System.Drawing.Point(91, 101);
            this.textboxtc.Name = "textboxtc";
            this.textboxtc.Size = new System.Drawing.Size(147, 21);
            this.textboxtc.TabIndex = 8;
            // 
            // textboxtel
            // 
            this.textboxtel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textboxtel.Location = new System.Drawing.Point(91, 70);
            this.textboxtel.Name = "textboxtel";
            this.textboxtel.Size = new System.Drawing.Size(147, 21);
            this.textboxtel.TabIndex = 7;
            // 
            // textboxadsoyad
            // 
            this.textboxadsoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textboxadsoyad.Location = new System.Drawing.Point(91, 40);
            this.textboxadsoyad.Name = "textboxadsoyad";
            this.textboxadsoyad.Size = new System.Drawing.Size(147, 21);
            this.textboxadsoyad.TabIndex = 6;
            // 
            // labelil
            // 
            this.labelil.AutoSize = true;
            this.labelil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelil.Location = new System.Drawing.Point(12, 256);
            this.labelil.Name = "labelil";
            this.labelil.Size = new System.Drawing.Size(26, 15);
            this.labelil.TabIndex = 5;
            this.labelil.Text = "İlçe";
            // 
            // labelcinsiyet
            // 
            this.labelcinsiyet.AutoSize = true;
            this.labelcinsiyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelcinsiyet.Location = new System.Drawing.Point(12, 231);
            this.labelcinsiyet.Name = "labelcinsiyet";
            this.labelcinsiyet.Size = new System.Drawing.Size(49, 15);
            this.labelcinsiyet.TabIndex = 4;
            this.labelcinsiyet.Text = "Cinsiyet";
            // 
            // labeladres
            // 
            this.labeladres.AutoSize = true;
            this.labeladres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labeladres.Location = new System.Drawing.Point(13, 130);
            this.labeladres.Name = "labeladres";
            this.labeladres.Size = new System.Drawing.Size(38, 15);
            this.labeladres.TabIndex = 3;
            this.labeladres.Text = "Adres";
            // 
            // labeltc
            // 
            this.labeltc.AutoSize = true;
            this.labeltc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labeltc.Location = new System.Drawing.Point(12, 101);
            this.labeltc.Name = "labeltc";
            this.labeltc.Size = new System.Drawing.Size(60, 15);
            this.labeltc.TabIndex = 2;
            this.labeltc.Text = "Tc Kimlik ";
            // 
            // labeltelefon
            // 
            this.labeltelefon.AutoSize = true;
            this.labeltelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labeltelefon.Location = new System.Drawing.Point(12, 70);
            this.labeltelefon.Name = "labeltelefon";
            this.labeltelefon.Size = new System.Drawing.Size(48, 15);
            this.labeltelefon.TabIndex = 1;
            this.labeltelefon.Text = "Telefon";
            // 
            // labeladsoyad
            // 
            this.labeladsoyad.AutoSize = true;
            this.labeladsoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labeladsoyad.Location = new System.Drawing.Point(14, 40);
            this.labeladsoyad.Name = "labeladsoyad";
            this.labeladsoyad.Size = new System.Drawing.Size(58, 15);
            this.labeladsoyad.TabIndex = 0;
            this.labeladsoyad.Text = "Ad Soyad";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 389);
            this.Controls.Add(this.groupboxkisiselbilgiler);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Bilgilerinizi Giriniz";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupboxkisiselbilgiler.ResumeLayout(false);
            this.groupboxkisiselbilgiler.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemkb;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemhk;
        private System.Windows.Forms.GroupBox groupboxkisiselbilgiler;
        private System.Windows.Forms.Label labeladres;
        private System.Windows.Forms.Label labeltc;
        private System.Windows.Forms.Label labeltelefon;
        private System.Windows.Forms.Label labeladsoyad;
        private System.Windows.Forms.TextBox textboxtc;
        private System.Windows.Forms.TextBox textboxtel;
        private System.Windows.Forms.TextBox textboxadsoyad;
        private System.Windows.Forms.Label labelil;
        private System.Windows.Forms.Label labelcinsiyet;
        private System.Windows.Forms.ComboBox comboboxil;
        private System.Windows.Forms.RadioButton radiobuttonkadın;
        private System.Windows.Forms.RadioButton radiobuttonerkek;
        private System.Windows.Forms.TextBox textboxadres;
        private System.Windows.Forms.Button btnlistele;
        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.Button btnsifirla;
    }
}

