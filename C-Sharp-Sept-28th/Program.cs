using System;

namespace C_Sharp_Sept_28th
{
    class Program
    {
        static void Main(string[] args)
        {
            // BootCamp Corriculum

            var gitgithub = new Topic();
            //gitgithub.Id = 400;
            gitgithub.Name = "Git/GitHub";
            gitgithub.Category = "SCM"; // Source Control Management
            gitgithub.Difficulty = 2; // level 1 - 3 (easy - hard)
            gitgithub.print();

            var sqlserver = new Topic()
            {
                Name = "SQL Server",
                Category = "Database",
                Difficulty = 3
            };
            sqlserver.print();

        }
    }
}
