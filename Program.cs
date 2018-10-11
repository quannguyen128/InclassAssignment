using System;
using System.Collections.Generic;
using System.Linq;

namespace InClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
           using(var db = new AppDbContext())
            {
                //no matter what, delete and then create 
                db.Database.EnsureDeleted();
                db.Database.EnsureCreated();

                    if(!db.Students.Any())
                    {
                        List<Student> students = new List<Student>()
                        {
                            new Student()
                            {
                                StudentID = 1,
                                FirstName = "Quan",
                                LastName = "Nguyen",
                                Role = "Senior"
                            },
                            new Student()
                            {
                                 StudentID = 2,
                                FirstName = "Trevor",
                                LastName = "Fleeman",
                                Role = "Senior"
                            },
                            new Student()
                            {
                                 StudentID = 3,
                                FirstName = "Arron",
                                LastName = "Hebert",
                                Role = "Senior"
                            },      
                             new Student()
                            {
                                 StudentID = 4,
                                FirstName = "Alexander",
                                LastName = "Roder",
                                Role = "Senior"
                            },    
                             new Student()
                            {
                                 StudentID = 5,
                                FirstName = "Alexander",
                                LastName = "McDonald",
                                Role = "Senior"
                            },       
                             new Student()
                            {
                                 StudentID = 6,
                                FirstName = "Amy",
                                LastName = "Saysouriyosack",
                                Role = "Senior"
                            },          
                             new Student()
                            {
                                 StudentID = 7,
                                FirstName = "Catherine",
                                LastName = "McGovern",
                                Role = "Senior"
                            }, 
                             new Student()
                            {
                                 StudentID = 8,
                                FirstName = "Casareo",
                                LastName = "Lona",
                                Role = "Senior"
                            }, 
                             new Student()
                            {
                                 StudentID = 9,
                                FirstName = "Charles",
                                LastName = "Coufal",
                                Role = "Senior"
                            }, 
                             new Student()
                            {
                                 StudentID = 10,
                                FirstName = "Claudia",
                                LastName = "Silva",
                                Role = "Senior"
                            }, 
                             new Student()
                            {
                                 StudentID = 11,
                                FirstName = "Cory",
                                LastName = "Williams",
                                Role = "Senior"
                            }, 
                             new Student()
                            {
                                 StudentID = 12,
                                FirstName = "Gabriela",
                                LastName = "Velenauela",
                                Role = "Senior"
                            }, 
                             new Student()
                            {
                                 StudentID = 13,
                                FirstName = "John",
                                LastName = "Cunningham",
                                Role = "Senior"
                            }, 
                             new Student()
                            {
                                 StudentID = 14,
                                FirstName = "Kayla",
                                LastName = "Washington",
                                Role = "Senior"
                            }, 
                             new Student()
                            {
                                 StudentID = 16,
                                FirstName = "Laith",
                                LastName = "Alfaloujeh",
                                Role = "Senior"
                            }, 
                             new Student()
                            {
                                 StudentID =17,
                                FirstName = "Mara",
                                LastName = "Kinoff",
                                Role = "Senior"
                            }, 
                             new Student()
                            {
                                 StudentID = 18,
                                FirstName = "Matthew",
                                LastName = "Webb",
                                Role = "Senior"
                            }, 
                             new Student()
                            {
                                 StudentID = 19,
                                FirstName = "Mekkala",
                                LastName = "Bourapa",
                                Role = "Senior"
                            }, 
                             new Student()
                            {
                                 StudentID = 20,
                                FirstName = "Micheal",
                                LastName = "Matthews",
                                Role = "Senior"
                            }, 
                             new Student()
                            {
                                 StudentID = 21,
                                FirstName = "Micheal",
                                LastName = "Hayes",
                                Role = "Senior"
                            }, 
                             new Student()
                            {
                                 StudentID = 22,
                                FirstName = "Phelps",
                                LastName = "Merrell",
                                Role = "Senior"
                            }, 
                             new Student()
                            {
                                 StudentID = 23,
                                FirstName = "Todd",
                                LastName = "Kile",
                                Role = "Senior"
                            }, 
                             new Student()
                            {
                                 StudentID = 24,
                                FirstName = "Yi Fu",
                                LastName = "Ji",
                                Role = "Senior"
                            }, 
                        };

                        db.Students.AddRange(students);  
                        db.SaveChanges();                                              
                    }
                    else 
                    {
                        var students = db.Students.ToList();
                        foreach(Student s in students)
                        {
                            Console.WriteLine(s);
                        }
                        
                        // Hopefully this chunk of code should print out students who are not seniors 
                        var studentsFiltered = students.Where(s => s.Role != "Senior");
                        /*var studentsFiltered = from s in db.Students
                                                 where s.Role != "Senior" 
                                                 select s;*/
                        foreach(Student s in students)
                        {
                            Console.WriteLine(s);
                        }
                        //This chunk of code should pull up a list of students whose first name starts with M                          
                         var namesWithM = from s in db.Students
                                            where s.FirstName.StartsWith("M")
                                            select s;
                          foreach(Student s in students)
                        {
                            Console.WriteLine(s);
                        }
                    //This chunk of code should pull up a list of students whose last name starts with L
                          var namesWithL = from s in db.Students
                                            where s.LastName.StartsWith("L")
                                            select s;
                          foreach(Student s in students)
                        {
                            Console.WriteLine(s);
                        }
                        
                        //this chunk should display the student John
                        var John = students.Where(s => s.FirstName == "John");
                           foreach(Student s in students)
                        {
                            Console.WriteLine(s);
                        }

                         //this chunk should display the student Alexander
                        var Alexander = students.Where(s => s.FirstName == "Alexander");
                           foreach(Student s in students)
                        {
                            Console.WriteLine(s);
                        }
                        
                        
                    //This chunk should sort students by first name
                         var studentsOrdered = db.Students
                                                 .OrderBy(s => s.FirstName);
                           foreach(Student s in students)
                        {
                            Console.WriteLine(s);
                        }
                    //Orders last name descending 
                        var studentsOrdered1 = db.Students
                                                 .OrderByDescending(s => s.LastName);
                           foreach(Student s in students)
                        {
                            Console.WriteLine(s);
                        }
            //This was as far as I got
                }       
                      


                    
            }    
        }
    }
}
    