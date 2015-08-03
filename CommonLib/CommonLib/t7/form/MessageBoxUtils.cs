namespace t7.common
{
    using Properties;
    using System.Windows.Forms;

    public class MessageBoxUtils
    {
        public static DialogResult Error(string message)
        {
            return MessageBox.Show(message, Resource.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static DialogResult Error(string message, string caption)
        {
            return MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
