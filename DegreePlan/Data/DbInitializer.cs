using DegreePlan.Models;
using System;
using System.Linq;

namespace DegreePlan.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            //context.Database.EnsureCreated();

            // Look for any Degrees.
            if (context.Degrees.Any())
            {
                Console.WriteLine("Degrees already exist.");
            }
            else
            {
                var degrees = new Degree[]
                {
                     new Degree{DegreeID = 1 , DegreeAbv = "ACS+2" , DegreeName = "MS ACS +2"},
                     new Degree{DegreeID = 2 , DegreeAbv = "ACS+DB" , DegreeName = "MS ACS+ DB"},
                     new Degree{DegreeID = 3 , DegreeAbv = "ACS+NF" , DegreeName = "MS ACS + NF"},
                     new Degree{DegreeID = 4 , DegreeAbv = "ACS" , DegreeName = "MS ACS"},
                };
                Console.WriteLine($"Inserted {degrees.Length} new degrees.");
                foreach (DegreePlan d in degrees)
                {
                    context.Degrees.Add(d);
                }
                context.SaveChanges();
            }
            if (context.Credits.Any())
            {
                Console.WriteLine("Credits already exist.");
            }
            else
            {
                var credits = new Credit[]
                {
                     new Credit{ CreditID =460 , CreditAbv ="DB" , CreditName ="Database" , IsSummer =0, IsSpring =1 , IsFall =1},
                     new Credit{ CreditID =356 , CreditAbv ="NF" , CreditName ="Network Fundamentals" , IsSummer =0, IsSpring =1 , IsFall =1},
                     new Credit{ CreditID =542 , CreditAbv ="542" , CreditName ="OOP with java" , IsSummer =0, IsSpring =1 , IsFall =1},
                     new Credit{ CreditID =563 , CreditAbv ="563" , CreditName ="Web apps" , IsSummer =0, IsSpring =1 , IsFall =1},
                     new Credit{ CreditID =560 , CreditAbv ="560" , CreditName ="Advanced Database" , IsSummer =1, IsSpring =1 , IsFall =1},
                     new Credit{ CreditID =664 , CreditAbv ="664-UX" , CreditName ="User Experience Design" , IsSummer =0, IsSpring =1 , IsFall =1},
                     new Credit{ CreditID =618 , CreditAbv ="618-PM" , CreditName ="Project management" , IsSummer =1, IsSpring =0 , IsFall =0},
                     new Credit{ CreditID =555 , CreditAbv ="555-NS" , CreditName ="Network Security" , IsSummer =0, IsSpring =1 , IsFall =1},
                     new Credit{ CreditID =691 , CreditAbv ="691-GDP1" , CreditName ="GDP1" , IsSummer =1, IsSpring =1 , IsFall =1},
                     new Credit{ CreditID =692 , CreditAbv ="692-GDP2" , CreditName ="GDP2" , IsSummer =0, IsSpring =1 , IsFall =1},
                     new Credit{ CreditID =64 , CreditAbv ="Mobile" , CreditName ="643 or 644 mobile" , IsSummer =0, IsSpring =1 , IsFall =1},
                     new Credit{ CreditID =10 , CreditAbv ="E1" , CreditName ="Elective1" , IsSummer =0, IsSpring =1 , IsFall =1},
                     new Credit{ CreditID =20 , CreditAbv ="E2" , CreditName ="Elective2" , IsSummer =0, IsSpring =1 , IsFall =1},

                };
                Console.WriteLine($"Inserted {credits.Length} new credits.");
                foreach (DegreePlan d in credits)
                {
                    context.Credits.Add(d);
                }
                context.SaveChanges();
            }
            if (context.DegreeCredits.Any())
            {
                Console.WriteLine("DegreeCredits already exist.");
            }
            else
            {
                var degreecredits = new DegreeCredit[]
                {
                        new DegreeCredit{ DegreeCreditID = 1 ,  DegreeID = 1 , CreditID = 460},
                        new DegreeCredit{ DegreeCreditID = 2 ,  DegreeID = 1 , CreditID = 356},
                        new DegreeCredit{ DegreeCreditID = 3 ,  DegreeID = 1 , CreditID = 542},
                        new DegreeCredit{ DegreeCreditID = 4 ,  DegreeID = 1 , CreditID = 563},
                        new DegreeCredit{ DegreeCreditID = 5 ,  DegreeID = 1 , CreditID = 560},
                        new DegreeCredit{ DegreeCreditID = 6 ,  DegreeID = 1 , CreditID = 664},
                        new DegreeCredit{ DegreeCreditID = 7 ,  DegreeID = 1 , CreditID = 618},
                        new DegreeCredit{ DegreeCreditID = 8 ,  DegreeID = 1 , CreditID = 555},
                        new DegreeCredit{ DegreeCreditID = 9 ,  DegreeID = 1 , CreditID = 691},
                        new DegreeCredit{ DegreeCreditID = 10 ,  DegreeID = 1 , CreditID = 692},
                        new DegreeCredit{ DegreeCreditID = 11 ,  DegreeID = 1 , CreditID = 64},
                        new DegreeCredit{ DegreeCreditID = 12 ,  DegreeID = 1 , CreditID = 10},
                        new DegreeCredit{ DegreeCreditID = 13 ,  DegreeID = 1 , CreditID = 20},

                };

                Console.WriteLine($"Inserted {degreecredits.Length} new degree credits.");
                foreach (DegreePlan d in degreecredits)
                {
                    context.DegreeCredits.Add(d);
                }
                context.SaveChanges();
            }
             if (context.Student.Any())
            {
                Console.WriteLine("Students already exist.");
            }
            else
            {
                var students = new Student[]
                {
                    new Student { StudentID=533619, FamilyName=Cheekoti, GivenName=Vennela, SID=S533619, CatPawsID=919568817},
                    new Student { StudentID=533907, FamilyName=Gade, GivenName=Susritha, SID=S533907, CatPawsID=919570703},
                    new Student { StudentID=533623, FamilyName=Gone, GivenName=Sathwika, SID=S533623, CatPawsID=919568816},


                };
                Console.WriteLine($"Inserted {students.Length} new students.");
                foreach (DegreePlan d in students)
                {
                    context.Student.Add(d);
                }
                context.SaveChanges();
            }
             if (context.DegreePlan.Any())
            {
                Console.WriteLine("DegreePlans already exist.");
            }
            else
            {
                var degreeplans = new Student[]
                {
                        new DegreePlan {DegreePlanID=7251, StudentID=533619, DegreePlanAbv=Super Fast, DegreePlanName=As Fast as I can, DegreeID=1},
                        new DegreePlan {DegreePlanID=7258, StudentID=533619, DegreePlanAbv=slow and Easy, DegreePlanName=As slow as I can, DegreeID=1},
                        new DegreePlan {DegreePlanID=7253, StudentID=533623, DegreePlanAbv=Super Fast, DegreePlanName=As Fast as I can, DegreeID=1},
                        new DegreePlan {DegreePlanID=7255, StudentID=533907, DegreePlanAbv=Slow and Easy, DegreePlanName=As slow as I can, DegreeID=1},
                        new DegreePlan {DegreePlanID=7257, StudentID=533907, DegreePlanAbv=Super Fast, DegreePlanName=As Fast as I can, DegreeID=1},
                        new DegreePlan {DegreePlanID=7254, StudentID=533623, DegreePlanAbv=Slow and Easy, DegreePlanName=As slow as I can, DegreeID=1},


                };
                Console.WriteLine($"Inserted {degreeplans.Length} new students.");
                foreach (DegreePlan d in degreeplans)
                {
                    context.DegreePlan.Add(d);
                }
                context.SaveChanges();
            }
        }

    }
}