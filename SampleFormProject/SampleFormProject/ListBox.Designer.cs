
namespace SampleFormProject
{
    partial class ListBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListBox));
            this.txtAdd = new System.Windows.Forms.TextBox();
            this.txtRemove = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lstNames = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtAdd
            // 
            resources.ApplyResources(this.txtAdd, "txtAdd");
            this.txtAdd.Name = "txtAdd";
            // 
            // txtRemove
            // 
            resources.ApplyResources(this.txtRemove, "txtRemove");
            this.txtRemove.Name = "txtRemove";
            // 
            // btnAdd
            // 
            resources.ApplyResources(this.btnAdd, "btnAdd");
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            resources.ApplyResources(this.btnRemove, "btnRemove");
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lstNames
            // 
            this.lstNames.FormattingEnabled = true;
            resources.ApplyResources(this.lstNames, "lstNames");
            this.lstNames.Name = "lstNames";
            // 
            // ListBox
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lstNames);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtRemove);
            this.Controls.Add(this.txtAdd);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ListBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAdd;
        private System.Windows.Forms.TextBox txtRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.ListBox lstNames;
    }
}