using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class ApplyManager
    {
        public void ToApply(ICreditManager creditManager,List<ILoggerService> loggerServices)
        {
            creditManager.Calculate();
            foreach (var logger in loggerServices)
            {
                logger.Log();
            }
            

        }


        public void CreditPreInformation(List<ICreditManager> credits)
        {
            foreach (var credit in credits)
            {
                credit.Calculate();
            }
        }


    }

}
