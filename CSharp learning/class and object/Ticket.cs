using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_and_object
{
    /// <summary>
    /// 写一个Ticket类,有一个距离属性(本属性只读,在构造方法中赋值),不能为负数,有一个价格属性,价格属性只读,并且根据距离distance计算价格Price (1元/公里):
        //0-100公里 票价不打折
        //101-200公里 总额打9.5折
        //201-300公里 总额打9折
        //300公里以上 总额打8折
        //有一个方法,可以显示这张票的信息.

    /// </summary>
    public class Ticket
    {
        public double Distance
        {
            set
            {
                if (value>0)
                {
                    Distance = value;
                }
                else
                {
                    Console.WriteLine("Error! Distance should be positive integer.");
                }
            }
            get
            {
                return Distance;
            }
        }
        public double Price { get;  }
        public Ticket(int distance)
        {
            if (distance<=0)
            {
                Console.WriteLine("The distance should be bigger than 0.");
            }
            if (distance>0 && distance<=100)
            {
                Price = 1.0*distance;
            }
            else if (distance > 100 && distance <= 200)
            {
                Price = 0.95 * distance;
            }
            else if (distance > 200 && distance <= 300)
            {
                Price = 0.9 * distance;
            }
            else if (distance > 400)
            {
                Price = 0.8 * distance;
            }
        }

        public void DisplayTicketInformation()
        {
            Console.WriteLine("The price of your ticket is {0}",this.Price);
        }

        
    }
}
