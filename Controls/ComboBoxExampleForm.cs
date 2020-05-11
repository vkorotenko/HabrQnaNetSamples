using System.Collections.Generic;
using System.Windows.Forms;

namespace Kvn.HabrQnaNetSamples.Controls
{
    public partial class ComboBoxExampleForm : Form
    {
        public ComboBoxExampleForm()
        {
            InitializeComponent();
            
            ForeachControlsInForm();
            ForeachFromList();
        }

        private void ForeachFromList()
        {
            var cmBox = new List<ComboBox>()
            {
                startCompound1,
                startCompound2,
                startCompound3,
                startCompound4
            };

            const string item = "Subname";
            foreach (var box in cmBox)
            {
                box.Items.Add(item);
            }
        }

        private void ForeachControlsInForm()
        {
            const string propName = "Name";
            foreach (Control control in Controls)
            {
                if (control is ComboBox cmb)
                {
                    cmb.Items.Add(propName);
                }
            }
        }
    }
}
