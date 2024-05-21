using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using RotatorSlideShow.Properties;

namespace RotatorSlideShow
{
    [Serializable]
    public class RotatorSlideShowFile
    {
        ArrayList files;

        public RotatorSlideShowFile()
        {
            files = new ArrayList();
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public ArrayList Files
        {
            get { return files; }
        }
    }
}