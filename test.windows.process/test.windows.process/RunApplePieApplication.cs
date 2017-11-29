using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test.windows.process
{
    public class RunApplePieApplication
    {
        public static string Execute (string cups, string apple)
        {
            Process myProcess = new Process();
            
            myProcess.StartInfo.UseShellExecute = false;
            myProcess.StartInfo.FileName = "C:\\Temp\\apple.pie.calculator.exe";
            myProcess.StartInfo.RedirectStandardInput = true;
            myProcess.StartInfo.RedirectStandardOutput = true;

            myProcess.Start();
            myProcess.StandardInput.WriteLine(cups);
            myProcess.StandardInput.WriteLine(apple);
            string output = myProcess.StandardOutput.ReadToEnd();
            myProcess.WaitForExit();
            myProcess.Close();

            //Split overload method requires string array and StringSplitOptions
            string[] lines = output.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);

            return lines[2];
            
        }
    }
}

