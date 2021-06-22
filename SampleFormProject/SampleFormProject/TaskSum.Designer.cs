
namespace SampleFormProject
{
    partial class TaskSum
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
            this.txtFirstNumber = new System.Windows.Forms.TextBox();
            this.txtSecondNumber = new System.Windows.Forms.TextBox();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.btnSum = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtFirstNumber
            // 
            this.txtFirstNumber.Location = new System.Drawing.Point(32, 48);
            this.txtFirstNumber.Name = "txtFirstNumber";
            this.txtFirstNumber.Size = new System.Drawing.Size(130, 20);
            this.txtFirstNumber.TabIndex = 0;
            this.txtFirstNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFirstNumber.TextChanged += new System.EventHandler(this.txtFirstNumber_TextChanged);
            // 
            // txtSecondNumber
            // 
            this.txtSecondNumber.Location = new System.Drawing.Point(32, 106);
            this.txtSecondNumber.Name = "txtSecondNumber";
            this.txtSecondNumber.Size = new System.Drawing.Size(130, 20);
            this.txtSecondNumber.TabIndex = 1;
            this.txtSecondNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblAnswer
            // 
            this.lblAnswer.Location = new System.Drawing.Point(62, 177);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(100, 23);
            this.lblAnswer.TabIndex = 2;
            // 
            // btnSum
            // 
            this.btnSum.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSum.Location = new System.Drawing.Point(198, 48);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(75, 78);
            this.btnSum.TabIndex = 4;
            this.btnSum.Text = "Sum";
            this.btnSum.UseVisualStyleBackColor = false;
            this.btnSum.Click += new System.EventHandler(this.btnSum_Click);
            // 
            // txtResult
            // 
            this.txtResult.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtResult.Location = new System.Drawing.Point(32, 177);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(130, 20);
            this.txtResult.TabIndex = 5;
            this.txtResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TaskSum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(285, 231);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnSum);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.txtSecondNumber);
            this.Controls.Add(this.txtFirstNumber);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TaskSum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TaskForSum";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFirstNumber;
        private System.Windows.Forms.TextBox txtSecondNumber;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.TextBox txtResult;
    }
}