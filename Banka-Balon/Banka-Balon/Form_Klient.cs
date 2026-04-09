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
    public partial class Form_Klient : Form
    {
        Klient User;
        public Form_Klient(Klient user)
        {
            InitializeComponent();
            User = user;

            

            if (User != null ) 
            {
                tb_Jmeno.Text = User.Jmeno;
                tb_Prijmeni.Text = User.Prijmeni;
                tb_Username.Text = User.UzivatelskeJmeno;
                tb_Heslo.Text = User.Heslo;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            {
                if (User == null)
                {
                    try
                    {
                        Klient novyKlient = new Klient(tb_Jmeno.Text, tb_Prijmeni.Text, tb_Username.Text, tb_Heslo.Text);
                        Klient.PridejKlienta(novyKlient);
                        DialogResult = DialogResult.OK;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Něco se pokazilo, zkontrolujte znovu zadané údaje");
                        DialogResult = DialogResult.None;
                    }
                }
                else
                {
                    try
                    {
                        Klient upravenyKlient = new Klient(tb_Jmeno.Text, tb_Prijmeni.Text, tb_Username.Text, tb_Heslo.Text);
                        Klient.PridejKlienta(upravenyKlient);
                        DialogResult = DialogResult.OK;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Něco se pokazilo, zkontrolujte znovu zadané údaje");
                        DialogResult = DialogResult.None;
                    }

                }
            }

        }
  }
}


