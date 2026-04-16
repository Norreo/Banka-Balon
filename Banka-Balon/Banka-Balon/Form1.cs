using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Banka_Balon
{
    public partial class Form_Hlavni : Form
    {
        public Form_Hlavni()
        {
            InitializeComponent();
            Klient.DeserializujZXml("database.xml");
            foreach (var klient in Klient.Ucty)
            {
                listbox_klient.Items.Add(klient);
            }
        }

        private void btn_pridejKlienta_Click_1(object sender, EventArgs e)
        {
            Klient User = null;
            Form_Klient f2 = new Form_Klient(User);
            f2.ShowDialog();
            if (f2.DialogResult == DialogResult.OK)
            {
                listbox_klient.Items.Clear();
                foreach (var klient in Klient.Ucty)
                {
                    listbox_klient.Items.Add(klient);
                    Klient.SerializujDoXml("database.xml");
                }
            }

        }

        private void btn_upravitKlienta_Click_1(object sender, EventArgs e)
        {
            if (listbox_klient.SelectedItem != null)
            {
                Klient User = (Klient)listbox_klient.SelectedItem;
                Form_Klient f2 = new Form_Klient(User);
                f2.ShowDialog();
                if (f2.DialogResult == DialogResult.OK)
                {
                    Klient.Ucty.Remove(User);
                    listbox_klient.Items.Clear();
                    foreach (var klient in Klient.Ucty)
                    {
                        listbox_klient.Items.Add(klient);
                        Klient.SerializujDoXml("database.xml");
                    }
                }
            }
            else
            {
                MessageBox.Show("Vyberte klienta, kterého chcete upravit.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_odstranKlienta_Click_1(object sender, EventArgs e)
        {
            if (listbox_klient.SelectedItem != null)
            {
                Klient User = (Klient)listbox_klient.SelectedItem;
                Klient.Ucty.Remove(User);
                listbox_klient.Items.Clear();
                foreach (var klient in Klient.Ucty)
                {
                    listbox_klient.Items.Add(klient);
                }
            }
        }
    }
}






