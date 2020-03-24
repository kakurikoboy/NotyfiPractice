using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace NotifyPractice
{
    public class NotifyItem<T> : IHaveLimit
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private T item;
        public T Item
        {
            get => item;
            set
            {
                item = value;
            }
        }

        private int limit;
        public int Limit
        {
            get => limit;
            set
            {
                limit = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Set"));
            }
        }

        public NotifyItem()
        {
            //PropertyChanged += Notify_PropertyChanged;
        }
        public NotifyItem(T item) : this()
        {
            Item = item;
        }

        public bool GetToLimit()
        {
            return (Limit==0);
        }

        
    }
}
