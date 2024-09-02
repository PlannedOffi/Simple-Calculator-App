namespace Simple_CalculatorNEW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double FirstNumber = 0; //initialize values without looping
            double SecondNumber = 0;
            double Result = 0;

            bool cond = true;  // set a condition


            do
            {

                if (cond == false)    //beginning of loop is true
                {
                    break;
                }

                try         // try and catch function for if wrong values are inputed into first or second number
                {
                    Console.WriteLine("Enter First Number: ");
                    FirstNumber = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter Second Number: ");
                    SecondNumber = Convert.ToDouble(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine("INVALID NUMBER, PLEASE INSERT A CORRECT NUMBER");
                    continue; //start the program over 
                }

                Console.WriteLine("Choose an Arithmetic Operator from the list: ");
                Console.WriteLine("+");
                Console.WriteLine("-");
                Console.WriteLine("*");
                Console.WriteLine("/");
                Console.WriteLine("_____________________________________________");

                Console.WriteLine("Arithmetic Operator: ");


                do
                {

                    switch (Console.ReadLine())
                    {
                        case "+":
                            Result = FirstNumber + SecondNumber;
                            Console.WriteLine("Result: " + Result);
                            break;

                        case "-":
                            Result = FirstNumber - SecondNumber;
                            Console.WriteLine("Result: " + Result);
                            break;

                        case "*":
                            Result = FirstNumber * SecondNumber;
                            Console.WriteLine("Result: " + Result);
                            break;

                        case "/":
                            Result = FirstNumber / SecondNumber;
                            Console.WriteLine("Result: " + Result);
                            break;

                        default:
                            Console.WriteLine("PLEASE SELECT A PROPER OPERATION FROM THE LIST!");
                            cond = false;   // sets flag condition to false if default case happens
                            break;
                    }
                    if (cond)    // check if condition is true
                    {
                        break;
                    }
                    cond =true;        
                    continue;  //ends the program and starts againg
                }
                while (true);

                do
                {
                    Console.WriteLine("Do you want to do more calculations? Select (Y/N)");
                    string option = Console.ReadLine().ToUpper();
                    if (option != "Y" && option != "N")
                    {
                        Console.WriteLine("INVALID OPTION, PLEASE SELECT EITHER OF (Y/N)");
                        continue;
                    }
                    if (option == "N")
                    {
                        cond = false;  //false condition for if option is N
                    }
                    break;
                }
                while (true);

            }
            while (true);
            return; // break out of entire loop
        }

    }
}

