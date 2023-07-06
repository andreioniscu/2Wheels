using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2Wheels
{
    public partial class MsgBox : Form
    {
        public MsgBox(string mesaj, string button, bool eroare)
        {
            InitializeComponent();
            label1.Text = mesaj;
            if (eroare)
            {
                this.BackColor = Color.Red;
                label1.BackColor = Color.Red;
            }
            button1.Text = button;
            this.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
