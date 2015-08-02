namespace t7.common
{
    using System.Windows.Forms;

    public class ListBoxUtils
    {
        public static void TopScroll(ListBox control)
        {
            control.TopIndex = 0;
        }

        public static void BottomScroll(ListBox control)
        {
            control.TopIndex = control.Items.Count - 1;
        }
    }
}
