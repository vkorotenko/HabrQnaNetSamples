#region License

// // Разработано: Коротенко Владимиром Николаевичем (Vladimir N. Korotenko)
// // email: koroten@ya.ru
// // skype:vladimir-korotenko
// // https://vkorotenko.ru
// // Создано:  14.05.2020 9:44

#endregion


using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Kvn.HabrQnaNetSamples.Code
{
    /// <summary>
    /// Тестовый источник для отображения layout
    /// </summary>
    public class DataBaseLayoutSource
    {
        private const string TypeExpense = "Расход";
        private const string TypeComing = "Приход";
        private const string CategoryWork = "Работа";
        private const string CategoryEntertainment = "Развлечения";

        private DataBaseLayoutSource()
        {
            var now = DateTime.Now;
            Items = new List<Item>()
            {
                new Item{Amount = 100, Category = CategoryWork, Date = now, Id = 1, ItemType = TypeComing, Total = 5},
                new Item{Amount = 101, Category = CategoryEntertainment, Date = now, Id = 2, ItemType = TypeComing, Total = 6},
                new Item{Amount = 102, Category = CategoryEntertainment, Date = now, Id = 3, ItemType = TypeComing, Total = 7},
                new Item{Amount = 103, Category = CategoryWork, Date = now, Id = 4, ItemType = TypeComing, Total = 8},
                new Item{Amount = 104, Category = CategoryEntertainment, Date = now, Id = 5, ItemType = TypeExpense, Total = 9},
                new Item{Amount = 105, Category = CategoryEntertainment, Date = now, Id = 6, ItemType = TypeExpense, Total = 10},

            };

        }

        public class Item
        {
            public int Id { get; set; }

            [DisplayName("Тип")] public string ItemType { get; set; }
            [DisplayName("Категория")] public string Category { get; set; }
            [DisplayName("Дата")] public DateTime Date { get; set; }

            [DisplayName("Сумма")] public decimal Amount { get; set; }

            [DisplayName("Всего")] public decimal Total { get; set; }
        }

        private static DataBaseLayoutSource _instance;
        public static DataBaseLayoutSource Instance => _instance ?? (_instance = new DataBaseLayoutSource());

        public IEnumerable<Item> Items { get; private set; }
    }
}