using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Helper
{


    public class ComboBoxItem<T>
    {
        public T Value { get; set; }
        public string DisplayText { get; set; }

        public override string ToString()
        {
            return DisplayText;
        }
    }
    public class ComboBoxHelper
    {
        public static void LockComboBox(ComboBox comboBox, string lockedItem)
        {
            int index = comboBox.FindStringExact(lockedItem);
            if (index != -1)
            {
                comboBox.SelectedIndex = index;
                comboBox.Enabled = false;
            }
        }

       public static void UnlockComboBox(ComboBox comboBox)
        {
            comboBox.Enabled = true;
        }
    }
   
    }

