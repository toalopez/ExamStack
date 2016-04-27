using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace ExamStack
{
    public partial class MainExams : Form
    {
        ExamCollection submittedTests = null;

        public MainExams()
        {
            InitializeComponent();
           
        }

        private void MainExams_Load(object sender, EventArgs e)
        {
            submittedTests = new ExamCollection();

        }

        private void btnTurnIn_Click(object sender, EventArgs e)
        {
            Test t = new Test();
            RadListDataItem d = new RadListDataItem();
            t.Name = txtName.Text;
            t.Numero = Convert.ToInt16(txtExamNum.Text);

            submittedTests.Add(t);

            d.Text = t.Name;
            d.Value = t.Numero;

            lstExams.Items.Add(d);

            txtName.Text = "";
            txtExamNum.Text = "";
            
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            // testBindingSource.DataSource = submittedTests;
            // lstExams.DataSource = testBindingSource;
        }
    }
}
