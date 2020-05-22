using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Kvn.HabrQnaNetSamples.Controls
{
    public class TextBoxRound : Control
    {
        #region --переменные--

        StringFormat SF = new StringFormat();
        int TopBorderOffset = 0;
        protected TextBox tbInput = new TextBox();

        #endregion
        #region --свойства--
        public string TextPreview { get; set; } = "Input text";
        public Font FontTextPreview { get; set; } = new Font("Arial", 24, FontStyle.Bold);
        public Color BorderColor { get; set; } = Color.Blue;
        public Color BorderColorNotActive { get; set; } = Color.DarkGray;

        public string TextInput
        {
            get => tbInput.Text;
            set => tbInput.Text = value;
        }

        [Browsable(false)]
        public new string Text { get; set; }
        #endregion


        public TextBoxRound()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.UserPaint, true);
            DoubleBuffered = true;
            Size = new Size(850, 120);
            Font = new Font("Arial", 33.75F, FontStyle.Regular);
            ForeColor = Color.Black;
            BackColor = Color.White;
            SF.Alignment = StringAlignment.Center;
            SF.LineAlignment = StringAlignment.Center;

            AdjustTextBoxInput();
            this.Controls.Add(tbInput);
        }
        private void AdjustTextBoxInput()
        {
            TextBox tb = new TextBox();
            tbInput.Name = "InputBox";
            tbInput.BorderStyle = BorderStyle.None;
            tbInput.BackColor = BackColor;
            tbInput.ForeColor = ForeColor;
            tbInput.Font = Font;
            var offset = TextRenderer.MeasureText(TextPreview, FontTextPreview).Height / 2;

            tbInput.Location = new Point(5, Height / 2 - offset);
            tbInput.Size = new Size(Width - 10, tb.Height);
        }
    }

    public class AutoCompleteTextBox : TextBoxRound
    {
        public AutoCompleteTextBox()
        {
            var allowedStatorTypes = new AutoCompleteStringCollection();
            var allstate = new[] { "Test", "nTest" }.OrderBy(x => x).Select(x => x).Distinct().ToList();


            foreach (var item in allstate)
            {
                allowedStatorTypes.Add(item);
            }


            tbInput.AutoCompleteMode = AutoCompleteMode.Suggest;
            tbInput.AutoCompleteSource = AutoCompleteSource.CustomSource;
            tbInput.AutoCompleteCustomSource = allowedStatorTypes;
        }
    }
}
