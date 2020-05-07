using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsumeJSONV3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_pullJSON_Click(object sender, EventArgs e)
        {
            string appendValue = "courseParemeter=BCAD";

            Uri uri = ApiService.createURL(appendValue);

            List<CourseData> pulledCourse = new List<CourseData>();

            pulledCourse = ApiService.pullNestedOjbects(uri);

            foreach (var item in pulledCourse)
            {
                MessageBox.Show(item.moduleName);
                MessageBox.Show(item.formative1Weight.ToString());
            }

            


        }
    }
}
