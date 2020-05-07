using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace classSingleton
{

   

    sealed class Singleton
    {
        static int count;

        private static Singleton instance= null;

        public static Singleton GetSingleton
        {

            get
            {
                if (instance == null)
                
                instance = new Singleton();
                return instance;
                

            }

        }

        public void logError(string fromclass)
        {

            MessageBox.Show(" I have logged the error to THIS OBJECT instantiante "+ count+" from the "
                + fromclass + "class");
        
        }

        public void writeError(string errro)
        { 
            //WRITE TO c:eRRORboboooOH CRAP FILE 
        }

        

        private Singleton() 
        {

            count++;
            MessageBox.Show(" I have been implimented" + count + "times");
        
        }

      
    }

  
}
