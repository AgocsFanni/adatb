using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patients.Betegek.Records
{
    class Patients
    {
        private string patientId;

        public string PatientId {
           get
            {
                return patientId;
            }

            set
            {
                if (value==null)
                {
                    throw new ArgumentNullException ("A patientID nem lehet nulla!");

                  
                }
                if (value.Length != 7)
                {
                    throw new ArgumentOutOfRangeException("A patientID 7 karakter!");
                }

                patientId = value;
            }

        }


        private string last_name;

        public string Last_name
        {
            get
            {
                return last_name;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("A last_name nem lehet nulla!");


                }
                last_name = value;
            }

        }




        private string first_name;

        public string First_name
        {
            get
            {
                return first_name;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("A first name nem lehet nulla!");


                }

                first_name = value;
            }

        }


        private string gender;

        public string Gender
        {
            get
            {
                return gender;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("A gender nem lehet nulla!");


                }
                if (value.Length != 1)
                {
                    throw new ArgumentOutOfRangeException("A nem csak 1 karakter!");
                }

                gender = value;
            }

        }

        private string hicn;

        public string Hicn
        {
            get
            {
                return hicn;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("A patientID nem lehet nulla!");


                }
                if (value.Length != 9)
                {
                    throw new ArgumentOutOfRangeException("A TB kártya 9 karakter!");
                }

                hicn = value;
            }

        }

        private DateTime last_visit;

        public DateTime  Last_visit
        {
            get
            {
                return last_visit;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Az utolso ittléte nem lehet nulla!");


                }

                last_visit = value;
            }

        }


        private string hospital_id;

        public string Hospital_id
        {
            get
            {
                return hospital_id;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("A hospitalID nem lehet nulla!");


                }

                hospital_id = value;
            }

        }

    }
}
