namespace Patients
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
            this.dgv_Patients = new System.Windows.Forms.DataGridView();
            this.tb_patient_id = new System.Windows.Forms.TextBox();
            this.tb_last_name = new System.Windows.Forms.TextBox();
            this.tb_first_name = new System.Windows.Forms.TextBox();
            this.tb_hicn = new System.Windows.Forms.TextBox();
            this.cmb_gender = new System.Windows.Forms.ComboBox();
            this.dtp_last_visit = new System.Windows.Forms.DateTimePicker();
            this.tb_hospital_id = new System.Windows.Forms.TextBox();
            this.btn_torles = new System.Windows.Forms.Button();
            this.btn_beszuras = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Patients)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Patients
            // 
            this.dgv_Patients.AccessibleDescription = "";
            this.dgv_Patients.AccessibleName = "";
            this.dgv_Patients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Patients.Location = new System.Drawing.Point(47, 2);
            this.dgv_Patients.Name = "dgv_Patients";
            this.dgv_Patients.RowTemplate.Height = 24;
            this.dgv_Patients.Size = new System.Drawing.Size(690, 246);
            this.dgv_Patients.TabIndex = 0;
            this.dgv_Patients.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Patients_CellContentClick);
            // 
            // tb_patient_id
            // 
            this.tb_patient_id.AccessibleName = "";
            this.tb_patient_id.Location = new System.Drawing.Point(145, 268);
            this.tb_patient_id.Name = "tb_patient_id";
            this.tb_patient_id.Size = new System.Drawing.Size(100, 22);
            this.tb_patient_id.TabIndex = 1;
            this.tb_patient_id.TextChanged += new System.EventHandler(this.tb_patient_id_TextChanged);
            // 
            // tb_last_name
            // 
            this.tb_last_name.Location = new System.Drawing.Point(145, 310);
            this.tb_last_name.Name = "tb_last_name";
            this.tb_last_name.Size = new System.Drawing.Size(100, 22);
            this.tb_last_name.TabIndex = 2;
            // 
            // tb_first_name
            // 
            this.tb_first_name.Location = new System.Drawing.Point(145, 351);
            this.tb_first_name.Name = "tb_first_name";
            this.tb_first_name.Size = new System.Drawing.Size(100, 22);
            this.tb_first_name.TabIndex = 3;
            // 
            // tb_hicn
            // 
            this.tb_hicn.Location = new System.Drawing.Point(431, 307);
            this.tb_hicn.Name = "tb_hicn";
            this.tb_hicn.Size = new System.Drawing.Size(100, 22);
            this.tb_hicn.TabIndex = 4;
            // 
            // cmb_gender
            // 
            this.cmb_gender.FormattingEnabled = true;
            this.cmb_gender.Location = new System.Drawing.Point(124, 390);
            this.cmb_gender.Name = "cmb_gender";
            this.cmb_gender.Size = new System.Drawing.Size(121, 24);
            this.cmb_gender.TabIndex = 5;
            // 
            // dtp_last_visit
            // 
            this.dtp_last_visit.Location = new System.Drawing.Point(392, 272);
            this.dtp_last_visit.Name = "dtp_last_visit";
            this.dtp_last_visit.Size = new System.Drawing.Size(200, 22);
            this.dtp_last_visit.TabIndex = 6;
            // 
            // tb_hospital_id
            // 
            this.tb_hospital_id.Location = new System.Drawing.Point(431, 351);
            this.tb_hospital_id.Name = "tb_hospital_id";
            this.tb_hospital_id.Size = new System.Drawing.Size(100, 22);
            this.tb_hospital_id.TabIndex = 7;
            // 
            // btn_torles
            // 
            this.btn_torles.Location = new System.Drawing.Point(638, 268);
            this.btn_torles.Name = "btn_torles";
            this.btn_torles.Size = new System.Drawing.Size(128, 34);
            this.btn_torles.TabIndex = 8;
            this.btn_torles.Text = "Torles";
            this.btn_torles.UseVisualStyleBackColor = true;
            this.btn_torles.Click += new System.EventHandler(this.btn_torles_Click);
            // 
            // btn_beszuras
            // 
            this.btn_beszuras.Location = new System.Drawing.Point(638, 339);
            this.btn_beszuras.Name = "btn_beszuras";
            this.btn_beszuras.Size = new System.Drawing.Size(128, 34);
            this.btn_beszuras.TabIndex = 9;
            this.btn_beszuras.Text = "Beszuras";
            this.btn_beszuras.UseVisualStyleBackColor = true;
            this.btn_beszuras.Click += new System.EventHandler(this.btn_beszuras_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 268);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Beteg Azonosító";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 312);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Vezetéknév";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 348);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Keresztnév";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 393);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Nem";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(349, 310);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "TB szám";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(349, 356);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "KórházID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(332, 268);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Itt járt";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_beszuras);
            this.Controls.Add(this.btn_torles);
            this.Controls.Add(this.tb_hospital_id);
            this.Controls.Add(this.dtp_last_visit);
            this.Controls.Add(this.cmb_gender);
            this.Controls.Add(this.tb_hicn);
            this.Controls.Add(this.tb_first_name);
            this.Controls.Add(this.tb_last_name);
            this.Controls.Add(this.tb_patient_id);
            this.Controls.Add(this.dgv_Patients);
            this.Name = "Form1";
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Patients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Patients;
        private System.Windows.Forms.TextBox tb_patient_id;
        private System.Windows.Forms.TextBox tb_last_name;
        private System.Windows.Forms.TextBox tb_first_name;
        private System.Windows.Forms.TextBox tb_hicn;
        private System.Windows.Forms.ComboBox cmb_gender;
        private System.Windows.Forms.DateTimePicker dtp_last_visit;
        private System.Windows.Forms.TextBox tb_hospital_id;
        private System.Windows.Forms.Button btn_torles;
        private System.Windows.Forms.Button btn_beszuras;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

