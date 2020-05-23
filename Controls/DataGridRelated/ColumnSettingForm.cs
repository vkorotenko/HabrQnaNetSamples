using System.Windows.Forms;

namespace Kvn.HabrQnaNetSamples.Controls.DataGridRelated
{
    public partial class ColumnSettingForm : Form
    {
        public ColumnSettingForm()
        {
            InitializeComponent();
            habraLinkLabel.Click += (sender, args) => { System.Diagnostics.Process.Start(habraLinkLabel.Text); };
        }
    }
}
