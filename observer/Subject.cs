using System;
using System.Collections.Generic;
using System.Text;

namespace observer
{
    interface Subject
    {
        void registerObserver(Observer o);
        void removeObserver(Observer o);
        void notifyObserver();
    }
}
