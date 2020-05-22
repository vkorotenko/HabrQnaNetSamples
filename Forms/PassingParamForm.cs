using System.Diagnostics;
using System.Windows.Forms;

namespace Kvn.HabrQnaNetSamples.Forms
{
    public partial class PassingParamForm : Form
    {
        /// <summary>
        /// Дочерняя форма
        /// </summary>
        private PassingParamChildForm _paramForm;
        public PassingParamForm()
        {
            InitializeComponent();
        }

        private void HabraLinkLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(HabraLink.Text);
        }

        private void CreateFormButtonClick(object sender, System.EventArgs e)
        {
            if (_paramForm == null) _paramForm = new PassingParamChildForm(42);
            _paramForm.Show();
        }
        /// <summary>
        /// Использование метода для доступа к защищенным членам класса. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SetWidthButtonClick(object sender, System.EventArgs e)
        {
            _paramForm?.SetWidthPictureBox(90);
        }
        /// <summary>
        /// Вынос всего контрола наружу. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SetButtonPublicClick(object sender, System.EventArgs e)
        {
            if (_paramForm != null)
            {
                _paramForm.SamplePictureBox.Width = 77;
            }
        }
    }
}