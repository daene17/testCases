using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldAtWork
{
    public class TestCase
    {
        public string name { get; set; }
        public string ticket { get; set; }
        public string status { get; set; }
        public string summary { get; set; }
        public string prerequisites { get; set; }
        public string steps { get; set; }
        public string behavior { get; set; }
        
        public int index { get; set; }

        public TestCase() { }
    }
}
