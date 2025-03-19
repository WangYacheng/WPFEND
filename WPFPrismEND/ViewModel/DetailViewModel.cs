using Prism.Services.Dialogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFPrismEND.ViewModel
{
    public class DetailViewModel: IDialogAware
    {
        private string _value="love is over";

        public event Action<IDialogResult> RequestClose;

        public string Value { get; set; }

        public string Title => "Hello Dialog";

        public DetailViewModel() 
        {
            
        }

        public bool CanCloseDialog()
        {
            return true;
        }

        public void OnDialogClosed()
        {
           
        }

        public void OnDialogOpened(IDialogParameters parameters)
        {
           
        }

        private void OnClose()
        {
            IDialogResult dialogResult = new DialogResult();
            dialogResult.Parameters.Add("A", true);
            RequestClose?.Invoke(dialogResult);



        }
    }
}
