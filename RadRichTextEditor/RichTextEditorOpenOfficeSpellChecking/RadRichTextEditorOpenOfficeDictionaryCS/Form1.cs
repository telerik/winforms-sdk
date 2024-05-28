using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinForms.Documents.FormatProviders.Txt;

namespace _1074335_RadRichTextEditorDictionary
{
    public partial class Form1 : Form
    {
        private static readonly string AffFilePath = @"..\..\ThirdPartyLibs\Dictionaries\main.aff";
        private static readonly string DicFilePath = @"..\..\ThirdPartyLibs\Dictionaries\main.dic";

        private HunspellSpellChecker hunspellSpellChecker;

        public Form1()
        {
            InitializeComponent();

            this.radRichTextEditor1.IsSpellCheckingEnabled = true;
            this.richTextEditorRibbonBar1.AssociatedRichTextEditor = this.radRichTextEditor1;

            using (Stream affFile = File.OpenRead(AffFilePath))
            using (Stream dicFile = File.OpenRead(DicFilePath))
            {
                this.hunspellSpellChecker = new HunspellSpellChecker(affFile, dicFile);
                this.radRichTextEditor1.SpellChecker = this.hunspellSpellChecker;
            }

            this.radRichTextEditor1.Document = new TxtFormatProvider().Import("Sooooome incorrrect teeext!");

        }
    }
}
