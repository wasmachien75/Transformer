using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransformerApp
{
    class RunStats
    {
        String _resultStr;

        public String Stats { get { return _resultStr; } }

        public RunStats(Process proc, String sourceStr, XslProcessor p)
        {
            long mem = proc.PrivateMemorySize64 / 1024000;
            TimeSpan ts = proc.StartTime - DateTime.Now;
            string time = ts.ToString(@"hh\:mm\:ss");
            int sourceByteCount = Encoding.UTF8.GetByteCount(sourceStr) / 1024;
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(String.Format("Active processor: {0}", p.ToString()));
            sb.AppendLine("Current memory usage: ~" + mem.ToString() + " MB");
            sb.AppendLine("Run time: " + time);
            sb.AppendLine("Source XML size: ~" + sourceByteCount.ToString() + " KB");
            sb.AppendLine("Your name: " + System.Environment.UserName);
            _resultStr = sb.ToString();
        }
    }
}
