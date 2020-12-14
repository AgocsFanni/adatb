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

            MessageBox.Show(string.Format("{0} sor lett törölve", ToroltSorok));
            if (ToroltSorok != 0)
            {
                bgWorker.RunWorkerAsync();
            }

        }


        private void btn_beszuras_Click(object sender, EventArgs e)
        {
            Patient p = new Patient()
            {
                Patient_id = tb_patient_id.Text,
                Last_name = tb_last_name.Text,
                First_name =tb_first_name.Text,
                Gender = cb_gender.SelectedItem.ToString(),
                Last_visit = dtp_last_visit.Value,
                Health_insurance_card_numb = tb_hicn.Text,
                Hospital_id= tb_hospital_id.Text
               
            };
            tablaManager.Insert(p);
            bgWorker.RunWorkerAsync();

            MessageBox.Show("Sikeres feltöltés!");

            tb_patient_id.Clear();
            tb_last_name.Clear();
            tb_first_name.Clear();
            tb_hicn.Clear();
            tb_hospital_id.Clear();

        }


        private void Form1_Show(object sender, EventArgs e)
        {
            bgWorker.RunWorkerAsync();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            bgWorker.WorkerSupportsCancellation = true;

            dtp_last_visit.CustomFormat = "yyyy-mm-dd";
            dtp_last_visit.ShowUpDown = true;
            cb_gender.DataSource = Enum.GetValues(typeof(Gender));

            InitDataGridView();

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
        private void BgWorker_RunWorkerComplete(object sender, RunWorkerCompletedEventArgs e)
        {
            FillDataGridView();
        }

        private void BgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            rekords_PatientList = tablaManager.Select();
        }

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

                DataGridViewCell HICNCell = new DataGridViewTextBoxCell();
                HICNCell.Value = rekords_PatientList[i].Health_insurance_card_numb;
                Row.Cells.Add(HICNCell);


                Rows[i] = Row;
            }
            dgv_Patients.Rows.Clear();
            dgv_Patients.Rows.AddRange(Rows);
        }

        private void tb_ID_Leave(object sender, EventArgs e)
        {
            string actual = tb_patient_id.Text;
            bool Correct = tablaManager.CheckPatient_id(actual);
            tb_patient_id.BackColor = Correct ? Color.White : Color.Yellow;
        }
    }
}
