#region License
// // Разработано: Коротенко Владимиром Николаевичем (Vladimir N. Korotenko)
// // email: koroten@ya.ru
// // skype:vladimir-korotenko
// // https://vkorotenko.ru
// // Создано:  11.05.2020 13:37
#endregion

using System.Collections.Generic;

namespace Kvn.HabrQnaNetSamples.Code
{
    public class TreeLeaf
    {
        public TreeLeaf(TreeLeaf parent = null)
        {
            Leaves = new List<TreeLeaf>();
            Parent = parent;
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Icon { get; set; }
        public List<TreeLeaf> Leaves { get; private set; }
        public TreeLeaf Parent { get; private set; }
    }
}