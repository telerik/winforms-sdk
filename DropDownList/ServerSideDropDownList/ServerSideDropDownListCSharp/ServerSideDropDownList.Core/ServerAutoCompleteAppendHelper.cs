using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace ServerSideDropDownList.Core
{
    public class ServerAutoCompleteAppendHelper<T> : AutoCompleteAppendHelper
    {
        public IQueryable<T> Data { get; private set; }

        public ServerAutoCompleteAppendHelper(RadDropDownListElement owner, IEnumerable<T> data)
            : base(owner)
        {
            this.Data = data.AsQueryable();
            ExpressionBuilder.Instance.Optimize(this.Data);
        }

        public override void AutoComplete(KeyPressEventArgs e)
        {
            string findString = this.CreateFindString(e);

            var whereExp = ExpressionBuilder.Instance.BuildStartsWithExpression<T>(this.Owner.AutoCompleteValueMember, findString);
            var selectExp = ExpressionBuilder.Instance.BuildSelectExpression<T>(this.Owner.AutoCompleteValueMember);

            string result = this.Data.Where(whereExp).Select(selectExp).OrderBy(x => x.Length).FirstOrDefault();
            if (result != null)
            {
                Owner.EditableElementText = result;
                Owner.SelectionStart = findString.Length;
                Owner.SelectionLength = Owner.EditableElementText.Length;
                e.Handled = true;
            }
        }

        private string CreateFindString(KeyPressEventArgs e)
        {
            string findString = "";
            if (Owner.SelectionLength == 0)
            {
                findString = Owner.EditableElementText + e.KeyChar;
            }
            else
            {
                findString = Owner.EditableElementText.Substring(0, Owner.SelectionStart) + e.KeyChar;
            }

            return findString;
        }
    }
}