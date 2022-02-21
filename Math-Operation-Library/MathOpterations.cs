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
    }
}
