
namespace MainWindow.View
{
    partial class MainForm
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
            this.lbPatientList = new System.Windows.Forms.ListBox();
            this.btPatientAdd = new System.Windows.Forms.Button();
            this.btPatientRemove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbPatientList
            // 
            this.lbPatientList.BackColor = System.Drawing.Color.AntiqueWhite;
            this.lbPatientList.FormattingEnabled = true;
            this.lbPatientList.ItemHeight = 15;
            this.lbPatientList.Location = new System.Drawing.Point(12, 12);
            this.lbPatientList.Name = "lbPatientList";
            this.lbPatientList.Size = new System.Drawing.Size(268, 379);
            this.lbPatientList.TabIndex = 0;
            // 
            // btPatientAdd
            // 
            this.btPatientAdd.BackColor = System.Drawing.SystemColors.Highlight;
            this.btPatientAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btPatientAdd.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btPatientAdd.Location = new System.Drawing.Point(12, 406);
            this.btPatientAdd.Name = "btPatientAdd";
            this.btPatientAdd.Size = new System.Drawing.Size(108, 41);
            this.btPatientAdd.TabIndex = 1;
            this.btPatientAdd.Text = "Добавить";
            this.btPatientAdd.UseVisualStyleBackColor = false;
            // 
            // btPatientRemove
            // 
            this.btPatientRemove.BackColor = System.Drawing.SystemColors.Highlight;
            this.btPatientRemove.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btPatientRemove.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btPatientRemove.Location = new System.Drawing.Point(172, 406);
            this.btPatientRemove.Name = "btPatientRemove";
            this.btPatientRemove.Size = new System.Drawing.Size(108, 41);
            this.btPatientRemove.TabIndex = 2;
            this.btPatientRemove.Text = "Удалить";
            this.btPatientRemove.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btPatientRemove);
            this.Controls.Add(this.btPatientAdd);
            this.Controls.Add(this.lbPatientList);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbPatientList;
        private System.Windows.Forms.Button btPatientAdd;
        private System.Windows.Forms.Button btPatientRemove;
    }
}