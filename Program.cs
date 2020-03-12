using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_Code
{
    class Program
    {
        static void Main(string[] args)
        {
            int Position, Value, Option;
            Stack S = new Stack();
            do
            {
                Console.WriteLine("Enter Any Option You Want To Perfrom On Stack");
                Console.WriteLine("0 : Exist");
                Console.WriteLine("1: Push Value in Stack");
                Console.WriteLine("2: Pop Value From Stack");
                Console.WriteLine("3: Access Value From Stack");
                Console.WriteLine("4: Change Value From Stack ");
                Console.WriteLine("5: Count Value in Stack");
                Console.WriteLine("6: Display All Values That Are In The Stack");
                Console.WriteLine("7: Check Stack Is Empty Or Not?");
                Console.WriteLine("8: Chack Stack Is Full or Not?");
                Console.Write("Enter Option You Want To Perform :");
                Option = int.Parse(Console.ReadLine());
                switch(Option)
                {
                    case 0:
                        break;
                    case 1:
                        Console.Write("Enter Value You Want To Enter in Stack :");
                        Value = int.Parse(Console.ReadLine());
                        S.Push(Value);
                        Console.WriteLine("Value Is Pushed in Stack");
                        break;
                    case 2:
                        S.Pop();
                        Console.WriteLine("Value Is Poped");
                        break;
                    case 3:
                        Console.Write("Enter Position You Want To Acces :");
                        Position = int.Parse(Console.ReadLine());
                        Console.WriteLine("Vaule You Want To Access Is :"+S.Peek(Position));
                        break;
                    case 4:
                        Console.Write("Enter Posion Where You Wamt To Change The Value: ");
                        Position = int.Parse(Console.ReadLine());
                        Console.Write("Enter The Value You Want To Enter in Change :");
                        Value = int.Parse(Console.ReadLine());
                        S.Change(Position, Value);
                        Console.WriteLine("Value Is Changed !");
                        break;
                    case 5:
                        Console.Write("Number of Values in Stack Is:"+S.Count());
                        Console.WriteLine();
                        break;
                    case 6:
                        Console.WriteLine("Values in Stack Are :");
                        S.Display();
                        break;
                    case 7:
                        if(S.IsEmpty())
                        {
                            Console.WriteLine("Stack Is Empty");
                        }
                        else
                        {
                            Console.WriteLine("Stack Is Not Empty ");
                        }
                        break;
                    case 8:
                        if(S.IsFull())
                        {
                            Console.WriteLine("Stack Is Full");
                        }
                        else
                        {
                            Console.WriteLine("Stack Is Not Full");
                        }
                        break;
                    default:
                        Console.WriteLine("Enter Valid Value");
                        break;
                }
            } while (Option != 0);
        }
    }
}
