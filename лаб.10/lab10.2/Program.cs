using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Task2
{
    class MobileTariff
    {
        public const string name = "Для всiєї сiм'ї";
        public DateTime date_start = new DateTime(2021, 3, 20);
        public DateTime date_end = new DateTime(2022, 3, 20);
        public int subscription_fee = 150;
        public double cost_per_minute = 1.5;

        public TimeSpan DataFind()
        {
            TimeSpan date_sub = date_end.Subtract(date_start);
            return date_sub;
        }

        public double PricingForACall()
        {
            Console.Write("Скiльки Вам потрiбно хвилин для дзвiнка?:");
            uint call = uint.Parse(Console.ReadLine());
            return call * cost_per_minute;
        }

        public long SubscriptionFeeInAdvance()
        {
            Console.Write("На скiльки мiсяцiв Ви хочете взяти абонплату?:");
            uint subscription = uint.Parse(Console.ReadLine());
            int action = Convert.ToInt32(date_end.Subtract(date_start));
            while (subscription > action)
            {
                Console.Write($"Лихо! Тариф дiє тiльки {date_end.Subtract(date_start)}");
                Console.Write("На скiльки мiсяцiв Ви хочете взяти абонплату?:");
                subscription = uint.Parse(Console.ReadLine());
            }
            return subscription_fee * subscription;
        }
    }
}