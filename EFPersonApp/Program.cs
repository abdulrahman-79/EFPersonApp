using EFPersonApp;
using System.Data.Common;

using (var db = new AppDbContext())
{
    db.Database.EnsureCreated();

    while(true)
    {
        foreach (var p in db.EfPerson)
        {
            Console.WriteLine($"Name: {p.Name} ----- Age: {p.Age}");
            Console.WriteLine("\n");
        }


        int NewAge;
        while (true)
        {
            Console.WriteLine("Enter Age: ");
            string? ageInput = Console.ReadLine();

            if (int.TryParse(ageInput, out NewAge))
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }


        Console.WriteLine("Enter Name: ");
        string? NewName = Console.ReadLine();

        db.EfPerson.Add(new Person
        {
            Age = NewAge,
            Name = NewName ?? ""
        });
        db.SaveChanges();

        Console.WriteLine("Do you want to add another entry? y/n");
        char ans = (char)Console.Read();
        if (ans == 'n')
        {
            break;
        }
    }

}
