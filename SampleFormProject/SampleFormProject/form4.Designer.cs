
namespace SampleFormProject
{
    partial class form4
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
            this.txtSave = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtRead = new System.Windows.Forms.TextBox();
            this.btnRead = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSave
            // 
            this.txtSave.Location = new System.Drawing.Point(70, 96);
            this.txtSave.Name = "txtSave";
            this.txtSave.Size = new System.Drawing.Size(162, 20);
            this.txtSave.TabIndex = 0;
            this.txtSave.TextChanged += new System.EventHandler(this.txtSave_TextChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(145, 138);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtRead
            // 
            this.txtRead.Location = new System.Drawing.Point(276, 33);
            this.txtRead.Multiline = true;
            this.txtRead.Name = "txtRead";
            this.txtRead.Size = new System.Drawing.Size(147, 83);
            this.txtRead.TabIndex = 2;
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(348, 138);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(75, 23);
            this.btnRead.TabIndex = 3;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 197);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.txtRead);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtSave);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Operation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSave;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtRead;
        private System.Windows.Forms.Button btnRead;
    }
}