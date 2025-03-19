using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFPrismEND.ViewModel
{
    public class MainModel:BindableBase
    {
        private string _title = "Prism Start 11";
        public string Title  
        {
            get { return _title; }
            set { _title = value; }
        }


        //发布消息

    }
}
