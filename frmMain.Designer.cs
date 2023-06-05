
namespace Lab3_PatientHistoryData
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgvPatients = new System.Windows.Forms.DataGridView();
            this.PatientID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SurName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HomeTown = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Section = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Born = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsSmoker = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.HairColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EyeColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnRest = new System.Windows.Forms.Button();
            this.btnSetEyeColor = new System.Windows.Forms.Button();
            this.btnSetHairColor = new System.Windows.Forms.Button();
            this.lblEyeColor = new System.Windows.Forms.Label();
            this.lblHairColor = new System.Windows.Forms.Label();
            this.lblSecondColor = new System.Windows.Forms.Label();
            this.lblColorFirst = new System.Windows.Forms.Label();
            this.chkSmoker = new System.Windows.Forms.CheckBox();
            this.dtpBorn = new System.Windows.Forms.DateTimePicker();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.txtSection = new System.Windows.Forms.TextBox();
            this.lblSection = new System.Windows.Forms.Label();
            this.txtHomeTown = new System.Windows.Forms.TextBox();
            this.lblHomeTown = new System.Windows.Forms.Label();
            this.cboGenders = new System.Windows.Forms.ComboBox();
            this.lblSex = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.nudPatientID = new System.Windows.Forms.NumericUpDown();
            this.lblPatientID = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.ttpMainForm = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatients)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPatientID)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPatients
            // 
            this.dgvPatients.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPatients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PatientID,
            this.FirstName,
            this.SurName,
            this.Sex,
            this.HomeTown,
            this.Section,
            this.Born,
            this.IsSmoker,
            this.HairColor,
            this.EyeColor});
            this.dgvPatients.Location = new System.Drawing.Point(6, 12);
            this.dgvPatients.MultiSelect = false;
            this.dgvPatients.Name = "dgvPatients";
            this.dgvPatients.ReadOnly = true;
            this.dgvPatients.RowTemplate.Height = 25;
            this.dgvPatients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPatients.Size = new System.Drawing.Size(857, 182);
            this.dgvPatients.TabIndex = 0;
            this.ttpMainForm.SetToolTip(this.dgvPatients, "List of Patients");
            this.dgvPatients.SelectionChanged += new System.EventHandler(this.SelectionChanged);
            // 
            // PatientID
            // 
            this.PatientID.DataPropertyName = "PatientID";
            this.PatientID.HeaderText = "Patient ID";
            this.PatientID.Name = "PatientID";
            this.PatientID.ReadOnly = true;
            this.PatientID.Width = 90;
            // 
            // FirstName
            // 
            this.FirstName.DataPropertyName = "FirstName";
            this.FirstName.HeaderText = "First Name";
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            // 
            // SurName
            // 
            this.SurName.DataPropertyName = "SurName";
            this.SurName.HeaderText = "Surname";
            this.SurName.Name = "SurName";
            this.SurName.ReadOnly = true;
            // 
            // Sex
            // 
            this.Sex.DataPropertyName = "Sex";
            this.Sex.HeaderText = "Sex";
            this.Sex.Name = "Sex";
            this.Sex.ReadOnly = true;
            this.Sex.Width = 70;
            // 
            // HomeTown
            // 
            this.HomeTown.DataPropertyName = "HomeTown";
            this.HomeTown.HeaderText = "Home Town";
            this.HomeTown.Name = "HomeTown";
            this.HomeTown.ReadOnly = true;
            // 
            // Section
            // 
            this.Section.DataPropertyName = "Section";
            this.Section.HeaderText = "Section";
            this.Section.Name = "Section";
            this.Section.ReadOnly = true;
            this.Section.Width = 70;
            // 
            // Born
            // 
            this.Born.DataPropertyName = "Born";
            this.Born.HeaderText = "Date of Birth";
            this.Born.Name = "Born";
            this.Born.ReadOnly = true;
            // 
            // IsSmoker
            // 
            this.IsSmoker.DataPropertyName = "IsSmoker";
            this.IsSmoker.HeaderText = "Smoker";
            this.IsSmoker.Name = "IsSmoker";
            this.IsSmoker.ReadOnly = true;
            this.IsSmoker.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IsSmoker.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.IsSmoker.Width = 60;
            // 
            // HairColor
            // 
            this.HairColor.DataPropertyName = "HairColor";
            this.HairColor.HeaderText = "Hair Color";
            this.HairColor.Name = "HairColor";
            this.HairColor.ReadOnly = true;
            // 
            // EyeColor
            // 
            this.EyeColor.DataPropertyName = "EyeColor";
            this.EyeColor.HeaderText = "Eye Color";
            this.EyeColor.Name = "EyeColor";
            this.EyeColor.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnRemove);
            this.groupBox1.Controls.Add(this.btnAbout);
            this.groupBox1.Controls.Add(this.btnRest);
            this.groupBox1.Controls.Add(this.btnSetEyeColor);
            this.groupBox1.Controls.Add(this.btnSetHairColor);
            this.groupBox1.Controls.Add(this.lblEyeColor);
            this.groupBox1.Controls.Add(this.lblHairColor);
            this.groupBox1.Controls.Add(this.lblSecondColor);
            this.groupBox1.Controls.Add(this.lblColorFirst);
            this.groupBox1.Controls.Add(this.chkSmoker);
            this.groupBox1.Controls.Add(this.dtpBorn);
            this.groupBox1.Controls.Add(this.lblBirthDate);
            this.groupBox1.Controls.Add(this.txtSection);
            this.groupBox1.Controls.Add(this.lblSection);
            this.groupBox1.Controls.Add(this.txtHomeTown);
            this.groupBox1.Controls.Add(this.lblHomeTown);
            this.groupBox1.Controls.Add(this.cboGenders);
            this.groupBox1.Controls.Add(this.lblSex);
            this.groupBox1.Controls.Add(this.txtSurname);
            this.groupBox1.Controls.Add(this.lblSurname);
            this.groupBox1.Controls.Add(this.txtFirstName);
            this.groupBox1.Controls.Add(this.lblFirstName);
            this.groupBox1.Controls.Add(this.nudPatientID);
            this.groupBox1.Controls.Add(this.lblPatientID);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnExit);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(6, 200);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(857, 182);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add/Edit";
            // 
            // btnRemove
            // 
            this.btnRemove.ForeColor = System.Drawing.Color.Black;
            this.btnRemove.Location = new System.Drawing.Point(529, 133);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(79, 43);
            this.btnRemove.TabIndex = 25;
            this.btnRemove.Text = "Re&move";
            this.ttpMainForm.SetToolTip(this.btnRemove, "Romve a patient  from the list");
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.ForeColor = System.Drawing.Color.Black;
            this.btnAbout.Location = new System.Drawing.Point(776, 17);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(75, 66);
            this.btnAbout.TabIndex = 24;
            this.btnAbout.Text = "A&bout";
            this.ttpMainForm.SetToolTip(this.btnAbout, "About this application");
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnRest
            // 
            this.btnRest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRest.ForeColor = System.Drawing.Color.Black;
            this.btnRest.Location = new System.Drawing.Point(614, 133);
            this.btnRest.Name = "btnRest";
            this.btnRest.Size = new System.Drawing.Size(75, 43);
            this.btnRest.TabIndex = 23;
            this.btnRest.Text = "&Rest";
            this.ttpMainForm.SetToolTip(this.btnRest, "Reset the form to intial defualts");
            this.btnRest.UseVisualStyleBackColor = true;
            this.btnRest.Click += new System.EventHandler(this.btnRest_Click);
            // 
            // btnSetEyeColor
            // 
            this.btnSetEyeColor.ForeColor = System.Drawing.Color.Black;
            this.btnSetEyeColor.Location = new System.Drawing.Point(664, 73);
            this.btnSetEyeColor.Name = "btnSetEyeColor";
            this.btnSetEyeColor.Size = new System.Drawing.Size(47, 44);
            this.btnSetEyeColor.TabIndex = 22;
            this.btnSetEyeColor.Text = "Set";
            this.btnSetEyeColor.UseVisualStyleBackColor = true;
            this.btnSetEyeColor.Click += new System.EventHandler(this.btnSetEyeColor_Click);
            // 
            // btnSetHairColor
            // 
            this.btnSetHairColor.ForeColor = System.Drawing.Color.Black;
            this.btnSetHairColor.Location = new System.Drawing.Point(664, 17);
            this.btnSetHairColor.Name = "btnSetHairColor";
            this.btnSetHairColor.Size = new System.Drawing.Size(47, 44);
            this.btnSetHairColor.TabIndex = 21;
            this.btnSetHairColor.Text = "Set";
            this.btnSetHairColor.UseVisualStyleBackColor = true;
            this.btnSetHairColor.Click += new System.EventHandler(this.btnSetHairColor_Click);
            // 
            // lblEyeColor
            // 
            this.lblEyeColor.BackColor = System.Drawing.Color.Gray;
            this.lblEyeColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEyeColor.Location = new System.Drawing.Point(602, 73);
            this.lblEyeColor.Name = "lblEyeColor";
            this.lblEyeColor.Size = new System.Drawing.Size(47, 44);
            this.lblEyeColor.TabIndex = 20;
            this.lblEyeColor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblHairColor
            // 
            this.lblHairColor.BackColor = System.Drawing.Color.Gray;
            this.lblHairColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblHairColor.Location = new System.Drawing.Point(602, 17);
            this.lblHairColor.Name = "lblHairColor";
            this.lblHairColor.Size = new System.Drawing.Size(47, 44);
            this.lblHairColor.TabIndex = 19;
            this.lblHairColor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSecondColor
            // 
            this.lblSecondColor.Location = new System.Drawing.Point(529, 73);
            this.lblSecondColor.Name = "lblSecondColor";
            this.lblSecondColor.Size = new System.Drawing.Size(67, 44);
            this.lblSecondColor.TabIndex = 18;
            this.lblSecondColor.Text = "Eye Color";
            this.lblSecondColor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblColorFirst
            // 
            this.lblColorFirst.Location = new System.Drawing.Point(529, 19);
            this.lblColorFirst.Name = "lblColorFirst";
            this.lblColorFirst.Size = new System.Drawing.Size(67, 44);
            this.lblColorFirst.TabIndex = 17;
            this.lblColorFirst.Text = "Hair Color";
            this.lblColorFirst.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chkSmoker
            // 
            this.chkSmoker.AutoSize = true;
            this.chkSmoker.Location = new System.Drawing.Point(240, 146);
            this.chkSmoker.Name = "chkSmoker";
            this.chkSmoker.Size = new System.Drawing.Size(66, 19);
            this.chkSmoker.TabIndex = 16;
            this.chkSmoker.Text = "Smoker";
            this.chkSmoker.UseVisualStyleBackColor = true;
            // 
            // dtpBorn
            // 
            this.dtpBorn.Location = new System.Drawing.Point(317, 104);
            this.dtpBorn.Name = "dtpBorn";
            this.dtpBorn.Size = new System.Drawing.Size(200, 23);
            this.dtpBorn.TabIndex = 15;
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Location = new System.Drawing.Point(240, 110);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(59, 15);
            this.lblBirthDate.TabIndex = 14;
            this.lblBirthDate.Text = "Birth Date";
            // 
            // txtSection
            // 
            this.txtSection.Location = new System.Drawing.Point(317, 67);
            this.txtSection.Name = "txtSection";
            this.txtSection.Size = new System.Drawing.Size(100, 23);
            this.txtSection.TabIndex = 13;
            // 
            // lblSection
            // 
            this.lblSection.AutoSize = true;
            this.lblSection.Location = new System.Drawing.Point(240, 70);
            this.lblSection.Name = "lblSection";
            this.lblSection.Size = new System.Drawing.Size(46, 15);
            this.lblSection.TabIndex = 12;
            this.lblSection.Text = "Section";
            // 
            // txtHomeTown
            // 
            this.txtHomeTown.Location = new System.Drawing.Point(317, 32);
            this.txtHomeTown.Name = "txtHomeTown";
            this.txtHomeTown.Size = new System.Drawing.Size(100, 23);
            this.txtHomeTown.TabIndex = 11;
            // 
            // lblHomeTown
            // 
            this.lblHomeTown.AutoSize = true;
            this.lblHomeTown.ForeColor = System.Drawing.Color.Transparent;
            this.lblHomeTown.Location = new System.Drawing.Point(240, 32);
            this.lblHomeTown.Name = "lblHomeTown";
            this.lblHomeTown.Size = new System.Drawing.Size(71, 15);
            this.lblHomeTown.TabIndex = 10;
            this.lblHomeTown.Text = "Home Town";
            // 
            // cboGenders
            // 
            this.cboGenders.FormattingEnabled = true;
            this.cboGenders.Location = new System.Drawing.Point(95, 144);
            this.cboGenders.Name = "cboGenders";
            this.cboGenders.Size = new System.Drawing.Size(100, 23);
            this.cboGenders.TabIndex = 9;
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Location = new System.Drawing.Point(22, 147);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(25, 15);
            this.lblSex.TabIndex = 8;
            this.lblSex.Text = "Sex";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(95, 110);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(100, 23);
            this.txtSurname.TabIndex = 7;
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(22, 113);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(54, 15);
            this.lblSurname.TabIndex = 6;
            this.lblSurname.Text = "Surname";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(95, 70);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 23);
            this.txtFirstName.TabIndex = 5;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(22, 73);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(64, 15);
            this.lblFirstName.TabIndex = 4;
            this.lblFirstName.Text = "First Name";
            // 
            // nudPatientID
            // 
            this.nudPatientID.Enabled = false;
            this.nudPatientID.Location = new System.Drawing.Point(95, 30);
            this.nudPatientID.Name = "nudPatientID";
            this.nudPatientID.Size = new System.Drawing.Size(120, 23);
            this.nudPatientID.TabIndex = 3;
            // 
            // lblPatientID
            // 
            this.lblPatientID.AutoSize = true;
            this.lblPatientID.Location = new System.Drawing.Point(22, 32);
            this.lblPatientID.Name = "lblPatientID";
            this.lblPatientID.Size = new System.Drawing.Size(58, 15);
            this.lblPatientID.TabIndex = 2;
            this.lblPatientID.Text = "Parient ID";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(695, 133);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 43);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "&Save";
            this.ttpMainForm.SetToolTip(this.btnSave, "Save new patient or edit the selected patient from the list");
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Location = new System.Drawing.Point(776, 133);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 43);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "E&xit";
            this.ttpMainForm.SetToolTip(this.btnExit, "Exit the Application ");
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmMain
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Lab3_PatientHistoryData.Properties.Resources.ghassss;
            this.CancelButton = this.btnRest;
            this.ClientSize = new System.Drawing.Size(869, 394);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvPatients);
            this.MaximumSize = new System.Drawing.Size(885, 433);
            this.MinimumSize = new System.Drawing.Size(885, 433);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Patients History ";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatients)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPatientID)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPatients;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SurName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn HomeTown;
        private System.Windows.Forms.DataGridViewTextBoxColumn Section;
        private System.Windows.Forms.DataGridViewTextBoxColumn Born;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsSmoker;
        private System.Windows.Forms.DataGridViewTextBoxColumn HairColor;
        private System.Windows.Forms.DataGridViewTextBoxColumn EyeColor;
        private System.Windows.Forms.Label lblPatientID;
        private System.Windows.Forms.NumericUpDown nudPatientID;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label lblHomeTown;
        private System.Windows.Forms.ComboBox cboGenders;
        private System.Windows.Forms.TextBox txtSection;
        private System.Windows.Forms.Label lblSection;
        private System.Windows.Forms.TextBox txtHomeTown;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.DateTimePicker dtpBorn;
        private System.Windows.Forms.CheckBox chkSmoker;
        private System.Windows.Forms.Label lblSecondColor;
        private System.Windows.Forms.Label lblColorFirst;
        private System.Windows.Forms.Label lblEyeColor;
        private System.Windows.Forms.Label lblHairColor;
        private System.Windows.Forms.Button btnSetHairColor;
        private System.Windows.Forms.Button btnSetEyeColor;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btnRest;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.ToolTip ttpMainForm;
        private System.Windows.Forms.Button btnRemove;
    }
}

