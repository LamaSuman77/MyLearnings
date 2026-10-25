using System;

string name = "Suman Tamang";
string role = "Software Developer";
string email = "suman@gmail.com";

string[] skills = { "Problem Solver", "Debugger" };
string[] projects =
{
    "Hotel Management System",
    "Moneezy - Financial App",
    "Sewe Mile - App that helps elderly people get care from their sons"
};

Console.WriteLine("=================================");
Console.WriteLine($"   {name}");
Console.WriteLine($"   {role}");
Console.WriteLine("=================================");
Console.WriteLine();

Console.WriteLine($"Email : {email}");
Console.WriteLine();

Console.WriteLine("SKILLS");
foreach (string skill in skills)
{
    Console.WriteLine($"  - {skill}");
}
Console.WriteLine();

Console.WriteLine("PROJECTS");
foreach (string project in projects)
{
    Console.WriteLine($"  - {project}");
}
Console.WriteLine();

Console.WriteLine("Press any key to exit...");
Console.ReadKey();