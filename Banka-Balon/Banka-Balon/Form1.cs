using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banka_Balon
{
    public partial class Form_Hlavni : Form
    {
        public Form_Hlavni()
        {
            InitializeComponent();
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            Form_Klient fk = new Form_Klient();
            fk.ShowDialog();
        }
    }
}
