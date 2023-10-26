using OOPBasics;

Person person = new Person("Shahadat", "Hossain");
string name = person.GetName( " " );
Console.WriteLine(name);

Person person2 = new Person("Saleh", "Ahmed");
//person2.FirstName = "";
//person2.LastName = "Hassan";
string name2 = person2.GetName(" ");
Console.WriteLine(name2);
//Console.WriteLine(person2.FullName);