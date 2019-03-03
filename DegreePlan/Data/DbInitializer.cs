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
             if (context.Students.Any())
            {
                Console.WriteLine("Students already exist.");
            }
            else
            {
                var students = new Student[]
                {
                    new Student { StudentID=533619, FamilyName="Cheekoti", GivenName="Vennela", SID=S533619, CatPawsID=919568817},
                    new Student { StudentID=533907, FamilyName="Gade", GivenName="Susritha", SID=S533907, CatPawsID=919570703},
                    new Student { StudentID=533623, FamilyName="Gone", GivenName="Sathwika", SID=S533623, CatPawsID=919568816},


                };
                Console.WriteLine($"Inserted {students.Length} new students.");
                foreach (DegreePlan d in students)
                {
                    context.Students.Add(d);
                }
                context.SaveChanges();
            }
             if (context.DegreePlans.Any())
            {
                Console.WriteLine("DegreePlans already exist.");
            }
            else
            {
                var degreeplans = new Student[]
                {
                        new DegreePlan {DegreePlanID=7251, StudentID=533619, DegreePlanAbv="Super Fast", DegreePlanName="As Fast as I can", DegreeID=1},
                        new DegreePlan {DegreePlanID=7258, StudentID=533619, DegreePlanAbv="slow and Easy", DegreePlanName="As slow as I can", DegreeID=1},
                        new DegreePlan {DegreePlanID=7253, StudentID=533623, DegreePlanAbv="Super Fast", DegreePlanName="As Fast as I can", DegreeID=1},
                        new DegreePlan {DegreePlanID=7255, StudentID=533907, DegreePlanAbv="Slow and Easy", DegreePlanName="As slow as I can", DegreeID=1},
                        new DegreePlan {DegreePlanID=7257, StudentID=533907, DegreePlanAbv="Super Fast", DegreePlanName="As Fast as I can", DegreeID=1},
                        new DegreePlan {DegreePlanID=7254, StudentID=533623, DegreePlanAbv="Slow and Easy", DegreePlanName="As slow as I can", DegreeID=1},


                };
                Console.WriteLine($"Inserted {degreeplans.Length} new students.");
                foreach (DegreePlan d in degreeplans)
                {
                    context.DegreePlans.Add(d);
                }
                context.SaveChanges();
            }
            if (context.StudentTerms.Any())
            {
                Console.WriteLine("StudentTerm already exist.");
            }
            else
            {
                var Studentterms = new StudentTerm[]
                {
                    new StudentTerm{ StudenTermID = 1 , StudentID = 533619 , Term = 1 , TermAbv = "S18 ", TermName = "Spring 2018" , DegreeplanID = 7258},
                    new StudentTerm { StudenTermID = 2, StudentID = 533619, Term = 2, TermAbv = "Su18", TermName = "Summer 2018", DegreeplanID = 7258 },
                    new StudentTerm { StudenTermID = 3, StudentID = 533619, Term = 3, TermAbv = "F18", TermName = "Fall 2018", DegreeplanID = 7258 },
                    new StudentTerm { StudenTermID = 4, StudentID = 533619, Term = 4, TermAbv = "S19", TermName = "Spring 2019", DegreeplanID = 7258 },
                    new StudentTerm { StudenTermID = 5, StudentID = 533619, Term = 5, TermAbv = "Su19", TermName = "Summer 2019", DegreeplanID = 7258 },
                    new StudentTerm { StudenTermID = 6, StudentID = 533619, Term = 6, TermAbv = "F19", TermName = "Fall 2019", DegreeplanID = 7258 },
                    new StudentTerm { StudenTermID = 7, StudentID = 533623, Term = 1, TermAbv = "F19", TermName = "Fall 2019", DegreeplanID = 7255 },
                    new StudentTerm { StudenTermID = 8, StudentID = 533623, Term = 2, TermAbv = "S20", TermName = "Spring 2020", DegreeplanID = 7255 },
                    new StudentTerm { StudenTermID = 9, StudentID = 533623, Term = 3, TermAbv = "Su20", TermName = "Summer 2020", DegreeplanID = 7255 },
                    new StudentTerm { StudenTermID = 10,StudentID = 533623, Term = 4, TermAbv = "F20", TermName = "Fall 2020", DegreeplanID = 7255 },
                    new StudentTerm { StudenTermID = 11, StudentID = 533623, Term = 5, TermAbv = "S21", TermName = "Spring 2021", DegreeplanID = 7255 },
                    new StudentTerm { StudenTermID = 12, StudentID = 533907, Term = 1, TermAbv = "F18", TermName = "Fall2018", DegreeplanID = 7254 },
                    new StudentTerm { StudenTermID = 13, StudentID = 533907, Term = 2, TermAbv = "S19", TermName = "Spring2019", DegreeplanID = 7254 },
                    new StudentTerm { StudenTermID = 14, StudentID = 533907, Term = 3, TermAbv = "SU19", TermName = "Summer2019", DegreeplanID = 7254 },
                    new StudentTerm { StudenTermID = 15, StudentID = 533907, Term = 4, TermAbv = "F20", TermName = "Fall2019", DegreeplanID = 7254 },
                    new StudentTerm { StudenTermID = 16, StudentID = 533907, Term = 5, TermAbv = "S20", TermName = "Spring2020", DegreeplanID = 7254 },

                };
                Console.WriteLine($"Inserted {Studentterms.Length} new degrees.");
                foreach (StudentTerm d in Studentterms)
                {
                    context.StudentTerms.Add(d);
                }
                context.SaveChanges();
            }
            if (context.Slots.Any())
            {
                Console.WriteLine("Slot already exist.");
            }
            else
            {
                var Slots = new Slot[]
                {
                    new Slot{ SlotID = 1, DegreePlan = 7255,  Term = 1, CreditID = 356,Status="C"},
                    new Slot{ SlotID = 2, DegreePlan = 7255,  Term = 1, CreditID = 542,Status="C"},
                    new Slot{ SlotID = 3, DegreePlan = 7255,  Term = 1, CreditID = 563,Status="C"},
                    new Slot{ SlotID = 4, DegreePlan = 7255,  Term = 1, CreditID = 460,Status="C"},
                    new Slot{ SlotID = 5, DegreePlan = 7255,  Term = 2, CreditID = 560,Status="A"},
                    new Slot{ SlotID = 6, DegreePlan = 7255,  Term = 2, CreditID = 664,Status="A"},
                    new Slot{ SlotID = 7, DegreePlan = 7255,  Term = 2, CreditID = 64,Status="A"},
                    new Slot{ SlotID = 8, DegreePlan = 7255,  Term = 3, CreditID = 618,Status="P"},
                    new Slot{ SlotID = 9, DegreePlan = 7255,  Term = 3, CreditID = 691,Status="P"},
                    new Slot{ SlotID = 10, DegreePlan = 7255,  Term = 4, CreditID = 10,Status="P"},
                    new Slot{ SlotID = 11, DegreePlan = 7255,  Term = 4, CreditID = 555,Status="P"},
                    new Slot{ SlotID = 12, DegreePlan = 7255,  Term = 5, CreditID = 20,Status="P"},
                    new Slot{ SlotID = 13, DegreePlan = 7255,  Term = 5, CreditID = 692,Status="P"},


                };
                Console.WriteLine($"Inserted {Slots.Length} new degrees.");
                foreach (Slot d in Slots)
                {
                    context.Slots.Add(d);
                }
                context.SaveChanges();
            }

        }

    }
}