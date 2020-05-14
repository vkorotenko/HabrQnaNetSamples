#region License
// // Разработано: Коротенко Владимиром Николаевичем (Vladimir N. Korotenko)
// // email: koroten@ya.ru
// // skype:vladimir-korotenko
// // https://vkorotenko.ru
// // Создано:  14.05.2020 19:36
#endregion

using Kvn.HabrQnaNetSamples.Dbl;
using System.Linq;
using System.Windows.Forms;

namespace Kvn.HabrQnaNetSamples.Database
{
    public partial class MySqlDataGridForm : Form
    {
        private const string Label = "https://qna.habr.com/q/771267";
        public MySqlDataGridForm()
        {
            InitializeComponent();
            habraLabel.Text = Label;
            habraLabel.LinkClicked += HabraLabel_LinkClicked;

            using (var ctx = new MySqlDataContext())
            {
                dataGridView1.DataSource = ctx.Items.ToList();
            }
        }

        private void HabraLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(Label);
        }
    }
}
