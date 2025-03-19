using Prism.Events;
using Prism.Ioc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WPFPrismEND.Base;
using WPFPrismEND.ViewModel;

namespace WPFPrismEND.View
{
    /// <summary>
    /// DialogWindow.xaml 的交互逻辑
    /// </summary>
    public partial class Dialog1Window : Window
    {
        
        public Dialog1Window(IEventAggregator eventAggregator,
            IContainerProvider containerProvider)
        {

            InitializeComponent();


            this.DataContext = containerProvider.Resolve<DialogViewModel>();

            eventAggregator.GetEvent<OpenMessage>()
                .Subscribe(OnOpen);

           
        }

        private void OnOpen(string arg)
        {
            // 窗口的打开
            // new SubWindow().ShowDialog();
        }

        private void btnPublish_Click(object sender, RoutedEventArgs e)
        {
            
           
        }
    }
}
