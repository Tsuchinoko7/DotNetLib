namespace t7.common
{
    using Properties;
    using System.Windows.Forms;

    /// <summary>
    /// 
    /// </summary>
    public class MessageBoxUtils
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public static DialogResult Error(string message)
        {
            return MessageBox.Show(message, Resource.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        /// <param name="caption"></param>
        /// <returns></returns>
        public static DialogResult Error(string message, string caption)
        {
            return MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
