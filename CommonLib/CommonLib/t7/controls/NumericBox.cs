namespace t7.controls
{
    using System.ComponentModel;
    using System.Windows.Forms;

    public class NumericBox : TextBox
    {
        public NumericBox()
        {
            this.TextAlign = HorizontalAlignment.Right;

            this.KeyPress += (sender, e) =>
            {
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
    }
}
