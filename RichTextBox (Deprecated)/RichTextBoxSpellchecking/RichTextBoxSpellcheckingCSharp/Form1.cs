using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.RichTextBox;
using Telerik.WinControls.RichTextBox.Layout;
using Telerik.WinControls.RichTextBox.TextSearch;
using Telerik.WinControls.UI;

namespace RichTextBoxSpellchecking
{
    public partial class Form1 : RadForm
    {
        public Form1()
        {
            InitializeComponent();

            new SpellCheckRichTextBox()
            {
                Parent = this,
                Dock = DockStyle.Fill
            };
        }
    }

    public class SpellCheckRichTextBox : RadRichTextBox
    { 
        #region Fields

        private RadSpellChecker spellChecker;
        private IControlSpellChecker controlSpellChecker;

        #endregion

        #region Properties

        public new RadSpellChecker SpellChecker
        {
            get { return this.spellChecker; }
        }

        public new bool IsSpellCheckingEnabled
        {
            get { return true; }
        }

        public bool AutoReplaceOnSpellCheck { get; set; }

        public IControlSpellChecker ControlSpellChecker
        {
            get { return this.controlSpellChecker; }
        }

        #endregion

        #region SpellChecking

        protected override void CreateChildItems(Telerik.WinControls.RadElement parent)
        {
            base.CreateChildItems(parent);

            this.spellChecker = new RadSpellChecker();
            this.controlSpellChecker = this.spellChecker.GetControlSpellChecker(typeof(RadRichTextBox));
            this.controlSpellChecker.CurrentControl = this;
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                this.SpellCheckCore(this.GetCurrentWord());
            }

            base.OnKeyDown(e);
        }

        protected override void OnLoad(System.Drawing.Size desiredSize)
        {
            base.OnLoad(desiredSize);
            //this is need in order to initialize the dictionaries when loaded instead of when typing
            this.controlSpellChecker.SpellChecker.CheckWordIsCorrect("loadFasterWord");
        }

        private string GetCurrentWord()
        {
            DocumentPosition endPosition = new DocumentPosition(this.Document.CaretPosition);
            DocumentPosition startPosition = new DocumentPosition(endPosition);
            this.SelectCurrentWord(startPosition);
            string lastWord = this.Document.Selection.GetSelectedText();
            this.Document.Selection.Clear();

            return lastWord;
        }

        private void SelectCurrentWord(DocumentPosition position)
        {
            position.MoveToCurrentWordStart();
            this.Document.Selection.SetSelectionStart(position);
            position.MoveToCurrentWordEnd();
            this.Document.Selection.AddSelectionEnd(position);
        }

        protected virtual void SpellCheckCore(string word)
        {
            if (string.IsNullOrEmpty(word) || this.controlSpellChecker.IgnoredWords.ContainsWord(word))
            {
                return;
            }

            this.SelectCurrentWord(this.Document.CaretPosition);

            if (this.AutoReplaceOnSpellCheck)
            {
                string[] suggestions = (string[])this.ControlSpellChecker.SpellChecker.GetSuggestions(this.Document.Selection.GetSelectedText());
                if (suggestions.Length > 0)
                {
                    this.Insert(suggestions[0]);
                }
            }
            else
            {
                if (!controlSpellChecker.SpellChecker.CheckWordIsCorrect(word))
                {
                    this.ChangeUnderlineDecoration(Telerik.WinControls.RichTextBox.UI.UnderlineType.Wave);
                    this.Document.Selection.Clear();

                    this.ChangeUnderlineDecoration(Telerik.WinControls.RichTextBox.UI.UnderlineType.None);
                }
                else
                {
                    this.ChangeUnderlineDecoration(Telerik.WinControls.RichTextBox.UI.UnderlineType.None);
                    this.Document.Selection.Clear();
                }
            }
        }

        public void IgnoreWord(string word)
        {
            this.controlSpellChecker.IgnoredWords.AddWord(word);
            DocumentTextSearch search = new DocumentTextSearch(this.Document);
            DocumentPosition savedPosition = this.Document.CaretPosition;

            foreach (TextRange text in search.FindAll(word))
            {
                this.Document.Selection.AddSelectionStart(text.StartPosition);
                this.Document.Selection.AddSelectionEnd(text.EndPosition);
                this.ChangeUnderlineDecoration(Telerik.WinControls.RichTextBox.UI.UnderlineType.None);
            }

            this.Document.Selection.AddSelectionStart(savedPosition);
            this.Document.Selection.AddSelectionEnd(savedPosition);
        }

        #endregion

        #region SpellCheckContextMenu

        private RadDropDownMenu BuildContextMenu(SpanLayoutBox spanBox)
        {
            RadDropDownMenu menu = new RadDropDownMenu();
            RadMenuItem menuItem;

            if (this.Document.Selection.IsEmpty && this.IsSpellCheckingEnabled && spanBox != null)
            {
                this.Document.CaretPosition.MoveToInline(spanBox, 0);

                string spanBoxTextAlphaNumericOnly = String.Concat(spanBox.Text.TakeWhile(c => char.IsLetterOrDigit(c)));

                if (spanBoxTextAlphaNumericOnly.Length > 0 && !this.ControlSpellChecker.SpellChecker.CheckWordIsCorrect(spanBoxTextAlphaNumericOnly))
                {
                    string[] suggestions = (string[])this.ControlSpellChecker.SpellChecker.GetSuggestions(spanBox.Text);

                    if (suggestions.Length <= 0)
                    {
                        menuItem = new RadMenuItem("(No Spelling Suggestions)");
                        menuItem.Enabled = false;
                        menu.Items.Add(menuItem);
                    }

                    foreach (string suggestion in suggestions)
                    {
                        menuItem = new RadMenuItem(suggestion);
                        menuItem.Click += (object sender, EventArgs e) => { this.ReplaceCurrentWord(spanBox, (sender as RadMenuItem).Text); };
                        menu.Items.Add(menuItem);
                    }

                    menu.Items.Add(new SeparatorElement());

                    menuItem = new RadMenuItem("Add to Dictionary");
                    menuItem.Click += (object sender, EventArgs e) => { this.ControlSpellChecker.SpellChecker.AddWord(spanBoxTextAlphaNumericOnly); };
                    menu.Items.Add(menuItem);

                    menu.Items.Add(new SeparatorElement());
                }
            }

            menuItem = new RadMenuItem("Undo");
            menuItem.Click += (object sender, EventArgs e) => { this.Undo(); };
            menu.Items.Add(menuItem);

            menu.Items.Add(new SeparatorElement());

            menuItem = new RadMenuItem("Cut");
            menuItem.Click += (object sender, EventArgs e) => { this.Cut(); };
            menu.Items.Add(menuItem);

            menuItem = new RadMenuItem("Copy");
            menuItem.Click += (object sender, EventArgs e) => { this.Copy(); };
            menu.Items.Add(menuItem);

            menuItem = new RadMenuItem("Paste");
            menuItem.Click += (object sender, EventArgs e) => { this.Paste(); };

            menu.Items.Add(menuItem);

            menuItem = new RadMenuItem("Delete");
            menuItem.Click += (object sender, EventArgs e) => { this.Delete(false); };
            menu.Items.Add(menuItem);

            menu.Items.Add(new SeparatorElement());

            menuItem = new RadMenuItem("Select All");
            menuItem.Click += (object sender, EventArgs e) => { this.Document.Selection.SelectAll(); };
            menu.Items.Add(menuItem);

            return menu;
        }

        private void ReplaceCurrentWord(SpanLayoutBox spanBox, string newWord)
        {
            this.Document.CaretPosition.MoveToInline(spanBox, 0);

            DocumentPosition endPosition = new DocumentPosition(this.Document.CaretPosition);
            endPosition.MoveToCurrentWordEnd();

            this.Document.Selection.Clear();
            this.Document.Selection.AddSelectionStart(this.Document.CaretPosition);
            this.Document.Selection.AddSelectionEnd(endPosition);

            this.Insert(newWord);
        }

        protected override void OnMouseDown(System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                SpanLayoutBox spanBox = this.Document.GetLayoutBoxByPosition(e.Location) as SpanLayoutBox;
                this.BuildContextMenu(spanBox).Show(this, e.Location);
            }

            base.OnMouseDown(e);
        }

        #endregion
    }
}
