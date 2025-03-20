namespace ConsoleApp9
{
    internal class Program
    {
        static void Main()
        {
            var bookLibrary = new Library<Book>();

            try
            {
                bookLibrary.Add(new Book("1984", "George Orwell", 1949, 328, "Dystopian"));
                bookLibrary.Add(new Book("To Kill a Mockingbird", "Harper Lee", 1960, 281, "Fiction"));

                Console.WriteLine("Все книги в библиотеке:");
                bookLibrary.PrintAll();

                bookLibrary.CheckOut("1984");

                Console.WriteLine("\nДоступные книги:");
                var availableBooks = bookLibrary.GetAllAvailable();
                foreach (var book in availableBooks)
                {
                    Console.WriteLine($"Название: {book.Title}, Автор: {book.Author}");
                }

                bookLibrary.Return("1984");

                bookLibrary.Remove("To Kill a Mockingbird");
                Console.WriteLine("\nПосле удаления книги 'To Kill a Mockingbird':");
                bookLibrary.PrintAll();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }
    }
}
