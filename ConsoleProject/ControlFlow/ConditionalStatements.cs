using System;
namespace ConsoleProject.ControlFlow

//IF/ELSE

//if (condition)
//elseif(another Condition)
//else(yet another Condition)

//SWITCH/CASE
//Here "role" is the variable
//"role" is being compared to Role.Admin, Role.Moderator
//if none of these conditions are true then we go to "default"

//switch(role)
//{
//    case Role.Admin:
//             ...
//             break
//    case Role.Moderator:
//             ...
//             break;
//    default:
//             ...
//             break;
//}
{
    #region ConditionalStatements
    //class ConditionalStatements
    //{
    //    static void Main(string[] args)
    //    {
    //        int hour = 10;

    //        //if Hour is greater than 0 AND less than 12...
    //        //CW "It's morning"
    //        if (hour > 0 && hour < 12)
    //        {
    //            Console.WriteLine("It's morning");
    //        }
    //        else if (hour >= 12 && hour < 18)
    //        {
    //            Console.WriteLine("It's afternoon");
    //        }
    //        else
    //        {
    //            Console.WriteLine("It's night");
    //        }
    //    }
    //}
    #endregion

    #region ConditionalOperators
    //class ConditionalOperators
    //{
    //    static void Main(string[] args)
    //    {
    //        bool isGoldCustomer = true;

    //        //float price;

    //        //if (isGoldCustomer)
    //        //{
    //        //    price = 19.95f;
    //        //}
    //        //else
    //        //{
    //        //    price = 29.95f;
    //        //}

    //        //ConditionalStatement
    //        //Notice that ":" symbolizes OR
    //        float price = (isGoldCustomer) ? 19.95f : 29.95f;
    //        Console.WriteLine(price);
    //    }
    //}
    #endregion

    public enum Seasons
    {
        Spring,
        Winter,
        Fall,
        Summer
    }

    class SwitchCases
    {
        static void Main(string[] args)
        {
            var seasons = Seasons.Summer;

            switch (seasons)
            {
                case Seasons.Summer:
                    Console.WriteLine("Catch some waves and daze!");
                    break;

                case Seasons.Fall:
                    Console.WriteLine("Beautiful time to see the changes!");
                    break;

                case Seasons.Winter:
                    Console.WriteLine("Burrrr, it's chilly out there!");
                    break;

                default:
                    Console.WriteLine("Not a valid season");
                    break;
            }
        }
    }
}
