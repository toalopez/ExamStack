using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace ExamStack
{
    public partial class MainExams : Form
    {
        ExamCollection submittedTests = null;
        ExamCollection outForChecking = null;

        public MainExams()
        {
            InitializeComponent();
           
        }

        private void MainExams_Load(object sender, EventArgs e)
        {
            submittedTests = new ExamCollection();
            outForChecking = new ExamCollection();

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

        private void btnView_Click(object sender, EventArgs e)
        {
              string fullName = txtName.Text;
              int pos = -1;
              bool found = false;

            foreach(var prueba in submittedTests)
            {
                pos += 1;

                Test Examen = (Test)prueba;
                if ( Examen.Name == fullName)
                {
                    outForChecking.Add(Examen);
                    txtExamNum.Text = Examen.Numero.ToString();
                    found = true;
                    break;
                }
                               
            }

            if (found == true)
            {
                submittedTests.RemoveAt(pos);
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            string fullName = txtName.Text;
            int pos = -1;
            bool found = false;

            foreach (var prueba in outForChecking)
            {
                pos += 1;

                Test Examen = (Test)prueba;
                if (Examen.Name == fullName)
                {
                    submittedTests.Add(Examen);
                    found = true;
                    break;
                }

            }

            if (found == true)
            {
                outForChecking.RemoveAt(pos);
                MessageBox.Show("Exam has been returned");

            }
        }
    }
}
