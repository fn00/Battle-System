namespace Automated_Testing_17._06._24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    public class Calculator
    {
        public Calculator()
        {

        }
        public void Menu()
        {
            string user_choice;
            int numone;
            int numtwo;
            string[] Valid = { "1", "2", "3", "4" };


            Console.WriteLine("Do you want to:\n1.Add\n2.Subtract\n3.Multiply\n4.Divide");
            user_choice = Console.ReadLine();
            while (true)
            {
                Console.WriteLine("Enter your first number");
                numone = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter your second number");
                numtwo = int.Parse(Console.ReadLine());
                if (Valid.Contains(user_choice))
                {
                    if (user_choice == "1")
                    {

                    }
                    else if (user_choice == "2")
                    {

                    }
                    else if (user_choice == "3")
                    {
                        //Console.WriteLine(numeone * numtwo);
                    }
                    else;
                    {

                    }
                }
            }
        }
        public int Add(int numone, int numtwo)
        {
            int answer = numone + numtwo;
            return answer;
        }

        public int Subtract(int numone, int numtwo)
        {
            int answer = numone - numtwo;
            return answer;
        }

        public int Multiply(int numone, int numtwo)
        {
            int answer = numone * numtwo;
            return answer;
        }

        public int Divide(int numone, int numtwo)
        {
            int answer = numone / numtwo;
            return answer;
        }
    }
}