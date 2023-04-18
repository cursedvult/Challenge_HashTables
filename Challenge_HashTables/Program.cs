using System.Collections;

namespace Challenge_HashTables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student[] students =
            {
                new Student(1, "Denis", 88),
                new Student(2, "Olaf", 97),
                new Student(6, "Ragner", 65),
                new Student(1, "Luise", 73),
                new Student(4, "Levi", 58),                         
            };
            Hashtable ht = new Hashtable();
            for (int i = 0; i < students.Length; i++) 
            {
                Student temp = students[i];               
                if (!ht.ContainsKey(temp.Id))
                {
                    ht.Add(students[i].Id, students[i]);
                }
                else 
                {
                    Console.WriteLine("Sorry, a student with the same ID was already registered!");
                }
            }
            foreach (Student value in ht.Values)
            {
                Console.WriteLine(value.Id);
                Console.WriteLine(value.Name);
                Console.WriteLine(value.GPA);
            }
        }
    }
}