namespace RadioCatalog
{
    public interface IMessageService
    {
        void ShowMessage(string message);
        void ShowExclamation(string message);
        void ShowError(string message);
        bool ShowDialogYesNo(string dialog);
    }
}
