using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotifyPractice
{
    public interface IHaveLimit : INotifyPropertyChanged
    {
        public int Limit { get; }

        public bool GetToLimit();
    }
}
