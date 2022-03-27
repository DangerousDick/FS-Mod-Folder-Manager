using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;

namespace FS22_Mod_Manager
{
    internal class Logger
    {
        private string m_exePath = string.Empty;
        private bool addTimeStamp = false;

        public Logger(string logFileName)
        {
            if (logFileName != null)
            {
                m_exePath = logFileName;
                string msg = "Farmming Simulator Log" +  "\r\n-------------------------------------";
                LogWrite(msg);
            }
        }        

        public void LogWrite(string logMessage, bool addTime = false)
        {
            if (null != m_exePath)
            {
                try
                {
                    addTimeStamp = addTime;
                    using (StreamWriter w = File.AppendText(m_exePath))
                    {
                        Log(logMessage, w);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private void Log(string logMessage, TextWriter txtWriter)
        {
            try
            {
                if (addTimeStamp) { txtWriter.WriteLine("{0}:{1}", DateTime.Now.ToLongTimeString(), logMessage); }
                else { txtWriter.WriteLine(logMessage); }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
