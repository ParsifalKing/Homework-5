Person person = new Person();
 System.Console.Write("Enter your FirstName : ");
 person.FirstName = Console.ReadLine();
 System.Console.Write("Enter your LastName : ");
 person.LastName = Console.ReadLine();
 System.Console.Write("Enter your Age : ");
 person.Age = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("FirstName: " + person.GetInfo1());
System.Console.WriteLine("LastName: " + person.GetInfo2());
System.Console.WriteLine("Age: " + person.GetInfo3());


public class Person
{
public  string FirstName ;
public string LastName;
public int Age;
 
 public string GetInfo1()
 {
    return $"{FirstName}";
 }
 public string GetInfo2()
 {
    return $"{LastName} ";
 }
 public string GetInfo3()
 {
    return $"{Age}";
 }
 
}





