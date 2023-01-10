using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLFootballSystem.Util.Theme
{
    class Theme
    {
        static Dictionary<ThemeColor, Color> Light = new Dictionary<ThemeColor, Color>() {
                { ThemeColor.Primary, Color.WhiteSmoke },
                { ThemeColor.Secondary, Color.Silver },
                { ThemeColor.Tertiary, Color.White },
                { ThemeColor.Text, Color.Black }
        };
        
        static Dictionary<ThemeColor, Color> Dark = new Dictionary<ThemeColor, Color>(){
            { ThemeColor.Primary, Color.DimGray },
            { ThemeColor.Secondary, Color.DimGray },
            { ThemeColor.Tertiary, Color.Black },
            { ThemeColor.Text, Color.White }
        };

        static Dictionary<ThemeColor, Color> Nature = new Dictionary<ThemeColor, Color>() {
            { ThemeColor.Primary, Color.DarkSeaGreen },
            { ThemeColor.Secondary, Color.AliceBlue },
            { ThemeColor.Tertiary, Color.Honeydew },
            { ThemeColor.Text, Color.Black }
        };
        public static Dictionary<ThemeColor, Color> GetLight()
        {
            return Light;
        }

        public static Dictionary<ThemeColor, Color> GetDark()
        {
            return Dark;
        }

        public static Dictionary<ThemeColor, Color> GetNature()
        {
            return Nature;
        }


    }
}
