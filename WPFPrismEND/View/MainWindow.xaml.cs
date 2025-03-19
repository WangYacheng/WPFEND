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
        //private IEventAggregator _eventAggregator;
        public MainWindow(IEventAggregator eventAggregator)
        {
            InitializeComponent();

            eventAggregator = Messenger.Defualt;
            //this.DataContext = new MainModel();

            ////订阅消息
            //_eventAggregator.GetEvent<EventMessage>().Subscribe(Receive);
            //
            //发布消息
            //eventAggregator.GetEvent<EventMessage>().Publish();
            //
            ////泛型版本
            //eventAggregator.GetEvent<EventMessageArgs>().Subscribe(Receive);
            //
            //eventAggregator.GetEvent<EventMessageArgs>().Publish("Hello luyao");

            //IEventAggregator的委托
            //eventAggregator.GetEvent<EventMessageDelegate>().Subscribe(Receive);
            //
            //eventAggregator.GetEvent<EventMessageDelegate>().Publish(new EventAction()
            //{
            //    ResultAction = new Action<bool>(state =>
            //    {
            //        Console.WriteLine("state="+ state);
            //    })
            //});

            //IEventAggregator的过滤
            //eventAggregator.GetEvent<EventMessageArgsFilter>().Subscribe(Receive,data=>data.Id==1);

            //eventAggregator.GetEvent<EventMessageArgsFilter>().Publish(new DataModel() { Id=2,Text="love"});

            //bool keepSubscriberReferenceAlive
            // false     true->对象销毁的时候，做注销操作
        }

        private void Receive()
        {
            Console.WriteLine(" MainWindow Receive ");
        }

        private void Receive(string str)
        {
            Console.WriteLine( " 泛型参数  "+str );
        }

        private void Receive1(string str)
        {
            Console.WriteLine(" 泛型参数  " + str);
        }

        private void Receive(EventAction action)
        {
            action.ResultAction.Invoke(true);
        }

        private void Receive(DataModel data)
        {
            Console.WriteLine("IEventAggregator的过滤");
        }

      

        private void btnSubscribe_Click(object sender, RoutedEventArgs e)
        {
            //_eventAggregator.GetEvent<EventMessage>().Subscribe(Receive);
        }

        private void btnPublish_Click(object sender, RoutedEventArgs e)
        {
            //_eventAggregator.GetEvent<EventMessage>().Publish();
        }
    }
}