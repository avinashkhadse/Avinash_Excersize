using System;

namespace Iteration
{
    /*    public class foreachEx
        {
            public void show()
            {
                var numbers = new int[] { 1, 2, 3, 4 };

                foreach (var number in numbers)
                {
                    Console.WriteLine(number);
                }
            }
        }
    */

    /*    public class forEx
        {
            public void show()
            {
                var i = 0;
                while (i <= 10)
                {
                    if(i%2 == 0)
                        Console.WriteLine(i);
                    i++;
                }
            }
        }
    */

    /*    public class randomNo
        {
            public void show()
            {
                var random = new Random();
                for(var i = 0; i < 10; i++)
                {
                    Console.WriteLine(random.Next(1,10));
                }
            }
        }
    */
    /*    public class randomCh
        {
            public void show()
            {
                var random = new Random();
                const int passLength = 10;

                var buffer = new char[passLength];


                for (var i = 0; i < passLength; i++)
                {
                    buffer[i] = (char)('a'+random.Next(0,26));
                    var password = new string(buffer);

                    Console.WriteLine(password);
                }
            }
        }
    */

    /*Write a program to count how many numbers between 1 and 100 are
     * divisible by 3 with no remainder.Display the count on the console.*/

    /*    public class divisibleCount
        {
            public void show()
            {
                int a = 0;

                for(int i = 1; i <= 100; i++)
                {

                    if (i % 3 == 0)
                    {
                        Console.WriteLine(i);
                        a++;
                    }
                }
                Console.WriteLine(a);

            }
        }
    */

    /*Write a program and continuously ask the user to enter a number or "ok" to
     * exit.Calculate the sum of all the previously entered numbers and display
     * it on the console.*/

    /*    public class sumCal
        {

            public void show()
            {
                int number;
                string s = "Avinash";
                int sum = 0;
                char[] num;

                do
                {
                    Console.WriteLine("Enter the number");
                    number = Convert.ToInt32(Console.ReadLine().Split(','));

                    num = new char[number];


                }
                while (s == "OK");

                for (int i = 0; i < num.Length; i++)
                {
                    sum = num[i];

                }
                Console.WriteLine(sum);

                //Console.WriteLine(sum);

            }
        }
    */

    /*    public class factNo
        {
            public void show()
            {
                Console.WriteLine("Enter the number");
                int a = int.Parse(Console.ReadLine());
                int fact = 1;

                for(int i = a; i > 0; i--)
                {
                    fact = fact * i;
                }
                Console.WriteLine("Factorial of "+ a + " is = "+ fact);
            }
        }
    */
    /*Write a program that picks a random number between 1 and 10.
     * Give the user 4 chances to guess the number.If the user
     * guesses the number, display “You won"; otherwise,
     * display “You lost". (To make sure the program is behaving
     * correctly, you can display the secret number on the console first.)*/

    /*    public class guessNum
        {
            public void show()
            {
                var random = new Random();
                int a = random.Next(1, 10);

                for (int i = 1; i <= 4; i++)
                {
                    Console.WriteLine("Enter your guess");
                    int g = int.Parse(Console.ReadLine());

                    if (g == a)
                    {
                        Console.WriteLine("You won");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("You lost");

                    }
                }
                Console.WriteLine("Correct number is " + a);
            }
        }
    */

    /*Write a program and ask the user to enter a series of numbers
     *separated by comma.Find the maximum of the numbers and display
     *it on the console.For example, if the user enters “5, 3, 8, 1, 4",
     *the program should display 8.*/

/*    public class maxNo
    {
        //int count = 0;
        public void show()
        {
            Console.WriteLine("Enter the series of number");
            string str = Console.ReadLine();
            char[] ch = str.ToCharArray();

         
            
            int[] myarr = new int[ch.Length];
            for (int i = 0; i < myarr.Length; i++)
            {
                 
              
                myarr[i] = (int)ch[i]; 
           }
            Console.WriteLine("Int string is " + (myarr[0]));
        }
*/
      
    }


    public class Avinash
    {
        public static void Main(string[] args)
        {
            /*            foreachEx f1 = new foreachEx () ;
                          f1.show();
            */

            /*            forEx f1 = new forEx();
                          f1.show();
            */

            /*            randomNo r1 = new randomNo();
                          r1.show();
            */

            /*            randomCh r2 = new randomCh();
                          r2.show();
            */

            /*            divisibleCount d = new divisibleCount();
                          d.show();
            */

            /*            sumCal s = new sumCal();
                          s.show();
            */

            /*            factNo f = new factNo();
                          f.show();
            */

            /*            guessNum gn= new guessNum();
                          gn.show();
            */

            maxNo m = new maxNo();
            m.show();




        }
    }

}