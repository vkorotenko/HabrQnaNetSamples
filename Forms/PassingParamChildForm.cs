using System.Windows.Forms;

namespace Kvn.HabrQnaNetSamples.Forms
{
    public partial class PassingParamChildForm : Form
    {
        private int _pictureWidth;
        /// <summary>
        /// Дочерняя форма принимающая параметр контрола в конструкторе. 
        /// </summary>
        /// <param name="width">Ширина контрола</param>
        public PassingParamChildForm(int width)
        {
            InitializeComponent();
            _pictureWidth = width; // тут мы используем сразу, но можем и потом
            SamplePictureBox.Width = _pictureWidth;
        }
        /// <summary>
        /// Установка ширины уже после создания формы.
        /// Используется когда контрол не доступен снаружи, например у него модификаторы private, protected
        /// </summary>
        /// <param name="width"></param>
        public void SetWidthPictureBox(int width)
        {
            SamplePictureBox.Width = width;
        }
    }
}
