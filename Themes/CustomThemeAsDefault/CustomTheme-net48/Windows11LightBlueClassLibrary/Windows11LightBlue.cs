using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Telerik.WinControls;

namespace Windows11LightBlueClassLibrary
{
    public class Windows11LightBlue : RadThemeComponentBase

    {
        static bool loaded;
        public Windows11LightBlue()
        {
            ThemeRepository.RegisterTheme(this);
        }

        public override void Load()
        {
            if (!loaded || this.IsDesignMode)
            {
                loaded = true;
                Assembly resourceAssembly = typeof(Windows11LightBlue).Assembly;
                this.LoadResource(resourceAssembly, "Windows11LightBlueClassLibrary.Windows11CompactLightBlue.tssp");
            }
        }
        public override string ThemeName
        {
            get { return "Windows11CompactLightBlue"; }
        }
    }
}

