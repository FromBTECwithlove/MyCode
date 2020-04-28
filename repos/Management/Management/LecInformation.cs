using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Management
{
    public struct lecInformation
    {
        public int lecId;
        public string lecName;
        public string lecEmail;
        public string lecAddress;
        public int lecPhone;
        public DateTime lecDoB;
        public string lecDepartment;
        public void AddNlec()
        {
            Console.WriteLine(" \t \t \t \t \t \t***********************************");
            Console.WriteLine(" \t \t \t \t \t \t*Enter the information of Lecturer*");
            Console.WriteLine(" \t \t \t \t \t \t***********************************");
            Console.Write("Enter ID of Lecturer like xxxxxxxx: x is a number [0 - 9], ex(12345678): ");
            string input = Console.ReadLine();
            while (input.Length != 8 || !int.TryParse(input, out lecId))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error invalid entry!");
                Console.ResetColor();
                Console.Write("Enter ID of Lecturer like xxxxxxxx: x is a number [0 - 9], ex(12345678): ");
                input = Console.ReadLine();
            }
            Console.WriteLine("The ID of lecturer:{0} ", input);
            do
            {
                Console.Write("Enter Lecturer's name : ");
                lecName = Console.ReadLine().ToUpper();
                if (lecName == "")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error invalid entry! Try again.");
                    Console.ResetColor();
                }
            } while (lecName == "");
            do
            {
                Console.Write("Enter Email of Lecturer: ");
                lecEmail = Console.ReadLine();
                if (lecEmail == "")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error invalid entry! Try again.");
                    Console.ResetColor();
                }

            } while (lecEmail == "");
            do
            {
                Console.Write("Enter Address of Lecturer: ");
                lecAddress = Console.ReadLine().ToUpper();
                if (lecAddress == "")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error invalid entry! Try again.");
                    Console.ResetColor();
                }
            } while (lecAddress == "");

            Console.Write("Enter the phone number of lecturer: ");
            string Sdt = Console.ReadLine();
            while (!int.TryParse(Sdt, out lecPhone) || lecPhone < 1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error invalid entry! Try again.");
                Console.ResetColor();
                Console.Write("Enter the phone number of lecturer: ");
                Sdt = Console.ReadLine();
            }
            Console.WriteLine("The phone of lecturer:{0} ", Sdt);
            Console.Write("Enter DOB of lecturer (yyyy/MM/dd): ");
            string dateOfB = Console.ReadLine();
            while (!DateTime.TryParse(dateOfB, out lecDoB))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error invalid entry! Try again.");
                Console.ResetColor();
                Console.Write("Enter DOB of lecturer (yyyy/MM/dd): ");
                dateOfB = Console.ReadLine();
            }
            Console.WriteLine("DOB of lecturer: {0}", dateOfB);

            do
            {
                Console.Write("Enter the Department of the Lecturer: ");
                lecDepartment = Console.ReadLine().ToUpper();
                if (lecDepartment == "")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error invalid entry! Try again.");
                    Console.ResetColor();
                }
            } while (lecDepartment == "");
        }

        public void ViewLLec()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine();
            Console.WriteLine(" \t \t \t \t******************************************************");
            Console.WriteLine(" \t \t \t \t* \t \t View list of Lecturer \t \t     *");
            Console.WriteLine(" \t \t \t \t******************************************************");
            Console.WriteLine(" \t \t \t \t*ID           :{0} ", lecId + "\t\t\t\t     *");
            Console.WriteLine(" \t \t \t \t*Name         :{0} ", lecName + "\t\t     *");
            Console.WriteLine(" \t \t \t \t*Email        :{0} ", lecEmail + "\t\t     *");
            Console.WriteLine(" \t \t \t \t*Address      :{0} ", lecAddress + " *");
            Console.WriteLine(" \t \t \t \t*Phone        :{0} ", lecPhone + "\t\t\t     *");
            Console.WriteLine(" \t \t \t \t*DoB          :{0} ", lecDoB.ToString("dd/MM/yyyy") + "\t\t\t     *");
            Console.WriteLine(" \t \t \t \t*Department   :{0} ", lecDepartment + "\t\t     *");
            Console.WriteLine(" \t \t \t \t******************************************************");
            Console.WriteLine();/*
            Console.WriteLine("ID \t|Name \t\t  |Email\t\t|Address \t\t\t   |Phone \t |DoB \t |Department|");
            Console.WriteLine(lecId+"|"+lecName + "|" +lecEmail + "|" +lecAddress + "|" +lecPhone + "|" +lecDoB + "|" +lecDepartment);*/
        }
        const string fileName = "LecturerManagement.dat";

        public void Save(BinaryWriter binaryWriter)
        {
            binaryWriter.Write(lecId);
            binaryWriter.Write(lecName);
            binaryWriter.Write(lecEmail);
            binaryWriter.Write(lecAddress);
            binaryWriter.Write(lecPhone);
            binaryWriter.Write(lecDoB.ToString());
            binaryWriter.Write(lecDepartment);
        }

        public void Load(BinaryReader binaryReader)
        {
            lecId = binaryReader.ReadInt32();
            lecName = binaryReader.ReadString();
            lecEmail = binaryReader.ReadString();
            lecAddress = binaryReader.ReadString();
            lecPhone = binaryReader.ReadInt32();
            lecDoB = DateTime.Parse(binaryReader.ReadString());
            lecDepartment = binaryReader.ReadString();
        }
    }

    public struct LecturerManagement
    {
        private List<lecInformation> Data;
        public void AddNewLecturer()
        {
            string r;
            do
            {
                lecInformation lecF = new lecInformation();
                lecF.AddNlec();
                Data.Add(lecF);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Do you want to continue !? (y: yes / Enter: No): \t");
                r = Console.ReadLine();
                Console.ResetColor();
            } while (r.Equals("y"));
        }
        private const string FileN = "b.tt";
        public void ViewListLecturer()
        {
            if (File.Exists(FileN))
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("In list of Lecturer have {0} Lecturer!", Data.Count);
                Console.ResetColor();
                Console.WriteLine("Press enter to continue =>.");
                Console.ReadLine();
                foreach (lecInformation item in Data)
                {
                    item.ViewLLec();
                    Console.WriteLine(" \t \t \t \tEnter to see the next Lecturer...!");
                    Console.ReadLine();
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Have not Lecturer in list..!!!");
                Console.ResetColor();
                Console.WriteLine("Press enter to continue =>.");
                Console.ReadLine();
            }
        }
        public void SaveList()
        {
            BinaryWriter bw = new BinaryWriter(new FileStream(FileN, FileMode.Create));
            bw.Write(Data.Count);
            foreach (lecInformation item in Data)
            {
                item.Save(bw);
            }
            bw.Close();
        }
        public void ReadLecturerList()
        {
            Data = new List<lecInformation>();
            if (File.Exists(FileN))
            {
                BinaryReader binaryR = new BinaryReader(new FileStream(FileN, FileMode.Open));
                int a = binaryR.ReadInt32();
                for (int i = 0; i < a; i++)
                {
                    lecInformation lecF = new lecInformation();
                    lecF.Load(binaryR);
                    Data.Add(lecF);
                }
                binaryR.Close();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("The list of Lecturer had readed !!");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Have not Lecturer is this list !!!");
                Console.ResetColor();
            }
            Console.WriteLine("Press enter to continue =>.");
            Console.ReadLine();
        }
        string tt, dk1;
        int tms;
        public void SearchIDLecturer()
        {
            do
            {
                if (File.Exists(FileN))
                {
                    int j = 0;
                    Console.Write("Enter the ID of Lecturer to search, example(12345678):");
                    string tms2 = Console.ReadLine();
                    while (!int.TryParse(tms2, out tms) || tms2.Length != 8)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Error invalid entry! Try again.");
                        Console.ResetColor();
                        Console.Write("Enter the ID of Lecturer to search, example(12345678):");
                        tms2 = Console.ReadLine();
                    }
                    for (int i = 0; i < Data.Count; i++)
                    {
                        if (tms == Data[i].lecId)
                        {
                            Data[i].ViewLLec();
                            j++;
                        }
                    }
                    if (j == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Not found the ID of Lecturer that you had entered !!");
                        Console.ResetColor();
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("The list have not any Lecturer !!!");
                    Console.ResetColor();
                    Console.WriteLine("Press enter to continue =>.");
                }
                Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Do you want to continue? (y. Yes / Enter. No): ");
                Console.ResetColor();
                dk1 = Console.ReadLine();
            } while (dk1 == "y");
        }
        public void SearchNameLecturer()
        {
            if (File.Exists(FileN))
            {
                int j = 0;
                Console.Write("Enter the name of Lecturer which want to search: ");
                tt = Console.ReadLine().ToUpper();
                for (int i = 0; i < Data.Count; i++)
                {
                    if (tt == Data[i].lecName.ToUpper())
                    {
                        Data[i].ViewLLec();
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
                Console.WriteLine("The list have not any Lecturer !!!");
                Console.ResetColor();
                Console.WriteLine("Press enter to continue =>.");
            }
            Console.ReadLine();
        }
        public void DeleteLecturerInf()
        {
            int qlx;
            string dk, dk1;
            do
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n Have {0} Lecturer is the list !!!", Data.Count);
                ViewListLecturer();
                Console.ResetColor();
                Console.WriteLine("Press enter to continue =>.");
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
                        Console.WriteLine("{0}. \t{1}", i + 1, Data[i].lecName);
                        Console.ResetColor();
                    }
                }
                do
                {
                    Console.Write("\n Enter the Lecturers you want to delete in order of: \t");
                    string qlx2 = Console.ReadLine();
                    while (!int.TryParse(qlx2, out qlx))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Error invalid entry!");
                        Console.ResetColor();
                        Console.Write("Enter the lecture you want to delete in order of again: \t");
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
                    Console.WriteLine("Delete successfull {0}.", qlx);
                    Console.ResetColor();
                }
                Console.Write("\n Do you want to continue to delete? (Y. Continue / Enter. No): ");
                dk1 = Console.ReadLine().ToLower();
            } while (dk1 == "y");
        }
        public lecInformation editlecInf(int inf)
        {
            string mess = "Error invalid entry! Try again.";
            string id, name, DoB, address, phone, email, Department;

            lecInformation lecF = new lecInformation();

            //edit ID inf of Lecturer
            Console.WriteLine("\n ID of Lecturer: {0}", Data[inf].lecId);
            Console.Write("Enter the new information (or ENTER to ignore):");
            id = Console.ReadLine();
            if (id != "")
            {
                while (!int.TryParse(id, out lecF.lecId) || id.Length != 8)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(mess);
                    Console.ResetColor();
                    Console.Write("Enter the new information xxxxxxxx(x - is number):");
                    id = Console.ReadLine();
                }
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Edit successful !");
                Console.ResetColor();
            }
            else lecF.lecId = Data[inf].lecId;


            //Edit name of Lecturer
            Console.WriteLine("\nTHe name of Lecturer: {0}", Data[inf].lecName);
            Console.Write("Enter the new information (or ENTER to ignore): ");
            name = Console.ReadLine().ToUpper();
            if (name != "")
            {
                lecF.lecName = name;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Edit name successful !");
                Console.ResetColor();
            }
            else lecF.lecName = Data[inf].lecName;

            //Edit DoB information of Lecturer
            Console.WriteLine("\nDate of Birth: {0}", Data[inf].lecDoB.ToString("dd/MM/yyyy"));
            Console.Write("Enter the new information (yyyy/MM/dd) (or ENTER to ignore): ");
            DoB = Console.ReadLine();
            if (DoB != "")
            {
                while (!DateTime.TryParse(DoB, out lecF.lecDoB))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(mess);
                    Console.ResetColor();
                    Console.Write("Enter the new information(yyyy/MM/dd): ");
                    DoB = Console.ReadLine();
                }
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Edit succesful !");
                Console.ResetColor();
            }
            else lecF.lecDoB = Data[inf].lecDoB;

            //Edit address information of Lecturer
            Console.WriteLine("\nAddress: {0}", Data[inf].lecAddress);
            Console.Write("Enter the new information (or ENTER to ignore):");
            address = Console.ReadLine().ToUpper();
            if (address != "")
            {
                lecF.lecAddress = address;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Edit successful !");
                Console.ResetColor();
            }
            else lecF.lecAddress = Data[inf].lecAddress;

            //Edit the phone number information of Lecturer
            Console.WriteLine("\nPhone number: {0}", Data[inf].lecPhone);
            Console.Write("Enter the new information (or ENTER to ignore):");
            phone = Console.ReadLine();
            if (phone != "")
            {
                while (!int.TryParse(phone, out lecF.lecPhone) || phone.Length != 10)
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
            else lecF.lecPhone = Data[inf].lecPhone;

            //edit Email inf of Lecturer
            Console.WriteLine("\n Email: {0}", Data[inf].lecEmail);
            Console.Write("Enter the new information (or ENTER to ignore): ");
            email = Console.ReadLine().ToUpper();
            if (email != "")
            {
                lecF.lecEmail = email;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Edit successful !");
                Console.ResetColor();
            }
            else lecF.lecEmail = Data[inf].lecEmail;

            //edit the Department of Lecturer
            Console.WriteLine("\n The Department of Lecturer: {0}", Data[inf].lecDepartment);
            Console.Write("Enter the new information (or ENTER to ignore): ");
            Department = Console.ReadLine().ToUpper();
            if (Department != "")
            {
                lecF.lecDepartment = Department;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Edit successful !");
                Console.ResetColor();
            }
            else lecF.lecDepartment = Data[inf].lecDepartment;
            return lecF;
        }

        public void EditLecturerInf()
        {
            string mess = "Error invalid entry! Try again.";
            int stt;
            if (File.Exists(FileN))
            {
                if (Data.Count == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n Have not Lecturer in the list !!!");
                    Console.ResetColor();
                    goto end;
                }
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n The list have {0} Lecturer!", Data.Count);
                Console.ResetColor();
                for (int i = 0; i < Data.Count; i++)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("{0}. {1}", i + 1, Data[i].lecName);
                    Console.ResetColor();
                }
                do
                {
                    Console.Write("\n Choose the Lecturer to edit Lecturers' information: \t");
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
                lecInformation sF = new lecInformation();
                sF = editlecInf(stt);
                Data.RemoveAt(stt);
                Data.Insert(stt, sF);
                SaveList();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\nThe information edit had saved !");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("The list have not any Lecturer !!!");
                Console.ResetColor();
            }
        end:
            Console.ReadLine();
        }
    }
}
