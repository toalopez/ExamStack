namespace ExamStack
{
    partial class MainExams
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components;

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
            this.lblName = new Telerik.WinControls.UI.RadLabel();
            this.lblExamNum = new Telerik.WinControls.UI.RadLabel();
            this.radSeparator1 = new Telerik.WinControls.UI.RadSeparator();
            this.txtName = new Telerik.WinControls.UI.RadTextBoxControl();
            this.txtExamNum = new Telerik.WinControls.UI.RadTextBoxControl();
            ((System.ComponentModel.ISupportInitialize)(this.lblName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblExamNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSeparator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtExamNum)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(25, 22);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(45, 18);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name : ";
            // 
            // lblExamNum
            // 
            this.lblExamNum.Location = new System.Drawing.Point(413, 22);
            this.lblExamNum.Name = "lblExamNum";
            this.lblExamNum.Size = new System.Drawing.Size(86, 18);
            this.lblExamNum.TabIndex = 1;
            this.lblExamNum.Text = "Exam Number : ";
            // 
            // radSeparator1
            // 
            this.radSeparator1.Location = new System.Drawing.Point(12, 46);
            this.radSeparator1.Name = "radSeparator1";
            this.radSeparator1.Size = new System.Drawing.Size(619, 22);
            this.radSeparator1.TabIndex = 2;
            this.radSeparator1.Text = "radSeparator1";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(77, 19);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(291, 27);
            this.txtName.TabIndex = 3;
            // 
            // txtExamNum
            // 
            this.txtExamNum.Location = new System.Drawing.Point(505, 19);
            this.txtExamNum.Name = "txtExamNum";
            this.txtExamNum.Size = new System.Drawing.Size(54, 27);
            this.txtExamNum.TabIndex = 4;
            // 
            // MainExams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 528);
            this.Controls.Add(this.txtExamNum);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.radSeparator1);
            this.Controls.Add(this.lblExamNum);
            this.Controls.Add(this.lblName);
            this.Name = "MainExams";
            this.Text = "Exam Stack";
            ((System.ComponentModel.ISupportInitialize)(this.lblName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblExamNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSeparator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtExamNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel lblName;
        private Telerik.WinControls.UI.RadLabel lblExamNum;
        private Telerik.WinControls.UI.RadSeparator radSeparator1;
        private Telerik.WinControls.UI.RadTextBoxControl txtName;
        private Telerik.WinControls.UI.RadTextBoxControl txtExamNum;
    }
}

