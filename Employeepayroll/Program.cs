namespace Employeepayroll
{
    internal class Program
    {
    

        static void Main(string[] args)
        {
            Console.WriteLine("welecome to employee pay roll");
            Console.WriteLine("choose option\n 1.check absent present");
            int opt = Convert.ToInt32(Console.ReadLine());
            
            switch(opt)
            {
                case 1:
                    employeePresentAbsent.emplyeeattendcecheck();
                    break;
                default:
                    Console.WriteLine("enter the wrong choice");
                    break;
            }
        
        
        }



    }
}