namespace Assessment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Reset:
            Console.Clear();
            Console.WriteLine("Enter Hour via (12-hr time frame):");
            int intHour = Convert.ToInt32(Console.ReadLine());

            if (intHour < 13 && intHour > 0)
            {
                Console.WriteLine("Enter Minutes:");
                int intMinute = Convert.ToInt32(Console.ReadLine());
                if (intMinute > -1 && intMinute < 61)
                {
                    double hourDeg = (intHour * 30) + (intMinute * 30 / 60);
                    double minuteDeg = (intMinute * 6);
                    double answer = Math.Abs(hourDeg - minuteDeg);
                    double answer_2 = answer;

                    if (answer > 180)
                    {
                        answer_2 = answer;
                        answer = 360 - answer;
                    }
                    else {
                        answer_2 = 360 - answer;
                    }


                    Console.WriteLine("Angle between both minute and hour is : {0}", answer);
                    Console.WriteLine("The rest of the angle is : {0}", answer_2);
                    Console.WriteLine("Want to try again? (Y/N)");
                    string res = Console.ReadLine();

                    if (res.ToUpper() == "Y") {
                        goto Reset;
                    }
                    return;
                }
                else
                {
                    Console.WriteLine("Invalid! Please input 1-60");
                    Console.ReadLine();
                    return;
                }
            }
            else {
                Console.WriteLine("Invalid! Please input 1-12");
                Console.ReadLine();
                return;
            }

          
        }
    }
}