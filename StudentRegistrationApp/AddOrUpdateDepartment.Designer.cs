
namespace StudentRegistrationApp
{
    partial class AddOrUpdateDepartmentForm
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
            this.listBoxDepartment = new System.Windows.Forms.ListBox();
            this.labelDepartmentCode = new System.Windows.Forms.Label();
            this.textBoxDepartmentCode = new System.Windows.Forms.TextBox();
            this.textBoxDepartmentName = new System.Windows.Forms.TextBox();
            this.labelDepartmentName = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxDepartment
            // 
            this.listBoxDepartment.FormattingEnabled = true;
            this.listBoxDepartment.ItemHeight = 16;
            this.listBoxDepartment.Location = new System.Drawing.Point(38, 37);
            this.listBoxDepartment.Name = "listBoxDepartment";
            this.listBoxDepartment.Size = new System.Drawing.Size(218, 228);
            this.listBoxDepartment.TabIndex = 0;
            // 
            // labelDepartmentCode
            // 
            this.labelDepartmentCode.AutoSize = true;
            this.labelDepartmentCode.Location = new System.Drawing.Point(38, 301);
            this.labelDepartmentCode.Name = "labelDepartmentCode";
            this.labelDepartmentCode.Size = new System.Drawing.Size(119, 17);
            this.labelDepartmentCode.TabIndex = 1;
            this.labelDepartmentCode.Text = "Department Code";
            // 
            // textBoxDepartmentCode
            // 
            this.textBoxDepartmentCode.Location = new System.Drawing.Point(38, 326);
            this.textBoxDepartmentCode.Name = "textBoxDepartmentCode";
            this.textBoxDepartmentCode.Size = new System.Drawing.Size(116, 22);
            this.textBoxDepartmentCode.TabIndex = 2;
            // 
            // textBoxDepartmentName
            // 
            this.textBoxDepartmentName.Location = new System.Drawing.Point(38, 405);
            this.textBoxDepartmentName.Name = "textBoxDepartmentName";
            this.textBoxDepartmentName.Size = new System.Drawing.Size(234, 22);
            this.textBoxDepartmentName.TabIndex = 4;
            // 
            // labelDepartmentName
            // 
            this.labelDepartmentName.AutoSize = true;
            this.labelDepartmentName.Location = new System.Drawing.Point(38, 380);
            this.labelDepartmentName.Name = "labelDepartmentName";
            this.labelDepartmentName.Size = new System.Drawing.Size(123, 17);
            this.labelDepartmentName.TabIndex = 3;
            this.labelDepartmentName.Text = "Department Name";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(41, 460);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(113, 37);
            this.buttonAdd.TabIndex = 5;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(210, 460);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(113, 37);
            this.buttonUpdate.TabIndex = 6;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            // 
            // AddOrUpdateDepartmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 554);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxDepartmentName);
            this.Controls.Add(this.labelDepartmentName);
            this.Controls.Add(this.textBoxDepartmentCode);
            this.Controls.Add(this.labelDepartmentCode);
            this.Controls.Add(this.listBoxDepartment);
            this.Name = "AddOrUpdateDepartmentForm";
            this.Text = "Add Or Update Department";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxDepartment;
        private System.Windows.Forms.Label labelDepartmentCode;
        private System.Windows.Forms.TextBox textBoxDepartmentCode;
        private System.Windows.Forms.TextBox textBoxDepartmentName;
        private System.Windows.Forms.Label labelDepartmentName;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonUpdate;
    }
}