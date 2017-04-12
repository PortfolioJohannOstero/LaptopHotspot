using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Text.RegularExpressions;
using System.Diagnostics;
using System.IO;

namespace LaptopHotspot
{
    class cmdController
    {
        private ProcessStartInfo psi = null;
        private Process process = null;

        private string methodName = "";

        public string MethodName { get { return methodName; } }

        public cmdController(string cmd)
        {
            methodName = cmd;
            psi = new ProcessStartInfo(cmd);

            psi.UseShellExecute = false;
            psi.RedirectStandardOutput = true;
            psi.CreateNoWindow = true;

            process = new Process();

            if(psi.UseShellExecute)
            process.StartInfo.FileName = cmd;

        }

        public void start(string arg)
        {
            psi.Arguments = arg;
            process = Process.Start(psi);
        }

        public string extractLineFromOutput(string stringInLine)
        {
            string output = process.StandardOutput.ReadToEnd();

            string result = "";
            int startOfIndex = 0;

            if(output.Contains(stringInLine))
            {
                startOfIndex = output.IndexOf(stringInLine);
                while(output[startOfIndex] != '\n')
                {
                    result += output[startOfIndex];
                    startOfIndex++;
                }

                return result;
            }

            return "";
        }

        public string extractAllOutput()
        {
            return process.StandardOutput.ReadToEnd();
        }
    }
}
