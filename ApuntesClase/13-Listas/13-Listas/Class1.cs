using System;

public class Dictionary
{
	class StudentName
	{
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Id { get; set; }
	}

    public static void Main()
    {
        var student = new Dictionary<int, StudentName>()
        {
            { 111, new StudentName { Nombre = "Manolo", Apellido = "Romero", Id = 1}},
            { 112, new StudentName { Nombre = "Steven", Apellido = "Scalzo", Id = 2}},
            { 113, new StudentName { Nombre = "David", Apellido = "Alfageme", Id = 3}}
        };

        foreach(var index in Enumerable.Range(111, 3))
        {
            Console.WriteLine($"Student {index} is {students[index].Nombre} {students[index].Apellido}");
        }
        Console.WriteLine();

        var students2 = new Dictionary<int, StudentName>()
        {
            [111] = new StudentName { Nombre = "Manolo", Apellido = "Romero", Id = 1 },
            [112] = new StudentName { Nombre = "Steven", Apellido = "Scalzo", Id = 2 },
            [113] = new StudentName { Nombre = "David", Apellido = "Alfageme", Id = 3 }
        };

        foreach(var index in Enumerable.Range(111, 3))
        {
            Console.WriteLine($"Student {index} is {students[index].FirstName} {students[index].LastName}");
        }
    }
}
