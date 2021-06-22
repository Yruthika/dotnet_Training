
namespace SampleFormProject
{
    partial class DataMigration
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
            this.btnMigrate = new System.Windows.Forms.Button();
            this.txtReverse = new System.Windows.Forms.TextBox();
            this.btnReverse = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.txtMigrate = new System.Windows.Forms.TextBox();
            this.txtRead = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtSave
            // 
            this.txtSave.Location = new System.Drawing.Point(84, 40);
            this.txtSave.Name = "txtSave";
            this.txtSave.Size = new System.Drawing.Size(154, 20);
            this.txtSave.TabIndex = 0;
            this.txtSave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(121, 80);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnMigrate
            // 
            this.btnMigrate.Location = new System.Drawing.Point(339, 268);
            this.btnMigrate.Name = "btnMigrate";
            this.btnMigrate.Size = new System.Drawing.Size(91, 23);
            this.btnMigrate.TabIndex = 2;
            this.btnMigrate.Text = "Migrate";
            this.btnMigrate.UseVisualStyleBackColor = true;
            this.btnMigrate.Click += new System.EventHandler(this.btnMigrate_Click);
            // 
            // txtReverse
            // 
            this.txtReverse.Location = new System.Drawing.Point(527, 164);
            this.txtReverse.Multiline = true;
            this.txtReverse.Name = "txtReverse";
            this.txtReverse.Size = new System.Drawing.Size(154, 80);
            this.txtReverse.TabIndex = 3;
            this.txtReverse.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnReverse
            // 
            this.btnReverse.Location = new System.Drawing.Point(569, 268);
            this.btnReverse.Name = "btnReverse";
            this.btnReverse.Size = new System.Drawing.Size(75, 23);
            this.btnReverse.TabIndex = 4;
            this.btnReverse.Text = "Reverse";
            this.btnReverse.UseVisualStyleBackColor = true;
            this.btnReverse.Click += new System.EventHandler(this.btnReverse_Click);
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(121, 268);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(75, 23);
            this.btnRead.TabIndex = 5;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // txtMigrate
            // 
            this.txtMigrate.Location = new System.Drawing.Point(309, 164);
            this.txtMigrate.Multiline = true;
            this.txtMigrate.Name = "txtMigrate";
            this.txtMigrate.Size = new System.Drawing.Size(154, 80);
            this.txtMigrate.TabIndex = 7;
            this.txtMigrate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtRead
            // 
            this.txtRead.Location = new System.Drawing.Point(84, 164);
            this.txtRead.Multiline = true;
            this.txtRead.Name = "txtRead";
            this.txtRead.Size = new System.Drawing.Size(154, 80);
            this.txtRead.TabIndex = 8;
            this.txtRead.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DataMigration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(760, 337);
            this.Controls.Add(this.txtRead);
            this.Controls.Add(this.txtMigrate);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.btnReverse);
            this.Controls.Add(this.txtReverse);
            this.Controls.Add(this.btnMigrate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtSave);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DataMigration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Migration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSave;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnMigrate;
        private System.Windows.Forms.TextBox txtReverse;
        private System.Windows.Forms.Button btnReverse;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.TextBox txtMigrate;
        private System.Windows.Forms.TextBox txtRead;
    }
}