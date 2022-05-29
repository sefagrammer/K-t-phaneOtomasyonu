namespace KutuphaneOtomasyonu
{
    partial class IslemPaneli
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IslemPaneli));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Ksilbtn = new System.Windows.Forms.Button();
            this.Kduzenbtn = new System.Windows.Forms.Button();
            this.Keklebtn = new System.Windows.Forms.Button();
            this.Kullanicibtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.KaynakEkleBtn = new System.Windows.Forms.Button();
            this.KaynakDuzenleBtn = new System.Windows.Forms.Button();
            this.KaynakSilBtn = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.panel1.Controls.Add(this.KaynakSilBtn);
            this.panel1.Controls.Add(this.KaynakDuzenleBtn);
            this.panel1.Controls.Add(this.KaynakEkleBtn);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.Ksilbtn);
            this.panel1.Controls.Add(this.Kduzenbtn);
            this.panel1.Controls.Add(this.Keklebtn);
            this.panel1.Controls.Add(this.Kullanicibtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 636);
            this.panel1.TabIndex = 0;
            // 
            // Ksilbtn
            // 
            this.Ksilbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(96)))), ((int)(((byte)(26)))));
            this.Ksilbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Ksilbtn.FlatAppearance.BorderSize = 0;
            this.Ksilbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ksilbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Ksilbtn.ImageKey = "delete.png";
            this.Ksilbtn.ImageList = this.ımageList1;
            this.Ksilbtn.Location = new System.Drawing.Point(0, 210);
            this.Ksilbtn.Name = "Ksilbtn";
            this.Ksilbtn.Size = new System.Drawing.Size(150, 70);
            this.Ksilbtn.TabIndex = 7;
            this.Ksilbtn.Text = "              Kullanıcı Sil";
            this.Ksilbtn.UseVisualStyleBackColor = false;
            this.Ksilbtn.Click += new System.EventHandler(this.Ksilbtn_Click);
            // 
            // Kduzenbtn
            // 
            this.Kduzenbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(96)))), ((int)(((byte)(26)))));
            this.Kduzenbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Kduzenbtn.FlatAppearance.BorderSize = 0;
            this.Kduzenbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Kduzenbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Kduzenbtn.ImageKey = "update.png";
            this.Kduzenbtn.ImageList = this.ımageList1;
            this.Kduzenbtn.Location = new System.Drawing.Point(0, 140);
            this.Kduzenbtn.Name = "Kduzenbtn";
            this.Kduzenbtn.Size = new System.Drawing.Size(150, 70);
            this.Kduzenbtn.TabIndex = 6;
            this.Kduzenbtn.Text = "              Kullanıcı Düzenle";
            this.Kduzenbtn.UseVisualStyleBackColor = false;
            this.Kduzenbtn.Click += new System.EventHandler(this.Kduzenbtn_Click);
            // 
            // Keklebtn
            // 
            this.Keklebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(96)))), ((int)(((byte)(26)))));
            this.Keklebtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Keklebtn.FlatAppearance.BorderSize = 0;
            this.Keklebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Keklebtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Keklebtn.ImageKey = "add.png";
            this.Keklebtn.ImageList = this.ımageList1;
            this.Keklebtn.Location = new System.Drawing.Point(0, 70);
            this.Keklebtn.Name = "Keklebtn";
            this.Keklebtn.Size = new System.Drawing.Size(150, 70);
            this.Keklebtn.TabIndex = 5;
            this.Keklebtn.Text = "              Kullanıcı Ekle";
            this.Keklebtn.UseVisualStyleBackColor = false;
            this.Keklebtn.Click += new System.EventHandler(this.Keklebtn_Click);
            // 
            // Kullanicibtn
            // 
            this.Kullanicibtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(81)))), ((int)(((byte)(22)))));
            this.Kullanicibtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Kullanicibtn.FlatAppearance.BorderSize = 0;
            this.Kullanicibtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Kullanicibtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Kullanicibtn.ImageKey = "users.png";
            this.Kullanicibtn.ImageList = this.ımageList1;
            this.Kullanicibtn.Location = new System.Drawing.Point(0, 0);
            this.Kullanicibtn.Name = "Kullanicibtn";
            this.Kullanicibtn.Size = new System.Drawing.Size(150, 70);
            this.Kullanicibtn.TabIndex = 4;
            this.Kullanicibtn.Text = "              Kullanıcılar";
            this.Kullanicibtn.UseVisualStyleBackColor = false;
            this.Kullanicibtn.Click += new System.EventHandler(this.Kullanicibtn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(81)))), ((int)(((byte)(22)))));
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.ImageKey = "books.png";
            this.button1.ImageList = this.ımageList1;
            this.button1.Location = new System.Drawing.Point(0, 280);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 70);
            this.button1.TabIndex = 8;
            this.button1.Text = "              Kaynaklar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // KaynakEkleBtn
            // 
            this.KaynakEkleBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(96)))), ((int)(((byte)(26)))));
            this.KaynakEkleBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.KaynakEkleBtn.FlatAppearance.BorderSize = 0;
            this.KaynakEkleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KaynakEkleBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.KaynakEkleBtn.ImageKey = "add book.png";
            this.KaynakEkleBtn.ImageList = this.ımageList1;
            this.KaynakEkleBtn.Location = new System.Drawing.Point(0, 350);
            this.KaynakEkleBtn.Name = "KaynakEkleBtn";
            this.KaynakEkleBtn.Size = new System.Drawing.Size(150, 70);
            this.KaynakEkleBtn.TabIndex = 9;
            this.KaynakEkleBtn.Text = "              Kaynak Ekle";
            this.KaynakEkleBtn.UseVisualStyleBackColor = false;
            // 
            // KaynakDuzenleBtn
            // 
            this.KaynakDuzenleBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(96)))), ((int)(((byte)(26)))));
            this.KaynakDuzenleBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.KaynakDuzenleBtn.FlatAppearance.BorderSize = 0;
            this.KaynakDuzenleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KaynakDuzenleBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.KaynakDuzenleBtn.ImageKey = "update book.png";
            this.KaynakDuzenleBtn.ImageList = this.ımageList1;
            this.KaynakDuzenleBtn.Location = new System.Drawing.Point(0, 420);
            this.KaynakDuzenleBtn.Name = "KaynakDuzenleBtn";
            this.KaynakDuzenleBtn.Size = new System.Drawing.Size(150, 70);
            this.KaynakDuzenleBtn.TabIndex = 10;
            this.KaynakDuzenleBtn.Text = "              Kaynak Düzenle";
            this.KaynakDuzenleBtn.UseVisualStyleBackColor = false;
            // 
            // KaynakSilBtn
            // 
            this.KaynakSilBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(96)))), ((int)(((byte)(26)))));
            this.KaynakSilBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.KaynakSilBtn.FlatAppearance.BorderSize = 0;
            this.KaynakSilBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KaynakSilBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.KaynakSilBtn.ImageKey = "delete book.png";
            this.KaynakSilBtn.ImageList = this.ımageList1;
            this.KaynakSilBtn.Location = new System.Drawing.Point(0, 490);
            this.KaynakSilBtn.Name = "KaynakSilBtn";
            this.KaynakSilBtn.Size = new System.Drawing.Size(150, 70);
            this.KaynakSilBtn.TabIndex = 11;
            this.KaynakSilBtn.Text = "              Kaynak Sil";
            this.KaynakSilBtn.UseVisualStyleBackColor = false;
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "users.png");
            this.ımageList1.Images.SetKeyName(1, "add.png");
            this.ımageList1.Images.SetKeyName(2, "delete.png");
            this.ımageList1.Images.SetKeyName(3, "update.png");
            this.ımageList1.Images.SetKeyName(4, "add book.png");
            this.ımageList1.Images.SetKeyName(5, "books.png");
            this.ımageList1.Images.SetKeyName(6, "delete book.png");
            this.ımageList1.Images.SetKeyName(7, "update book.png");
            // 
            // IslemPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(1288, 636);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Name = "IslemPaneli";
            this.Text = "IslemPaneli";
            this.Load += new System.EventHandler(this.IslemPaneli_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Ksilbtn;
        private System.Windows.Forms.Button Kduzenbtn;
        private System.Windows.Forms.Button Keklebtn;
        private System.Windows.Forms.Button Kullanicibtn;
        private System.Windows.Forms.Button KaynakSilBtn;
        private System.Windows.Forms.Button KaynakDuzenleBtn;
        private System.Windows.Forms.Button KaynakEkleBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ImageList ımageList1;
    }
}