using System;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {

            ICreditManager vehicleCreditManager = new VehicleCreditManager();

            ICreditManager personalFinanceCreditManager = new PersonalFinanceCreditManager();

            ApplyManager applyManager = new ApplyManager();
            applyManager.ToApply(personalFinanceCreditManager);
            applyManager.ToApply(vehicleCreditManager);

        }
    }
}
