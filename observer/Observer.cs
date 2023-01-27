using System;
using System.Collections.Generic;
using System.Text;

namespace observer
{
    interface Observer
    {

        void update(float temperature, float humidity, float preassure);
    }
}
