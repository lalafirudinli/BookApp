
using BookApp.App.Services.Implementations;


BookService Book = new BookService();

Console.WriteLine("0.Close App");
Console.WriteLine("1.Show Book");
Console.WriteLine("2.Create Books");

string Request = Console.ReadLine();

while (Request!="0" )
{
  switch(Request)
    {

            case "1":
            Book.GetFullInfo();
            break;
            case "2":
            Book.Createbook();
            break;


        default:
            Console.WriteLine("Add valid option");
            break;

    }


            Console.WriteLine("0.Close App");
            Console.WriteLine("1.Show Book");
            Console.WriteLine("2.Create Book");

            Request = Console.ReadLine();



}
