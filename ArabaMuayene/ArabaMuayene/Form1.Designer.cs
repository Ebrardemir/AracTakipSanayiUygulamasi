namespace ArabaMuayene
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMenu = new System.Windows.Forms.Panel();
            this.ıconmusteriekle = new FontAwesome.Sharp.IconButton();
            this.ıconmusterigoruntule = new FontAwesome.Sharp.IconButton();
            this.ıconaaracekle = new FontAwesome.Sharp.IconButton();
            this.ıconaracgoruntule = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.lblHome = new System.Windows.Forms.Label();
            this.iconChild = new FontAwesome.Sharp.IconPictureBox();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.panelDesktop1 = new System.Windows.Forms.Panel();
            this.panelicon = new System.Windows.Forms.Panel();
            this.ıconExit = new FontAwesome.Sharp.IconButton();
            this.btnMinimize = new FontAwesome.Sharp.IconButton();
            this.btnMaximize = new FontAwesome.Sharp.IconButton();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconChild)).BeginInit();
            this.panelicon.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelMenu.Controls.Add(this.ıconmusteriekle);
            this.panelMenu.Controls.Add(this.ıconmusterigoruntule);
            this.panelMenu.Controls.Add(this.ıconaaracekle);
            this.panelMenu.Controls.Add(this.ıconaracgoruntule);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 566);
            this.panelMenu.TabIndex = 0;
            // 
            // ıconmusteriekle
            // 
            this.ıconmusteriekle.Dock = System.Windows.Forms.DockStyle.Top;
            this.ıconmusteriekle.FlatAppearance.BorderSize = 0;
            this.ıconmusteriekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ıconmusteriekle.ForeColor = System.Drawing.Color.Gainsboro;
            this.ıconmusteriekle.IconChar = FontAwesome.Sharp.IconChar.PersonCirclePlus;
            this.ıconmusteriekle.IconColor = System.Drawing.Color.Gainsboro;
            this.ıconmusteriekle.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ıconmusteriekle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ıconmusteriekle.Location = new System.Drawing.Point(0, 402);
            this.ıconmusteriekle.Name = "ıconmusteriekle";
            this.ıconmusteriekle.Size = new System.Drawing.Size(220, 83);
            this.ıconmusteriekle.TabIndex = 4;
            this.ıconmusteriekle.Text = "Müşteri Ekle";
            this.ıconmusteriekle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ıconmusteriekle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ıconmusteriekle.UseVisualStyleBackColor = true;
            this.ıconmusteriekle.Click += new System.EventHandler(this.ıconmusteriekle_Click);
            // 
            // ıconmusterigoruntule
            // 
            this.ıconmusterigoruntule.Dock = System.Windows.Forms.DockStyle.Top;
            this.ıconmusterigoruntule.FlatAppearance.BorderSize = 0;
            this.ıconmusterigoruntule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ıconmusterigoruntule.ForeColor = System.Drawing.Color.Gainsboro;
            this.ıconmusterigoruntule.IconChar = FontAwesome.Sharp.IconChar.Person;
            this.ıconmusterigoruntule.IconColor = System.Drawing.Color.Gainsboro;
            this.ıconmusterigoruntule.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ıconmusterigoruntule.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ıconmusterigoruntule.Location = new System.Drawing.Point(0, 319);
            this.ıconmusterigoruntule.Name = "ıconmusterigoruntule";
            this.ıconmusterigoruntule.Size = new System.Drawing.Size(220, 83);
            this.ıconmusterigoruntule.TabIndex = 3;
            this.ıconmusterigoruntule.Text = "Müşteri Görüntüle";
            this.ıconmusterigoruntule.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ıconmusterigoruntule.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ıconmusterigoruntule.UseVisualStyleBackColor = true;
            this.ıconmusterigoruntule.Click += new System.EventHandler(this.ıconmusterigoruntule_Click);
            // 
            // ıconaaracekle
            // 
            this.ıconaaracekle.Dock = System.Windows.Forms.DockStyle.Top;
            this.ıconaaracekle.FlatAppearance.BorderSize = 0;
            this.ıconaaracekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ıconaaracekle.ForeColor = System.Drawing.Color.Gainsboro;
            this.ıconaaracekle.IconChar = FontAwesome.Sharp.IconChar.CarOn;
            this.ıconaaracekle.IconColor = System.Drawing.Color.Gainsboro;
            this.ıconaaracekle.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ıconaaracekle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ıconaaracekle.Location = new System.Drawing.Point(0, 236);
            this.ıconaaracekle.Name = "ıconaaracekle";
            this.ıconaaracekle.Size = new System.Drawing.Size(220, 83);
            this.ıconaaracekle.TabIndex = 2;
            this.ıconaaracekle.Text = "Araç Ekle";
            this.ıconaaracekle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ıconaaracekle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ıconaaracekle.UseVisualStyleBackColor = true;
            this.ıconaaracekle.Click += new System.EventHandler(this.ıconaaracekle_Click);
            // 
            // ıconaracgoruntule
            // 
            this.ıconaracgoruntule.Dock = System.Windows.Forms.DockStyle.Top;
            this.ıconaracgoruntule.FlatAppearance.BorderSize = 0;
            this.ıconaracgoruntule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ıconaracgoruntule.ForeColor = System.Drawing.Color.Gainsboro;
            this.ıconaracgoruntule.IconChar = FontAwesome.Sharp.IconChar.Car;
            this.ıconaracgoruntule.IconColor = System.Drawing.Color.Gainsboro;
            this.ıconaracgoruntule.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ıconaracgoruntule.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ıconaracgoruntule.Location = new System.Drawing.Point(0, 153);
            this.ıconaracgoruntule.Name = "ıconaracgoruntule";
            this.ıconaracgoruntule.Size = new System.Drawing.Size(220, 83);
            this.ıconaracgoruntule.TabIndex = 1;
            this.ıconaracgoruntule.Text = "Araç Görüntüle";
            this.ıconaracgoruntule.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ıconaracgoruntule.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ıconaracgoruntule.UseVisualStyleBackColor = true;
            this.ıconaracgoruntule.Click += new System.EventHandler(this.ıconaracgoruntule_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.btnHome);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.panelLogo.Size = new System.Drawing.Size(220, 153);
            this.panelLogo.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.Image = global::ArabaMuayene.Properties.Resources._5;
            this.btnHome.InitialImage = global::ArabaMuayene.Properties.Resources._1;
            this.btnHome.Location = new System.Drawing.Point(12, 24);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(194, 109);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnHome.TabIndex = 0;
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panelTitleBar.Controls.Add(this.panelicon);
            this.panelTitleBar.Controls.Add(this.lblHome);
            this.panelTitleBar.Controls.Add(this.iconChild);
            this.panelTitleBar.Controls.Add(this.panelDesktop);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(220, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(869, 105);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown_1);
            // 
            // lblHome
            // 
            this.lblHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHome.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblHome.Location = new System.Drawing.Point(72, 40);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(161, 34);
            this.lblHome.TabIndex = 1;
            this.lblHome.Text = "Home";
            // 
            // iconChild
            // 
            this.iconChild.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.iconChild.ForeColor = System.Drawing.Color.MediumPurple;
            this.iconChild.IconChar = FontAwesome.Sharp.IconChar.House;
            this.iconChild.IconColor = System.Drawing.Color.MediumPurple;
            this.iconChild.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconChild.IconSize = 42;
            this.iconChild.Location = new System.Drawing.Point(24, 32);
            this.iconChild.Name = "iconChild";
            this.iconChild.Size = new System.Drawing.Size(42, 42);
            this.iconChild.TabIndex = 0;
            this.iconChild.TabStop = false;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panelDesktop.Location = new System.Drawing.Point(96, 139);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(678, 459);
            this.panelDesktop.TabIndex = 3;
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.Location = new System.Drawing.Point(220, 105);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(869, 13);
            this.panelShadow.TabIndex = 2;
            // 
            // panelDesktop1
            // 
            this.panelDesktop1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panelDesktop1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop1.Location = new System.Drawing.Point(220, 118);
            this.panelDesktop1.Name = "panelDesktop1";
            this.panelDesktop1.Size = new System.Drawing.Size(869, 448);
            this.panelDesktop1.TabIndex = 3;
            // 
            // panelicon
            // 
            this.panelicon.Controls.Add(this.btnMinimize);
            this.panelicon.Controls.Add(this.btnMaximize);
            this.panelicon.Controls.Add(this.ıconExit);
            this.panelicon.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelicon.Location = new System.Drawing.Point(731, 0);
            this.panelicon.Name = "panelicon";
            this.panelicon.Size = new System.Drawing.Size(138, 105);
            this.panelicon.TabIndex = 0;
            // 
            // ıconExit
            // 
            this.ıconExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ıconExit.IconChar = FontAwesome.Sharp.IconChar.Remove;
            this.ıconExit.IconColor = System.Drawing.Color.Gainsboro;
            this.ıconExit.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.ıconExit.Location = new System.Drawing.Point(118, 5);
            this.ıconExit.Name = "ıconExit";
            this.ıconExit.Size = new System.Drawing.Size(20, 20);
            this.ıconExit.TabIndex = 0;
            this.ıconExit.UseVisualStyleBackColor = true;
            this.ıconExit.Click += new System.EventHandler(this.ıconExit_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMinimize.IconColor = System.Drawing.Color.Gainsboro;
            this.btnMinimize.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnMinimize.Location = new System.Drawing.Point(41, 3);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(26, 25);
            this.btnMinimize.TabIndex = 1;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click_1);
            // 
            // btnMaximize
            // 
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.btnMaximize.IconColor = System.Drawing.Color.Gainsboro;
            this.btnMaximize.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnMaximize.Location = new System.Drawing.Point(82, 5);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(20, 20);
            this.btnMaximize.TabIndex = 2;
            this.btnMaximize.UseVisualStyleBackColor = true;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 566);
            this.Controls.Add(this.panelDesktop1);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconChild)).EndInit();
            this.panelicon.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton ıconaracgoruntule;
        private FontAwesome.Sharp.IconButton ıconmusteriekle;
        private FontAwesome.Sharp.IconButton ıconmusterigoruntule;
        private FontAwesome.Sharp.IconButton ıconaaracekle;
        private System.Windows.Forms.PictureBox btnHome;
        private System.Windows.Forms.Panel panelTitleBar;
        private FontAwesome.Sharp.IconPictureBox iconChild;
        private System.Windows.Forms.Label lblHome;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Panel panelShadow;
        private System.Windows.Forms.Panel panelDesktop1;
        private System.Windows.Forms.Panel panelicon;
        private FontAwesome.Sharp.IconButton ıconExit;
        private FontAwesome.Sharp.IconButton btnMinimize;
        private FontAwesome.Sharp.IconButton btnMaximize;
    }
}

