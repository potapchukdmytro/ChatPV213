using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class SingUp : Form
    {
        public DialogResult result;

        public SingUp()
        {
            InitializeComponent();
            result = DialogResult.Abort;
            StartPosition = FormStartPosition.CenterParent;
        }

        private void signInBtn_Click(object sender, EventArgs e)
        {
            result = DialogResult.OK;
            Close();
        }

        private void buttonSingUp_Click(object sender, EventArgs e)
        {

        }
    }
}
