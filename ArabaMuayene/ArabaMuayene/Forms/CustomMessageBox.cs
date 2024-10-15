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
    public partial class CustomMessageBox : Form
    { 
        public CustomMessageBox()
        {
            InitializeComponent();
        }
        private static readonly frmCustomMessageBox _messageBox = new frmCustomMessageBox();

        public static DialogResult ShowMessage(string message, string caption, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            _messageBox.Initialize(message, caption, buttons, icon);
            return _messageBox.ShowDialog();
        }

        public static DialogResult ShowConfirmation(string message, string caption)
        {
            _messageBox.InitializeConfirmation(message, caption);
            return _messageBox.ShowDialog();
        }

        public static DialogResult ShowError(string message,string caption, MessageBoxButtons buttons=MessageBoxButtons.OK, MessageBoxIcon icon = MessageBoxIcon.Error)
        {
            _messageBox.InitializeError(message, caption, buttons, icon);
            return _messageBox.ShowDialog();
        }


       
    }
}
