using Prism.Events;
using Prism.Ioc;
using Prism.Services.Dialogs;
using Prism.Unity;
using System.Configuration;
using System.Data;
using System.Windows;
using WPFPrismEND.Base;
using WPFPrismEND.View;

namespace WPFPrismEND
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : PrismApplication
    {
        protected override Window CreateShell()
        {
           
            return Container.Resolve<Dialog1Window>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            //containerRegistry.RegisterDialogWindow<DialogWindow>();
            containerRegistry.RegisterDialog<UCDetail>();
        }
    }

}
