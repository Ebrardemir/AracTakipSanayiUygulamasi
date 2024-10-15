namespace ArabaMuayene.Forms
{
    partial class MusteriGoruntule
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
            this.SeparatorPnl1 = new System.Windows.Forms.Panel();
            this.StatusPnl = new System.Windows.Forms.Panel();
            this.SeparatorPnl2 = new System.Windows.Forms.Panel();
            this.ContentPnl = new System.Windows.Forms.Panel();
            this.LogoPnl = new System.Windows.Forms.Panel();
            this.DatePbx = new FontAwesome.Sharp.IconPictureBox();
            this.TimePbx = new FontAwesome.Sharp.IconPictureBox();
            this.DataLbl = new System.Windows.Forms.Label();
            this.TimeLbl = new System.Windows.Forms.Label();
            this.DashboardBtn = new System.Windows.Forms.Button();
            this.UserList = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.StatusPnl.SuspendLayout();
            this.ContentPnl.SuspendLayout();
            this.LogoPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DatePbx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimePbx)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SeparatorPnl1
            // 
            this.SeparatorPnl1.BackColor = System.Drawing.Color.White;
            this.SeparatorPnl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.SeparatorPnl1.Location = new System.Drawing.Point(0, 0);
            this.SeparatorPnl1.Name = "SeparatorPnl1";
            this.SeparatorPnl1.Size = new System.Drawing.Size(1107, 1);
            this.SeparatorPnl1.TabIndex = 2;
            // 
            // StatusPnl
            // 
            this.StatusPnl.BackColor = System.Drawing.Color.MidnightBlue;
            this.StatusPnl.Controls.Add(this.TimeLbl);
            this.StatusPnl.Controls.Add(this.DatePbx);
            this.StatusPnl.Controls.Add(this.DataLbl);
            this.StatusPnl.Controls.Add(this.TimePbx);
            this.StatusPnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.StatusPnl.Location = new System.Drawing.Point(0, 1);
            this.StatusPnl.Name = "StatusPnl";
            this.StatusPnl.Size = new System.Drawing.Size(1107, 47);
            this.StatusPnl.TabIndex = 3;
            // 
            // SeparatorPnl2
            // 
            this.SeparatorPnl2.BackColor = System.Drawing.Color.White;
            this.SeparatorPnl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.SeparatorPnl2.Location = new System.Drawing.Point(0, 48);
            this.SeparatorPnl2.Name = "SeparatorPnl2";
            this.SeparatorPnl2.Size = new System.Drawing.Size(1107, 1);
            this.SeparatorPnl2.TabIndex = 4;
            // 
            // ContentPnl
            // 
            this.ContentPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.ContentPnl.Controls.Add(this.panel1);
            this.ContentPnl.Controls.Add(this.LogoPnl);
            this.ContentPnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContentPnl.Location = new System.Drawing.Point(0, 49);
            this.ContentPnl.Name = "ContentPnl";
            this.ContentPnl.Size = new System.Drawing.Size(1107, 739);
            this.ContentPnl.TabIndex = 5;
            // 
            // LogoPnl
            // 
            this.LogoPnl.Controls.Add(this.DashboardBtn);
            this.LogoPnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.LogoPnl.Location = new System.Drawing.Point(0, 0);
            this.LogoPnl.Name = "LogoPnl";
            this.LogoPnl.Size = new System.Drawing.Size(1107, 10);
            this.LogoPnl.TabIndex = 0;
            // 
            // DatePbx
            // 
            this.DatePbx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.DatePbx.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DatePbx.ForeColor = System.Drawing.Color.Gainsboro;
            this.DatePbx.IconChar = FontAwesome.Sharp.IconChar.CalendarDay;
            this.DatePbx.IconColor = System.Drawing.Color.Gainsboro;
            this.DatePbx.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.DatePbx.Location = new System.Drawing.Point(705, 9);
            this.DatePbx.Name = "DatePbx";
            this.DatePbx.Size = new System.Drawing.Size(32, 32);
            this.DatePbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DatePbx.TabIndex = 0;
            this.DatePbx.TabStop = false;
            // 
            // TimePbx
            // 
            this.TimePbx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.TimePbx.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TimePbx.ForeColor = System.Drawing.Color.Gainsboro;
            this.TimePbx.IconChar = FontAwesome.Sharp.IconChar.ClockFour;
            this.TimePbx.IconColor = System.Drawing.Color.Gainsboro;
            this.TimePbx.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.TimePbx.Location = new System.Drawing.Point(900, 9);
            this.TimePbx.Name = "TimePbx";
            this.TimePbx.Size = new System.Drawing.Size(32, 32);
            this.TimePbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TimePbx.TabIndex = 1;
            this.TimePbx.TabStop = false;
            // 
            // DataLbl
            // 
            this.DataLbl.AutoSize = true;
            this.DataLbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DataLbl.ForeColor = System.Drawing.Color.Gainsboro;
            this.DataLbl.Location = new System.Drawing.Point(743, 14);
            this.DataLbl.Name = "DataLbl";
            this.DataLbl.Size = new System.Drawing.Size(42, 20);
            this.DataLbl.TabIndex = 0;
            this.DataLbl.Text = "Date";
            // 
            // TimeLbl
            // 
            this.TimeLbl.AutoSize = true;
            this.TimeLbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TimeLbl.ForeColor = System.Drawing.Color.Gainsboro;
            this.TimeLbl.Location = new System.Drawing.Point(938, 14);
            this.TimeLbl.Name = "TimeLbl";
            this.TimeLbl.Size = new System.Drawing.Size(44, 20);
            this.TimeLbl.TabIndex = 1;
            this.TimeLbl.Text = "Time";
            // 
            // DashboardBtn
            // 
            this.DashboardBtn.Location = new System.Drawing.Point(1, 117);
            this.DashboardBtn.Name = "DashboardBtn";
            this.DashboardBtn.Size = new System.Drawing.Size(57, 28);
            this.DashboardBtn.TabIndex = 0;
            this.DashboardBtn.Text = "button1";
            this.DashboardBtn.UseVisualStyleBackColor = true;
            // 
            // UserList
            // 
            this.UserList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UserList.IconChar = FontAwesome.Sharp.IconChar.UserCircle;
            this.UserList.IconColor = System.Drawing.Color.Black;
            this.UserList.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.UserList.Location = new System.Drawing.Point(3, -5);
            this.UserList.Name = "UserList";
            this.UserList.Size = new System.Drawing.Size(49, 45);
            this.UserList.TabIndex = 1;
            this.UserList.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.UserList);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1107, 37);
            this.panel1.TabIndex = 4;
            // 
            // MusteriGoruntule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1107, 788);
            this.Controls.Add(this.ContentPnl);
            this.Controls.Add(this.SeparatorPnl2);
            this.Controls.Add(this.StatusPnl);
            this.Controls.Add(this.SeparatorPnl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MusteriGoruntule";
            this.Text = "MusteriGoruntule";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.StatusPnl.ResumeLayout(false);
            this.StatusPnl.PerformLayout();
            this.ContentPnl.ResumeLayout(false);
            this.LogoPnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DatePbx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimePbx)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel SeparatorPnl1;
        private System.Windows.Forms.Panel StatusPnl;
        private System.Windows.Forms.Panel SeparatorPnl2;
        private System.Windows.Forms.Panel ContentPnl;
        private System.Windows.Forms.Panel LogoPnl;
        private FontAwesome.Sharp.IconPictureBox DatePbx;
        private FontAwesome.Sharp.IconPictureBox TimePbx;
        public System.Windows.Forms.Label DataLbl;
        public System.Windows.Forms.Label TimeLbl;
        private System.Windows.Forms.Button DashboardBtn;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton UserList;
    }
}