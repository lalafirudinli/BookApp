Console.WriteLine("Enter Student name:");
string name = Console.ReadLine();

Console.WriteLine("Enter Student Surname");
string surname = Console.ReadLine();

Console.WriteLine("Enter Student Group");
string group = Console.ReadLine();

Console.WriteLine("Enter Student Point");
double point = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter Student Graduation");
bool typee = Convert.ToBoolean(Console.ReadLine());

StudentUtil.Student student = new StudentUtil.Student (name, surname, group, point, typee) ;

Console.WriteLine(student.GetFullName());
Console.WriteLine(student.GetFullInfo());
Console.WriteLine(student.Check_Point());
