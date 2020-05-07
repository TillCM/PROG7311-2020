using System;
using System.IO;
using System.Text;

namespace Logger
{
  public class Log :Ilog
  {

        private Log() { }
        private static Log instance = null;

        public static Log GetInstance 
        {
            get
            {
                if (instance == null)

                    instance = new Log();
                return instance;
            }
        }


        public void logException(string errorMessage)
        {
            
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("********************error log****************");
            builder.AppendLine(DateTime.Now.ToString());
            builder.AppendLine(errorMessage);

            string[] paths = { @"C:\VCAPILOGS", "ApiErrors",  "log.txt" };

            string fullPath = Path.Combine(paths);
            File.SetAttributes(fullPath, FileAttributes.Normal);

          
            StreamWriter writeMessage = new StreamWriter(fullPath, append: true);

            using (writeMessage)
            {
                writeMessage.Write(errorMessage.ToString());
                // writeMessage.Flush();
            }


        }
    }

}
