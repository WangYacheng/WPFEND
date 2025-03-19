using Prism.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFPrismEND.Base
{
    public class EventMessage:PubSubEvent
    {
    }

    public class EventMessageArgs : PubSubEvent<string>
    { }

    public class EventMessageDelegate : PubSubEvent<EventAction> { }

    public class EventMessageArgsFilter : PubSubEvent<DataModel>
    {}

    public class EventAction
    {
        public Action<bool> ResultAction { get; set; }
    }

    public class OpenMessage : PubSubEvent<string>
    {
    }
}
