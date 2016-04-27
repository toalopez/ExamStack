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
            this.components = new System.ComponentModel.Container();
            this.lblName = new Telerik.WinControls.UI.RadLabel();
            this.lblExamNum = new Telerik.WinControls.UI.RadLabel();
            this.radSeparator1 = new Telerik.WinControls.UI.RadSeparator();
            this.txtName = new Telerik.WinControls.UI.RadTextBoxControl();
            this.txtExamNum = new Telerik.WinControls.UI.RadTextBoxControl();
            this.lstExams = new Telerik.WinControls.UI.RadListControl();
            this.lblExamList = new Telerik.WinControls.UI.RadLabel();
            this.btnTurnIn = new Telerik.WinControls.UI.RadButton();
            this.btnView = new Telerik.WinControls.UI.RadButton();
            this.btnReturn = new Telerik.WinControls.UI.RadButton();
            this.btnFinish = new Telerik.WinControls.UI.RadButton();
            this.testBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.lblName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblExamNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSeparator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtExamNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstExams)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblExamList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTurnIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReturn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFinish)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testBindingSource)).BeginInit();
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
            // lstExams
            // 
            this.lstExams.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstExams.DataSource = this.testBindingSource;
            this.lstExams.DisplayMember = "Name";
            this.lstExams.Location = new System.Drawing.Point(25, 98);
            this.lstExams.Name = "lstExams";
            this.lstExams.Size = new System.Drawing.Size(594, 227);
            this.lstExams.TabIndex = 5;
            this.lstExams.Text = "radListControl1";
            this.lstExams.ValueMember = "Numero";
            // 
            // lblExamList
            // 
            this.lblExamList.Location = new System.Drawing.Point(25, 74);
            this.lblExamList.Name = "lblExamList";
            this.lblExamList.Size = new System.Drawing.Size(64, 18);
            this.lblExamList.TabIndex = 6;
            this.lblExamList.Text = "Exam List  : ";
            // 
            // btnTurnIn
            // 
            this.btnTurnIn.Location = new System.Drawing.Point(29, 347);
            this.btnTurnIn.Name = "btnTurnIn";
            this.btnTurnIn.Size = new System.Drawing.Size(87, 32);
            this.btnTurnIn.TabIndex = 7;
            this.btnTurnIn.Text = "Turn In";
            this.btnTurnIn.Click += new System.EventHandler(this.btnTurnIn_Click);
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(140, 347);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(87, 32);
            this.btnView.TabIndex = 8;
            this.btnView.Text = "View";
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(252, 347);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(87, 32);
            this.btnReturn.TabIndex = 9;
            this.btnReturn.Text = "Return";
            // 
            // btnFinish
            // 
            this.btnFinish.Location = new System.Drawing.Point(356, 347);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(87, 32);
            this.btnFinish.TabIndex = 10;
            this.btnFinish.Text = "Finish";
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // testBindingSource
            // 
            this.testBindingSource.DataSource = typeof(ExamStack.Test);
            // 
            // MainExams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 405);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnTurnIn);
            this.Controls.Add(this.lblExamList);
            this.Controls.Add(this.lstExams);
            this.Controls.Add(this.txtExamNum);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.radSeparator1);
            this.Controls.Add(this.lblExamNum);
            this.Controls.Add(this.lblName);
            this.Name = "MainExams";
            this.Text = "Exam Stack";
            this.Load += new System.EventHandler(this.MainExams_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lblName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblExamNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSeparator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtExamNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstExams)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblExamList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTurnIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReturn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFinish)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel lblName;
        private Telerik.WinControls.UI.RadLabel lblExamNum;
        private Telerik.WinControls.UI.RadSeparator radSeparator1;
        private Telerik.WinControls.UI.RadTextBoxControl txtName;
        private Telerik.WinControls.UI.RadTextBoxControl txtExamNum;
        private Telerik.WinControls.UI.RadListControl lstExams;
        private Telerik.WinControls.UI.RadLabel lblExamList;
        private Telerik.WinControls.UI.RadButton btnTurnIn;
        private Telerik.WinControls.UI.RadButton btnView;
        private Telerik.WinControls.UI.RadButton btnReturn;
        private Telerik.WinControls.UI.RadButton btnFinish;
        private System.Windows.Forms.BindingSource testBindingSource;
    }
}

