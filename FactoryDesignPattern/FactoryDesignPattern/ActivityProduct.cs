using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    class ActivityProduct : IProduct
    {
        readonly int activityId = 3;
        readonly string activityName = "XYZ show";
        int cost = 500;
        string data = "";
        bool isBook = false;
        Logger logs = Logger.getInstance();
        public ActivityProduct()
        {
            ActivityFare activityFare = new ActivityFare();
            cost = activityFare.ProfitOnFare(cost);
        }
        public void Book(IRepository database)
        {
            logs.loggingDetails("Moving into :- Book method of activity class");
            Console.WriteLine("Booking...");
            isBook = true;
            data = "activityId:" + activityId + ",activityName:" + activityName + ",cost:" + cost + ",isBook:" + isBook;
            Console.WriteLine("..");
            Console.WriteLine("Successfully booked");
            logs.loggingDetails("Successfully booked");
        }
        
        public void Save(IRepository database)
        {
            Console.WriteLine("Saving...");
            logs.loggingDetails("Moving into :- Book method of activity class");
            data = "activityId:" + activityId + ",activityName:" + activityName + ",cost:" + cost + ",isBook:" + isBook;
            Console.WriteLine("..");
            Console.WriteLine("Successfully saved");
            logs.loggingDetails("Successfully saved");
        }
    }
}
