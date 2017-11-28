using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace test.windows.process
{
    class Program
    {
        static void Main(string[] args)
        {

            Process myProcess = new Process();

            try
            {
                string result = RunApplePieApplication.Execute("7", "Cortland");
                Console.WriteLine(result);
                Console.ReadLine();

                /*myProcess.StartInfo.UseShellExecute = false;                
                myProcess.StartInfo.FileName = "C:\\Temp\\apple.pie.calculator.exe";
                //myProcess.StartInfo.CreateNoWindow = true;
                myProcess.StartInfo.RedirectStandardInput = true;
                myProcess.StartInfo.RedirectStandardOutput = true;
                

                myProcess.Start();
                // This code assumes the process you are starting will terminate itself. 
                // Given that is is started without a window so you cannot terminate it 
                // on the desktop, it must terminate itself or you can do it programmatically
                // from this application using the Kill method.
                myProcess.StandardInput.WriteLine("5");
                myProcess.StandardInput.WriteLine("Cortland");
                string output = myProcess.StandardOutput.ReadToEnd();                
                myProcess.WaitForExit();
                myProcess.Close();

                //Use the appropriate split overload method (arguemnts are string array to split on, and StringSplitOptions)
                string[] lines = output.Split(new [] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
                
                Console.WriteLine("Capture output for Integration testing");
                Console.WriteLine(lines[2]);
                Console.ReadLine();
                */
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadLine();

            }



        }
        
    }
}
