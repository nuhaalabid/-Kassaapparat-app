using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kassaapparat_app
{
    public partial class KassaRegister : Form
    {
        internal Form1 Form1;

        public KassaRegister()
        {
            InitializeComponent();
        }

        private void kassaregisterbutton_Click(object sender, EventArgs e)
        {
            Form1.SetUsernameAndPassword(kassaregisterNamnBox.Text,kassaregisterPassBox.Text);
            Close();
        }
    }
}
