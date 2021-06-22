
namespace SampleFormProject
{
    partial class FormDBInteraction
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
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.lblPlace = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtDateOfBirth = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPlace = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFirstName
            // 
            this.lblFirstName.Location = new System.Drawing.Point(146, 55);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(131, 23);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "FirstName";
            this.lblFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLastName
            // 
            this.lblLastName.Location = new System.Drawing.Point(146, 115);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(131, 23);
            this.lblLastName.TabIndex = 1;
            this.lblLastName.Text = "LastName";
            this.lblLastName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.Location = new System.Drawing.Point(146, 174);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(131, 23);
            this.lblDateOfBirth.TabIndex = 2;
            this.lblDateOfBirth.Text = "DateOfBirth";
            this.lblDateOfBirth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlace
            // 
            this.lblPlace.Location = new System.Drawing.Point(136, 292);
            this.lblPlace.Name = "lblPlace";
            this.lblPlace.Size = new System.Drawing.Size(131, 23);
            this.lblPlace.TabIndex = 4;
            this.lblPlace.Text = "Place";
            this.lblPlace.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEmail
            // 
            this.lblEmail.Location = new System.Drawing.Point(136, 233);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(131, 23);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "Email";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.Location = new System.Drawing.Point(157, 350);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(131, 23);
            this.lblPhoneNumber.TabIndex = 6;
            this.lblPhoneNumber.Text = "PhoneNumber";
            this.lblPhoneNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(185, 81);
            this.txtFirstName.Multiline = true;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(172, 20);
            this.txtFirstName.TabIndex = 7;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(185, 141);
            this.txtLastName.Multiline = true;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(172, 20);
            this.txtLastName.TabIndex = 8;
            // 
            // txtDateOfBirth
            // 
            this.txtDateOfBirth.Location = new System.Drawing.Point(185, 200);
            this.txtDateOfBirth.Multiline = true;
            this.txtDateOfBirth.Name = "txtDateOfBirth";
            this.txtDateOfBirth.Size = new System.Drawing.Size(172, 20);
            this.txtDateOfBirth.TabIndex = 9;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(185, 259);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(172, 20);
            this.txtEmail.TabIndex = 10;
            // 
            // txtPlace
            // 
            this.txtPlace.Location = new System.Drawing.Point(185, 318);
            this.txtPlace.Multiline = true;
            this.txtPlace.Name = "txtPlace";
            this.txtPlace.Size = new System.Drawing.Size(172, 20);
            this.txtPlace.TabIndex = 11;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(185, 376);
            this.txtPhoneNumber.Multiline = true;
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(172, 20);
            this.txtPhoneNumber.TabIndex = 12;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnSubmit.Location = new System.Drawing.Point(201, 431);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(134, 23);
            this.btnSubmit.TabIndex = 13;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // FormDBInteraction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 515);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtPlace);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtDateOfBirth);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblPlace);
            this.Controls.Add(this.lblDateOfBirth);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDBInteraction";
            this.Text = "DBInteraction Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.Label lblPlace;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtDateOfBirth;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPlace;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Button btnSubmit;
    }
}