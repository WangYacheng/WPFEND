using Prism.Events;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WPFPrismEND.Base;
using WPFPrismEND.ViewModel;

namespace WPFPrismEND
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow(IEventAggregator eventAggregator)
        {
            InitializeComponent();
            this.DataContext = new MainModel();

            //订阅消息
            eventAggregator.GetEvent<EventMessage>().Subscribe(Receive);

            //发布消息
            eventAggregator.GetEvent<EventMessage>().Publish();

            //泛型版本
            eventAggregator.GetEvent<EventMessageArgs>().Subscribe(Receive);

            eventAggregator.GetEvent<EventMessageArgs>().Publish("Hello luyao");




        }

        private void Receive()
        {
            Console.WriteLine(" MainWindow Receive ");
        }

        private void Receive(string str)
        {
            Console.WriteLine( " 泛型参数  "+str );
        }
    }
}