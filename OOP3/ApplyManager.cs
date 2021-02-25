using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class ApplyManager
    {
        public void ToApply(ICreditManager creditManager)
        {
            creditManager.Calculate();

        }
    }
}
