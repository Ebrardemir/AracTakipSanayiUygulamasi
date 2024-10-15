using ArabaMuayene.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArabaMuayene.Forms
{
    public partial class frmAlert : Form
    {
        public frmAlert()
        {
            InitializeComponent();
            this.TopMost = true;
        }
        public enum enmAction
        {
            wait,
            start,
            close
        }

        public enum enmType
        {
            Success,
            Warning,
            Error,
            Info
        }

        private frmAlert.enmAction action;
        private int x, y;

        

        public void timer1_Tick(object sender, EventArgs e)
        {
            switch (this.action) {
                case enmAction.wait:
                    timer1.Interval = 5000;
                    action = enmAction.close;
                    break;
                case frmAlert.enmAction.start:
                    this.timer1.Interval = 1;
                    this.Opacity += 0.1;
                    if (this.x < this.Location.X)
                    {
                        this.Left--;
                    }
                    else
                    {
                        if (this.Opacity == 1.0) {
                            action = frmAlert.enmAction.wait;
                        }
                    }
                    break;
                case enmAction.close:
                    timer1.Interval = 1;
                    this.Opacity -= 0.1;

                    this.Left -= 3;
                    if (base.Opacity == 0.0)
                    {
                        this.Hide();
                        timer1.Stop();
                    }
                    break;

            }
        }
        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void showAlert(string msg, enmType type)
        {
            this.Opacity = 0.0;
            this.StartPosition= FormStartPosition.Manual;
            string fname;
/*
            for(int i = 1; i < 10; i++)
            {
                this.x = Screen.PrimaryScreen.WorkingArea.Width - base.Width - 5;
            }

            switch (type) {
                case enmType.Success:
                    this.ıconPictureBox1.Image = Resources.Checkmark_30px;
            }
*/
            this.MsgLbl.Text = msg;
            this.Show();
            this.action = enmAction.start;
            this.timer1.Interval = 1;
            this.timer1.Start();
        }


    } 
}
