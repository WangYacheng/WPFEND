using Prism.Commands;
using Prism.Events;
using Prism.Services.Dialogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace WPFPrismEND.ViewModel
{
    public class DialogViewModel
    {
        private IEventAggregator _eventAggregator;
        private IDialogService _dialogService;


        public DelegateCommand OpenCommand { get; set; }

        private string _title = "Dialog";

        public event Action<IDialogResult> RequestClose;

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }


        public DialogViewModel(IEventAggregator eventAggregator
          , IDialogService dialogService)
        {
            _eventAggregator = eventAggregator;
            _dialogService = dialogService;

            OpenCommand = new DelegateCommand(Open);
        }

        public void Open()
        {
            _dialogService.ShowDialog("UCDetail");
        
        }

        /*
        public bool CanCloseDialog()
        {
           
        }

        public void OnDialogClosed()
        {
           
        }

        public void OnDialogOpened(IDialogParameters parameters)
        {
           
        }
        */

        /*
         1, 普通版弹窗
         2，弹窗回调
         3，带参数弹窗
        
         */
    }
}
