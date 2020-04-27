using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SingletonIntroduction
{
    
    class Singleton
    {
        private static int count;
        private static Singleton instance = null;

        public static Singleton GetInstance
        {
            get 
            {
                if (instance == null)
         
                    instance = new Singleton();
                    return instance;
            }
        }

       private Singleton()
        {
            count++;
            MessageBox.Show("I have instantiated this class " + count + " times");
        }

        public void displayClass (string value)
        {
            MessageBox.Show(" I was instantiated in the  " + value + "class");
        }
    }
}
