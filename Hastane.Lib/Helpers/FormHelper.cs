using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hastane.Lib.Models;

namespace Hastane.Lib.Helpers
{
    public class FormHelper
    {
        public void FormuTemizle(Form form)
        {
            foreach (Control control in form.Controls)
            {
                if (control is TextBox)
                    control.Text = string.Empty;
                else if (control is ComboBox cmb)
                    cmb.SelectedIndex = -1;
                else if (control is CheckedListBox chcklst)
                    chcklst.SelectedIndex = -1;
                else if (control is ListBox lst)
                    lst.SelectedIndex = -1;
                else if (control is CheckBox cb)
                    cb.Checked = default(bool);
                else if (control is DateTimePicker)
                    control.Text = DateTime.Now.ToShortDateString();
            }
        }

        public void ListBoxYenile<T>(ListBox lstBox, List<T> lst) where T : Kisi
        {
            lstBox.DataSource = lst;
        }
    }
}
