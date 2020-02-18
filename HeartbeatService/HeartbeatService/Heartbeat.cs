using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
//
using Timer = System.Timers.Timer;

namespace HeartbeatService
{
    public class Heartbeat
    {
        private readonly Timer _timer;

        public Heartbeat()
        {
            MessageBox.Show("Hello there.");
            _timer = new Timer(1000) {AutoReset = true};
            _timer.Elapsed += TimerElapsed;
        }

        private void TimerElapsed(object sender, ElapsedEventArgs e)
        {
            string inputPath = "\"C:\\DataSyncer\\datasyncer.dat\"";
            string outputPath = "\"C:\\DataSyncer\\datasyncer.out\"";

            System.Diagnostics.Process pProcess = new System.Diagnostics.Process();
            pProcess.StartInfo.FileName = "c:\\DataSyncer\\jessidatasyncer.exe";
            pProcess.StartInfo.Arguments = inputPath + " " + outputPath;
            pProcess.Start();
            pProcess.WaitForExit();
            pProcess.Close();
        }

        public void Start()
        {
            _timer.Start();
        }

        public void Stop()
        {
            _timer.Stop();
        }
    }
}
