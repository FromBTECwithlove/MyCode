using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace Management
{
    public struct StdInformation
    {
        public string stdId;
        public string stdName;
        public string stdEmail;
        public string stdAddress;
        public int stdPhone;
        public DateTime stdDoB;
        public string stdBatch;
        public void AddNStd()
        {
            Console.WriteLine(" \t \t \t \t \t \t**********************************");
            Console.WriteLine(" \t \t \t \t \t \t*Enter the information of student*");
            Console.WriteLine(" \t \t \t \t \t \t**********************************");
            do
            {
                Console.Write("Enter ID of student like GTxxxxx or GCxxxxx: x is a number [0 - 9], ex (GT12345): ");
                stdId = Console.ReadLine();
                string ID = @"[^GT]\d{5}$";
                if (stdId.Length != 7 || stdId != ID)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Try again Enter ID with format, please!");
                    Console.ResetColor();
                }
            } while (stdId.Length != 7);
            Console.WriteLine("ID of student :{0}", stdId);
            do
            {
                Console.Write("Enter student's name : ");
                stdName = Console.ReadLine().ToUpper();
                if (stdName == "")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please enter the name of student!");
                    Console.ResetColor();
                }
            } while (stdName == "");
            do
            {
                Console.Write("Enter Email of student: ");
                stdEmail = Console.ReadLine().ToUpper();
                if (stdEmail == "")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please enter email of student!");
                    Console.ResetColor();
                }
            } while (stdEmail == "");
            do
            {
                Console.Write("Enter Address of student: ");
                stdAddress = Console.ReadLine().ToUpper();
                if (stdAddress == "")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please enter address of student!");
                    Console.ResetColor();
                }
            } while (stdAddress == "");
            Console.Write("Enter the phone number of Student: ");
            string Sdt = Console.ReadLine();
            while (!int.TryParse(Sdt, out stdPhone) || stdPhone < 1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error invalid entry!");
                Console.ResetColor();
                Console.Write("Enter the phone number of Student: ");
                Sdt = Console.ReadLine();
            }
            Console.WriteLine("The phone of Student:{0} ", Sdt);
            Console.Write("Enter DOB of student (yyyy/MM/dd): ");
            string dateOfB = Console.ReadLine();
            while (!DateTime.TryParse(dateOfB, out stdDoB))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error invalid entry!");
                Console.ResetColor();
                Console.Write("Enter DOB of student (yyyy/MM/dd): ");
                dateOfB = Console.ReadLine();
            }
            Console.WriteLine("DOB of student: {0}", dateOfB);
            do
            {
                Console.Write("Enter the batch of the student: ");
                stdBatch = Console.ReadLine().ToUpper();
                if (stdBatch == "")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please enter the batch of student!");
                    Console.ResetColor();
                }
            } while (stdBatch == "");
        }
        public void ViewLStd()
        {
            Console.WriteLine();
            Console.WriteLine(" \t \t \t \t******************************************************");
            Console.WriteLine(" \t \t \t \t* \t \t View list of student \t \t     *");
            Console.WriteLine(" \t \t \t \t******************************************************");
            Console.WriteLine(" \t \t \t \t*ID           :{0} ", stdId + "\t\t\t\t     *");
            Console.WriteLine(" \t \t \t \t*Name         :{0} ", stdName + "\t\t\t     *");
            Console.WriteLine(" \t \t \t \t*Email        :{0} ", stdEmail + "\t\t     *");
            Console.WriteLine(" \t \t \t \t*Address      :{0} ", stdAddress + "  *");
            Console.WriteLine(" \t \t \t \t*Phone        :{0} ", stdPhone + "\t\t\t     *");
            Console.WriteLine(" \t \t \t \t*DoB          :{0} ", stdDoB.ToString("dd/MM/yyyy") + "\t\t\t     *");
            Console.WriteLine(" \t \t \t \t*Batch        :{0} ", stdBatch + "\t\t\t     *");
            Console.WriteLine(" \t \t \t \t******************************************************");
            Console.WriteLine();
        }
        const string fileName = "StudentManagement.dat";
        public void Save(BinaryWriter binaryWriter)
        {
            binaryWriter.Write(stdId);
            binaryWriter.Write(stdName);
            binaryWriter.Write(stdEmail);
            binaryWriter.Write(stdAddress);
            binaryWriter.Write(stdPhone);
            binaryWriter.Write(stdDoB.ToString());
            binaryWriter.Write(stdBatch);
        }

        public void Load(BinaryReader binaryReader)
        {
            stdId = binaryReader.ReadString();
            stdName = binaryReader.ReadString();
            stdEmail = binaryReader.ReadString();
            stdAddress = binaryReader.ReadString();
            stdPhone = binaryReader.ReadInt32();
            stdDoB = DateTime.Parse(binaryReader.ReadString());
            stdBatch = binaryReader.ReadString();
        }
    }

    public struct StudentManagement
    {
        private List<StdInformation> Data;
        public void AddNewStudent()
        {
            string r;
            do
            {
                StdInformation stdF = new StdInformation();
                stdF.AddNStd();
                Data.Add(stdF);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Do you want to continue? (y: Yes / Enter: No): \t");
                r = Console.ReadLine().ToLower();
                Console.ResetColor();
            } while (r.Equals("y"));
        }
        private const string FileN = "b.dat";
        public void ViewListStudent()
        {
            if (File.Exists(FileN))
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("In list of student have {0} student!", Data.Count);
                Console.ResetColor();
                Console.WriteLine("Press enter to continue =>.");
                Console.ReadLine();
                foreach (StdInformation item in Data)
                {
                    item.ViewLStd();
                    Console.WriteLine(" \t \t \t \tEnter to see the next student...!");
                    Console.ReadLine();
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Have not student in list..!!!");
                Console.ResetColor();
                Console.WriteLine("Press enter to continue =>.");
                Console.ReadLine();
            }
        }
        public void SaveList()
        {
            BinaryWriter bw = new BinaryWriter(new FileStream(FileN, FileMode.Create));
            bw.Write(Data.Count);
            foreach (StdInformation item in Data)
            {
                item.Save(bw);
            }
            bw.Close();
        }
        public void ReadStudentList()
        {
            Data = new List<StdInformation>();
            if (File.Exists(FileN))
            {
                BinaryReader binaryR = new BinaryReader(new FileStream(FileN, FileMode.Open));
                int a = binaryR.ReadInt32();
                for (int i = 0; i < a; i++)
                {
                    StdInformation stdF = new StdInformation();
                    stdF.Load(binaryR);
                    Data.Add(stdF);
                }
                binaryR.Close();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("The list of student had readed !!");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Have not student is this list !!!");
                Console.ResetColor();
            }
            Console.WriteLine("Press enter to continue =>.");
            Console.ReadLine();
        }
        string tms, tt;
        public void SearchIDStudent()
        {
            if (File.Exists(FileN))
            {
                int j = 0;
                Console.Write("Enter the ID of student to search, example(GT12345):");
                tms = Console.ReadLine().ToUpper();
                while (tms.Length != 7)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error invalid entry! Try again.");
                    Console.ResetColor();
                    Console.Write("Enter the ID of student to search, example(GT12345):");
                    tms = Console.ReadLine();
                }
                for (int i = 0; i < Data.Count; i++)
                {
                    if (tms == Data[i].stdId.ToUpper())
                    {
                        Data[i].ViewLStd();
                        j++;
                    }
                }
                if (j == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Not found the ID of student that you had entered !!");
                    Console.ResetColor();
                    Console.WriteLine("Press enter to continue =>.");
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("The list have not any student !!!");
                Console.ResetColor();
                Console.WriteLine("Press enter to continue =>.");
            }
            Console.ReadLine();
        }
        public void SearchNameStudent()
        {
            if (File.Exists(FileN))
            {
                int j = 0;
                Console.Write("Enter the name of student which want to search: ");
                tt = Console.ReadLine().ToUpper();
                for (int i = 0; i < Data.Count; i++)
                {
                    if (tt == Data[i].stdName.ToUpper())
                    {
                        Data[i].ViewLStd();
                        j++;
                    }
                }
                if (j == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Not found the name which had entered !");
                    Console.ResetColor();
                    Console.WriteLine("Press enter to continue =>.");
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("The list have not any student !!!");
                Console.ResetColor();
                Console.WriteLine("Press enter to continue =>.");
            }
            Console.ReadLine();
        }
        public void DeleteStudentInf()
        {
            int qlx;
            string dk, dk1;
            do
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n Have {0} student is the list !!!", Data.Count);
                ViewListStudent();
                Console.ResetColor();
                if (Data.Count == 0)
                {
                    Console.WriteLine();
                    Console.ReadLine();
                    break;
                }
                else
                {
                    for (int i = 0; i < Data.Count; i++)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("{0}. \t{1}", i + 1, Data[i].stdName);
                        Console.ResetColor();
                    }
                }
                do
                {
                    Console.Write("\n Enter the students you want to delete in order of: \t");
                    string qlx2 = Console.ReadLine();
                    while (!int.TryParse(qlx2, out qlx))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Error invalid entry!");
                        Console.ResetColor();
                        Console.Write("Enter the student you want to delete in order of again: ");
                        qlx2 = Console.ReadLine();
                    }
                    if (qlx > Data.Count || qlx < 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("Not found ID entered! Try again.");
                        Console.ResetColor();
                    }
                } while (qlx < 1 || qlx > Data.Count);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Are you sure? (y. Yes / Enter. No): ");
                dk = Console.ReadLine().ToLower();
                Console.ResetColor();
                if (dk == "y")
                {
                    Data.RemoveAt(qlx - 1);
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Delete successfull {0}!", qlx);
                    Console.ResetColor();
                }
                Console.Write("\n Do you want to continue to delete? (y. Continue / Enter. No): ");
                dk1 = Console.ReadLine().ToLower();
            } while (dk1 == "y");
        }
        public StdInformation editStdInf(int inf)
        {
            string mess = "Error invalid entry! Try again.";
            string id, name, DoB, address, phone, email, batch;
            StdInformation stdF = new StdInformation();

            //edit ID inf of student
            Console.WriteLine("\n ID of student: {0}", Data[inf].stdId);
            Console.Write("Enter the new information (or ENTER to ignore): GT");
            id = Console.ReadLine().ToUpper();
            if (id != "")
            {
                stdF.stdId = "GT" + id;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Edit successful !");
                Console.ResetColor();
            }
            else stdF.stdId = Data[inf].stdId;

            //Edit name of student
            Console.WriteLine("\nTHe name of student: {0}", Data[inf].stdName);
            Console.Write("Enter the new information (or ENTER to ignore): ");
            name = Console.ReadLine().ToUpper();
            if (name != "")
            {
                stdF.stdName = name;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Edit name successful !");
                Console.ResetColor();
            }
            else stdF.stdName = Data[inf].stdName;

            //Edit DoB information of student
            Console.WriteLine("\nDate of Birth: {0}", Data[inf].stdDoB.ToString("dd/MM/yyyy"));
            Console.Write("Enter the new information (yyyy/MM/dd) (or ENTER to ignore): ");
            DoB = Console.ReadLine();
            if (DoB != "")
            {
                while (!DateTime.TryParse(DoB, out stdF.stdDoB))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(mess);
                    Console.ResetColor();
                    Console.Write("Enter the new information (yyyy/MM/dd)");
                    DoB = Console.ReadLine();
                }
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Edit succesful !");
                Console.ResetColor();
            }
            else stdF.stdDoB = Data[inf].stdDoB;

            //Edit address information of student
            Console.WriteLine("\nAddress: {0}", Data[inf].stdAddress);
            Console.Write("Enter the new information (or ENTER to ignore):");
            address = Console.ReadLine().ToUpper();
            if (address != "")
            {
                stdF.stdAddress = address;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Edit successful !");
                Console.ResetColor();
            }
            else stdF.stdAddress = Data[inf].stdAddress;

            //Edit the phone number information of student
            Console.WriteLine("\nPhone number: {0}", Data[inf].stdPhone);
            Console.Write("Enter the new information (or ENTER to ignore):");
            phone = Console.ReadLine();
            if (phone != "")
            {
                while (!int.TryParse(phone, out stdF.stdPhone) || phone.Length != 10)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(mess);
                    Console.ResetColor();
                    Console.Write("Enter the new information: ");
                    phone = Console.ReadLine();
                }
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Edit successful !");
                Console.ResetColor();
            }
            else stdF.stdPhone = Data[inf].stdPhone;

            //edit Email inf of student
            Console.WriteLine("\n Email: {0}", Data[inf].stdEmail);
            Console.Write("Enter the new information (or ENTER to ignore): ");
            email = Console.ReadLine().ToUpper();
            if (email != "")
            {
                stdF.stdEmail = email;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Edit successful !");
                Console.ResetColor();
            }
            else stdF.stdEmail = Data[inf].stdEmail;

            //edit the batch of student
            Console.WriteLine("\n The batch of student: {0}", Data[inf].stdBatch);
            Console.Write("Enter the new information (or ENTER to ignore): ");
            batch = Console.ReadLine().ToUpper();
            if (batch != "")
            {
                stdF.stdBatch = batch;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Edit successful !");
                Console.ResetColor();
            }
            else stdF.stdBatch = Data[inf].stdBatch;
            return stdF;
        }

        public void EditStudentInf()
        {
            string mess = "Error invalid entry! Try again.";
            int stt;
            if (File.Exists(FileN))
            {
                if (Data.Count == 0)
                {
                    Console.WriteLine("\n Have not Student in the list !!!");
                    goto end;
                }
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n The list have {0} student!", Data.Count);
                Console.ResetColor();
                for (int i = 0; i < Data.Count; i++)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("{0}. {1}", i + 1, Data[i].stdName);
                    Console.ResetColor();
                }
                do
                {
                    Console.Write("\n Choose the student to edit students' information: ");
                    string stt2 = Console.ReadLine();
                    while (!int.TryParse(stt2, out stt))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(mess);
                        Console.ResetColor();
                        Console.Write("Choose the Lecturer to edit Lecturers' information again: \t");
                        stt2 = Console.ReadLine();
                    }
                    if (stt < 1 || stt > Data.Count)
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine(mess);
                        Console.ResetColor();
                    }
                } while (stt < 1 || stt > Data.Count);
                stt--;
                StdInformation sF = new StdInformation();
                sF = editStdInf(stt);
                Data.RemoveAt(stt);
                Data.Insert(stt, sF);
                SaveList();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\nThe information edit had saved!");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("The list have not any student !!!");
                Console.ResetColor();
            }
        end:
            Console.ReadLine();
        }
    }
}
