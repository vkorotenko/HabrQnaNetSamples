#region License
// // Разработано: Коротенко Владимиром Николаевичем (Vladimir N. Korotenko)
// // email: koroten@ya.ru
// // skype:vladimir-korotenko
// // https://vkorotenko.ru
// // Создано:  14.05.2020 10:17
#endregion

using System.Windows.Forms;
using Kvn.HabrQnaNetSamples.Code;

namespace Kvn.HabrQnaNetSamples.Database
{
    public partial class DatabaseLayoutForm : Form
    {
        private readonly DataBaseLayoutSource _ds;
        public DatabaseLayoutForm()
        {
 
            InitializeComponent();
            _ds = DataBaseLayoutSource.Instance;
            itemBindingSource.DataSource = _ds.Items;
        }
    }
}