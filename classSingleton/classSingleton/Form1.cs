using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace classSingleton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Singleton test = Singleton.GetSingleton;
            test.logError("test");
            Singleton test2 = Singleton.GetSingleton;
            test.logError("test2");
            Singleton mary = Singleton.GetSingleton;
            mary.logError("mary");
                 
        }
    }
}
