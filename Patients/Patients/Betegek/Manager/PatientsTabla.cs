﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 using Oracle.ManagedDataAccess.Client;
using Patients.Betegek.Records;

namespace Patients.Betegek.Manager
{
    class PatientsTabla
    {
        OracleConnection OpenOracleConnection()
        {
            OracleConnection oc = new OracleConnection();

            string connectionString = @"Data Source=193.225.33.71;User Id=ORA_S1340;Password=EKE2020;";
            oc.ConnectionString = connectionString;
            return oc;
        }

        public List<Patient> Select()
        {
            List<Patient> records = new List<Patient>();

            OracleConnection oc = new OracleConnection();
            oc.Open();


            OracleCommand command = new OracleCommand()
            {
                CommandType = System.Data.CommandType.Text,
                CommandText = "SELECT patient_id,last_name ,first_name," +
                " gender, health_insurance_card_numb,last_visit, hospital_id "
            };

            command.Connection = oc;

            OracleDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                
                Patient p = new Patient();
                p.Patient_id = reader["patient_id"].ToString();
                p.Last_name = reader["last_name"].ToString();
                p.First_name = reader["first_name"].ToString();
                p.Gender = reader["gender"].ToString();
                p.Health_insurance_card_numb = reader["health_insurance_card_numb "].ToString();
                p.Last_visit = DateTime.Parse(reader["last_visit"].ToString());
                p.Hospital_id = reader["hospital_id"].ToString();
              
                records.Add(p);
            }
            reader.Close();
            oc.Close();

            return records;
        }


        public int Delete(Patient record)
        {
            OracleConnection oc = OpenOracleConnection();
            oc.Open();

            OracleTransaction ot = oc.BeginTransaction(System.Data.IsolationLevel.ReadCommitted);

            OracleCommand command = new OracleCommand()
            {
                CommandType = System.Data.CommandType.Text,
                CommandText = "DELETE FROM patients WHERE patient_id = :patient_id"
            };


            //ne égesse programba--> paraméterek
            OracleParameter patientParameter = new OracleParameter()
            {
                DbType = System.Data.DbType.String,
                ParameterName = ":patient_id",
                Direction = System.Data.ParameterDirection.Input, //mi adjuk be, nem olvassuk ki
                Value = record.Patient_id
            };
            command.Parameters.Add(patientParameter);

            command.Connection = oc;
            command.Transaction = ot; 

            //hány sort érint. Nincs értelme, mert egy patient csak 1 soros lesz
            int torolt_sorok = 0;
            try
            {
                torolt_sorok = command.ExecuteNonQuery();
                ot.Commit();
            }
            catch (Exception)
            {
                ot.Rollback(); //ha nincs olyan, akkor visszagorget, nem száll el
            }
            oc.Close();

            return torolt_sorok;
        }


        public int Insert(Patient record)
        { 
            OracleConnection oc = OpenOracleConnection();
            oc.Open();
            /*
            OracleTransaction ot = oc.BeginTransaction(System.Data.IsolationLevel.ReadCommitted);

            OracleCommand command = new OracleCommand()
            {
                CommandType = System.Data.CommandType.StoredProcedure, //sqlből procedura
                CommandText = "spInsert_patients" 
            }; */

            OracleCommand command = new OracleCommand();
          
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "INSERT INTO patients(patient_id  , last_name ," +
                " first_name , gender , health_insurance_card_numb , last_visit , hospital_id )" +
                "VALUES(:Patient_id, :Last_name, :First_name," +
                " :Gender, :Health_insurance_card_numb, :Last_visit, :Hospital_id)";

            OracleParameter patient_idParameter = new OracleParameter()
            {
                DbType = System.Data.DbType.String,
                ParameterName = "p_patient_id",
                Direction = System.Data.ParameterDirection.Input,
                Value = record.Patient_id
            };
            command.Parameters.Add(patient_idParameter);

            OracleParameter lastParameter = new OracleParameter()
            {
                DbType = System.Data.DbType.String,
                ParameterName = "p_last_name",
                Direction = System.Data.ParameterDirection.Input,
                Value = record.Last_name
            };
            command.Parameters.Add(lastParameter);

            OracleParameter firstParameter = new OracleParameter()
            {
                DbType = System.Data.DbType.String,
                ParameterName = "p_first_name",
                Direction = System.Data.ParameterDirection.Input,
                Value = record.First_name
            };
            command.Parameters.Add(firstParameter);

            OracleParameter genderParameter = new OracleParameter()
            {
                DbType = System.Data.DbType.String,
                ParameterName = "p_gender",
                Direction = System.Data.ParameterDirection.Input,
                Value = record.Gender
            };
            command.Parameters.Add(genderParameter);

            OracleParameter dateParameter = new OracleParameter()
            {
                DbType = System.Data.DbType.String,
                ParameterName = "p_date",
                Direction = System.Data.ParameterDirection.Input,
                Value = record.Last_visit
            };
            command.Parameters.Add(dateParameter);

            OracleParameter hicnParameter = new OracleParameter()
            {
                DbType = System.Data.DbType.String,
                ParameterName = "p_health_insurance_card_numb",
                Direction = System.Data.ParameterDirection.Input,
                Value = record.Health_insurance_card_numb
            };
            command.Parameters.Add(hicnParameter);

            OracleParameter hospitaltParameter = new OracleParameter()
            {
                DbType = System.Data.DbType.String,
                ParameterName = "p_hospital_id",
                Direction = System.Data.ParameterDirection.Input,
                Value = record.Hospital_id
            };
            command.Parameters.Add(hospitaltParameter);

            OracleParameter rowcountParameter = new OracleParameter()
            {
                DbType = System.Data.DbType.Int32,
                ParameterName = "p_out_rowcnt",
                Direction = System.Data.ParameterDirection.Output //sikeresen bement e, ez output
            };

            command.Connection = oc;
           // command.Transaction = ot;

            oc.Close();

            try
            {
                command.ExecuteNonQuery();
                int affectedRows = int.Parse(rowcountParameter.Value.ToString());
               // ot.Commit();
                return affectedRows;
            }
            catch (Exception)
            {
                
                return 0;
            }

        }

        public int Update(Patient record)
        {
            OracleConnection oc = OpenOracleConnection();
            oc.Open();
            
            OracleTransaction ot = oc.BeginTransaction(System.Data.IsolationLevel.ReadCommitted);

            OracleCommand command = new OracleCommand()
            {
                CommandType = System.Data.CommandType.StoredProcedure, //sqlből procedura
                CommandText = "spUpdate_patients" 
            }; 

          

            OracleParameter patient_idParameter = new OracleParameter()
            {
                DbType = System.Data.DbType.String,
                ParameterName = "p_patient_id",
                Direction = System.Data.ParameterDirection.Input,
                Value = record.Patient_id
            };
            command.Parameters.Add(patient_idParameter);

            OracleParameter lastParameter = new OracleParameter()
            {
                DbType = System.Data.DbType.String,
                ParameterName = "p_last_name",
                Direction = System.Data.ParameterDirection.Input,
                Value = record.Last_name
            };
            command.Parameters.Add(lastParameter);

            OracleParameter firstParameter = new OracleParameter()
            {
                DbType = System.Data.DbType.String,
                ParameterName = "p_first_name",
                Direction = System.Data.ParameterDirection.Input,
                Value = record.First_name
            };
            command.Parameters.Add(firstParameter);

            OracleParameter genderParameter = new OracleParameter()
            {
                DbType = System.Data.DbType.String,
                ParameterName = "p_gender",
                Direction = System.Data.ParameterDirection.Input,
                Value = record.Gender
            };
            command.Parameters.Add(genderParameter);

            OracleParameter dateParameter = new OracleParameter()
            {
                DbType = System.Data.DbType.String,
                ParameterName = "p_date",
                Direction = System.Data.ParameterDirection.Input,
                Value = record.Last_visit
            };
            command.Parameters.Add(dateParameter);

            OracleParameter hicnParameter = new OracleParameter()
            {
                DbType = System.Data.DbType.String,
                ParameterName = "p_health_insurance_card_numb",
                Direction = System.Data.ParameterDirection.Input,
                Value = record.Health_insurance_card_numb
            };
            command.Parameters.Add(hicnParameter);

            OracleParameter hospitaltParameter = new OracleParameter()
            {
                DbType = System.Data.DbType.String,
                ParameterName = "p_hospital_id",
                Direction = System.Data.ParameterDirection.Input,
                Value = record.Hospital_id
            };
            command.Parameters.Add(hospitaltParameter);

            OracleParameter rowcountParameter = new OracleParameter()
            {
                DbType = System.Data.DbType.Int32,
                ParameterName = "p_out_rowcnt",
                Direction = System.Data.ParameterDirection.Output //sikeresen bement e, ez output
            };

            command.Connection = oc;
             command.Transaction = ot;

            oc.Close();

            try
            {
                command.ExecuteNonQuery();
                int affectedRows = int.Parse(rowcountParameter.Value.ToString());
                 ot.Commit();
                return affectedRows;
            }
            catch (Exception)
            {

                return 0;
            }

        }


        public bool CheckPatient_id(string patientID)
        {
            OracleConnection oc = OpenOracleConnection();
            oc.Open();

            OracleCommand command = new OracleCommand()
            {
                CommandType = System.Data.CommandType.StoredProcedure,
                CommandText = "sf_check_patient_id" 
            };

            OracleParameter correct = new OracleParameter()
            {
                DbType = System.Data.DbType.Int32,
                Direction = System.Data.ParameterDirection.ReturnValue
            };

            OracleParameter patientIDarameter = new OracleParameter()
            {
                DbType = System.Data.DbType.String,
                ParameterName = "p_patient_id",
                Direction = System.Data.ParameterDirection.Input,
                Value = patientID

            };
            command.Parameters.Add(patientIDarameter);

            command.Connection = oc;

            try
            {
                int succesful = int.Parse(correct.Value.ToString());

                return succesful != 0; // mert ha 0 lenne, akkor gáz van
            }
            catch (Exception)
            {
                return false; //vissza tér false-al
            }

        }

        public bool CheckLast(string LastN)
        {
            OracleConnection oc = OpenOracleConnection();
            oc.Open();

            OracleCommand command = new OracleCommand()
            {
                CommandType = System.Data.CommandType.StoredProcedure,
                CommandText = "sf_check_last"
            };

            OracleParameter correct = new OracleParameter()
            {
                DbType = System.Data.DbType.Int32,
                Direction = System.Data.ParameterDirection.ReturnValue
            };

            OracleParameter lastNameParameter = new OracleParameter()
            {
                DbType = System.Data.DbType.String,
                ParameterName = "p_last_name",
                Direction = System.Data.ParameterDirection.Input,
                Value = LastN

            };
            command.Parameters.Add(lastNameParameter);

            command.Connection = oc;

            try
            {
                int succesful = int.Parse(correct.Value.ToString());

                return succesful != 0; 
            }
            catch (Exception)
            {
                return false; 
            }

        }

        public bool CheckFirst(string LastN)
        {
            OracleConnection oc = OpenOracleConnection();
            oc.Open();

            OracleCommand command = new OracleCommand()
            {
                CommandType = System.Data.CommandType.StoredProcedure,
                CommandText = "sf_check_first"
            };

            OracleParameter correct = new OracleParameter()
            {
                DbType = System.Data.DbType.Int32,
                Direction = System.Data.ParameterDirection.ReturnValue
            };

            OracleParameter firstNameParameter = new OracleParameter()
            {
                DbType = System.Data.DbType.String,
                ParameterName = "p_first_name",
                Direction = System.Data.ParameterDirection.Input,
                Value = LastN

            };
            command.Parameters.Add(firstNameParameter);

            command.Connection = oc;

            try
            {
                int succesful = int.Parse(correct.Value.ToString());

                return succesful != 0; 
            }
            catch (Exception)
            {
                return false; 
            }

        }


        public bool CheckHICNt(string hicn)
        {
            OracleConnection oc = OpenOracleConnection();
            oc.Open();

            OracleCommand command = new OracleCommand()
            {
                CommandType = System.Data.CommandType.StoredProcedure,
                CommandText = "sf_check_hicn"
            };

            OracleParameter correct = new OracleParameter()
            {
                DbType = System.Data.DbType.Int32,
                Direction = System.Data.ParameterDirection.ReturnValue
            };

            OracleParameter hicnParameter = new OracleParameter()
            {
                DbType = System.Data.DbType.String,
                ParameterName = "p_h_i_c_n",
                Direction = System.Data.ParameterDirection.Input,
                Value = hicn

            };
            command.Parameters.Add(hicn);

            command.Connection = oc;

            try
            {
                int succesful = int.Parse(correct.Value.ToString());

                return succesful != 0;
            }
            catch (Exception)
            {
                return false;
            }

        }




    }
}
