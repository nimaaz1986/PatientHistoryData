/*Name : Nima Azadikhah
 * Date: ----
 * Student ID: ------
 * Title: Lab3- Collection of object(Patient)
 * Github: nimaaz1986
 */

#region USING STATEMENTS
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
#endregion

namespace Lab3_PatientHistoryData
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        #region GLOBAL VARABLES
        List<String> Genders = new List<String>();
        Boolean DoGridSelectionChange = false;

        #endregion

        #region EVENTS HANDELES
        /// <summary>
        /// Main form loading commands
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMain_Load(object sender, EventArgs e)
        {
            PopulateGenders();
            cboGenders.DataSource = Genders;
            Patient.patients.AddRange(Patient.GetSamplePatients());
            UpdateDataGrid();

        }

        private void btnSetHairColor_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            lblHairColor.BackColor = colorDialog1.Color;
                
        }
        private void btnSetEyeColor_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            lblEyeColor.BackColor = colorDialog1.Color;

        }
        private void btnRest_Click(object sender, EventArgs e)
        {
            SetDefaults();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// Events: Execute the form about by clicking About button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAbout_Click(object sender, EventArgs e)
        {
            frmAbout frm = new frmAbout();
            frm.ShowDialog();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            Patient ptt = new Patient(); // creating new patient and auto numbering them
            ptt.FirstName = txtFirstName.Text; // get that information
            ptt.SurName = txtSurname.Text;
            ptt.Sex = cboGenders.SelectedValue.ToString();
            ptt.HomeTown = txtHomeTown.Text;
            ptt.Section = txtSection.Text;
            ptt.Born = dtpBorn.Value;
            ptt.IsSmoker = chkSmoker.Checked;
            ptt.HairColor = lblHairColor.BackColor;
            ptt.EyeColor = lblEyeColor.BackColor;

            //determine if adding new patient or editing
            if (nudPatientID.Value == 0)  // if PatientID equal to zero this mean you can add new one
            {
                Patient.patients.Add(ptt); // adding a new patient
            }
            else
            {
                // this code  edithing a row then we click on that with changing its Patient ID
                // editing(replace) //we are removing a Patient.find a Patient return a Patient and find a Patient by sending in patient ID 
                Patient.patients.Remove(Patient.FindPatient((Int32)nudPatientID.Value));
                ptt.PatientID = (Int32)nudPatientID.Value;
                Patient.patients.Add(ptt);// remove the old patient version  and add new one of them again;

            }
            UpdateDataGrid();
            SetDefaults();

        }
        /// <summary>
        /// set to edit the clicked data row
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectionChanged(object sender, EventArgs e)
        {
            if (DoGridSelectionChange && dgvPatients.SelectedRows.Count > 0)
            {
                int patientID = int.Parse(dgvPatients.SelectedRows[0].Cells[0].Value.ToString());
                Patient ppt = Patient.FindPatient(patientID);
                PapulatePatient(ppt);

            }


        }
        /// <summary>
        /// Remove one row from Patients List
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRemove_Click(object sender, EventArgs e)
        {
            
            Patient.patients.Remove(Patient.FindPatient((Int32)nudPatientID.Value));
            
            UpdateDataGrid();
            SetDefaults();

        }



        #endregion




        #region CUMSTOM METHOD
        private void PopulateGenders()
        {
            Genders.Add("Male");
            Genders.Add("Female");
        }


        private void SetDefaults()
        {
            lblHairColor.BackColor = Color.Gray;
            lblEyeColor.BackColor = Color.Gray;
            txtFirstName.Clear();
            txtSurname.Clear();
            cboGenders.SelectedItem = "Male";
            txtHomeTown.Clear();
            txtSection.Clear();
            dtpBorn.Value = DateTime.Now;
            nudPatientID.Value = 0;
            chkSmoker.Checked = false;
        }

        private void UpdateDataGrid()
        {
            DoGridSelectionChange = false;
            dgvPatients.DataSource = null;
            dgvPatients.DataSource = Patient.patients;
            dgvPatients.ClearSelection();
            DoGridSelectionChange = true;
        }

        private void PapulatePatient(Patient p)
        {
            this.nudPatientID.Value = p.PatientID;
            this.txtFirstName.Text = p.FirstName;
            this.txtSurname.Text = p.SurName;
            this.cboGenders.SelectedItem = p.Sex;
            this.txtHomeTown.Text = p.HomeTown;
            this.txtSection.Text = p.Section;
            this.dtpBorn.Value = p.Born;
            this.chkSmoker.Checked = p.IsSmoker;
            this.lblHairColor.BackColor = p.HairColor;
            this.lblEyeColor.BackColor = p.EyeColor;
        }

       





        #endregion

        
    }
}
