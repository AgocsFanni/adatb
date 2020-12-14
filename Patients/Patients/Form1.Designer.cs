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
            this.cb_gender = new System.Windows.Forms.ComboBox();
            this.dtp_last_visit = new System.Windows.Forms.DateTimePicker();
            this.tb_hospital_id = new System.Windows.Forms.TextBox();
            this.btn_torles = new System.Windows.Forms.Button();
            this.btn_beszuras = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Patients)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Patients
            // 
            this.dgv_Patients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Patients.Location = new System.Drawing.Point(0, 0);
            this.dgv_Patients.Name = "dgv_Patients";
            this.dgv_Patients.RowTemplate.Height = 24;
            this.dgv_Patients.Size = new System.Drawing.Size(710, 249);
            this.dgv_Patients.TabIndex = 0;
            // 
            // tb_patient_id
            // 
            this.tb_patient_id.Location = new System.Drawing.Point(12, 268);
            this.tb_patient_id.Name = "tb_patient_id";
            this.tb_patient_id.Size = new System.Drawing.Size(100, 22);
            this.tb_patient_id.TabIndex = 1;
            // 
            // tb_last_name
            // 
            this.tb_last_name.Location = new System.Drawing.Point(12, 307);
            this.tb_last_name.Name = "tb_last_name";
            this.tb_last_name.Size = new System.Drawing.Size(100, 22);
            this.tb_last_name.TabIndex = 2;
            // 
            // tb_first_name
            // 
            this.tb_first_name.Location = new System.Drawing.Point(12, 347);
            this.tb_first_name.Name = "tb_first_name";
            this.tb_first_name.Size = new System.Drawing.Size(100, 22);
            this.tb_first_name.TabIndex = 3;
            // 
            // tb_hicn
            // 
            this.tb_hicn.Location = new System.Drawing.Point(243, 307);
            this.tb_hicn.Name = "tb_hicn";
            this.tb_hicn.Size = new System.Drawing.Size(100, 22);
            this.tb_hicn.TabIndex = 4;
            // 
            // cb_gender
            // 
            this.cb_gender.FormattingEnabled = true;
            this.cb_gender.Location = new System.Drawing.Point(12, 392);
            this.cb_gender.Name = "cb_gender";
            this.cb_gender.Size = new System.Drawing.Size(121, 24);
            this.cb_gender.TabIndex = 5;
            // 
            // dtp_last_visit
            // 
            this.dtp_last_visit.Location = new System.Drawing.Point(243, 268);
            this.dtp_last_visit.Name = "dtp_last_visit";
            this.dtp_last_visit.Size = new System.Drawing.Size(200, 22);
            this.dtp_last_visit.TabIndex = 6;
            // 
            // tb_hospital_id
            // 
            this.tb_hospital_id.Location = new System.Drawing.Point(243, 360);
            this.tb_hospital_id.Name = "tb_hospital_id";
            this.tb_hospital_id.Size = new System.Drawing.Size(100, 22);
            this.tb_hospital_id.TabIndex = 7;
            // 
            // btn_torles
            // 
            this.btn_torles.Location = new System.Drawing.Point(532, 268);
            this.btn_torles.Name = "btn_torles";
            this.btn_torles.Size = new System.Drawing.Size(128, 34);
            this.btn_torles.TabIndex = 8;
            this.btn_torles.Text = "Torles";
            this.btn_torles.UseVisualStyleBackColor = true;
            this.btn_torles.Click += new System.EventHandler(this.btn_torles_Click);
            // 
            // btn_beszuras
            // 
            this.btn_beszuras.Location = new System.Drawing.Point(532, 354);
            this.btn_beszuras.Name = "btn_beszuras";
            this.btn_beszuras.Size = new System.Drawing.Size(128, 34);
            this.btn_beszuras.TabIndex = 9;
            this.btn_beszuras.Text = "Beszuras";
            this.btn_beszuras.UseVisualStyleBackColor = true;
            this.btn_beszuras.Click += new System.EventHandler(this.btn_beszuras_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_beszuras);
            this.Controls.Add(this.btn_torles);
            this.Controls.Add(this.tb_hospital_id);
            this.Controls.Add(this.dtp_last_visit);
            this.Controls.Add(this.cb_gender);
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
        private System.Windows.Forms.ComboBox cb_gender;
        private System.Windows.Forms.DateTimePicker dtp_last_visit;
        private System.Windows.Forms.TextBox tb_hospital_id;
        private System.Windows.Forms.Button btn_torles;
        private System.Windows.Forms.Button btn_beszuras;
    }
}

