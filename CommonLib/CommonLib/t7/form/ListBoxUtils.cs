namespace t7.common
{
    using System.Windows.Forms;

    /// <summary>
    /// ListBox Control Utils
    /// </summary>
    public class ListBoxUtils
    {
        /// <summary>
        /// Scroll to the top
        /// </summary>
        /// <param name="control"></param>
        public static void ScrollTop(ListBox control)
        {
            control.TopIndex = 0;
        }

        /// <summary>
        /// Scroll to the bottom
        /// </summary>
        /// <param name="control"></param>
        public static void ScrollBottom(ListBox control)
        {
            control.TopIndex = control.Items.Count - 1;
        }
    }
}
