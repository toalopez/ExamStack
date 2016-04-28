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

            txtName.Select();
            
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {

            foreach (var prueba in outForChecking)
            {
                Test Examen = (Test)prueba;
                submittedTests.Add(Examen);
                RadListDataItem Item = this.lstReturnExams.SelectedItem as RadListDataItem;
                if (Item != null)
                {
                   lstExams.Items.Add(Item);
                }
                

            }

            outForChecking.Clear();
            this.lstReturnExams.Items.Clear();

            txtName.Text = "";
            txtExamNum.Text = "";

        }

        private void btnView_Click(object sender, EventArgs e)
        {
              int pos = -1;
              bool found = false;
              RadListDataItem Item = this.lstExams.SelectedItem as RadListDataItem;

              if (Item != null)
              {
                  string fullName = Item.Text;

                  foreach (var prueba in submittedTests)
                  {
                      pos += 1;

                      Test Examen = (Test)prueba;
                      if (Examen.Name == fullName)
                      {
                          outForChecking.Add(Examen);
                          txtName.Text = Examen.Name;
                          txtExamNum.Text = Examen.Numero.ToString();
                          found = true;
                          break;
                      }

                  }

                  if (found == true)
                  {
                      submittedTests.RemoveAt(pos);
                      if (this.lstExams.Items.Remove(Item) == true)
                      {
                          lstReturnExams.Items.Add(Item);
                      }
                  }
              }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            int pos = -1;
            bool found = false;
            RadListDataItem Item = this.lstReturnExams.SelectedItem as RadListDataItem;

            if (Item != null)
            {
                string fullName = Item.Text;

                foreach (var prueba in outForChecking)
                {
                    pos += 1;

                    Test Examen = (Test)prueba;
                    if (Examen.Name == fullName)
                    {
                        submittedTests.Add(Examen);
                        txtName.Text = "";
                        txtExamNum.Text = "";
                        found = true;
                        break;
                    }

                }

                if (found == true)
                {
                    outForChecking.RemoveAt(pos);
                    if (this.lstReturnExams.Items.Remove(Item) == true)
                    {
                        lstExams.Items.Add(Item);
                    }
                    MessageBox.Show("Thank you " + fullName, "Exam has been returned", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
