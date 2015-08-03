namespace t7.common
{
    using System.Windows.Forms;

    public class ListBoxUtils
    {
        public static void ScrollTop(ListBox control)
        {
            control.TopIndex = 0;
        }

        public static void ScrollBottom(ListBox control)
        {
            control.TopIndex = control.Items.Count - 1;
        }
    }
}
