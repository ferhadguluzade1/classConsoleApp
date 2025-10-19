using Program1;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

Student[] Students = new Student[20];
string newStudent;
string deleteStudent;
string favStudents;

Console.WriteLine("Emeliyyat nomresi sec: ");
int secim = Convert.ToInt32(Console.ReadLine());

if (secim >= 0 && secim < 5)
{
    Console.WriteLine("Duz reqem secildi");
    goto main;
}

main:

while (secim <= 4)
{
    goto condition;
}

condition:

if (secim == 1)
    Console.WriteLine("Create New Student");
else if (secim == 2)
    Console.WriteLine("Delete Student");
    if (secim == 2)
    {
        Students = new Student[0];
        Console.WriteLine(Students);
    }

else if (secim == 3)
    Console.WriteLine("Print All Student");

else if (secim == 4)
{
    Console.WriteLine("Print Fav Students");
    string fav;
    fav = Console.ReadLine();
    Console.WriteLine(fav);
    double grade = Convert.ToDouble(Console.ReadLine());

    if (grade > 90 && grade < 101)
    {
        favStudents = fav;
    }
}
else
    Console.WriteLine("Exit");
