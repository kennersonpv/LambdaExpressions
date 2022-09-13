using System;

namespace LambdaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            //What are lambdas?
            //No access modifier (public, private...)
            //No name
            //No return statement
            
            //args => expression
            //number => number*number
            Func<int, int> square = number => number * number;

            Console.WriteLine(square(5));
            
            // () => ...
            // x => ...
            // (x,y,z) =>

            const int factor = 5;

            Func<int, int> multiplier = n => n * factor;
            var result = multiplier(10);

            Console.WriteLine(result);

            Console.WriteLine(Square(5));
            
            //-----------------------------------------------

            var books = new BookRepository().GetBooks();
            var cheapBooks = books.FindAll(book => book.Price < 10);
            foreach (var book in cheapBooks)
            {
                Console.WriteLine(book.Title);
            }
        }

        static int Square(int number)
        {
            return number * number;
        }
    }
}