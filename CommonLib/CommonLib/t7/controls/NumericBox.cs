namespace t7.controls
{
    using System.ComponentModel;
    using System.Windows.Forms;

    /// <summary>
    /// 
    /// </summary>
    public class NumericBox : TextBox
    {
        /// <summary>
        /// 
        /// </summary>
        public NumericBox()
        {
            this.TextAlign = HorizontalAlignment.Right;

            this.KeyPress += (sender, e) =>
            {
                if (e.KeyChar == '+')
                {
                    this.Add();

                    e.Handled = true;
                    return;
                }

                if (e.KeyChar == '-')
                {
                    this.Subtract();

                    e.Handled = true;
                    return;
                }
                
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
            };
        }

        /// <summary>
        /// コントロールでテキストをどのように配置するかを取得または設定します。
        /// </summary>
        [DefaultValue(HorizontalAlignment.Right)]
        [Description("コントロールでテキストをどのように配置するかを取得または設定します。")]
        public new HorizontalAlignment TextAlign
        {
            get
            {
                return base.TextAlign;
            }

            set
            {
                base.TextAlign = value;
            }
        }

        private void Add()
        {
            if (this.Text.Length == 0)
            {
                return;
            }

            if (this.Text.Substring(0, 1).Equals("-"))
            {
                this.Text = this.Text.Substring(1);
            }
        }

        private void Subtract()
        {
            if (this.Text.Length == 0)
            {
                return;
            }

            if (!this.Text.Substring(0, 1).Equals("-"))
            {
                this.Text = "-" + this.Text;
            }
        }
    }
}
