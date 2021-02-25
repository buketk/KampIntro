using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {

            ICreditManager vehicleCreditManager = new VehicleCreditManager();

            ICreditManager personalFinanceCreditManager = new PersonalFinanceCreditManager();

            ApplyManager applyManager = new ApplyManager();
            //applyManager.ToApply(personalFinanceCreditManager);
            //applyManager.ToApply(vehicleCreditManager);

            DatabaseLoggerService databaseLoggerService = new DatabaseLoggerService();
            FileLoggerService fileLoggerService = new FileLoggerService();

            applyManager.ToApply(personalFinanceCreditManager,new List<ILoggerService> { databaseLoggerService });
            applyManager.ToApply(vehicleCreditManager,new List<ILoggerService> { databaseLoggerService, fileLoggerService });

            List<ICreditManager> credits = new List<ICreditManager> { vehicleCreditManager , personalFinanceCreditManager };
            //applyManager.CreditPreInformation(credits);


        }
    }
}
