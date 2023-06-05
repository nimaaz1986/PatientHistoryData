
namespace Lab3_PatientHistoryData
{
    partial class frmAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAbout));
            this.lablExplanation = new System.Windows.Forms.Label();
            this.lblAuthorBio = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lablExplanation
            // 
            this.lablExplanation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lablExplanation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lablExplanation.Location = new System.Drawing.Point(12, 9);
            this.lablExplanation.Name = "lablExplanation";
            this.lablExplanation.Size = new System.Drawing.Size(396, 131);
            this.lablExplanation.TabIndex = 0;
            this.lablExplanation.Text = resources.GetString("lablExplanation.Text");
            this.lablExplanation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lablExplanation.Click += new System.EventHandler(this.lablExplanation_Click);
            // 
            // lblAuthorBio
            // 
            this.lblAuthorBio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAuthorBio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAuthorBio.Location = new System.Drawing.Point(12, 160);
            this.lblAuthorBio.Name = "lblAuthorBio";
            this.lblAuthorBio.Size = new System.Drawing.Size(396, 96);
            this.lblAuthorBio.TabIndex = 1;
            this.lblAuthorBio.Text = "Author : Nima Azadikhah\r\nStudent ID: -----\r\nDate: ---\r\nGithub:nimaaz1986\r\n\r\n\r\n";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(171, 280);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 49);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "&OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // frmAbout
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 401);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lblAuthorBio);
            this.Controls.Add(this.lablExplanation);
            this.MaximumSize = new System.Drawing.Size(436, 440);
            this.MinimumSize = new System.Drawing.Size(436, 440);
            this.Name = "frmAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lablExplanation;
        private System.Windows.Forms.Label lblAuthorBio;
        private System.Windows.Forms.Button btnOk;
    }
}