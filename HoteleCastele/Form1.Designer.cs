namespace HoteleCastele
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DGV_Info = new System.Windows.Forms.DataGridView();
            this.BTN_GetAll = new System.Windows.Forms.Button();
            this.cmb_Country = new System.Windows.Forms.ComboBox();
            this.cmb_City = new System.Windows.Forms.ComboBox();
            this.cmb_Hotel = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Room = new System.Windows.Forms.Button();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.BTN_Rezervation = new System.Windows.Forms.Button();
            this.btn_Rezervari = new System.Windows.Forms.Button();
            this.txt_Room = new System.Windows.Forms.TextBox();
            this.txt_Service = new System.Windows.Forms.TextBox();
            this.txt_Family = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_Camera = new System.Windows.Forms.Label();
            this.dgv_opinii = new System.Windows.Forms.DataGridView();
            this.oracleCommand1 = new Oracle.ManagedDataAccess.Client.OracleCommand();
            this.btn_Web = new System.Windows.Forms.Button();
            this.btn_Export = new System.Windows.Forms.Button();
            this.btn_Import = new System.Windows.Forms.Button();
            this.btn_D_R = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Pret = new System.Windows.Forms.TextBox();
            this.pnl_delete = new System.Windows.Forms.Panel();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_Masina = new System.Windows.Forms.TextBox();
            this.txt_pret_masina = new System.Windows.Forms.TextBox();
            this.dgv_masini = new System.Windows.Forms.DataGridView();
            this.masina_nume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.masina_pret = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Info)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_opinii)).BeginInit();
            this.pnl_delete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_masini)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_Info
            // 
            this.DGV_Info.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Info.Location = new System.Drawing.Point(21, 227);
            this.DGV_Info.Name = "DGV_Info";
            this.DGV_Info.Size = new System.Drawing.Size(358, 211);
            this.DGV_Info.TabIndex = 0;
            this.DGV_Info.Visible = false;
            this.DGV_Info.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGV_Info_CellMouseClick);
            // 
            // BTN_GetAll
            // 
            this.BTN_GetAll.Location = new System.Drawing.Point(113, 29);
            this.BTN_GetAll.Name = "BTN_GetAll";
            this.BTN_GetAll.Size = new System.Drawing.Size(75, 23);
            this.BTN_GetAll.TabIndex = 1;
            this.BTN_GetAll.Text = "Show Hotels";
            this.BTN_GetAll.UseVisualStyleBackColor = true;
            this.BTN_GetAll.Click += new System.EventHandler(this.BTN_GetAll_Click);
            // 
            // cmb_Country
            // 
            this.cmb_Country.FormattingEnabled = true;
            this.cmb_Country.Location = new System.Drawing.Point(90, 58);
            this.cmb_Country.Name = "cmb_Country";
            this.cmb_Country.Size = new System.Drawing.Size(121, 21);
            this.cmb_Country.TabIndex = 2;
            this.cmb_Country.SelectedIndexChanged += new System.EventHandler(this.Cmb_Country_SelectedIndexChanged);
            // 
            // cmb_City
            // 
            this.cmb_City.FormattingEnabled = true;
            this.cmb_City.Location = new System.Drawing.Point(90, 85);
            this.cmb_City.Name = "cmb_City";
            this.cmb_City.Size = new System.Drawing.Size(121, 21);
            this.cmb_City.TabIndex = 3;
            this.cmb_City.SelectedIndexChanged += new System.EventHandler(this.Cmb_City_SelectedIndexChanged);
            // 
            // cmb_Hotel
            // 
            this.cmb_Hotel.FormattingEnabled = true;
            this.cmb_Hotel.Location = new System.Drawing.Point(90, 112);
            this.cmb_Hotel.Name = "cmb_Hotel";
            this.cmb_Hotel.Size = new System.Drawing.Size(121, 21);
            this.cmb_Hotel.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Hotel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "City";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Country";
            // 
            // btn_Room
            // 
            this.btn_Room.Location = new System.Drawing.Point(113, 139);
            this.btn_Room.Name = "btn_Room";
            this.btn_Room.Size = new System.Drawing.Size(75, 23);
            this.btn_Room.TabIndex = 6;
            this.btn_Room.Text = "Show Room";
            this.btn_Room.UseVisualStyleBackColor = true;
            this.btn_Room.Click += new System.EventHandler(this.Btn_Room_Click);
            // 
            // btn_Reset
            // 
            this.btn_Reset.Location = new System.Drawing.Point(927, 188);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(75, 23);
            this.btn_Reset.TabIndex = 7;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.Btn_Reset_Click);
            // 
            // BTN_Rezervation
            // 
            this.BTN_Rezervation.Location = new System.Drawing.Point(927, 18);
            this.BTN_Rezervation.Name = "BTN_Rezervation";
            this.BTN_Rezervation.Size = new System.Drawing.Size(75, 23);
            this.BTN_Rezervation.TabIndex = 9;
            this.BTN_Rezervation.Text = "Rezerva";
            this.BTN_Rezervation.UseVisualStyleBackColor = true;
            this.BTN_Rezervation.Click += new System.EventHandler(this.BTN_Rezervation_Click);
            // 
            // btn_Rezervari
            // 
            this.btn_Rezervari.Location = new System.Drawing.Point(927, 159);
            this.btn_Rezervari.Name = "btn_Rezervari";
            this.btn_Rezervari.Size = new System.Drawing.Size(75, 23);
            this.btn_Rezervari.TabIndex = 10;
            this.btn_Rezervari.Text = "Rezervari";
            this.btn_Rezervari.UseVisualStyleBackColor = true;
            this.btn_Rezervari.Click += new System.EventHandler(this.Btn_Rezervari_Click);
            // 
            // txt_Room
            // 
            this.txt_Room.Location = new System.Drawing.Point(279, 58);
            this.txt_Room.Name = "txt_Room";
            this.txt_Room.Size = new System.Drawing.Size(100, 20);
            this.txt_Room.TabIndex = 11;
            // 
            // txt_Service
            // 
            this.txt_Service.Location = new System.Drawing.Point(279, 85);
            this.txt_Service.Name = "txt_Service";
            this.txt_Service.Size = new System.Drawing.Size(100, 20);
            this.txt_Service.TabIndex = 11;
            // 
            // txt_Family
            // 
            this.txt_Family.Location = new System.Drawing.Point(279, 112);
            this.txt_Family.Name = "txt_Family";
            this.txt_Family.Size = new System.Drawing.Size(100, 20);
            this.txt_Family.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(421, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Family";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(421, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Service";
            // 
            // lbl_Camera
            // 
            this.lbl_Camera.AutoSize = true;
            this.lbl_Camera.Location = new System.Drawing.Point(421, 65);
            this.lbl_Camera.Name = "lbl_Camera";
            this.lbl_Camera.Size = new System.Drawing.Size(43, 13);
            this.lbl_Camera.TabIndex = 12;
            this.lbl_Camera.Text = "Camera";
            // 
            // dgv_opinii
            // 
            this.dgv_opinii.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_opinii.Location = new System.Drawing.Point(385, 227);
            this.dgv_opinii.Name = "dgv_opinii";
            this.dgv_opinii.Size = new System.Drawing.Size(341, 211);
            this.dgv_opinii.TabIndex = 13;
            this.dgv_opinii.Visible = false;
            // 
            // oracleCommand1
            // 
            this.oracleCommand1.Transaction = null;
            // 
            // btn_Web
            // 
            this.btn_Web.Location = new System.Drawing.Point(927, 48);
            this.btn_Web.Name = "btn_Web";
            this.btn_Web.Size = new System.Drawing.Size(75, 23);
            this.btn_Web.TabIndex = 14;
            this.btn_Web.Text = "Web";
            this.btn_Web.UseVisualStyleBackColor = true;
            this.btn_Web.Click += new System.EventHandler(this.Btn_Web_Click);
            // 
            // btn_Export
            // 
            this.btn_Export.Location = new System.Drawing.Point(21, 198);
            this.btn_Export.Name = "btn_Export";
            this.btn_Export.Size = new System.Drawing.Size(75, 23);
            this.btn_Export.TabIndex = 15;
            this.btn_Export.Text = "Export";
            this.btn_Export.UseVisualStyleBackColor = true;
            this.btn_Export.Click += new System.EventHandler(this.Btn_Export_Click);
            // 
            // btn_Import
            // 
            this.btn_Import.Location = new System.Drawing.Point(123, 197);
            this.btn_Import.Name = "btn_Import";
            this.btn_Import.Size = new System.Drawing.Size(75, 23);
            this.btn_Import.TabIndex = 16;
            this.btn_Import.Text = "Import";
            this.btn_Import.UseVisualStyleBackColor = true;
            this.btn_Import.Click += new System.EventHandler(this.Btn_Import_Click);
            // 
            // btn_D_R
            // 
            this.btn_D_R.Location = new System.Drawing.Point(889, 99);
            this.btn_D_R.Name = "btn_D_R";
            this.btn_D_R.Size = new System.Drawing.Size(113, 23);
            this.btn_D_R.TabIndex = 17;
            this.btn_D_R.Text = "Delete Rezervation";
            this.btn_D_R.UseVisualStyleBackColor = true;
            this.btn_D_R.Click += new System.EventHandler(this.Btn_D_R_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(421, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Pret";
            // 
            // txt_Pret
            // 
            this.txt_Pret.Location = new System.Drawing.Point(279, 141);
            this.txt_Pret.Name = "txt_Pret";
            this.txt_Pret.Size = new System.Drawing.Size(100, 20);
            this.txt_Pret.TabIndex = 20;
            // 
            // pnl_delete
            // 
            this.pnl_delete.Controls.Add(this.txt_id);
            this.pnl_delete.Controls.Add(this.btn_delete);
            this.pnl_delete.Controls.Add(this.label6);
            this.pnl_delete.Location = new System.Drawing.Point(698, 58);
            this.pnl_delete.Name = "pnl_delete";
            this.pnl_delete.Size = new System.Drawing.Size(185, 118);
            this.pnl_delete.TabIndex = 21;
            this.pnl_delete.Visible = false;
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(85, 39);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(100, 20);
            this.txt_id.TabIndex = 2;
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(59, 82);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 1;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.Btn_delete_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Id Delete";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(565, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Masina";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(553, 139);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Pretul Masini";
            // 
            // txt_Masina
            // 
            this.txt_Masina.Location = new System.Drawing.Point(626, 64);
            this.txt_Masina.Name = "txt_Masina";
            this.txt_Masina.Size = new System.Drawing.Size(100, 20);
            this.txt_Masina.TabIndex = 25;
            // 
            // txt_pret_masina
            // 
            this.txt_pret_masina.Location = new System.Drawing.Point(626, 134);
            this.txt_pret_masina.Name = "txt_pret_masina";
            this.txt_pret_masina.Size = new System.Drawing.Size(100, 20);
            this.txt_pret_masina.TabIndex = 25;
            // 
            // dgv_masini
            // 
            this.dgv_masini.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_masini.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.masina_nume,
            this.masina_pret});
            this.dgv_masini.Location = new System.Drawing.Point(732, 227);
            this.dgv_masini.Name = "dgv_masini";
            this.dgv_masini.Size = new System.Drawing.Size(269, 211);
            this.dgv_masini.TabIndex = 26;
            this.dgv_masini.Visible = false;
            this.dgv_masini.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Dgv_masini_CellMouseClick);
            // 
            // masina_nume
            // 
            this.masina_nume.DataPropertyName = "MASINA_NUME";
            this.masina_nume.HeaderText = "Numele masinii";
            this.masina_nume.Name = "masina_nume";
            // 
            // masina_pret
            // 
            this.masina_pret.DataPropertyName = "MASINA_PRET";
            this.masina_pret.HeaderText = "Pretul masinii";
            this.masina_pret.Name = "masina_pret";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 450);
            this.Controls.Add(this.dgv_masini);
            this.Controls.Add(this.txt_pret_masina);
            this.Controls.Add(this.txt_Masina);
            this.Controls.Add(this.pnl_delete);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_Pret);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_D_R);
            this.Controls.Add(this.btn_Import);
            this.Controls.Add(this.btn_Export);
            this.Controls.Add(this.btn_Web);
            this.Controls.Add(this.dgv_opinii);
            this.Controls.Add(this.lbl_Camera);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Family);
            this.Controls.Add(this.txt_Service);
            this.Controls.Add(this.txt_Room);
            this.Controls.Add(this.btn_Rezervari);
            this.Controls.Add(this.BTN_Rezervation);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.btn_Room);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_Hotel);
            this.Controls.Add(this.cmb_City);
            this.Controls.Add(this.cmb_Country);
            this.Controls.Add(this.BTN_GetAll);
            this.Controls.Add(this.DGV_Info);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Info)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_opinii)).EndInit();
            this.pnl_delete.ResumeLayout(false);
            this.pnl_delete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_masini)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_Info;
        private System.Windows.Forms.Button BTN_GetAll;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_Hotel;
        private System.Windows.Forms.ComboBox cmb_City;
        private System.Windows.Forms.ComboBox cmb_Country;
        private System.Windows.Forms.Button btn_Room;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Button BTN_Rezervation;
        private System.Windows.Forms.Button btn_Rezervari;
        private System.Windows.Forms.TextBox txt_Family;
        private System.Windows.Forms.TextBox txt_Service;
        private System.Windows.Forms.TextBox txt_Room;
        private System.Windows.Forms.Label lbl_Camera;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgv_opinii;
        private Oracle.ManagedDataAccess.Client.OracleCommand oracleCommand1;
        private System.Windows.Forms.Button btn_Web;
        private System.Windows.Forms.Button btn_Export;
        private System.Windows.Forms.Button btn_Import;
        private System.Windows.Forms.Button btn_D_R;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_Pret;
        private System.Windows.Forms.Panel pnl_delete;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_Masina;
        private System.Windows.Forms.TextBox txt_pret_masina;
        private System.Windows.Forms.DataGridView dgv_masini;
        private System.Windows.Forms.DataGridViewTextBoxColumn masina_nume;
        private System.Windows.Forms.DataGridViewTextBoxColumn masina_pret;
    }
}

