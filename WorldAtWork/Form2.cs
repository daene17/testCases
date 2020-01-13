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
    public partial class Form2 : Form
    {
        private Form1 f1;
        public TestCase newTestCase;
        public XElement ElementToCreate;
        public Form2(Form1 parentForm)
        {   
            InitializeComponent();
            f1 = parentForm;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            newTestCase = generateTestCase();
            this.Close();
        }

        private TestCase generateTestCase()
        {
            // get data from the textBoxes
            String name = this.nameTextBox.Text;
            String ticket = this.ticketTextBox.Text;
            String status = this.statusTextBox.Text;
            String summary = this.summaryTextBox.Text;
            String prerequisites = this.prerequisitesTextBox.Text;
            String steps = this.stepsTextBox.Text;
            String behavior = this.behaviorTextBox.Text;

            // create a new TestCase object 
            TestCase testCaseToCreate = new TestCase();

            // set the data values
            testCaseToCreate.name = name;
            testCaseToCreate.ticket = ticket;
            testCaseToCreate.status = status;
            testCaseToCreate.summary = summary;
            testCaseToCreate.prerequisites = prerequisites;
            testCaseToCreate.steps = steps;
            testCaseToCreate.behavior = behavior;

            // We also have to create an XElement so we can add to the XML file
            ElementToCreate = new XElement("TestCase",
                new XElement("name", name),
                new XElement("ticket", ticket),
                new XElement("summary", summary),
                new XElement("prerequisites", prerequisites),
                new XElement("steps", steps),
                new XElement("behavior", behavior),
                new XElement("status", status)
            );



            return testCaseToCreate;
        }


       
    }
}
