using PetAdoptionApp.Contracts.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetAdoptionApp.Services
{
    public class ModalDialogService : IDialogService
    {
        public async Task MessageDialogAsync(Page page, string title, string message)
        {
            await MessageDialogAsync(page, title, message, "OK");
        }

        public async Task MessageDialogAsync(Page page, string title, string message, string buttonText)
        {
            await page.DisplayAlert(title, message, buttonText);
        }

        public async Task<bool> ConfirmationDialogAsync(Page page, string title)
        {
            return await ConfirmationDialogAsync(page, title, string.Empty, "OK", "Cancel");
        }

        public async Task<bool> ConfirmationDialogAsync(Page page, string title, string yesButtonText, string cancelButtonText)
        {
            return await ConfirmationDialogAsync(page, title, string.Empty, yesButtonText, cancelButtonText);
        }

        public async Task<bool> ConfirmationDialogAsync(Page page, string title,string message, string yesButtonText, string cancelButtonText)
        {
            return await page.DisplayAlert(title, message, accept:yesButtonText, cancel:cancelButtonText, FlowDirection.MatchParent);
        }

        public async Task<string> InputStringDialogAsync(Page page, string title)
        {
            return await InputStringDialogAsync(page, title, string.Empty);
        }

        public async Task<string> InputStringDialogAsync(Page page, string title, string defaultText)
        {
            return await InputStringDialogAsync(page, title, defaultText, "OK", "Cancel");
        }

        public async Task<string> InputStringDialogAsync(Page page, string title, string defaultText, string okButtonText, string cancelButtonText, string placeholderText = null, int inputMaxLength = 250)
        {
            return await page.DisplayPromptAsync(title, defaultText, accept: okButtonText, cancel: cancelButtonText, placeholder: placeholderText, maxLength: inputMaxLength);
        }

        public async Task<string> ActionSheetAsync(Page page, string title, string cancelButtonText, string destructionButton = null, params string[] buttons)
        {
            return await page.DisplayActionSheet(title, cancelButtonText, destructionButton, buttons);
        }
    }
}