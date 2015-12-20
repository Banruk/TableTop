using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TableTop.Misc
{
    public static class Colors
    {
        public static Color ConvertColor(String color)
        {
            if (Regex.IsMatch(color, "^[#][0-9A-Fa-f]{6}$"))
            {
                return ColorTranslator.FromHtml(color);
            }
            else
            {
                return Color.FromName(color);
            }
        }
    }
}
