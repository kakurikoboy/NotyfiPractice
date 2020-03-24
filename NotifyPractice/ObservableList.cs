using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace NotifyPractice
{
    public class ObservableList<T> : IEnumerable<T> where T : class , IHaveLimit
    {
        private ObservableCollection<T> items;
        
        public T this[int i]
        {
            get => items[i];
            set => items[i] = value;
        }


        public ObservableList()
        {
            items = new ObservableCollection<T>();
        }


        private void Item_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            var _sender = sender as T;

            if (_sender.Limit == 0)
            {
                items.Remove(_sender);
            }
        }


        public void Add(T item)
        {
            item.PropertyChanged += Item_PropertyChanged;

            items.Add(item);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return items.GetEnumerator();
        }


        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)items).GetEnumerator();
        }
    }
}
