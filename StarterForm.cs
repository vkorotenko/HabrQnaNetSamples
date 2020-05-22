#region License
// // Разработано: Коротенко Владимиром Николаевичем (Vladimir N. Korotenko)
// // email: koroten@ya.ru
// // skype:vladimir-korotenko
// // https://vkorotenko.ru
// // Создано:  11.05.2020 13:34
#endregion

using System;
using System.Windows.Forms;
using Kvn.HabrQnaNetSamples.Database;
using Kvn.HabrQnaNetSamples.Forms;

namespace Kvn.HabrQnaNetSamples.Controls
{
    public partial class StarterForm : Form
    {
        public StarterForm()
        {
            InitializeComponent();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        #region Пункт меню Controls
        private void comboBoxMenuItem_Click(object sender, EventArgs e)
        {
            var combo = new ComboBoxExampleForm();
            combo.Show();
        }

        private void TreeViewSampleClick(object sender, EventArgs e)
        {
            var tree = new TreeViewBindingForm();
            tree.Show();
        }
        #endregion

        private void layoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new DatabaseLayoutForm();
            form.Show();
        }

        private void mySqlDataGridToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new MySqlDataGridForm();
            form.Show();
        }

        private void bindingFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new BindingForm();
            form.Show();
        }

        private void autoCompliteTextBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new AutoCompliteTexBox();
            form.Show();
        }

        private void pictureBoxCtrlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new PictureBoxCtrlForm();
            form.Show();
        }

        private void parameterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new PassingParamForm();
            form.Show();
        }
    }
}
