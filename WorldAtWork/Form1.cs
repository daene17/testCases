using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WorldAtWork
{
    public partial class Form1 : Form
    {
        public List<TestCase> testCases;
        public int index; // we want to keep track of the index at all times so we know which test case is current
        public TestCase currentTestCase;

        public Form1()
        {
            InitializeComponent();
            testCases = InitializeTestCases();

            // Add to the listview as well as the Test Case List
            foreach (TestCase tc in testCases)
            {
                ListViewItem item = new ListViewItem(new[] { tc.name, tc.summary, tc.status });
                testCaseList.Items.Add(item);
            }

        }

        

        private void addTestCase_Click(object sender, EventArgs e)
        {
            Form2 addForm = new Form2(this);
            addForm.ShowDialog(this);

            currentTestCase = addForm.newTestCase;

            // add to the listView
            ListViewItem item = new ListViewItem(new[] { currentTestCase.name, currentTestCase.summary, currentTestCase.status });
            testCaseList.Items.Add(item);

            // Add to the test case list
            testCases.Add(currentTestCase);

            // Add to XML Doc
            var path = Path.Combine(Environment.CurrentDirectory, "testCaseList.xml");
            XDocument doc = XDocument.Load(path);
            doc.Root.Add(addForm.ElementToCreate);
            doc.Save(path);


        }

        private void testCaseList_Activate(object sender, EventArgs e)
        {
            index = testCaseList.SelectedIndices[0];
            currentTestCase = testCases[index];

            Form3 showTestCaseForm = new Form3(this);
            showTestCaseForm.ShowDialog(this);
        }

        private void testCaseList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private List<TestCase> InitializeTestCases()
        {
            var xmlDoc = loadXML();

            TestCase testCaseObject = new TestCase();
            List<TestCase> initialTestCases = (from TestCase in xmlDoc.Element("TestCases").Elements("TestCase") // pull out each "TestCase" XML Object and convert to C# Object
                                               select new TestCase
                                               {
                                                   name = TestCase.Element("name").Value,
                                                   ticket = TestCase.Element("ticket").Value,
                                                   summary = TestCase.Element("summary").Value,
                                                   prerequisites = TestCase.Element("prerequisites").Value,
                                                   steps = TestCase.Element("steps").Value,
                                                   behavior = TestCase.Element("behavior").Value,
                                                   status = TestCase.Element("status").Value 
                                               }).ToList();
            return initialTestCases;
        }

        public XDocument loadXML()
        {
            var path = Path.Combine(Environment.CurrentDirectory, "testCaseList.xml");
            XDocument xmlDocument = XDocument.Load(path);
            return xmlDocument;
        }

        public void saveXML(XDocument xmlDocument)
        {
            var path = Path.Combine(Environment.CurrentDirectory, "testCaseList.xml");
            xmlDocument.Save(path);

        }
    }
}
