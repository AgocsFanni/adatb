using Patients.Betegek.Manager;
using Patients.Betegek.Records;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Patients
{
    public partial class Form1 : Form
    {
        PatientsTabla tablaManager;
        List<Patient> rekords_PatientList;
        BackgroundWorker bgWorker;

        public Form1()
        {
            InitializeComponent();
            cmb_gender.DataSource = Enum.GetNames(typeof(Gender));
            cmb_gender.SelectedIndex = 0;
            tablaManager = new PatientsTabla();
            rekords_PatientList = new List<Patient>();
            bgWorker = new BackgroundWorker();
        }

        private void btn_torles_Click(object sender, EventArgs e)
        {
            int ToroltSorok = 0;
            foreach (DataGridViewRow selectedRows in dgv_Patients.SelectedRows)
            {
                Patient Torlendo = new Patient();
                Torlendo.Patient_id = selectedRows.Cells["patient_id"].Value.ToString();

                ToroltSorok += tablaManager.Delete(Torlendo);
            }

            MessageBox.Show(string.Format("{0} törölve", ToroltSorok));
            if (ToroltSorok != 0)
            {
                bgWorker.RunWorkerAsync();
            }

        }


        private void btn_beszuras_Click(object sender, EventArgs e)
        {
            Patient pat = new Patient()
            {
                Patient_id = tb_patient_id.Text,
                Last_name = tb_last_name.Text,
                First_name =tb_first_name.Text,
                Gender = cmb_gender.SelectedItem.ToString(),
                Last_visit = dtp_last_visit.Value,
                Health_insurance_card_numb =tb_hicn.Text,
                Hospital_id= tb_hospital_id.Text
               
            };
            tablaManager.Insert(pat);
            bgWorker.RunWorkerAsync();

            MessageBox.Show("Sikeresen feltölve!");

            tb_patient_id.Clear();
            tb_last_name.Clear();
            tb_first_name.Clear();
            tb_hicn.Clear();
            tb_hospital_id.Clear();

        }
        /*
        private void dgv_Frissitese()
        {
            dgv_Patients.Rows.Clear();
            PatientsTabla patientsTable = new PatientsTabla();
            foreach (Patient pat in patientsTable.Select())
            {
                dgv_Patients.Rows.Add(new object[]
                {
                    pat.Patient_id,
                    pat.Last_name,
                    pat.First_name,
                    pat.Gender,
                    pat.Health_insurance_card_numb,
                    pat.Last_visit,
                    pat.Hospital_id
                });
            }

        }*/


       
        private void Form1_Load(object sender, EventArgs e)
        {
            bgWorker.WorkerSupportsCancellation = true;
         //   cmb_gender.DataSource = Enum.GetValues(typeof(Gender));
            dtp_last_visit.CustomFormat = "yy-MMM.-dd";
            dtp_last_visit.ShowUpDown = true;

            InitDataGridView();
           // dgv_Frissitese();
        }

        private void Form1_Show(object sender, EventArgs e)
        {
            bgWorker.RunWorkerAsync();
        }

        
        private void InitDataGridView()
        {
            dgv_Patients.Rows.Clear();
           dgv_Patients.Columns.Clear();

            DataGridViewColumn IdColumn = new DataGridViewColumn()
            {
                Name = "beteg_id",
                HeaderText = "Beteg ID",
                Visible = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader

            };
            dgv_Patients.Columns.Add(IdColumn);

            DataGridViewColumn LastColumn = new DataGridViewColumn()
            {
                Name = "last",
                HeaderText = "Vezetéknév",
                Visible = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader

            };
            dgv_Patients.Columns.Add(LastColumn);

            DataGridViewColumn FirstCoulmn = new DataGridViewColumn()
            {
                Name = "first",
                HeaderText = "Keresztnév",
                Visible = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            };
            dgv_Patients.Columns.Add(FirstCoulmn);


            DataGridViewColumn HICNCoulmn = new DataGridViewColumn()
            {
                Name = "tbkartya",
                HeaderText = "TB kártya száma",
                Visible = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            };
            dgv_Patients.Columns.Add(HICNCoulmn);


        }
        

       /*

        private void InitDataGridView()
        {
            dgv_Patients.Rows.Clear();
            dgv_Patients.Columns.Clear();

            dgv_Patients.AutoGenerateColumns = false;
            dgv_Patients.Columns.Add("patient_id  ", "Beteg ID");
            dgv_Patients.Columns.Add("last_name ", "Vezetéknév");
            dgv_Patients.Columns.Add("first_name ", "Keresztnév");
            dgv_Patients.Columns.Add("gender ", "Neme");
            dgv_Patients.Columns.Add("health_insurance_card_numb ", "TB kártya");
            dgv_Patients.Columns.Add("last_visit ", "Utoljára itt járt");
            dgv_Patients.Columns.Add("hospital_id ", "Hanyas kórház");
        }
        */


        private void FillDataGridView()
        {
            DataGridViewRow[] Rows = new DataGridViewRow[rekords_PatientList.Count];

            for (int i = 0; i < rekords_PatientList.Count; i++)
            {
                DataGridViewRow Row = new DataGridViewRow();

                DataGridViewCell IDCell = new DataGridViewTextBoxCell();
                IDCell.Value = rekords_PatientList[i].Patient_id;
                Row.Cells.Add(IDCell);


                DataGridViewCell LastCell = new DataGridViewTextBoxCell();
                LastCell.Value = rekords_PatientList[i].Last_name;
                Row.Cells.Add(LastCell);

                DataGridViewCell FirstCell = new DataGridViewTextBoxCell();
                FirstCell.Value = rekords_PatientList[i].First_name;
                Row.Cells.Add(FirstCell);

                DataGridViewCell genderCell = new DataGridViewTextBoxCell();
                genderCell.Value = rekords_PatientList[i].Gender;
                Row.Cells.Add(genderCell);

                DataGridViewCell HICNCell = new DataGridViewTextBoxCell();
                HICNCell.Value = rekords_PatientList[i].Health_insurance_card_numb;
                Row.Cells.Add(HICNCell);

                DataGridViewCell dateCell = new DataGridViewTextBoxCell();
                dateCell.Value = rekords_PatientList[i].Last_visit;
                Row.Cells.Add(dateCell);

                DataGridViewCell hospiCell = new DataGridViewTextBoxCell();
                hospiCell.Value = rekords_PatientList[i].Hospital_id;
                Row.Cells.Add(hospiCell);


                Rows[i] = Row;
            }
            dgv_Patients.Rows.Clear();
            dgv_Patients.Rows.AddRange(Rows);
        }

        private void BgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            rekords_PatientList = tablaManager.Select();
        }


        private void tb_ID_Leave(object sender, EventArgs e)
        {
            string actual = tb_patient_id.Text;
            bool Correct = tablaManager.CheckPatient_id(actual);
            tb_patient_id.BackColor = Correct ? Color.White : Color.Yellow;
        }

        private void tb_patient_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dgv_Patients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
