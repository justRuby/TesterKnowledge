using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Tester
{
    public class WrapRadioButton : RadioButton
    {
        Size cachedSizeOfOneLineOfText = Size.Empty;
        Dictionary<Size, Size> preferredSizeHash = new Dictionary<Size, Size>(3);

        public WrapRadioButton()
        {
            this.AutoSize = true;
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            CacheTextSize();
        }


        protected override void OnFontChanged(EventArgs e)
        {
            base.OnFontChanged(e);
            CacheTextSize();
        }


        private void CacheTextSize()
        {
            preferredSizeHash.Clear();


            if (String.IsNullOrEmpty(this.Text))
            {
                cachedSizeOfOneLineOfText = Size.Empty;
            }
            else
            {
                cachedSizeOfOneLineOfText = TextRenderer.MeasureText(this.Text, this.Font, new Size(Int32.MaxValue, Int32.MaxValue), TextFormatFlags.WordBreak);
            }
        }


        public override Size GetPreferredSize(Size proposedSize)
        {
            Size prefSize = base.GetPreferredSize(proposedSize);
            if ((prefSize.Width > proposedSize.Width) && (!String.IsNullOrEmpty(this.Text) && !proposedSize.Width.Equals(Int32.MaxValue) || !proposedSize.Height.Equals(Int32.MaxValue)))
            {

                Size bordersAndPadding = prefSize - cachedSizeOfOneLineOfText;

                Size newConstraints = proposedSize - bordersAndPadding - new Size(3, 0);
                if (!preferredSizeHash.ContainsKey(newConstraints))
                {
                    prefSize = bordersAndPadding + TextRenderer.MeasureText(this.Text, this.Font, newConstraints, TextFormatFlags.WordBreak);
                    preferredSizeHash[newConstraints] = prefSize;
                }
                else
                {
                    prefSize = preferredSizeHash[newConstraints];
                }
            }
            return prefSize;
        }
    }
}

