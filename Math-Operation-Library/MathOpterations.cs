using System;

namespace Math_Operation_Library
{
    public class MathOpterations
    {
        //library for addition 
        public static int Addition(String series)
        {
            int answer = 0;

            String[] numbers = series.Split(' ');

            //running foreach loop to iterate through the array of numbers
            foreach (string n in numbers)
            {

                int temp;

                //converting the string to int
                if (int.TryParse(n, out temp))
                {

                    //adding the int to answer
                    answer += temp;
                }
                else
                {
                    throw new ArgumentException();
                }

            }

            //returning the answer 
            return answer;


        }

        //library for Subtraction 
        public static int Subtraction(String series)
        {
            int answer = 0;

            String[] numbers = series.Split(' ');

            //running foreach loop to iterate through the array of numbers
            foreach (string n in numbers)
            {

                int temp;

                //converting the string to int
                if (int.TryParse(n, out temp))
                {

                    //subtracting the int to answer
                    answer -= temp;

                    //checking if the answer is less than 0 in the first run 
                    if (answer < 0)
                    {
                        //if yes then assigning the temp value to answer 
                        answer = temp;
                    }
                }
                else
                {
                    throw new ArgumentException();
                }

            }

            //returning the answer 
            return answer;


        }


        //library for Multiplication 
        public static int Multiplication(String series)
        {
            //setting the value of answer as 1 
            int answer = 1;

            String[] numbers = series.Split(' ');

            //running foreach loop to iterate through the array of numbers
            foreach (string n in numbers)
            {

                int temp;

                if (int.TryParse(n, out temp))
                {

                    //multiplying the numbers and saving in answer 
                    answer *= temp;
                }
                else
                {
                    throw new ArgumentException();
                }

            }

            //returning the answer 
            return answer;


        }

        //library for Division 
        public static int Division(String series)
        {
            int answer;

            String[] numbers = series.Split(' ');

            //taking the splitted numbers in two separate variables
            int a = Int32.Parse(numbers[0]);
            int b = Int32.Parse(numbers[1]);

            //checking if any of the numbers are 0 
            if (a == 0 || b == 0)
            {
                //if yes then throwing an exception
                throw new ArgumentException("Cannot divide by 0 ");
            }
            else
            {
                //if no then dividing the numbers 
                answer = a / b;
            }

            //returning the answer 
            return answer;


        }
    }
}
