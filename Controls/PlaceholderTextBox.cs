#region License
// // Разработано: Коротенко Владимиром Николаевичем (Vladimir N. Korotenko)
// // email: koroten@ya.ru
// // skype:vladimir-korotenko
// // https://vkorotenko.ru
// // Создано:  11.05.2020 13:38
#endregion

using System.Drawing;
using System.Windows.Forms;

namespace Kvn.HabrQnaNetSamples.Controls
{
    public class PlaceholderTextBox : TextBox
    {
        private string _placeholder;
        public string Placeholder
        {
            get => _placeholder;
            set { _placeholder = value; this.Invalidate(); }
        }
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg != 0xf) return;
            if (this.Focused || !string.IsNullOrEmpty(this.Text) || string.IsNullOrEmpty(this.Placeholder)) return;
            using (var g = this.CreateGraphics())
            {
                TextRenderer.DrawText(g, this.Placeholder, this.Font,
                    ClientRectangle, SystemColors.GrayText, this.BackColor,
                    TextFormatFlags.Top | TextFormatFlags.Left);
            }
        }
    }
}