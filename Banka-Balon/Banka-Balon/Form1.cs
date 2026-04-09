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
            Klient User = null;
            Form_Klient fk = new Form_Klient(User);
            fk.ShowDialog();
            if (fk.DialogResult == DialogResult.OK)
            {
                listbox_klient.Items.Clear();
                foreach (var klient in Klient.Ucty)
                {
                    listbox_klient.Items.Add(klient);
                }
            }
        }

        private void button_custom_Click(object sender, EventArgs e)
        {
            if (listbox_klient.SelectedItem != null)
            {
                Klient User = (Klient)listbox_klient.SelectedItem;
                Form_Klient fk = new Form_Klient(User);
                fk.ShowDialog();
                if (fk.DialogResult == DialogResult.OK)
                {
                    Klient.Ucty.Remove(User);
                    listbox_klient.Items.Clear();
                    foreach (var klient in Klient.Ucty)
                    {
                        listbox_klient.Items.Add(klient);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vyberte klienta, kterého chcete upravit.");
            }
        }
    }
}
