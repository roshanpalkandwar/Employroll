

namespace Employeepayroll
{
    internal class employeePresentAbsent
    {
        public static void emplyeeattendcecheck()
        {
            Random random = new Random();
            int empcheck = random.Next(0, 2);
            Console.WriteLine("random genrate value " + empcheck);
            if (empcheck == 0)
            {
                Console.WriteLine("emplyee present");

            }
            else
            {
                Console.WriteLine("employee absent");
            }

        }
    }
}
