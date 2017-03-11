using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Tienda_Virtual
{
    class Captcha
    {
        private Bitmap _bitmap = new Bitmap(310, 140);

        public Bitmap bitmap
        {
            get { return _bitmap; }
            set { _bitmap = value; }
        }
        private string _code = string.Empty;

        public string code
        {
            get { return _code; }
            set { _code = value; }
        }

        public Captcha()
        {
            SetRandomizedCode();
            SetBitmap();
        }

        private string[] _captcha2 = new string[7];

        public string[] captcha2
        {
            get { return _captcha2; }
            set { _captcha2 = value; }
        }

        private void SetBitmap()
        {
            FontStyle style = FontStyle.Italic | FontStyle.Strikeout | FontStyle.Underline | FontStyle.Regular | FontStyle.Bold;
            Font font = new Font("Arial", 50f, style);
            Graphics GFX = Graphics.FromImage(_bitmap);
            GFX.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            GFX.FillRectangle(Brushes.LightBlue, 0, 0, _bitmap.Width, _bitmap.Height);
            GFX.DrawString(_code, font, Brushes.CornflowerBlue, new Point(-26, -26));
            GFX.Transform.Rotate(50f);
        }

        private void SetRandomizedCode()
        {
            _code = string.Empty;
            Random random = new Random();
            string combination = "0123456789ABCDEFGHJKLMNOPQRSTUVWXYZ";
            StringBuilder captcha = new StringBuilder();
            for (int i = 0; i < 7; i++)
            {
                captcha.Append(combination[random.Next(combination.Length)]);
                _captcha2[i] = captcha[i].ToString();
            }
            _code = captcha.ToString();
        }
    }
}
