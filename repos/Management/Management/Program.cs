using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management.Main
{

    class ExcuteResult
    {
        static int MainMenu()
        {
            int mm;
            Console.Clear();
            Console.WriteLine(" \t \t \t \t \t \t****************************");
            Console.WriteLine(" \t \t \t \t \t \t*Welcome to User Management*");
            Console.WriteLine(" \t \t \t \t \t \t****************************");
            Console.WriteLine(" \t \t \t \t \t \t*1. Lecturers Management   *");
            Console.WriteLine(" \t \t \t \t \t \t*2. Students Management    *");
            Console.WriteLine(" \t \t \t \t \t \t*3. Exit                   *");
            Console.WriteLine(" \t \t \t \t \t \t****************************");
            Console.Write(" \t \t \t \t \t \tChoose function [1--3]: ");
            string m2 = Console.ReadLine();
            while (m2.Length != 1 || !int.TryParse(m2, out mm) || mm < 1 || mm > 3)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" \t \t \t \t \t \tError invalid entry!");
                Console.ResetColor();
                Console.Write(" \t \t \t \t \t \tChoose function [1--3]: ");
                m2 = Console.ReadLine();
            }
            return mm;
        }
        static int MenuStdManagement()
        {
            int mstd;
            Console.Clear();
            Console.WriteLine(" \t \t \t \t \t \t**********************************");
            Console.WriteLine(" \t \t \t \t \t \t*  Welcome to Student Management *");
            Console.WriteLine(" \t \t \t \t \t \t**********************************");
            Console.WriteLine(" \t \t \t \t \t \t*1.	Add new student          *");
            Console.WriteLine(" \t \t \t \t \t \t*2.	View all students        *");
            Console.WriteLine(" \t \t \t \t \t \t*3.	Search students by ID    *");
            Console.WriteLine(" \t \t \t \t \t \t*4.	Search students by Name  *");
            Console.WriteLine(" \t \t \t \t \t \t*5.	Delete students          *");
            Console.WriteLine(" \t \t \t \t \t \t*6.	Update student           *");
            Console.WriteLine(" \t \t \t \t \t \t*7.	Back to main menu        *");
            Console.WriteLine(" \t \t \t \t \t \t**********************************");
            Console.Write(" \t \t \t \t \t \tPlease choose function [1--7]: ");
            string mstd2 = Console.ReadLine();
            while (!int.TryParse(mstd2, out mstd) || mstd2.Length != 1 || mstd < 1 || mstd > 7)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" \t \t \t \t \t \tError invalid entry!");
                Console.ResetColor();
                Console.Write(" \t \t \t \t \t \tPlease choose function [1--7]: ");
                mstd2 = Console.ReadLine();
            }
            return mstd;
        }
        static int MenuLecManagement()
        {
            int mlec;
            Console.Clear();
            Console.WriteLine(" \t \t \t \t \t \t********************************");
            Console.WriteLine(" \t \t \t \t \t \t*Welcome to Lecturer Management*");
            Console.WriteLine(" \t \t \t \t \t \t********************************");
            Console.WriteLine(" \t \t \t \t \t \t*1.	Add new lecturer       *");
            Console.WriteLine(" \t \t \t \t \t \t*2.	View all lecturers     *");
            Console.WriteLine(" \t \t \t \t \t \t*3.	Search lecturer by ID  *");
            Console.WriteLine(" \t \t \t \t \t \t*4.	Search lecturer by Name*");
            Console.WriteLine(" \t \t \t \t \t \t*5.	Delete lecturers       *");
            Console.WriteLine(" \t \t \t \t \t \t*6.	Update lecturer        *");
            Console.WriteLine(" \t \t \t \t \t \t*7.	Back to main menu      *");
            Console.WriteLine(" \t \t \t \t \t \t********************************");
            Console.Write(" \t \t \t \t \t \tPlease choose function [1--7]: ");
            string mlec2 = Console.ReadLine();
            while (mlec2.Length != 1 || !int.TryParse(mlec2, out mlec) || mlec < 1 || mlec > 7)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" \t \t \t \t \t \tError invalid entry!");
                Console.ResetColor();
                Console.Write(" \t \t \t \t \t \tPlease choose function [1--7]: ");
                mlec2 = Console.ReadLine();
            }
            return mlec;
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            StudentManagement stdM = new StudentManagement();
            LecturerManagement lecM = new LecturerManagement();
            lecM.ReadLecturerList();
            stdM.ReadStudentList();
            int m;
            do
            {
            Menu:
                switch (m = MainMenu())
                {
                    case 1:
                    Lecturer:
                        Console.Clear();
                        switch (MenuLecManagement())
                        {
                            case 1:
                                Console.Clear();
                                lecM.AddNewLecturer();
                                goto Lecturer;
                            case 2:
                                Console.Clear();
                                lecM.SaveList();
                                lecM.ViewListLecturer();
                                goto Lecturer;
                            case 3:
                                Console.Clear();
                                lecM.SearchIDLecturer();
                                goto Lecturer;
                            case 4:
                                Console.Clear();
                                lecM.SearchNameLecturer();
                                goto Lecturer;
                            case 5:
                                Console.Clear();
                                lecM.DeleteLecturerInf();
                                goto Lecturer;
                            case 6:
                                Console.Clear();
                                lecM.EditLecturerInf();
                                goto Lecturer;
                            case 7:
                                goto Menu;
                            default:
                                break;
                        }
                        break;
                    case 2:
                    Student:
                        Console.Clear();
                        do
                        {
                            switch (MenuStdManagement())
                            {
                                case 1:
                                    Console.Clear();
                                    stdM.AddNewStudent();
                                    goto Student;
                                case 2:
                                    Console.Clear();
                                    stdM.ViewListStudent();
                                    stdM.SaveList();
                                    goto Student;
                                case 3:
                                    Console.Clear();
                                    stdM.SearchIDStudent();
                                    goto Student;
                                case 4:
                                    Console.Clear();
                                    stdM.SearchNameStudent();
                                    goto Student;
                                case 5:
                                    Console.Clear();
                                    stdM.DeleteStudentInf();
                                    goto Student;
                                case 6:
                                    Console.Clear();
                                    stdM.EditStudentInf();
                                    goto Student;
                                case 7: goto Menu;
                                default:
                                    break;
                            }
                        } while (m != 7);
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;
                    default: break;
                }
            } while (m != 3);
        }
    }
}
