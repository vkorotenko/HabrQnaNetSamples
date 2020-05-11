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
    public class TreeSource
    {
        public TreeSource()
        {
            Leaves = new List<TreeLeaf>();
        }
        public List<TreeLeaf> Leaves { get; set; }

        /// <summary>
        /// Load data stub. In this example use mock data. In real application load data from database or web service
        /// </summary>
        public void LoadData()
        {
            var first = new TreeLeaf { Description = "First description", Title = "First" };
            var firstSubs = new[]
            {
                new TreeLeaf(first){Description = "First desc",Title = "First"},
                new TreeLeaf(first){Description = "Second desc",Title = "Second"},
                new TreeLeaf(first){Description = "Third desc",Title = "Third"}
            };
            first.Leaves.AddRange(firstSubs);
            var second = new TreeLeaf { Description = "Second description", Title = "Second" };
            var third = new TreeLeaf { Description = "Third description", Title = "Third" };
            Leaves.AddRange(new[]
            {
                first,
                second,
                third,
            });
        }
    }
}
