using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WorldAtWork
{
    public partial class Form3 : Form
    {
        private Form1 f1;
        private TestCase currentTestCase;
        private int index;
        public Form3(Form1 parentForm)
        {
            InitializeComponent();
            f1 = parentForm;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            currentTestCase = f1.currentTestCase;
            index = f1.index;
            // initialize all of the labels

            this.nameContentLabel.Text = currentTestCase.name;
            this.ticketContentLabel.Text = currentTestCase.ticket;
            this.statusContentLabel.Text = currentTestCase.status;
            this.summaryContentLabel.Text = currentTestCase.summary;
            this.prerequisitesContentLabel.Text = currentTestCase.prerequisites;
            this.stepsContentLabel.Text = currentTestCase.steps;
            this.behaviorContentLabel.Text = currentTestCase.behavior;

            
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            f1.testCases.RemoveAt(index); // delete from our test case array
            f1.testCaseList.Items.RemoveAt(index); // delete from the listview

            // delete from XML file
            var xmlDoc = f1.loadXML();
            var q = from node in xmlDoc.Descendants("TestCase")
                    where node.Element("name").Value == currentTestCase.name
                    select node;
            q.Remove();
            f1.saveXML(xmlDoc);

            this.Close();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            var editForm = new Form2(f1);
            initializeEditForm(editForm);

            editForm.ShowDialog(this);

            var newTestCase = editForm.newTestCase; // the current test case for this form will now become the NEW (edited) testcase

            ListViewItem item = new ListViewItem(new[] { newTestCase.name, newTestCase.summary, newTestCase.status }); // create an item to put in the listview

            //Remove and insert new element in the front end list
            f1.testCaseList.Items.RemoveAt(index); // remove the original
            f1.testCaseList.Items.Insert(index, item); // insert this one at the same index

            //remove from the testcase array and add the new one at the same index
            f1.testCases.RemoveAt(index);
            f1.testCases.Insert(index, newTestCase);

            // Edit XML Doc
            var xmlDoc = f1.loadXML();
            var q = (from node in xmlDoc.Descendants("TestCase")
                     where node.Element("name").Value == currentTestCase.name
                     select node).ToList();

            q.Descendants("name").SingleOrDefault().SetValue(newTestCase.name);
            q.Descendants("ticket").SingleOrDefault().SetValue(newTestCase.ticket);
            q.Descendants("status").SingleOrDefault().SetValue(newTestCase.status);
            q.Descendants("summary").SingleOrDefault().SetValue(newTestCase.summary);
            q.Descendants("prerequisites").SingleOrDefault().SetValue(newTestCase.prerequisites);
            q.Descendants("steps").SingleOrDefault().SetValue(newTestCase.steps);
            q.Descendants("behavior").SingleOrDefault().SetValue(newTestCase.behavior);

            f1.saveXML(xmlDoc);
            this.Close();
        }

        private void initializeEditForm(Form2 editTestCaseForm)
        {
            
            
            editTestCaseForm.nameTextBox.Text = f1.currentTestCase.name;
            editTestCaseForm.ticketTextBox.Text = f1.currentTestCase.ticket;
            editTestCaseForm.summaryTextBox.Text = f1.currentTestCase.summary;
            editTestCaseForm.prerequisitesTextBox.Text = f1.currentTestCase.prerequisites;
            editTestCaseForm.stepsTextBox.Text = f1.currentTestCase.steps;
            editTestCaseForm.behaviorTextBox.Text = f1.currentTestCase.behavior;
            editTestCaseForm.statusTextBox.Text = f1.currentTestCase.status;
        }
    }
}
