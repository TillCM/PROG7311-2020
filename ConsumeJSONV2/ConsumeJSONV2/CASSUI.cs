using ConsumeJSONV2.NestedCourse;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsumeJSONV2
{
    public partial class CASSUI : Form
    {
        public CASSUI()
        {
            InitializeComponent();
        }

        private void btn_pullJSON_Click(object sender, EventArgs e)
        {
           
            List<CourseData> courseInfo = new List<CourseData>();
            String parameter = "courseParemeter = BCAD";
            Uri uri =  ApiService.createURL(parameter);
             courseInfo = ApiService.pullNestedObjects(uri);

            foreach (var item in courseInfo)
                
            {
                
               MessageBox.Show(item.moduleName);
                MessageBox.Show(item.weightFormative1.ToString());
            }




        }
    }
}
