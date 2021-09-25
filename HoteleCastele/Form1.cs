using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using DataTable = System.Data.DataTable;

namespace HoteleCastele
{

    public partial class Form1 : Form
    {
        Dal.DalHotel DalHotel = new Dal.DalHotel();
        Dal.DalCity DalCity = new Dal.DalCity();
        Dal.DalH_S DalH_S = new Dal.DalH_S();
        Dal.DalCountry DalCountry = new Dal.DalCountry();
        Dal.DalRoom DalRoom = new Dal.DalRoom();
        Dal.DalOpinii DalOpinii = new Dal.DalOpinii();
        Dal.DalRezervari DalRezervari = new Dal.DalRezervari();
        Dal.DalExport Export = new Dal.DalExport();
        Dal.DalMasini dalMasini = new Dal.DalMasini();

        public Form1()
        {
            InitializeComponent();
            DGV_Info.Columns.Add("Price", "Price");
            DGV_Info.Columns["Price"].Visible = false;
            dgv_masini.Columns.Add("Pret","Pret masina");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmb_City.Enabled = false;
            cmb_Hotel.Enabled = false;
            cmb_Country.Enabled = false;
        }

        public void BTN_GetAll_Click(object sender, EventArgs e)
        {

            try
            {
                cmb_Country.Enabled = true;
                DGV_Info.Columns["Price"].Visible = false;
                dgv_opinii.Visible = false;
                DGV_Info.Visible = true;
                DataTable dt = new DataTable();
                dt = DalHotel.GetAll();
                DGV_Info.DataSource = dt;
                cmb_Country.Items.Clear();
                List<string> Country = new List<string>();
                Country = DalCountry.Country();
                cmb_Country.DataSource = Country;
                dgv_masini.Visible = false;
            }
            catch (Exception ss)
            {
                using (StreamWriter file = new StreamWriter(@"D:\Erori.txt", true))
                {
                    file.WriteLine(ss.Message);
                }
            }
            cmb_City.Enabled = false;
            cmb_Hotel.Enabled = false;

        }

        public void Cmb_Country_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmb_Country.SelectedItem.ToString() != "Select Country")
                {
                    cmb_Country.Enabled = true;

                    List<string> City = new List<string>();
                    City = DalCity.City(cmb_Country.SelectedIndex);
                    cmb_City.DataSource = City;

                    if (cmb_Country.SelectedIndex != -1)
                    {
                        cmb_City.Items.Clear();
                        City = DalCity.City(cmb_Country.SelectedIndex);
                        cmb_City.DataSource = City;
                        cmb_Hotel.Text = "";


                    }
                }
            }
            catch (Exception ss)
            {
                using (StreamWriter file = new StreamWriter(@"D:\Erori.txt", true))
                {
                    file.WriteLine(ss.Message);
                }
            }
            cmb_Hotel.Enabled = false;
        }

        public void Cmb_City_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cmb_City.Enabled = true;
                cmb_Hotel.Enabled = true;
                List<string> Hotel = new List<string>();
                Hotel = DalHotel.Hotel(cmb_City.SelectedItem.ToString());
                cmb_Hotel.DataSource = Hotel;
                if (cmb_City.SelectedIndex != -1)
                {
                    cmb_Hotel.Items.Clear();
                    Hotel = DalHotel.Hotel(cmb_City.SelectedItem.ToString());
                    cmb_Hotel.DataSource = Hotel;
                }
            }
            catch (Exception ss)
            {
                using (StreamWriter file = new StreamWriter(@"D:\Erori.txt", true))
                {
                    file.WriteLine(ss.Message);
                }
            }
        }

        public void Btn_Room_Click(object sender, EventArgs e)
        {
            try
            {
                Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-US");
                Thread.CurrentThread.CurrentUICulture = CultureInfo.CreateSpecificCulture("en-US");
                pnl_delete.Visible = false;
                DGV_Info.Columns["Price"].Visible = true;
                DataTable dt = new DataTable();
                DataTable table = dalMasini.GetMasini(cmb_Hotel.SelectedItem.ToString());
                DataSet ds = new DataSet();
                DGV_Info.Visible = true;
                dgv_opinii.Visible = true;
                ds = DalRoom.GetRoom(cmb_Hotel.SelectedItem.ToString());
                DGV_Info.DataSource = ds.Tables[0];
                DGV_Info.Columns["ROOM_ID"].Visible = false;
                dt = DalOpinii.Opinii(cmb_Hotel.SelectedItem.ToString());
                dgv_opinii.DataSource = dt;
                dgv_opinii.Columns["OPINIE"].Width = 300;
                dgv_masini.Columns["masina_pret"].Visible = false;
                DGV_Info.Columns["Pret"].Visible = false;
                dgv_masini.DataSource = table;
                dgv_masini.Visible = true;
                for (int i = 0; i < dgv_masini.Rows.Count; i++)
                { dgv_masini.Rows[i].Cells["Pret"].Value = string.Format("{0:c}", dgv_masini.Rows[i].Cells["masina_pret"].Value).ToString(); }
                for (int i = 0; i < DGV_Info.Rows.Count; i++)
                { DGV_Info.Rows[i].Cells["Price"].Value = string.Format("{0:c}", DGV_Info.Rows[i].Cells["Pret"].Value).ToString(); }
            }
            catch (Exception ss)
            {
                using (StreamWriter file = new StreamWriter(@"D:\Erori.txt", true))
                {
                    file.WriteLine(ss.Message);
                }
            }
        }

        public void Btn_Reset_Click(object sender, EventArgs e)
        {
            try
            {
                pnl_delete.Visible = false;
                Action<Control.ControlCollection> buton = null;
                buton = Controls =>
                {
                    foreach (Control Control in Controls)
                    {
                        if (Control is DataGridView)
                        {
                            (Control as DataGridView).Visible = false;
                        }
                        if (Control is ComboBox)
                        {
                            (Control as ComboBox).Text = "Select";
                        }
                        if (Control is System.Windows.Forms.TextBox)
                        {
                            (Control as System.Windows.Forms.TextBox).Text = "";
                        }
                    }
                };
                buton(Controls);
                cmb_Country.Text = "Select Country";
                cmb_City.Text = "";
                cmb_Hotel.Text = "";
                cmb_City.Enabled = false;
                cmb_Hotel.Enabled = false;
            }
            catch (Exception ss)
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"D:\Erori.txt", true))
                {
                    file.WriteLine(ss.Message);
                }
            }
        }
        public static string CountryText;
        public static string CityText;
        public static string HotelText;
        public static string StatusText;
        public static string CameraText;
        public static string ServiciText;
        public static string Id;
        public static double Price;
        public static double masina_p;
        public static string nume_mas;
        public void BTN_Rezervation_Click(object sender, EventArgs e)
        {
            try
            {
                DGV_Info.Columns["Price"].Visible = false;
                Verificare verif = new Verificare();
                CountryText = cmb_Country.Text;
                CityText = cmb_City.Text;
                HotelText = cmb_Hotel.Text;
                verif.Show();
            }
            catch (Exception ss)
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"D:\Erori.txt", true))
                {
                    file.WriteLine(ss.Message);
                }
            }

        }

        private void DGV_Info_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                pnl_delete.Visible = false;
                DataGridViewSelectedRowCollection Select = DGV_Info.SelectedRows;
                foreach (DataGridViewRow randuri in Select)
                {
                    DataRow Randulete = (randuri.DataBoundItem as DataRowView).Row;
                    StatusText = DGV_Info.Rows[Randulete.Table.Rows.IndexOf(Randulete)].Cells["STATUS"].Value.ToString();
                    CameraText = DGV_Info.Rows[Randulete.Table.Rows.IndexOf(Randulete)].Cells["ROOM"].Value.ToString();
                    ServiciText = DGV_Info.Rows[Randulete.Table.Rows.IndexOf(Randulete)].Cells["SERVICII"].Value.ToString();
                    txt_Room.Text = DGV_Info.Rows[Randulete.Table.Rows.IndexOf(Randulete)].Cells["ROOM"].Value.ToString();
                    txt_Service.Text = DGV_Info.Rows[Randulete.Table.Rows.IndexOf(Randulete)].Cells["SERVICII"].Value.ToString();
                    txt_Family.Text = DGV_Info.Rows[Randulete.Table.Rows.IndexOf(Randulete)].Cells["FAMILY"].Value.ToString();
                    Id = DGV_Info.Rows[Randulete.Table.Rows.IndexOf(Randulete)].Cells["ROOM_ID"].Value.ToString();
                    Price = Convert.ToInt32(DGV_Info.Rows[Randulete.Table.Rows.IndexOf(Randulete)].Cells["Pret"].Value.ToString());
                    txt_Pret.Text = DGV_Info.Rows[Randulete.Table.Rows.IndexOf(Randulete)].Cells["Pret"].Value.ToString();
                }
            }


            catch (Exception ss)
            {
                using (StreamWriter file = new StreamWriter(@"D:\Erori.txt", true))
                {
                    file.WriteLine(ss.Message);
                }
            }
        }

        private void Btn_Rezervari_Click(object sender, EventArgs e)
        {
            try
            {
                DGV_Info.Columns["Price"].Visible = false;
                DGV_Info.Visible = true;
                DataTable dt = new DataTable();
                dt = DalRezervari.GetRezervation();
                DGV_Info.DataSource = dt;
                dgv_masini.Visible = false;
                dgv_opinii.Visible = false;
                DGV_Info.Columns["REZERVATION_ID"].Visible = false;
            }
            catch (Exception ss)
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"D:\Erori.txt", true))
                {
                    file.WriteLine(ss.Message);
                }
            }
        }

        private void Btn_Web_Click(object sender, EventArgs e)
        {
            try
            {
                Web verif = new Web();

                verif.Show();
            }
            catch (Exception ss)
            {
                using (StreamWriter file = new StreamWriter(@"D:\Erori.txt", true))
                {
                    file.WriteLine(ss.Message);
                }
            }
        }

        private void Btn_Export_Click(object sender, EventArgs e)
        {
            Export.Export();
        }

        private void Btn_Import_Click(object sender, EventArgs e)
        {
            DGV_Info.Visible = true;
            DataTable dt = new DataTable();
            dt = Export.Import();
            DGV_Info.DataSource = dt;
        }

        private void Btn_D_R_Click(object sender, EventArgs e)
        {
            pnl_delete.Visible = true;
        }

        private void Btn_delete_Click(object sender, EventArgs e)
        {
            DalRezervari.DeleteRezervation(Convert.ToInt32(txt_id.Text));
            pnl_delete.Visible = false;
        }


        private void Dgv_masini_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                pnl_delete.Visible = false;
                DataGridViewSelectedRowCollection Select = dgv_masini.SelectedRows;

                foreach (DataGridViewRow randuri in Select)
                {
                    DataRow Randulete = (randuri.DataBoundItem as DataRowView).Row;
                    txt_Masina.Text = dgv_masini.Rows[Randulete.Table.Rows.IndexOf(Randulete)].Cells["masina_nume"].Value.ToString();
                    txt_pret_masina.Text = dgv_masini.Rows[Randulete.Table.Rows.IndexOf(Randulete)].Cells["Pret"].Value.ToString();
                    masina_p= Convert.ToInt32(dgv_masini.Rows[Randulete.Table.Rows.IndexOf(Randulete)].Cells["masina_pret"].Value.ToString());
                    nume_mas= dgv_masini.Rows[Randulete.Table.Rows.IndexOf(Randulete)].Cells["masina_nume"].Value.ToString();
                }
            }
            catch { }
        }
    }

}
