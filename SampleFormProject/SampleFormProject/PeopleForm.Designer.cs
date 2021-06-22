
namespace SampleFormProject
{
    partial class PeopleForm
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
            this.txtSearchingName = new System.Windows.Forms.TextBox();
            this.lblSearchingName = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblMarks = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtMarks = new System.Windows.Forms.TextBox();
            this.lblPlace = new System.Windows.Forms.Label();
            this.txtPlace = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtSearchingName
            // 
            this.txtSearchingName.Location = new System.Drawing.Point(93, 67);
            this.txtSearchingName.Name = "txtSearchingName";
            this.txtSearchingName.Size = new System.Drawing.Size(200, 20);
            this.txtSearchingName.TabIndex = 0;
            // 
            // lblSearchingName
            // 
            this.lblSearchingName.AutoSize = true;
            this.lblSearchingName.Location = new System.Drawing.Point(90, 51);
            this.lblSearchingName.Name = "lblSearchingName";
            this.lblSearchingName.Size = new System.Drawing.Size(35, 13);
            this.lblSearchingName.TabIndex = 1;
            this.lblSearchingName.Text = "Name";
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(325, 67);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 2;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(172, 141);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(172, 194);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(75, 13);
            this.lblPhoneNumber.TabIndex = 4;
            this.lblPhoneNumber.Text = "PhoneNumber";
            // 
            // lblMarks
            // 
            this.lblMarks.AutoSize = true;
            this.lblMarks.Location = new System.Drawing.Point(172, 293);
            this.lblMarks.Name = "lblMarks";
            this.lblMarks.Size = new System.Drawing.Size(50, 13);
            this.lblMarks.TabIndex = 5;
            this.lblMarks.Text = "Marks(%)";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(172, 244);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "Email";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(175, 157);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(225, 20);
            this.txtName.TabIndex = 7;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(175, 210);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(225, 20);
            this.txtPhoneNumber.TabIndex = 8;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(175, 260);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(225, 20);
            this.txtEmail.TabIndex = 9;
            // 
            // txtMarks
            // 
            this.txtMarks.Location = new System.Drawing.Point(175, 309);
            this.txtMarks.Name = "txtMarks";
            this.txtMarks.Size = new System.Drawing.Size(225, 20);
            this.txtMarks.TabIndex = 10;
            // 
            // lblPlace
            // 
            this.lblPlace.AutoSize = true;
            this.lblPlace.Location = new System.Drawing.Point(172, 341);
            this.lblPlace.Name = "lblPlace";
            this.lblPlace.Size = new System.Drawing.Size(34, 13);
            this.lblPlace.TabIndex = 11;
            this.lblPlace.Text = "Place";
            // 
            // txtPlace
            // 
            this.txtPlace.Location = new System.Drawing.Point(175, 357);
            this.txtPlace.Name = "txtPlace";
            this.txtPlace.Size = new System.Drawing.Size(225, 20);
            this.txtPlace.TabIndex = 12;
            // 
            // PeopleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 437);
            this.Controls.Add(this.txtPlace);
            this.Controls.Add(this.lblPlace);
            this.Controls.Add(this.txtMarks);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblMarks);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.lblSearchingName);
            this.Controls.Add(this.txtSearchingName);
            this.Name = "PeopleForm";
            this.Text = "People Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearchingName;
        private System.Windows.Forms.Label lblSearchingName;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblMarks;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtMarks;
        private System.Windows.Forms.Label lblPlace;
        private System.Windows.Forms.TextBox txtPlace;
    }
}