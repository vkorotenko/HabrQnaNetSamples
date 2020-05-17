#region License
// // Разработано: Коротенко Владимиром Николаевичем (Vladimir N. Korotenko)
// // email: koroten@ya.ru
// // skype:vladimir-korotenko
// // https://vkorotenko.ru
// // Создано:  17.05.2020 15:25
#endregion

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
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
            FactorOneTextBox.TextChanged += (o, args) => { _model.FactorOne = int.Parse(FactorOneTextBox.Text); };
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
    public class Model : INotifyPropertyChanged
    {
        public Action<float> ResultUpdated { get; set; }
        public Model() { }
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
                SetProperty(ref _factorOne, value);
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
                SetProperty(ref _factorTwo, value);
                Recalculate();
            }
        }

        #endregion
        #region FactorOneValues
        private string[] _oneValues;

        public string[] FactorOneValues
        {
            get => _oneValues;
            set => SetProperty(ref _oneValues, value);
        }
        #endregion
        #region FactorOneSelected
        private string _factorOneSelected;

        public string FactorOneSelected
        {
            get => _factorOneSelected;
            set => SetProperty(ref _factorOneSelected, value);
        }
        #endregion
        #region FactorTwoValues
        private string[] _twoValueStrings;

        public string[] FactorTwoValues
        {
            get => _twoValueStrings;
            set => SetProperty(ref _twoValueStrings, value);
        }
        #endregion
        #region FactorTwoSelected
        private string _factorTwoSelected;

        public string FactorTwoSelected
        {
            get => _factorTwoSelected;
            set => SetProperty(ref _factorTwoSelected, value);
        }
        #endregion

        #region INotifyPropertyChanged
        protected bool SetProperty<T>(ref T backingStore, T value,
            [CallerMemberName] string propertyName = "",
            Action onChanged = null)
        {
            if (EqualityComparer<T>.Default.Equals(backingStore, value))
                return false;

            backingStore = value;
            onChanged?.Invoke();
            OnPropertyChanged(propertyName);
            return true;
        }



        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            var changed = PropertyChanged;
            changed?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

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
