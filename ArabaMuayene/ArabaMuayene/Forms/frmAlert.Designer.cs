namespace ArabaMuayene.Forms
{
    partial class frmAlert
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.CloseBtn = new FontAwesome.Sharp.IconButton();
            this.ıconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.MsgLbl = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 60);
            this.panel1.TabIndex = 0;
            // 
            // CloseBtn
            // 
            this.CloseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseBtn.FlatAppearance.BorderSize = 0;
            this.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBtn.IconChar = FontAwesome.Sharp.IconChar.X;
            this.CloseBtn.IconColor = System.Drawing.Color.Gainsboro;
            this.CloseBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CloseBtn.Location = new System.Drawing.Point(221, 12);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(40, 35);
            this.CloseBtn.TabIndex = 1;
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // ıconPictureBox1
            // 
            this.ıconPictureBox1.BackColor = System.Drawing.Color.MidnightBlue;
            this.ıconPictureBox1.ForeColor = System.Drawing.Color.Gainsboro;
            this.ıconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            this.ıconPictureBox1.IconColor = System.Drawing.Color.Gainsboro;
            this.ıconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ıconPictureBox1.IconSize = 46;
            this.ıconPictureBox1.Location = new System.Drawing.Point(11, 12);
            this.ıconPictureBox1.Name = "ıconPictureBox1";
            this.ıconPictureBox1.Size = new System.Drawing.Size(46, 47);
            this.ıconPictureBox1.TabIndex = 2;
            this.ıconPictureBox1.TabStop = false;
            // 
            // MsgLbl
            // 
            this.MsgLbl.BackColor = System.Drawing.Color.MidnightBlue;
            this.MsgLbl.ForeColor = System.Drawing.Color.Gainsboro;
            this.MsgLbl.Location = new System.Drawing.Point(52, 17);
            this.MsgLbl.Name = "MsgLbl";
            this.MsgLbl.Size = new System.Drawing.Size(105, 30);
            this.MsgLbl.TabIndex = 3;
            this.MsgLbl.Text = "Message Text";
            this.MsgLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            // 
            // frmAlert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(273, 60);
            this.Controls.Add(this.MsgLbl);
            this.Controls.Add(this.ıconPictureBox1);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAlert";
            this.Text = "frmAlert";
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton CloseBtn;
        private FontAwesome.Sharp.IconPictureBox ıconPictureBox1;
        private System.Windows.Forms.Label MsgLbl;
        private System.Windows.Forms.Timer timer1;
    }
}