using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SingletonIntroduction
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Singleton test = Singleton.GetInstance;
            test.displayClass("test");
            Singleton test2 = Singleton.GetInstance;
            test.displayClass("test2");
            Singleton test3 = Singleton.GetInstance;
        }
    }
}
