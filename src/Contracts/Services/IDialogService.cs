namespace PetAdoptionApp.Contracts.Services
{
    public interface IDialogService
    {
        public Task MessageDialogAsync(Page page, string title, string message);

        public Task MessageDialogAsync(Page page, string title, string message, string buttonText);

        public Task<bool> ConfirmationDialogAsync(Page page, string title);

        public Task<bool> ConfirmationDialogAsync(Page page, string title, string yesButtonText, string cancelButtonText);

        public Task<bool> ConfirmationDialogAsync(Page page, string title, string message, string yesButtonText, string cancelButtonText);

        public Task<string> InputStringDialogAsync(Page page, string title);

        public Task<string> InputStringDialogAsync(Page page, string title, string defaultText);

        public Task<string> InputStringDialogAsync(Page page, string title, string defaultText, string okButtonText, string cancelButtonText, string placeholderText = null, int inputMaxLength = 250);

        public Task<string> ActionSheetAsync(Page page, string title, string cancelButtonText, string destructionButton = null, params string[] buttons);
    }
}