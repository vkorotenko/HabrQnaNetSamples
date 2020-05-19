#region License
// // Разработано: Коротенко Владимиром Николаевичем (Vladimir N. Korotenko)
// // email: koroten@ya.ru
// // skype:vladimir-korotenko
// // https://vkorotenko.ru
// // Создано:  17.05.2020 15:25
#endregion

using System;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace Kvn.HabrQnaNetSamples.Controls
{
    public partial class BindingForm : Form
    {
        private readonly Model _model = new Model();
        public BindingForm()
        {
            InitializeComponent();
            FillValues();// Заполняем значения при старте
            AddBinding();// Делаем привязки
        }

        private void AddBinding()
        {
            // при изменении значения возвращаем значение в модель, простой метод
            FactorOneTextBox.TextChanged += (o, args) =>
            {
                if (!string.IsNullOrWhiteSpace(FactorOneTextBox.Text)) _model.FactorOne = int.Parse(FactorOneTextBox.Text);
            };
            // то же самое, но все вынесено в функцию 
            FactorTwoTextBox.TextChanged += FactorTwoTextBox_TextChanged;
            // в принципе тут можно вызвать первоначальный подсчет результата
            ResultLabelResult.Text = "";
            // Подписываемся на обновление результата
            _model.ResultUpdated += (r) =>
            {
                // Проверка на вызов из другого потока, для WinForm это обязательно, иначе приложение моет рухнуть. 
                this.Invoke(() => ResultLabelResult.Text = r.ToString(CultureInfo.CurrentUICulture));
            };
        }



        private void FactorTwoTextBox_TextChanged(object sender, System.EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(FactorTwoTextBox.Text))
                _model.FactorTwo = int.Parse(FactorTwoTextBox.Text);
        }

        private void FillValues()
        {
            _model.LoadData();
            FactorOneTextBox.Text = _model.FactorOne.ToString();
            FactorTwoTextBox.Text = _model.FactorTwo.ToString();
            SourceOneComboBox.Items.AddRange(_model.FactorOneValues);
            SourceOneComboBox.SelectedItem = _model.FactorOneSelected;

            SourceTwoComboBox.Items.AddRange(_model.FactorTwoValues);
            SourceTwoComboBox.SelectedItem = _model.FactorTwoSelected;
        }
    }
    public class Model
    {
        public Action<float> ResultUpdated { get; set; }
        public void LoadData()
        {
            FactorOne = 2;
            FactorTwo = 4;

            FactorOneValues = new[]
            {
                "test one 1",
                "test one 2"
            };
            FactorOneSelected = FactorOneValues.Last();

            FactorTwoValues = new[]
            {
                "test two 1",
                "test two 2"
            };
            FactorTwoSelected = FactorTwoValues.First();
        }
        /// <summary>
        /// Вызываем пересчет суммы.
        /// </summary>
        private void Recalculate()
        {
            Result = FactorOne * FactorTwo * 1.2f;
            ResultUpdated?.Invoke(Result);
        }

        public float Result { get; private set; }
        #region FactorOne
        private int _factorOne;

        public int FactorOne
        {
            get => _factorOne;
            set
            {
                _factorOne = value;
                Recalculate();
            }
        }
        #endregion
        #region FactorTwo
        private int _factorTwo;

        public int FactorTwo
        {
            get => _factorTwo;
            set
            {
                _factorTwo = value;
                Recalculate();
            }
        }

        #endregion
        #region FactorOneValues

        public string[] FactorOneValues { get; set; }

        #endregion
        #region FactorOneSelected

        public string FactorOneSelected { get; set; }

        #endregion
        #region FactorTwoValues

        public string[] FactorTwoValues { get; set; }

        #endregion
        #region FactorTwoSelected

        public string FactorTwoSelected { get; set; }

        #endregion

    }

    public static class ControlExtensions
    {
        public static void Invoke(this Control control, Action action)
        {
            control.Invoke(action);
        }
    }
}
