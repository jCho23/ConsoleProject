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
    class ConditionalStatements
    {
        static void Main(string[] args)
        {
            int hour = 10;

            //if Hour is greater than 0 AND less than 12...
            //CW "It's morning"
            if (hour > 0 && hour < 12)
            {
                Console.WriteLine("It's morning");
            }
            else if (hour >= 12 && hour < 18)
            {
                Console.WriteLine("It's afternoon");
            }
            else
            {
                Console.WriteLine("It's night");
            }
        }
    }

    class ConditionalOperators
    {


    }
}
