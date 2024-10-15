namespace ArabaMuayene.Forms
{
    partial class frmCustomMessageBox
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
            this.SidePnl = new System.Windows.Forms.Panel();
            this.HeaderPnl = new System.Windows.Forms.Panel();
            this.IconPbx = new FontAwesome.Sharp.IconPictureBox();
            this.MessageCaptionLbl = new System.Windows.Forms.Label();
            this.FooterPnl = new System.Windows.Forms.Panel();
            this.ContentPnl = new System.Windows.Forms.Panel();
            this.MessageLbl = new System.Windows.Forms.Label();
            this.NoBtn = new System.Windows.Forms.Button();
            this.YesBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.OkBtn = new System.Windows.Forms.Button();
            this.HeaderPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconPbx)).BeginInit();
            this.ContentPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // SidePnl
            // 
            this.SidePnl.BackColor = System.Drawing.Color.MidnightBlue;
            this.SidePnl.Dock = System.Windows.Forms.DockStyle.Left;
            this.SidePnl.Location = new System.Drawing.Point(0, 0);
            this.SidePnl.Name = "SidePnl";
            this.SidePnl.Size = new System.Drawing.Size(10, 198);
            this.SidePnl.TabIndex = 0;
            // 
            // HeaderPnl
            // 
            this.HeaderPnl.BackColor = System.Drawing.Color.MidnightBlue;
            this.HeaderPnl.Controls.Add(this.IconPbx);
            this.HeaderPnl.Controls.Add(this.MessageCaptionLbl);
            this.HeaderPnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPnl.Location = new System.Drawing.Point(10, 0);
            this.HeaderPnl.Name = "HeaderPnl";
            this.HeaderPnl.Size = new System.Drawing.Size(424, 47);
            this.HeaderPnl.TabIndex = 1;
            // 
            // IconPbx
            // 
            this.IconPbx.BackColor = System.Drawing.Color.MidnightBlue;
            this.IconPbx.ForeColor = System.Drawing.SystemColors.ControlText;
            this.IconPbx.IconChar = FontAwesome.Sharp.IconChar.None;
            this.IconPbx.IconColor = System.Drawing.SystemColors.ControlText;
            this.IconPbx.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconPbx.IconSize = 40;
            this.IconPbx.Location = new System.Drawing.Point(376, 4);
            this.IconPbx.Name = "IconPbx";
            this.IconPbx.Size = new System.Drawing.Size(42, 40);
            this.IconPbx.TabIndex = 5;
            this.IconPbx.TabStop = false;
            // 
            // MessageCaptionLbl
            // 
            this.MessageCaptionLbl.AutoSize = true;
            this.MessageCaptionLbl.ForeColor = System.Drawing.Color.White;
            this.MessageCaptionLbl.Location = new System.Drawing.Point(5, 15);
            this.MessageCaptionLbl.Name = "MessageCaptionLbl";
            this.MessageCaptionLbl.Size = new System.Drawing.Size(113, 16);
            this.MessageCaptionLbl.TabIndex = 4;
            this.MessageCaptionLbl.Text = "Message Caption";
            // 
            // FooterPnl
            // 
            this.FooterPnl.BackColor = System.Drawing.Color.MidnightBlue;
            this.FooterPnl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.FooterPnl.Location = new System.Drawing.Point(10, 171);
            this.FooterPnl.Name = "FooterPnl";
            this.FooterPnl.Size = new System.Drawing.Size(424, 27);
            this.FooterPnl.TabIndex = 2;
            // 
            // ContentPnl
            // 
            this.ContentPnl.BackColor = System.Drawing.Color.MidnightBlue;
            this.ContentPnl.Controls.Add(this.MessageLbl);
            this.ContentPnl.Controls.Add(this.NoBtn);
            this.ContentPnl.Controls.Add(this.YesBtn);
            this.ContentPnl.Controls.Add(this.CancelBtn);
            this.ContentPnl.Controls.Add(this.OkBtn);
            this.ContentPnl.Location = new System.Drawing.Point(10, 47);
            this.ContentPnl.Name = "ContentPnl";
            this.ContentPnl.Size = new System.Drawing.Size(424, 124);
            this.ContentPnl.TabIndex = 3;
            // 
            // MessageLbl
            // 
            this.MessageLbl.AutoSize = true;
            this.MessageLbl.ForeColor = System.Drawing.Color.White;
            this.MessageLbl.Location = new System.Drawing.Point(6, 8);
            this.MessageLbl.Name = "MessageLbl";
            this.MessageLbl.Size = new System.Drawing.Size(67, 16);
            this.MessageLbl.TabIndex = 5;
            this.MessageLbl.Text = "Message ";
            // 
            // NoBtn
            // 
            this.NoBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.NoBtn.BackColor = System.Drawing.Color.Red;
            this.NoBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NoBtn.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.NoBtn.FlatAppearance.BorderSize = 0;
            this.NoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NoBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.NoBtn.ForeColor = System.Drawing.Color.White;
            this.NoBtn.Location = new System.Drawing.Point(362, 90);
            this.NoBtn.Name = "NoBtn";
            this.NoBtn.Size = new System.Drawing.Size(57, 28);
            this.NoBtn.TabIndex = 3;
            this.NoBtn.Text = "No";
            this.NoBtn.UseVisualStyleBackColor = false;
            this.NoBtn.Click += new System.EventHandler(this.NoBtn_Click);
            // 
            // YesBtn
            // 
            this.YesBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.YesBtn.BackColor = System.Drawing.Color.Blue;
            this.YesBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.YesBtn.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.YesBtn.FlatAppearance.BorderSize = 0;
            this.YesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.YesBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.YesBtn.ForeColor = System.Drawing.Color.White;
            this.YesBtn.Location = new System.Drawing.Point(299, 90);
            this.YesBtn.Name = "YesBtn";
            this.YesBtn.Size = new System.Drawing.Size(57, 28);
            this.YesBtn.TabIndex = 2;
            this.YesBtn.Text = "Yes";
            this.YesBtn.UseVisualStyleBackColor = false;
            this.YesBtn.Click += new System.EventHandler(this.YesBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CancelBtn.BackColor = System.Drawing.Color.Red;
            this.CancelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelBtn.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.CancelBtn.FlatAppearance.BorderSize = 0;
            this.CancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CancelBtn.ForeColor = System.Drawing.Color.White;
            this.CancelBtn.Location = new System.Drawing.Point(66, 90);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(74, 28);
            this.CancelBtn.TabIndex = 1;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = false;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // OkBtn
            // 
            this.OkBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.OkBtn.BackColor = System.Drawing.Color.ForestGreen;
            this.OkBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OkBtn.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.OkBtn.FlatAppearance.BorderSize = 0;
            this.OkBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OkBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OkBtn.ForeColor = System.Drawing.Color.White;
            this.OkBtn.Location = new System.Drawing.Point(3, 90);
            this.OkBtn.Name = "OkBtn";
            this.OkBtn.Size = new System.Drawing.Size(57, 28);
            this.OkBtn.TabIndex = 0;
            this.OkBtn.Text = "OK";
            this.OkBtn.UseVisualStyleBackColor = false;
            this.OkBtn.Click += new System.EventHandler(this.OkBtn_Click);
            // 
            // frmCustomMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(434, 198);
            this.Controls.Add(this.ContentPnl);
            this.Controls.Add(this.FooterPnl);
            this.Controls.Add(this.HeaderPnl);
            this.Controls.Add(this.SidePnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCustomMessageBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCustomMessageBox";
            this.HeaderPnl.ResumeLayout(false);
            this.HeaderPnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconPbx)).EndInit();
            this.ContentPnl.ResumeLayout(false);
            this.ContentPnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SidePnl;
        private System.Windows.Forms.Panel HeaderPnl;
        private System.Windows.Forms.Panel FooterPnl;
        private System.Windows.Forms.Panel ContentPnl;
        private System.Windows.Forms.Button OkBtn;
        private System.Windows.Forms.Button NoBtn;
        private System.Windows.Forms.Button YesBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Label MessageCaptionLbl;
        private FontAwesome.Sharp.IconPictureBox IconPbx;
        private System.Windows.Forms.Label MessageLbl;
    }
}