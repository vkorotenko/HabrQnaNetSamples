using System;
using System.Drawing;
using System.Windows.Forms;

namespace Kvn.HabrQnaNetSamples.Controls
{
    internal class PictureBoxCtrl : PictureBox
    {
        public PictureBoxCtrl()
        {
            Dock = DockStyle.Fill;
            BackColor = Color.Transparent;
            DoubleBuffered = true;
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            Invalidate();
        }


        protected override void OnPaint(PaintEventArgs pe)
        {
            //base.OnPaint(pe);
            if (Image == null) return;
            //pe.Graphics.Clear(BackColor);
            var kX = Image.Width / (float) Width;
            var kY = Image.Height / (float) Height;
            int w, h;
            if (kX < kY)
            {
                w = (int) (Image.Width / kY);
                h = (int) (Image.Height / kY);
            }
            else
            {
                w = (int) (Image.Width / kX);
                h = (int) (Image.Height / kX);
            }


            var dstRect = new Rectangle(
                (Width - w) / 2, Height - h,
                w, h
            );
            var srcRect = new Rectangle(0, 0, Image.Width, Image.Height);
            pe.Graphics.DrawImage(Image, dstRect, srcRect, GraphicsUnit.Pixel);
        }
    }
}