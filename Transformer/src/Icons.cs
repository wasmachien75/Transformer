using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransformerApp
{
    public enum Result
    {
        Success = 1,
        Error = 2,
        Warning = 3
    }

    public class StatusIcons
    {
        public static Bitmap GreenCheckMark
        {
            get { return Transformer.Properties.Resources.RedCross; }
        }
        public static Bitmap RedCross
        {
            get { return Transformer.Properties.Resources.RedCross; }
        }

        public static Bitmap Warning
        {
            get { return Transformer.Properties.Resources.WarningIcon; }
        }

    }
}
