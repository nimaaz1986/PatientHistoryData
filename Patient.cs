/* Patient Class Definition
 * Auther: Nima Azadikhah
 * Date: ------
 * GitHub: nimaaz1986
 */
#region USING STATEMENTS
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
#endregion




namespace Lab3_PatientHistoryData
{
    class Patient
    {
        #region Global Variables
        // create a list of patient
        // store each instance of patients in a list of patients
        public static List<Patient> patients = new List<Patient>();
        // the next time we ctraate a patient it is a number it is going to be
        private static int nextID = 1;

        #endregion


        #region Properties
        public int PatientID { get; set; }
        public String FirstName { get; set; }
        public String SurName { get; set; }
        public String Sex { get; set; }

        public String HomeTown { get; set; }
        public String Section { get; set; }
        public DateTime Born { get; set; }
        public Boolean IsSmoker { get; set; }
        public Color HairColor { get; set; }
        public Color EyeColor { get; set; }

        #endregion

        #region Constructors
        /// <summary>
        /// Default Constructor - using autoincrement PatientID
        /// </summary>
        public Patient()
        {
            // When we call the constructor(instantiate a new patient , we assign an ID)
            PatientID = nextID++;
            SetDefaults();
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="surName"></param>
        /// <param name="sex">Male or Female</param>
        /// <param name="howeTown">The town the patient was born on.</param>
        /// <param name="section">Which section of the hospital is the patient admitted to?</param>
        /// <param name="born">Date of brith</param>
        /// <param name="isSmoker"></param>
        /// <param name="hairColor"></param>
        /// <param name="eyeColor"></param>
        public Patient(String firstName,String surName,String sex,String howeTown, String section , DateTime born, Boolean isSmoker,
            Color hairColor, Color eyeColor)
        {

            // set the values of properties
            PatientID = nextID++;
            FirstName = firstName;
            SurName = surName;
            Sex = sex;
            HomeTown = howeTown;
            Section = section;
            Born = born;
            IsSmoker = isSmoker;
            HairColor = hairColor;
            EyeColor = eyeColor;


        }
         
        #endregion

        #region Custom Methods

        #region Instance Methods
        /// <summary>
        /// Sets the default values for all properties except the Patient ID;
        /// </summary>
        private void SetDefaults()
        {
            FirstName = string.Empty;
            SurName = string.Empty;
            Sex = string.Empty;
            HomeTown = string.Empty;
            Section = string.Empty ;
            Born = DateTime.Today;
            IsSmoker = false;
            HairColor = Color.Black;
            EyeColor = Color.Brown;

        }
        public  void ChangeSection(string newSection)
        {
            
            Section = newSection;

        }




        #endregion

        public static List<Patient> GetSamplePatients()
        {
            List<Patient> returnList = new List<Patient>();
            returnList.Add(new Patient("Kevin", "Dougherty", "Male", "Bowmanville", 
                "CCU", new DateTime(1990, 05, 11), false, Color.Yellow, Color.Blue));

            returnList.Add(new Patient("Ashley", "Butt", "Female", "Mississauga",
                "ICU", new DateTime(1978, 11, 01), true, Color.Black, Color.Brown));


            returnList.Add(new Patient("Kim", "Peckford", "Female", "Niagara Falls",
                "ICU", new DateTime(1995, 04, 02), false, Color.Beige, Color.LightGreen));




            return returnList;
        }

        #region Static Methods
        public static void ChangeSection(int patientID, string newSection)
        {
            Patient ill = FindPatient(patientID);
            ill.Section = newSection;

        }
        /// <summary>
        /// find the patient based on PatientID and return Patient.static because we are looking into the list of Patients 
        /// </summary>
        /// <param name="patientID"></param>
        /// <returns></returns>
        public static Patient FindPatient(int patientID)
        {
            return patients.Find(p => p.PatientID == patientID);
        }


        /// <summary>
        /// Select distinct section from Patient
        /// </summary>
        public static List<String> GetUniqueSections()
        {
            List<String> returnList = new List<String>();
            foreach(Patient p in patients)
            {
                if (!returnList.Contains(p.Section)) returnList.Add(p.Section);
            }
            return returnList;

        }

        /// <summary>
        /// Find All patients inside Patient list Where the comparison exists and return true if it exists
        /// </summary>
        /// <param name="patientID"></param>
        /// <returns></returns>
        public static Boolean PatientExists(int patientID)
        {
            return patients.FindAll(p => p.PatientID == patientID).Count > 0;
        }
        #endregion




        #endregion




    }
}
