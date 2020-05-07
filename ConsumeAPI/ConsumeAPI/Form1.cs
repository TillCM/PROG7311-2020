using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsumeAPI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ApiService.InitialiseAPI();
        }

        private  async void button1_Click(object sender, EventArgs e)
        {

            Uri test = ApiConsumer.createURL("courseParemeter=BCAD");

            var coursInfo = await ApiConsumer.pullJSON(test);

           


        }

      
       

        
    }
}
