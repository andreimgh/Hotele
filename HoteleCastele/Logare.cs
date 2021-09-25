using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HoteleCastele
{
    public partial class Logare : Form
    {
        Dal.DalLogare DalLogare = new Dal.DalLogare();

        public Logare()
        {
            InitializeComponent();
        }

        private void Btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_login_Click(object sender, EventArgs e)
        {
            List<bool> Verif = DalLogare.Verificare(txt_id.Text, parola);
            if (Verif[0] == true && Verif[1] == true)
            {
                Form1 form1 = new Form1();
                form1.Show();
                lbl_erori.Visible = false;
                
            }
            else if(Verif[0] != true && Verif[1] != true)
               lbl_erori.Text = "Datele introduse sunt incorecte";
            else if (Verif[0] != true)
                lbl_erori.Text = "Id incorect";
            else 
                lbl_erori.Text = "Parola incorecta";
           
        }

        public string parola=null;
        private void Txt_password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && (char.IsWhiteSpace(e.KeyChar) || char.IsSeparator(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar)))
            { e.Handled = true; }
            else if (char.IsControl(e.KeyChar) && (e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                if (txt_password.Text.Length > 0)
                    txt_password.Text = txt_password.Text.Remove(txt_password.Text.Length - 1, 1);
                else
                    e.Handled = true;

            }
            else if (char.IsControl(e.KeyChar) && e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                List<bool> Verif = DalLogare.Verificare(txt_id.Text, parola);
                if (Verif[0] == true && Verif[1] == true)
                {
                    Form1 form1 = new Form1();
                    form1.Show();
                }
                else if (Verif[0] != true && Verif[1] != true)
                    lbl_erori.Text = "Datele introduse sunt incorecte";
                else if (Verif[0] != true)
                    lbl_erori.Text = "Id incorect";
                else
                    lbl_erori.Text = "Parola incorecta";

            }
            else if (char.IsControl(e.KeyChar) && e.KeyChar == Convert.ToChar(Keys.Escape))
                e.Handled = true;
            else
            {

                string caracter = e.KeyChar.ToString();
                if (parola == null)
                {
                    parola = caracter;
                    e.Handled = true;
                    txt_password.Text = "*";
                }
                else
                {
                    parola = parola.Insert(parola.Length, caracter);
                    e.Handled = true;
                    txt_password.AppendText("*");
                }

            }
        }
    }
}