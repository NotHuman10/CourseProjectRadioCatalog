using System.Windows.Forms;

namespace RadioCatalog
{
    public class MessageService : IMessageService
    {
        public void ShowMessage(string message)
        {
            MessageBox.Show(message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void ShowExclamation(string exclamation)
        {
            MessageBox.Show(exclamation, "Exclamation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public void ShowError(string error)
        {
            MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public bool ShowDialogYesNo(string dialog)
        {
            string caption = "Подтвердите действие";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            MessageBoxIcon icon = MessageBoxIcon.Question;

            DialogResult result = MessageBox.Show(dialog, caption, buttons, icon);

            return result == DialogResult.Yes ? true : false;
        }
    }
}
