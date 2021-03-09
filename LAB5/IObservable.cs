using System;
using System.Collections.Generic;
using System.Text;

namespace LAB2_3
{
    interface IObservable
    {
        void AddObserver(IObserver o);
        void RemoveObserver(IObserver o);
        void NotifyObservers();
    }

    interface IObserver
    {
        void Update(object obj);
    }


}
