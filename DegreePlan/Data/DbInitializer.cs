
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
                     new Degree{DegreeId = 1 , DegreeAbv = "ACS+2" , DegreeName = "MS ACS +2"},
                     new Degree{DegreeId = 2 , DegreeAbv = "ACS+DB" , DegreeName = "MS ACS+ DB"},
                     new Degree{DegreeId = 3 , DegreeAbv = "ACS+NF" , DegreeName = "MS ACS + NF"},
                     new Degree{DegreeId = 4 , DegreeAbv = "ACS" , DegreeName = "MS ACS"},
                };
                Console.WriteLine($"Inserted {degrees.Length} new degrees.");
                foreach (Degree d in degrees)
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
                     new Credit{ CreditId =460 , CreditAbv ="DB" , CreditName ="Database" , IsSummer =0, IsSpring =1 , IsFall =1},
                     new Credit{ CreditId =356 , CreditAbv ="NF" , CreditName ="Network Fundamentals" , IsSummer =0, IsSpring =1 , IsFall =1},
                     new Credit{ CreditId =542 , CreditAbv ="542" , CreditName ="OOP with java" , IsSummer =0, IsSpring =1 , IsFall =1},
                     new Credit{ CreditId =563 , CreditAbv ="563" , CreditName ="Web apps" , IsSummer =0, IsSpring =1 , IsFall =1},
                     new Credit{ CreditId =560 , CreditAbv ="560" , CreditName ="Advanced Database" , IsSummer =1, IsSpring =1 , IsFall =1},
                     new Credit{ CreditId =664 , CreditAbv ="664-UX" , CreditName ="User Experience Design" , IsSummer =0, IsSpring =1 , IsFall =1},
                     new Credit{ CreditId =618 , CreditAbv ="618-PM" , CreditName ="Project management" , IsSummer =1, IsSpring =0 , IsFall =0},
                     new Credit{ CreditId =555 , CreditAbv ="555-NS" , CreditName ="Network Security" , IsSummer =0, IsSpring =1 , IsFall =1},
                     new Credit{ CreditId =691 , CreditAbv ="691-GDP1" , CreditName ="GDP1" , IsSummer =1, IsSpring =1 , IsFall =1},
                     new Credit{ CreditId =692 , CreditAbv ="692-GDP2" , CreditName ="GDP2" , IsSummer =0, IsSpring =1 , IsFall =1},
                     new Credit{ CreditId =64 , CreditAbv ="Mobile" , CreditName ="643 or 644 mobile" , IsSummer =0, IsSpring =1 , IsFall =1},
                     new Credit{ CreditId =10 , CreditAbv ="E1" , CreditName ="Elective1" , IsSummer =0, IsSpring =1 , IsFall =1},
                     new Credit{ CreditId =20 , CreditAbv ="E2" , CreditName ="Elective2" , IsSummer =0, IsSpring =1 , IsFall =1},

                };
                Console.WriteLine($"Inserted {credits.Length} new credits.");
                foreach (Credit d in credits)
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
                        new DegreeCredit{ DegreeCreditId = 1 ,  DegreeId = 1 , CreditId = 460},
                        new DegreeCredit{ DegreeCreditId = 2 ,  DegreeId = 1 , CreditId = 356},
                        new DegreeCredit{ DegreeCreditId = 3 ,  DegreeId = 1 , CreditId = 542},
                        new DegreeCredit{ DegreeCreditId = 4 ,  DegreeId = 1 , CreditId = 563},
                        new DegreeCredit{ DegreeCreditId = 5 ,  DegreeId = 1 , CreditId = 560},
                        new DegreeCredit{ DegreeCreditId = 6 ,  DegreeId = 1 , CreditId = 664},
                        new DegreeCredit{ DegreeCreditId = 7 ,  DegreeId = 1 , CreditId = 618},
                        new DegreeCredit{ DegreeCreditId = 8 ,  DegreeId = 1 , CreditId = 555},
                        new DegreeCredit{ DegreeCreditId = 9 ,  DegreeId = 1 , CreditId = 691},
                        new DegreeCredit{ DegreeCreditId = 10 ,  DegreeId = 1 , CreditId = 692},
                        new DegreeCredit{ DegreeCreditId = 11 ,  DegreeId = 1 , CreditId = 64},
                        new DegreeCredit{ DegreeCreditId = 12 ,  DegreeId = 1 , CreditId = 10},
                        new DegreeCredit{ DegreeCreditId = 13 ,  DegreeId = 1 , CreditId = 20},

                };

                Console.WriteLine($"Inserted {degreecredits.Length} new degree credits.");
                foreach (DegreeCredit d in degreecredits)
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
                    new Student { StudentId=533619, FamilyName="Cheekoti", GivenName="Vennela", SID="S533619", CatPawsID=919568817},
                    new Student { StudentId=533907, FamilyName="Gade", GivenName="Susritha", SID="S533907", CatPawsID=919570703},
                    new Student { StudentId=533623, FamilyName="Gone", GivenName="Sathwika", SID="S533623", CatPawsID=919568816},


                };
                Console.WriteLine($"Inserted {students.Length} new students.");
                foreach (Student d in students)
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
                var degreeplans = new Degreeplan[]
                {
                        new Degreeplan {DegreeplanId=7251, StudentId=533619, DegreePlanAbv="Super Fast", DegreePlanName="As Fast as I can", DegreeId=1},
                        new Degreeplan {DegreeplanId=7258, StudentId=533619, DegreePlanAbv="slow and Easy", DegreePlanName="As slow as I can", DegreeId=1},
                        new Degreeplan {DegreeplanId=7253, StudentId=533623, DegreePlanAbv="Super Fast", DegreePlanName="As Fast as I can", DegreeId=1},
                        new Degreeplan {DegreeplanId=7255, StudentId=533907, DegreePlanAbv="Slow and Easy", DegreePlanName="As slow as I can", DegreeId=1},
                        new Degreeplan {DegreeplanId=7257, StudentId=533907, DegreePlanAbv="Super Fast", DegreePlanName="As Fast as I can", DegreeId=1},
                        new Degreeplan {DegreeplanId=7254, StudentId=533623, DegreePlanAbv="Slow and Easy", DegreePlanName="As slow as I can", DegreeId=1},


                };
                Console.WriteLine($"Inserted {degreeplans.Length} new students.");
                foreach (Degreeplan d in degreeplans)
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
                    new StudentTerm{ StudentTermId = 1 ,  Term = 1 , TermAbv = "S18 ", TermName = "Spring 2018" , DegreeplanId = 7258},
                    new StudentTerm { StudentTermId = 2,  Term = 2, TermAbv = "Su18", TermName = "Summer 2018", DegreeplanId = 7258 },
                    new StudentTerm { StudentTermId = 3,  Term = 3, TermAbv = "F18", TermName = "Fall 2018", DegreeplanId = 7258 },
                    new StudentTerm { StudentTermId = 4,  Term = 4, TermAbv = "S19", TermName = "Spring 2019", DegreeplanId = 7258 },
                    new StudentTerm { StudentTermId = 5,  Term = 5, TermAbv = "Su19", TermName = "Summer 2019", DegreeplanId = 7258 },
                    new StudentTerm { StudentTermId = 6,  Term = 6, TermAbv = "F19", TermName = "Fall 2019", DegreeplanId = 7258 },
                    new StudentTerm { StudentTermId = 7,  Term = 1, TermAbv = "F19", TermName = "Fall 2019", DegreeplanId = 7255 },
                    new StudentTerm { StudentTermId = 8,  Term = 2, TermAbv = "S20", TermName = "Spring 2020", DegreeplanId = 7255 },
                    new StudentTerm { StudentTermId = 9,  Term = 3, TermAbv = "Su20", TermName = "Summer 2020", DegreeplanId = 7255 },
                    new StudentTerm { StudentTermId = 10, Term = 4, TermAbv = "F20", TermName = "Fall 2020", DegreeplanId = 7255 },
                    new StudentTerm { StudentTermId = 11, Term = 5, TermAbv = "S21", TermName = "Spring 2021", DegreeplanId = 7255 },
                    new StudentTerm { StudentTermId = 12,  Term = 1, TermAbv = "F18", TermName = "Fall2018", DegreeplanId = 7254 },
                    new StudentTerm { StudentTermId = 13,  Term = 2, TermAbv = "S19", TermName = "Spring2019", DegreeplanId = 7254 },
                    new StudentTerm { StudentTermId = 14,  Term = 3, TermAbv = "SU19", TermName = "Summer2019", DegreeplanId = 7254 },
                    new StudentTerm { StudentTermId = 15,  Term = 4, TermAbv = "F20", TermName = "Fall2019", DegreeplanId = 7254 },
                    new StudentTerm { StudentTermId = 16, Term = 5, TermAbv = "S20", TermName = "Spring2020", DegreeplanId = 7254 },

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
                    new Slot{ SlotId = 1, DegreePlanId = 7255,  Term = 1, CreditId = 356,Status="C"},
                    new Slot{ SlotId = 2, DegreePlanId = 7255,  Term = 1, CreditId = 542,Status="C"},
                    new Slot{ SlotId = 3, DegreePlanId = 7255,  Term = 1, CreditId = 563,Status="C"},
                    new Slot{ SlotId = 4, DegreePlanId = 7255,  Term = 1, CreditId = 460,Status="C"},
                    new Slot{ SlotId = 5, DegreePlanId = 7255,  Term = 2, CreditId = 560,Status="A"},
                    new Slot{ SlotId = 6, DegreePlanId = 7255,  Term = 2, CreditId = 664,Status="A"},
                    new Slot{ SlotId = 7, DegreePlanId = 7255,  Term = 2, CreditId = 64,Status="A"},
                    new Slot{ SlotId = 8, DegreePlanId = 7255,  Term = 3, CreditId = 618,Status="P"},
                    new Slot{ SlotId = 9, DegreePlanId = 7255,  Term = 3, CreditId = 691,Status="P"},
                    new Slot{ SlotId = 10, DegreePlanId = 7255,  Term = 4, CreditId = 10,Status="P"},
                    new Slot{ SlotId = 11, DegreePlanId = 7255,  Term = 4, CreditId = 555,Status="P"},
                    new Slot{ SlotId = 12, DegreePlanId = 7255,  Term = 5, CreditId = 20,Status="P"},
                    new Slot{ SlotId = 13, DegreePlanId = 7255,  Term = 5, CreditId = 692,Status="P"},


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