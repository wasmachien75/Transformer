using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransformerApp
{
    public static class Helper
    {
        public static void ShowErrorMessage(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static MemoryStream createStream(String text)
        {
            MemoryStream s = new MemoryStream();
            StreamWriter w = new StreamWriter(s);
            w.Write(text);
            w.Flush();
            s.Position = 0;
            return s;
        }
    }
}
