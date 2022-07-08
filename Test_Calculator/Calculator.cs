using System;

namespace Test_Calculator
{

    public class Calculator
    {

        public double Add(double n1, double n2)
        {
            double sum = n1 + n2;
            return sum;
        }

        public double Add(params double[] n)
        {
            double sum = 0;
            if (n.Length == 1)
            {
                Console.WriteLine("Please input two or more values!");
                sum = n[0];
            }else if(n.Length == 2)
            {
                double n1 = n[0];
                double n2 = n[1];
                sum = Add(n1, n2);

            }
            else
            {
                for (int i = 0; i < n.Length; i++)
                {
                    sum += n[i];
                }
            }
            Console.WriteLine($"The sum of values {string.Join(" + ", n)} is: {sum}");
            return sum;


        }

        public double Sub(double n1, double n2)
        {
            double sub = n1 - n2;
            return sub;
        }


        public double Sub(params double[] n)
        {
            double sub = n[0];
            if (n.Length == 1)
            {
                Console.WriteLine("Please input two or more values!");
                sub = n[0];
            }else if (n.Length == 2)
            {
                double n1 = n[0];
                double n2 = n[1];
                sub = Sub(n1, n2);

            }
            else
            {
                for(int i = 1; i < n.Length; i++)
                {
                    sub -= n[i];
                }
            }
            Console.WriteLine($"The subtraction of values {string.Join(" - ", n)} is: {sub}");
            return sub;

        }
        
        public double Mult(double n1, double n2)
        {
            double mult = n1 * n2;
            return mult;
        }

        public double Mult(params double[] n)
        {
            double mult = 1;
            if (n.Length == 1)
            {
                Console.WriteLine("Please input two or more values!");
                mult = n[0];
            }else if (n.Length == 2)
            {
                double n1 = n[0];
                double n2 = n[1];
                mult = Mult(n1, n2);
            }
            else
            {
                for (int i = 0; i < n.Length; i++)
                {
                    mult *= n[i];
                }
            }
            Console.WriteLine($"The result of {string.Join(" * ", n)} is: {mult}");
            return mult;
        }



        public double Div(double n1, double n2)
        { 
            if(n2 == 0)
            {
                Console.WriteLine("Error!!! You are trying divide by zero! Please try again with a valid value.");
                throw new DivideByZeroException();
            }
            double div = n1 / n2;
            return div;
        }


        public double Div(params double[] n)
        {
            double div = n[0];
            if (n.Length == 1)
            {
                Console.WriteLine("Please input two or more values!");
                div = n[0];
            }
            else if (n.Length == 2)
            {
                double n1 = n[0];
                double n2 = n[1];
                div = Div(n1, n2);
            }
            else
            {    
               for (int i = 1; i < n.Length; i++)
               {
                    /* Checking all indexes of the array,
                     * throwns exception if one of the values is zero */
                    if (n[i] == 0)
                    {
                        Console.WriteLine("Error!!! You are trying divide by zero! Please try again with a valid value.");
                        throw new DivideByZeroException();
                    }
                    div /= n[i];
               }
                
                
            }
            Console.WriteLine($"The result of {string.Join(" / ", n)} is: {div}");
            return div;
        }

        /* Dividing an interger number by zero throwns an exception */
        public int DivInt(int n1, int n2)
        {
            int div = n1 / n2;
            return div;
        }

        /* Dividing a double number by zero does not throwns an exception, the output is the infinity ( ∞ )*/
        public double DivDouble(double n1, double n2)
        {
            double div = n1 / n2;
            return div;
        }




        public double[] GetInput()
        {
            Console.WriteLine("Enter values separated by comma: ");
            string[] input = Console.ReadLine().Split(',');
            double[] values = input.Select(double.Parse).ToArray();

            return values;
        }


        public int Remainder(int dividend, int divisor)
        {
          
            int quotient = Math.DivRem(dividend, divisor, out int remainder);
            Console.WriteLine($"The dividend is : {dividend}\nThe divisor is : {divisor}\nThe quotient is : {quotient}\nThe remainder is : {remainder}\n");

            return remainder;
        }

        public double Fact(double n)
        {
            if(n < 0)
            {
                throw new Exception();
            }
            double res = 1;
            double inputedNumber = n;
            while (n != 1)
            {
                res = res * n;
                n = n - 1;
            }
            Console.WriteLine($"The factorial of {inputedNumber} is: {res}");

            return res;
        }



        public void MainMenu()
        {

            bool showMenu = true;
            double[] input = { };

            do
            {
                Console.WriteLine("\n--------Calculator--------\n");
                Console.WriteLine("\nPlease select an option: \n");
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Subtract");
                Console.WriteLine("3. Multiply");
                Console.WriteLine("4. Divide");
                Console.WriteLine("5. Remainder");
                Console.WriteLine("6. Factorial");
                Console.WriteLine("0. Quit");
                int.TryParse(Console.ReadLine(), out int option);


                switch (option)
                {
                    case 0:
                        showMenu = false;
                        Console.Clear();
                        break;
                    case 1:
                        Console.Clear();
                        Console.WriteLine("\n---Addition---\n");
                        input = GetInput();
                        Add(input);
                        Console.ReadLine();
                        showMenu = true;
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("\n---Subtraction---\n");
                        input = GetInput();
                        Sub(input);
                        Console.ReadLine();
                        showMenu = true;
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("\n---Multiplication---\n");
                        input = GetInput();
                        Mult(input);
                        Console.ReadLine();
                        showMenu = true;
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("\n---Division---\n");
                        input = GetInput();
                        Div(input);
                        Console.ReadLine();
                        showMenu = true;
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("\n---Remainder---\n");
                        Console.WriteLine("Enter the dividend: ");
                        int dividend = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the divisor: ");
                        int divisor = int.Parse(Console.ReadLine());
                        Remainder(dividend, divisor);
                        Console.ReadLine();
                        showMenu = true;
                        break;
                    case 6:
                        Console.Clear();
                        Console.WriteLine("\n---Factorial---\n");
                        Console.WriteLine("Input a value: ");
                        double value = double.Parse(Console.ReadLine());
                        Fact(value);
                        Console.ReadLine();
                        showMenu = true;
                        break;
                    default:
                        showMenu = true;
                        break;

                }

            } while (showMenu);



        }




    }


}

