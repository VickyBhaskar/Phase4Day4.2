// See https://aka.ms/new-console-template for more information
using ConsAppTwo;
List<Employee > employees=new List<Employee>()
{
    new Employee() { Id=1,Name="Vicky",Designation="Developer", DOJ = new DateTime(day: 12, month: 11, year:2022)},
    new Employee() { Id = 2, Name = "Vikash", Designation = "Developer2", DOJ = new DateTime(day: 10, month: 10, year:2021)},
    new Employee() { Id = 3, Name = "Vijay", Designation = "Developer3", DOJ = new DateTime(day: 11, month: 12, year:2023)},
    new Employee() { Id = 4, Name = "Vishnu", Designation = "Developer4", DOJ = new DateTime(day: 19, month: 09, year:2020)},
};
Console.WriteLine("Id\t Name \t Designation \t Date of Joining");
foreach (Employee emp in employees)
{
    Console.Write(emp.Id+"\t \t");
    Console.Write(emp.Name+"\t \t");
    Console.Write(emp.Designation + "\t \t");
    Console.Write(emp.DOJ.ToLongDateString());
    Console.WriteLine("\n");
}