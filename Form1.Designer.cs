namespace Bufe_Satis_Uygulamasi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            groupBox1 = new GroupBox();
            textBilet = new TextBox();
            lblBilet = new Label();
            textSu = new TextBox();
            lblSu = new Label();
            textCay = new TextBox();
            lblCay = new Label();
            txtMisir = new TextBox();
            lblMisir = new Label();
            groupBox2 = new GroupBox();
            lblBiletFiyat = new Label();
            lblSuFiyat = new Label();
            lblCayFiyat = new Label();
            lblMisirFiyat = new Label();
            groupBox3 = new GroupBox();
            button1 = new Button();
            lblKasaTutar = new Label();
            lblKasa = new Label();
            btnHesapla = new Button();
            lblToplamTutar = new Label();
            lblToplam = new Label();
            label11 = new Label();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveCaption;
            groupBox1.Controls.Add(textBilet);
            groupBox1.Controls.Add(lblBilet);
            groupBox1.Controls.Add(textSu);
            groupBox1.Controls.Add(lblSu);
            groupBox1.Controls.Add(textCay);
            groupBox1.Controls.Add(lblCay);
            groupBox1.Controls.Add(txtMisir);
            groupBox1.Controls.Add(lblMisir);
            groupBox1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox1.Location = new Point(51, 174);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(291, 358);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ürün Miktar";
            // 
            // textBilet
            // 
            textBilet.Location = new Point(115, 204);
            textBilet.Name = "textBilet";
            textBilet.Size = new Size(100, 33);
            textBilet.TabIndex = 7;
            // 
            // lblBilet
            // 
            lblBilet.AutoSize = true;
            lblBilet.Location = new Point(48, 207);
            lblBilet.Name = "lblBilet";
            lblBilet.Size = new Size(55, 25);
            lblBilet.TabIndex = 6;
            lblBilet.Text = "Bilet:";
            // 
            // textSu
            // 
            textSu.Location = new Point(115, 156);
            textSu.Name = "textSu";
            textSu.Size = new Size(100, 33);
            textSu.TabIndex = 5;
            // 
            // lblSu
            // 
            lblSu.AutoSize = true;
            lblSu.Location = new Point(65, 159);
            lblSu.Name = "lblSu";
            lblSu.Size = new Size(38, 25);
            lblSu.TabIndex = 4;
            lblSu.Text = "Su:";
            lblSu.Click += label3_Click;
            // 
            // textCay
            // 
            textCay.Location = new Point(115, 111);
            textCay.Name = "textCay";
            textCay.Size = new Size(100, 33);
            textCay.TabIndex = 3;
            // 
            // lblCay
            // 
            lblCay.AutoSize = true;
            lblCay.Location = new Point(54, 114);
            lblCay.Name = "lblCay";
            lblCay.Size = new Size(49, 25);
            lblCay.TabIndex = 2;
            lblCay.Text = "Çay:";
            // 
            // txtMisir
            // 
            txtMisir.Location = new Point(115, 71);
            txtMisir.Name = "txtMisir";
            txtMisir.Size = new Size(100, 33);
            txtMisir.TabIndex = 1;
            // 
            // lblMisir
            // 
            lblMisir.AutoSize = true;
            lblMisir.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblMisir.Location = new Point(42, 74);
            lblMisir.Name = "lblMisir";
            lblMisir.Size = new Size(61, 25);
            lblMisir.TabIndex = 0;
            lblMisir.Text = "Mısır:";
            lblMisir.Click += label1_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ActiveCaption;
            groupBox2.Controls.Add(lblBiletFiyat);
            groupBox2.Controls.Add(lblSuFiyat);
            groupBox2.Controls.Add(lblCayFiyat);
            groupBox2.Controls.Add(lblMisirFiyat);
            groupBox2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox2.Location = new Point(461, 170);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(291, 362);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Fiyat Liste";
            // 
            // lblBiletFiyat
            // 
            lblBiletFiyat.AutoSize = true;
            lblBiletFiyat.Location = new Point(45, 207);
            lblBiletFiyat.Name = "lblBiletFiyat";
            lblBiletFiyat.Size = new Size(117, 25);
            lblBiletFiyat.TabIndex = 7;
            lblBiletFiyat.Text = "Bilet: 300 TL";
            // 
            // lblSuFiyat
            // 
            lblSuFiyat.AutoSize = true;
            lblSuFiyat.Location = new Point(45, 159);
            lblSuFiyat.Name = "lblSuFiyat";
            lblSuFiyat.Size = new Size(86, 25);
            lblSuFiyat.TabIndex = 5;
            lblSuFiyat.Text = "Su: 15 TL";
            // 
            // lblCayFiyat
            // 
            lblCayFiyat.AutoSize = true;
            lblCayFiyat.Location = new Point(45, 114);
            lblCayFiyat.Name = "lblCayFiyat";
            lblCayFiyat.Size = new Size(100, 25);
            lblCayFiyat.TabIndex = 3;
            lblCayFiyat.Text = "Çay: 35 TL";
            // 
            // lblMisirFiyat
            // 
            lblMisirFiyat.AutoSize = true;
            lblMisirFiyat.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblMisirFiyat.Location = new Point(45, 74);
            lblMisirFiyat.Name = "lblMisirFiyat";
            lblMisirFiyat.Size = new Size(112, 25);
            lblMisirFiyat.TabIndex = 1;
            lblMisirFiyat.Text = "Mısır: 50 TL";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = SystemColors.ActiveCaption;
            groupBox3.Controls.Add(button1);
            groupBox3.Controls.Add(lblKasaTutar);
            groupBox3.Controls.Add(lblKasa);
            groupBox3.Controls.Add(btnHesapla);
            groupBox3.Controls.Add(lblToplamTutar);
            groupBox3.Controls.Add(lblToplam);
            groupBox3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox3.Location = new Point(889, 163);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(291, 369);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Kasa";
            // 
            // button1
            // 
            button1.Location = new Point(62, 166);
            button1.Name = "button1";
            button1.Size = new Size(131, 49);
            button1.TabIndex = 5;
            button1.Text = "Temizle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // lblKasaTutar
            // 
            lblKasaTutar.AutoSize = true;
            lblKasaTutar.Location = new Point(135, 233);
            lblKasaTutar.Name = "lblKasaTutar";
            lblKasaTutar.Size = new Size(58, 25);
            lblKasaTutar.TabIndex = 4;
            lblKasaTutar.Text = "00 TL";
            lblKasaTutar.Click += label13_Click;
            // 
            // lblKasa
            // 
            lblKasa.AutoSize = true;
            lblKasa.Location = new Point(72, 233);
            lblKasa.Name = "lblKasa";
            lblKasa.Size = new Size(57, 25);
            lblKasa.TabIndex = 3;
            lblKasa.Text = "Kasa:";
            // 
            // btnHesapla
            // 
            btnHesapla.Location = new Point(62, 113);
            btnHesapla.Name = "btnHesapla";
            btnHesapla.Size = new Size(131, 49);
            btnHesapla.TabIndex = 2;
            btnHesapla.Text = "Hesapla";
            btnHesapla.UseVisualStyleBackColor = true;
            btnHesapla.Click += button1_Click;
            // 
            // lblToplamTutar
            // 
            lblToplamTutar.AutoSize = true;
            lblToplamTutar.Location = new Point(135, 71);
            lblToplamTutar.Name = "lblToplamTutar";
            lblToplamTutar.Size = new Size(58, 25);
            lblToplamTutar.TabIndex = 1;
            lblToplamTutar.Text = "00 TL";
            // 
            // lblToplam
            // 
            lblToplam.AutoSize = true;
            lblToplam.Location = new Point(62, 71);
            lblToplam.Name = "lblToplam";
            lblToplam.Size = new Size(84, 25);
            lblToplam.TabIndex = 0;
            lblToplam.Text = "Toplam: ";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Snap ITC", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(51, 40);
            label11.Name = "label11";
            label11.Size = new Size(688, 82);
            label11.TabIndex = 3;
            label11.Text = "Büfe Satış Paneli";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(835, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(318, 122);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(1230, 627);
            Controls.Add(pictureBox1);
            Controls.Add(label11);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBilet;
        private Label lblBilet;
        private TextBox textSu;
        private Label lblSu;
        private TextBox textCay;
        private Label lblCay;
        private TextBox txtMisir;
        private Label lblMisir;
        private GroupBox groupBox2;
        private Label lblCayFiyat;
        private Label lblMisirFiyat;
        private Label lblBiletFiyat;
        private Label lblSuFiyat;
        private GroupBox groupBox3;
        private Button btnHesapla;
        private Label lblToplamTutar;
        private Label lblToplam;
        private Label label11;
        private PictureBox pictureBox1;
        private Label lblKasaTutar;
        private Label lblKasa;
        private Button button1;
    }
}
