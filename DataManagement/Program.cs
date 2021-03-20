using System; // C# Code
using System.Collections; // C# code >> the element at the specified index of ArrayList 
using System.IO; // C# code >> the element at the specified File Handling

/*  
    DISPLAY:

    =============-Wellcome to Sunshine Children Hospital-=================
    ----------------------------------------------------------------------
    1. Show All Patients Data
    2. Add New Patient Data
    3. Change Data
    4. Remove Data
    5. Exit
    Please select menu one through five! Enter Number:
    ######################################################################

    >>> PROGRAM:
    1. Display Patient List = Horizontal and vertikal display (automatic save file to 'C' storage)
    2. Adding New Patient   = Create New File and New Patient will entered in to new file automatically
    3. Change The Data      = Change data with spesific ID without adding new file
    4. Removing Patients    = It will be deleted automatically (file in 'C' storage) after instruction just once clicked
    5. Exit                 = from this program.

    >>> PATIENT DATA SAVED:
    1. Patient Name             : "XXXX"
    2. Room Number              : "YYY"
    3. Record Number(Patient ID): "000XXXYYY000"
    4. Region                   : "City or District"
    5. Date of Check in         : "Month/Date/Year" 
    6. BPJS                     : "Class-1" or "Class-2" or "Class-3"
*/

namespace Data_Project
{
    // "\n" : new line "\t" : new horizontal tab

    class DisplayList
    {
        struct Patient
        {
            // Declares properties on the struct
            private int noRoom;
            private float patientID;
            private string region; private string date;
            private string name; private string gender; private string BPJSClass;

            public void Get(string n, string g, float p, string b, int nR, string r, string d)
            {
                name = n; gender = g; patientID = p; BPJSClass = b; noRoom = nR; region = r; date = d;
            }

            //Display data from a struct
            public void Display()
            {
                Console.WriteLine("\tName      : {0} ", name);
                Console.WriteLine("\tGender    : {0} ", gender);
                Console.WriteLine("\tPatient ID: {0} ", patientID);
                Console.WriteLine("\tBPJS Class: {0} ", BPJSClass);
                Console.WriteLine("\tNo.Room   : {0} ", noRoom);
                Console.WriteLine("\tRegion    : {0} ", region);
                Console.WriteLine("\tDate      : {0} ", date);
            }
        };
        public void Menu1()
        {
            // Get new repository
            string path = @"C:\File_data";
            Directory.CreateDirectory(path);
            string filename = "Patient-List.txt";

            // Data included in the list
            string data =
                "\t>>>>__________No/Name/Gender/Patient_ID/Class/No.Room/Region/Date_of_Discharge__________<<<<\n\n" +
                "\tAmanda Arisa\t: Female : 000123976000 : Class-1 : 004 : Bogor \t\t:11/22/2018 \n" +
                "\tAnatha Lovia\t: Female : 000123678000 : Class-2 : 006 : Surabaya \t\t:02/12/2019\n " +
                "\tBeno Armando\t: Male\t : 000123879000 : Class-1 : 078 : Bandung \t\t:05/07/2020\n" +
                "\tDeano Dion\t: Male\t : 000123175000 : Class-3 : 090 : North Jakarta \t:03/30/2019\n" +
                "\tLino Sihite\t: Male\t : 000123477000 : Class-3 : 060 : Medan \t\t:01/21/2019\n" +
                "\tMaheswara\t: Male\t : 000123879000 : Class-1 : 003 : Yogyakarta \t\t:12/09/2019\n" +
                "\tOca Maheswari\t: Female : 000123678000 : Class-2 : 019 : Malang \t\t:02/11/2020\n" +
                "\tWisnu Surya\t: Male\t : 000123477000 : Class-1 : 082 : Seminyak \t\t:05/28/2019\n" +
                "\tLan Wangji\t: Male\t : 000123678000 : Class-2 : 041 : Pontianak\t\t:06/29/2019\n" +
                "\tZafra Manik\t: Male\t : 000123175000 : Class-1 : 079 : South Jakarta \t:11/30/2018\n";
            try
            {
                //  Create files by writing data
                File.WriteAllText(Path.Combine(path, filename), data);
                Console.WriteLine("\tFile {0} already created\n", Path.Combine(path, filename));
            }
            catch (IOException e)
            {
                // Error Handle
                Console.WriteLine("ERROR: {0}", e.Message);
                Environment.Exit(1);
            }

            // Open flie and reading the data from the file
            StreamReader file = null;
            try
            {
                Console.WriteLine("\n\tFile of contents: {0} ", Path.Combine(path, filename) +"\n");
                file = new StreamReader(Path.Combine(path, filename));
                int characterD = 0;
                Console.Write("\t============================================================================================\n");
                Console.Write("\t--------------------------------------------------------------------------------------------\n");
                
                // Read data per character
                while ((characterD = file.Read()) != -1)
                {
                    Console.Write((char)characterD);
                }

                Console.WriteLine("\n\tPlease press enter to change the display"); Console.ReadLine();
                
                // Clear display and change the display 
                Console.Clear();

                // Declare Patient 1,2,3... of type Patient
                Patient Patient1 = new Patient(); Patient Patient2 = new Patient();
                Patient Patient3 = new Patient(); Patient Patient4 = new Patient();
                Patient Patient5 = new Patient(); Patient Patient6 = new Patient();
                Patient Patient7 = new Patient(); Patient Patient8 = new Patient();
                Patient Patient9 = new Patient(); Patient Patient10 = new Patient();

                // Patient Specification 
                // Name / Gender / Patient ID / BPJS Class / No.Room / Region / Date
                Patient1.Get("Amanda Arisa  ", "Women ", 000123976000, "Class - 1  ", 004, "Bogor           ", "01/22/2020");
                Patient2.Get("Anatha Lovia  ", "Women ", 000123678000, "Class - 2  ", 006, "Surabaya        ", "02/12/2019");
                Patient3.Get("Lino Sihite   ", "Men	  ", 000123477000, "Class - 3  ", 060, "Medan           ", "09/12/2019");
                Patient4.Get("Beno Armando  ", "Men	  ", 000123879000, "Class - 1  ", 078, "Bandung         ", "05/07/2020");
                Patient5.Get("Deano Dion    ", "Men	  ", 000123175000, "Class - 3  ", 090, "Jakarta Utara   ", "03/30/2019");
                Patient6.Get("Maheswara     ", "Men	  ", 000123879000, "Class - 1  ", 003, "Yogjakarta      ", "12/09/2019");
                Patient7.Get("Oca Heswari   ", "Women ", 000123678000, "Class - 2  ", 019, "Malang          ", "02/11/2020");
                Patient8.Get("Wisnu Surya   ", "Men	  ", 000123477000, "Class - 1  ", 082, "Denpasar        ", "05/28/2019");
                Patient9.Get("Lan Wangji    ", "Men	  ", 000123678000, "Class - 2  ", 041, "Pontianak       ", "06/29/2019");
                Patient10.Get("Zafra Manik  ", "Men	  ", 000123175000, "Class - 1  ", 079, "Jakarta Selatan ", "11/30/2019");

                // Print Patients info
                Console.WriteLine("\n>>>>-----------Patient_1-----------<<<<"); Patient1.Display();
                Console.WriteLine("----------------------------------------\n");
                Console.WriteLine("\n>>>>-----------Patient_2-----------<<<<"); Patient2.Display();
                Console.WriteLine("----------------------------------------\n");
                Console.WriteLine("\n>>>>-----------Patient_3-----------<<<<"); Patient3.Display();
                Console.WriteLine("----------------------------------------\n");
                Console.WriteLine("\n>>>>-----------Patient_4-----------<<<<"); Patient4.Display();
                Console.WriteLine("----------------------------------------\n");
                Console.WriteLine("\n>>>>-----------Patient_5-----------<<<<"); Patient5.Display();
                Console.WriteLine("----------------------------------------\n");
                Console.WriteLine("\n>>>>-----------Patient_6-----------<<<<"); Patient6.Display();
                Console.WriteLine("----------------------------------------\n");
                Console.WriteLine("\n>>>>-----------Patient_7-----------<<<<"); Patient7.Display();
                Console.WriteLine("----------------------------------------\n");
                Console.WriteLine("\n>>>>-----------Patient_8-----------<<<<"); Patient8.Display();
                Console.WriteLine("----------------------------------------\n");
                Console.WriteLine("\n>>>>-----------Patient_9-----------<<<<"); Patient9.Display();
                Console.WriteLine("----------------------------------------\n");
                Console.WriteLine("\n>>>>-----------Patient_10-----------<<<<"); Patient10.Display();
                Console.WriteLine("----------------------------------------\n");
            }
            catch (FileNotFoundException e)
            {
                //
                Console.WriteLine("ERROR: {0}", e.Message);
                Environment.Exit(1);
            }
            catch (IOException e)
            {
                //
                Console.WriteLine("ERROR: {0}", e.Message);
                Environment.Exit(1);
            }

            finally
            {
                //
                if (file != null)
                {
                    file.Close();
                }
            }
        }
    }
    class AddPatient
    {
        public void Menu2()
        {
            Console.WriteLine("\n\tDo you want to add new patient data?");
            Console.WriteLine("\tWe need some data information from these patients.\n\tPlease fill in the data below,");

        // At this stage it will be calling back from "goto"
        menu2: Console.WriteLine();
            Console.Write("\tPatient Name                : "); string name = Console.ReadLine();
            Console.Write("\tRegion (city || district)   : "); string region = Console.ReadLine();
            Console.Write("\tGender (Female || Male)     : "); string gender = Console.ReadLine();
            Console.Write("\tNo.Room (2 numbers)         : "); int noRoom = int.Parse(Console.ReadLine());
            Console.Write("\tBpjs Class (1 || 2 || 3)    : "); int bpjsClass = int.Parse(Console.ReadLine());
            Console.Write("\tPatient ID (6 numbers)      : "); int patientID = int.Parse(Console.ReadLine());
            Console.Write("\tCheck in (month/date/year)  : "); string date = Console.ReadLine();

            Console.WriteLine("\n\tIf the data has been saved, the data cannot be changed again.\n\n\tIs the data entered correctly?");
            Console.Write("\tA.Yes, the data entered is correct.\n\tB.No, I want to change data\n");
            Console.Write("\tYour Answer: "); char Answer = char.Parse(Console.ReadLine());

            if (Answer == 'A' || Answer == 'a')
            {
                // create new repository
                string path = @"C:\File_data";
                Directory.CreateDirectory(path);
                string filename = "Patient-List-2.txt";

                // Data included in the list if female
                string newdata1 =
                "\t>>>>__________No/Name/Gender/Patient_ID/Class/No.Room/Region/Date_of_Discharge__________<<<<\n\n" +
                "\tAmanda Arisa\t: Female : 000123976000 : Class-1 : 004 : Bogor \t\t:11/22/2018 \n" +
                "\tAnatha Lovia\t: Female : 000123678000 : Class-2 : 006 : Surabaya \t\t:02/12/2019\n " +
                "\tBeno Armando\t: Male\t : 000123879000 : Class-1 : 078 : Bandung \t\t:05/07/2020\n" +
                "\tDeano Dion\t: Male\t : 000123175000 : Class-3 : 090 : North Jakarta \t:03/30/2019\n" +
                "\tLino Sihite\t: Male\t : 000123477000 : Class-3 : 060 : Medan \t\t:01/21/2019\n" +
                "\tMaheswara\t: Male\t : 000123879000 : Class-1 : 003 : Yogyakarta \t\t:12/09/2019\n" +
                "\tOca Maheswari\t: Female : 000123678000 : Class-2 : 019 : Malang \t\t:02/11/2020\n" +
                "\tWisnu Surya\t: Male\t : 000123477000 : Class-1 : 082 : Seminyak \t\t:05/28/2019\n" +
                "\tLan Wangji\t: Male\t : 000123678000 : Class-2 : 041 : Pontianak\t\t:06/29/2019\n" +
                "\tZafra Manik\t: Male\t : 000123175000 : Class-1 : 079 : South Jakarta \t:11/30/2018\n" +
                "\t" + name + "  \t: " + gender + " : 000" + patientID + "000 : Class-" + bpjsClass + " : " +"o"+
                    noRoom + " : " + region + " \t\t:" + date + "\n";

                // Data included in the list if Male
                string newdata2 =
                "\t>>>>__________No/Name/Gender/Patient_ID/Class/No.Room/Region/Date_of_Discharge__________<<<<\n\n" +
                "\tAmanda Arisa\t: Female : 000123976000 : Class-1 : 004 : Bogor \t\t:11/22/2018 \n" +
                "\tAnatha Lovia\t: Female : 000123678000 : Class-2 : 006 : Surabaya \t\t:02/12/2019\n " +
                "\tBeno Armando\t: Male\t : 000123879000 : Class-1 : 078 : Bandung \t\t:05/07/2020\n" +
                "\tDeano Dion\t: Male\t : 000123175000 : Class-3 : 090 : North Jakarta \t:03/30/2019\n" +
                "\tLino Sihite\t: Male\t : 000123477000 : Class-3 : 060 : Medan \t\t:01/21/2019\n" +
                "\tMaheswara\t: Male\t : 000123879000 : Class-1 : 003 : Yogyakarta \t\t:12/09/2019\n" +
                "\tOca Maheswari\t: Female : 000123678000 : Class-2 : 019 : Malang \t\t:02/11/2020\n" +
                "\tWisnu Surya\t: Male\t : 000123477000 : Class-1 : 082 : Seminyak \t\t:05/28/2019\n" +
                "\tLan Wangji\t: Male\t : 000123678000 : Class-2 : 041 : Pontianak\t\t:06/29/2019\n" +
                "\tZafra Manik\t: Male\t : 000123175000 : Class-1 : 079 : South Jakarta \t:11/30/2018\n" +
                "\t" + name + "  \t: " + gender + "\t : 000" + patientID + "000 : Class-" + bpjsClass + " : "+ "0" +
                   noRoom + " : " + region + " \t\t:" + date + "\n";

                try
                {
                    if (gender == "Female" || gender == "female")
                    {
                        // Create files by writing data
                        File.WriteAllText(Path.Combine(path, filename), newdata1);
                        Console.WriteLine("\n\tFile {0} already created\n", Path.Combine(path, filename));
                    }
                    else if (gender == "Male" || gender == "male")
                    {
                        // Create files by writing data
                        File.WriteAllText(Path.Combine(path, filename), newdata2);
                        Console.WriteLine("\n\tFile {0} already created\n", Path.Combine(path, filename));
                    }
                    else
                    {
                        Console.WriteLine("\n\t====PLEASE FOLLOW THE INSTRUCTION==="+
                            "\n\t========CHECK AGAIN YOUR DATA======="+"\n\n\tPress enter to continue!"); Console.ReadLine();
                        Console.Clear(); goto menu2; 

                    }
                }
                catch (IOException e)
                {
                    // error handling
                    Console.WriteLine("ERROR: {0}", e.Message);
                    Environment.Exit(1);
                }

                // Open flie and reading the data from the file
                StreamReader file = null;
                try
                {
                    Console.WriteLine("\tFile of contents: {0} ", Path.Combine(path, filename) + "\n");
                    file = new StreamReader(Path.Combine(path, filename));
                    int characterD = 0;
                    Console.Write("\t============================================================================================\n");
                    Console.Write("\t--------------------------------------------------------------------------------------------\n");

                    // Read data per character
                    while ((characterD = file.Read()) != -1)
                    {
                        Console.Write((char)characterD);
                    }
                }
                catch (FileNotFoundException e)
                {
                    // error handling
                    Console.WriteLine("ERROR: {0}", e.Message);
                    Environment.Exit(1);
                }
                catch (IOException e)
                {
                    // error handling
                    Console.WriteLine("ERROR: {0}", e.Message);
                    Environment.Exit(1);
                }
                finally
                {
                    // Final = Close
                    if (file != null)
                    {
                        file.Close();
                    }
                }
            }/*------------x------- end_TheFirst_if_menu2 ----------------x---------*/
            else 
            {
                Console.Clear(); Console.WriteLine("\n\tDo you want to add new patient data?");
                Console.WriteLine("\tWe need some data information from these patients.\n\tPlease fill in the data below,\n");
                // back to on the top
                goto menu2;
            } 
        } 
    }
    class Changedata
    {
        public void Menu3()
        {
            Console.Write("\t============================================================================================\n");
            Console.Write("\t--------------------------------------------------------------------------------------------\n");
            Console.WriteLine(
                "\t>>>>__________No/Name/Gender/Patient_ID/Class/No.Room/Region/Date_of_Discharge__________<<<<\n\n" +
                "\tAmanda Arisa\t: Female : 000123976000 : Class-1 : 004 : Bogor \t\t:11/22/2018 \n" +
                "\tAnatha Lovia\t: Female : 000125678000 : Class-2 : 006 : Tarakan \t\t:02/12/2019\n " +
                "\tBeno Armando\t: Male\t : 000123879000 : Class-1 : 078 : Bandung \t\t:05/07/2020\n" +
                "\tDeano Dion\t: Male\t : 000123175000 : Class-3 : 090 : North Jakarta \t:03/30/2019\n" +
                "\tLino Sihite\t: Male\t : 000123477000 : Class-3 : 060 : Medan \t\t:01/21/2019\n" +
                "\tMaheswara\t: Male\t : 000123874000 : Class-1 : 003 : Yogyakarta \t\t:12/09/2019\n" +
                "\tOca Maheswari\t: Female : 000123672000 : Class-2 : 019 : Malang \t\t:02/11/2020\n" +
                "\tWisnu Surya\t: Male\t : 000123457000 : Class-1 : 082 : Klungkung \t\t:05/28/2019\n" +
                "\tLan Wangji\t: Male\t : 000123671000 : Class-2 : 041 : Pontianak\t\t:06/29/2019\n" +
                "\tZafra Manik\t: Male\t : 000143172000 : Class-1 : 079 : South Jakarta \t:11/30/2018\n");
            Console.Write("\tPlease enter patient id number correctly to change the patient data: ");
            float idpatient = float.Parse(Console.ReadLine()); 

            switch (idpatient)
            {
                case 000123976000:
                    Console.Clear();

                    // ArrayList and adding elements to ArrayList 
                    // Creates and initializes a new ArrayList using Insert instead of Add.
                    ArrayList P_data1 = new ArrayList(6);
                    P_data1.Insert(0, "\tPatient Name                : Amanda Arisa");
                    P_data1.Insert(1, "\tGender (Female/Male)        : Female ");
                    P_data1.Insert(2, "\tPatient Id (6 numbers)      : 000123976000");
                    P_data1.Insert(3, "\tBpjs Class (1/2/3)          : Class-1");
                    P_data1.Insert(4, "\tNo.Room (3 numbers)         : 004");
                    P_data1.Insert(5, "\tRegion (city/district)      : Bogor");
                    P_data1.Insert(6, "\tCheck in (month/date/year)  : 11/22/2018");
                    // Displaying the elements in ArrayList 
                    Console.WriteLine("\n\tThe following is patient data on behalf of Amanda Arisa:\n");
                    foreach (string info_P in P_data1)
                    {
                        Console.WriteLine(info_P);
                    }
                    Console.WriteLine();
                    Console.Write("\tWhich data you want to change?\n\tPlease enter (\"Patient Name\", or \"Gender\", or \"Patient Id\", or etc ...) without punctuation here: ");
                    string changeData1 = Console.ReadLine();

                    if (changeData1 == "Patient Name" || changeData1 == "Patient name" || changeData1 == "patient name")
                    {
                        // Removing the element present at index 0 
                        P_data1.RemoveAt(0);

                        // Creates and initializes a new Queue.
                        Console.Write("\n\tPlease write patient name exactly        : ");
                        string Name = Console.ReadLine();
                        Queue P_name = new Queue();
                        P_name.Enqueue("\tPatient Name                : "+Name);

                        // Copies the Queue elements to the ArrayList at index 0.
                        P_data1.InsertRange(0, P_name);

                        // Displays the ArrayList.
                        Console.WriteLine("\n\tAfter adding the Queue, the ArrayList now contains:");

                        foreach (string info_P in P_data1)
                        {
                            Console.WriteLine(info_P);
                        }

                    }
                    else if (changeData1 == "Gender" || changeData1 == "gender")
                    {
                        // Removing the element present at index 1 
                        P_data1.RemoveAt(1);

                        Console.Write("\n\tPlease write gender exactly (Female/Male)        : ");
                        string gender = Console.ReadLine();

                        // Search for "Patient Id..." and add "Gender..." before it.
                        P_data1.Insert(P_data1.IndexOf("\tPatient Id (6 numbers)      : 000123976000"), "\tGender (Female/Male)        : " + gender);

                        // Displaying the elements in ArrayList 
                        Console.WriteLine("\n\t-----------------------------------------------------------------");
                        Console.WriteLine("\n\tThis is patient data after modified :");

                        foreach (string info_P in P_data1)
                        {
                            Console.WriteLine(info_P);
                        }
                    }
                    else if (changeData1 == "Patient Id" || changeData1 == "Patient id" || changeData1 == "patient id")
                    {
                        // Removing the element present at index 2 
                        P_data1.RemoveAt(2);

                        Console.Write("\n\tPlease write Patient Id exactly (6 numbers)      : ");
                        string id_P = Console.ReadLine();

                        // Search for "BPJS Class..." and add "Patient Id..." before it.
                        P_data1.Insert(P_data1.IndexOf("\tBpjs Class (1/2/3)          : Class-1"), "\tPatient Id (6 numbers)      : " + "000" + id_P + "000");

                        // Displaying the elements in ArrayList 
                        Console.WriteLine("\n\t-----------------------------------------------------------------");
                        Console.WriteLine("\n\tThis is patient data after modified :");

                        foreach (string info_P in P_data1)
                        {
                            Console.WriteLine(info_P);
                        }
                    }
                    else if (changeData1 == "BPJS Class" || changeData1 == "BPJS class" || changeData1 == "Bpjs Class" || changeData1 == "Bpjs class" || changeData1 == "bpjs class")
                    {
                        // Removing the element present at index 3 
                        P_data1.RemoveAt(3);

                        Console.Write("\n\tPlease write BPJS Class(Class - 1 / Class - 2 / Class - 3) exactly : ");
                        string Bpjs_C = Console.ReadLine();

                        // Search for "No.Room..." and add "BPJS Class..." before it.
                        P_data1.Insert(P_data1.IndexOf("\tNo.Room (3 numbers)         : 004"), "\tBpjs Class (1/2/3)          : Class-" + Bpjs_C);

                        // Displaying the elements in ArrayList 
                        Console.WriteLine("\n\t-----------------------------------------------------------------");
                        Console.WriteLine("\n\tThis is patient data after modified :");

                        foreach (string info_P in P_data1)
                        {
                            Console.WriteLine(info_P);
                        }
                    }
                    else if (changeData1 == "No Room" || changeData1 == "No room" || changeData1 == "no room")
                    {
                        // Removing the element present at index 4 
                        P_data1.RemoveAt(4);

                        Console.Write("\n\tPlease write No.Room (3 numbers) exactly : ");
                        int No_room = int.Parse(Console.ReadLine());

                        // Search for "Region..." and add "No.Room..." before it.
                        P_data1.Insert(P_data1.IndexOf("\tRegion (city/district)      : Bogor"), "\tNo.Room (3 numbers)         : " + No_room);

                        // Displaying the elements in ArrayList 
                        Console.WriteLine("\n\t-----------------------------------------------------------------");
                        Console.WriteLine("\n\tThis is patient data after modified :");

                        foreach (string info_P in P_data1)
                        {
                            Console.WriteLine(info_P);
                        }
                    }
                    else if (changeData1 == "Region" || changeData1 == "region")
                    {
                        // Removing the element present at index 5 
                        P_data1.RemoveAt(5);

                        Console.Write("\n\tPlease write Region(city/district) exactly : ");
                        string region = Console.ReadLine();

                        // Search for "Check in..." and add "Region..." before it.
                        P_data1.Insert(P_data1.IndexOf("\tCheck in (month/date/year)  : 11/22/2018"), "\tRegion (city/district)      : " + region);

                        // Displaying the elements in ArrayList 
                        Console.WriteLine("\n\t-----------------------------------------------------------------");
                        Console.WriteLine("\n\tThis is patient data after modified :");

                        foreach (string info_P in P_data1)
                        {
                            Console.WriteLine(info_P);
                        }
                    }
                    else if (changeData1 == "Check In" || changeData1 == "Check in" || changeData1 == "check in")
                    {
                        // Removing the element present at index 6 
                        P_data1.RemoveAt(6);

                        // Add "new check in" at the end.
                        Console.Write("\n\tPlease write Check in (month/date/year) exactly : ");
                        string check_i = Console.ReadLine();
                        string check_in = "Check in (month/date/year)  : " + check_i;
                        P_data1.Insert(P_data1.Count, "\t" + check_in);

                        // Displaying the elements in ArrayList 
                        Console.WriteLine("\n\t-----------------------------------------------------------------");
                        Console.WriteLine("\n\tThis is patient data after modified :");

                        foreach (string info_P in P_data1)
                        {
                            Console.WriteLine(info_P);
                        }
                    }

                    break;
                case 000125678000:
                    Console.Clear();

                    // ArrayList and adding elements to ArrayList 
                    // Creates and initializes a new ArrayList using Insert instead of Add.
                    ArrayList P_data2 = new ArrayList(10);
                    P_data2.Insert(0, "\tPatient Name                : Anantha Lovia");
                    P_data2.Insert(1, "\tGender (Female/Male)        : Female ");
                    P_data2.Insert(2, "\tPatient Id (6 numbers)      : 000125678000");
                    P_data2.Insert(3, "\tBpjs Class (1/2/3)          : Class-2");
                    P_data2.Insert(4, "\tNo.Room (3 numbers)         : 006");
                    P_data2.Insert(5, "\tRegion (city/district)      : Tarakan");
                    P_data2.Insert(6, "\tCheck in (month/date/year)  : 02/12/2019");

                    // Displaying the elements in ArrayList 
                    Console.WriteLine("\n\tThe following is patient data on behalf of Anantha Lovia:\n");
                    foreach (string info_P in P_data2)
                    {
                        Console.WriteLine(info_P);
                    }

                    Console.WriteLine();
                    Console.Write("\tWhich data you want to change?\n\tPlease enter (\"Patient Name\", or \"Gender\", or \"Patient Id\", or etc ...) without punctuation here: ");
                    string changeData2 = Console.ReadLine();

                    if (changeData2 == "Patient Name" || changeData2 == "Patient name" || changeData2 == "patient name")
                    {
                        // Removing the element present at index 0 
                        P_data2.RemoveAt(0);

                        // Creates and initializes a new Queue.
                        Console.Write("\n\tPlease write patient name exactly        : ");
                        string Name = Console.ReadLine();
                        Queue P_name = new Queue();
                        P_name.Enqueue("\tPatient Name                : " + Name);

                        // Copies the Queue elements to the ArrayList at index 0.
                        P_data2.InsertRange(0, P_name);

                        // Displays the ArrayList.
                        Console.WriteLine("\n\tAfter adding the Queue, the ArrayList now contains:");

                        foreach (string info_P in P_data2)
                        {
                            Console.WriteLine(info_P);
                        }
                    }
                    else if (changeData2 == "Gender" || changeData2 == "gender")
                    {
                        // Removing the element present at index 1 
                        P_data2.RemoveAt(1);

                        Console.Write("\n\tPlease write gender exactly (Female/Male)        : ");
                        string gender = Console.ReadLine();

                        // Search for "Patient Id..." and add "Gender..." before it.
                        P_data2.Insert(P_data2.IndexOf("\tPatient Id (6 numbers)      : 000125678000"), "\tGender (Female/Male)        : " + gender);

                        // Displaying the elements in ArrayList 
                        Console.WriteLine("\n\t-----------------------------------------------------------------");
                        Console.WriteLine("\n\tThis is patient data after modified :");

                        // Displaying the elements with looping
                        foreach (string info_P in P_data2)
                        {
                            Console.WriteLine(info_P);
                        }
                    }
                    else if (changeData2 == "Patient Id" || changeData2 == "Patient id" || changeData2 == "patient id")
                    {
                        // Removing the element present at index 2 
                        P_data2.RemoveAt(2);

                        Console.Write("\n\tPlease write Patient Id exactly (6 numbers)      : ");
                        float id_P = float.Parse(Console.ReadLine());

                        // Search for "BPJS Class..." and add "Patient Id..." before it.
                        P_data2.Insert(P_data2.IndexOf("\tBpjs Class (1/2/3)          : Class-2"), "\tPatient Id (6 numbers)      : " + "000" + id_P + "000");

                        // Displaying the elements in ArrayList 
                        Console.WriteLine("\n\t-----------------------------------------------------------------");
                        Console.WriteLine("\n\tThis is patient data after modified :");

                        foreach (string info_P in P_data2)
                        {
                            Console.WriteLine(info_P);
                        }
                    }
                    else if (changeData2 == "BPJS Class" || changeData2 == "BPJS class" || changeData2 == "Bpjs Class" || changeData2 == "Bpjs class" || changeData2 == "bpjs class")
                    {
                        // Removing the element present at index 3 
                        P_data2.RemoveAt(3);

                        Console.Write("\n\tPlease write BPJS Class(Class - 1 / Class - 2 / Class - 3) exactly : ");
                        string Bpjs_C = Console.ReadLine();

                        // Search for "No.Room..." and add "BPJS Class..." before it.
                        P_data2.Insert(P_data2.IndexOf("\tNo.Room (3 numbers)         : 006"), "\tBpjs Class (1/2/3)          : Class-" + Bpjs_C);

                        // Displaying the elements in ArrayList 
                        Console.WriteLine("\n\t-----------------------------------------------------------------");
                        Console.WriteLine("\n\tThis is patient data after modified :");

                        // Displaying the elements with looping
                        foreach (string info_P in P_data2)
                        {
                            Console.WriteLine(info_P);
                        }
                    }
                    else if (changeData2 == "No Room" || changeData2 == "No room" || changeData2 == "no room")
                    { 
                        // Removing the element present at index 4 
                        P_data2.RemoveAt(4);

                        Console.Write("\n\tPlease write No.Room (3 numbers) exactly : ");
                        int No_room = int.Parse(Console.ReadLine());

                        // Search for "Region..." and add "No.Room..." before it.
                        P_data2.Insert(P_data2.IndexOf("\tRegion (city/district)      : Tarakan"), "\tNo.Room (3 numbers)         : " + No_room);

                        // Displaying the elements in ArrayList 
                        Console.WriteLine("\n\t-----------------------------------------------------------------");
                        Console.WriteLine("\n\tThis is patient data after modified :");

                        // Displaying the elements with looping
                        foreach (string info_P in P_data2)
                        {
                            Console.WriteLine(info_P);
                        }
                    }
                    else if (changeData2 == "Region" || changeData2 == "region")
                    {
                        // Removing the element present at index 5 
                        P_data2.RemoveAt(5);

                        Console.Write("\n\tPlease write Region(city/district) exactly : ");
                        string region = Console.ReadLine();

                        // Search for "Check in..." and add "Region..." before it.
                        P_data2.Insert(P_data2.IndexOf("\tCheck in (month/date/year)  : 02/12/2019"), "\tRegion (city/district)      : " + region);

                        // Displaying the elements in ArrayList 
                        Console.WriteLine("\n\t-----------------------------------------------------------------");
                        Console.WriteLine("\n\tThis is patient data after modified :");

                        // Displaying the elements with looping
                        foreach (string info_P in P_data2)
                        {
                            Console.WriteLine(info_P);
                        }
                    }
                    else if (changeData2 == "Check In" || changeData2 == "Check in" || changeData2 == "check in")
                    {
                        // Removing the element present at index 6 
                        P_data2.RemoveAt(6);

                        // Add "new check in" at the end.
                        Console.Write("\n\tPlease write Check in (month/date/year) exactly : ");
                        string check_i = Console.ReadLine();
                        string check_in = "Check in (month/date/year)  : " + check_i;
                        P_data2.Insert(P_data2.Count, "\t" + check_in);

                        // Displaying the elements in ArrayList 
                        Console.WriteLine("\n\t-----------------------------------------------------------------");
                        Console.WriteLine("\n\tThis is patient data after modified :");

                        // Displaying the elements with looping
                        foreach (string info_P in P_data2)
                        {
                            Console.WriteLine(info_P);
                        }
                    }
                    break;
                case 000123879000:
                    Console.Clear();

                    // ArrayList and adding elements to ArrayList  
                    // Creates and initializes a new ArrayList using Insert instead of Add.
                    ArrayList P_data4 = new ArrayList(10);
                    P_data4.Insert(0, "\tPatient Name                : Beno Armando");
                    P_data4.Insert(1, "\tGender (Female/Male)        : Male ");
                    P_data4.Insert(2, "\tPatient Id (6 numbers)      : 000123879000");
                    P_data4.Insert(3, "\tBpjs Class (1/2/3)          : Class-1");
                    P_data4.Insert(4, "\tNo.Room (3 numbers)         : 078");
                    P_data4.Insert(5, "\tRegion (city/district)      : Bandung");
                    P_data4.Insert(6, "\tCheck in (month/date/year)  : 05/07/2020");

                    // Displaying the elements in ArrayList 
                    Console.WriteLine("\n\tThe following is patient data on behalf of Beno Armando:\n");
                    // Displaying the elements with looping
                    foreach (string info_P in P_data4)
                    {
                        Console.WriteLine(info_P);
                    }

                    Console.WriteLine();
                    Console.Write("\tWhich data you want to change?\n\tPlease enter (\"Patient Name\", or \"Gender\", or \"Patient Id\", or etc ...) without punctuation here: ");
                    string changeData4 = Console.ReadLine();

                    if (changeData4 == "Patient Name" || changeData4 == "Patient name" || changeData4 == "patient name")
                    {
                        // Removing the element present at index 0 
                        P_data4.RemoveAt(0);

                        // Creates and initializes a new Queue.
                        Console.Write("\n\tPlease write patient name exactly        : ");
                        string Name = Console.ReadLine();
                        Queue P_name = new Queue();
                        P_name.Enqueue("\tPatient Name                : " + Name);

                        // Copies the Queue elements to the ArrayList at index 0.
                        P_data4.InsertRange(0, P_name);

                        // Displays the ArrayList.
                        Console.WriteLine("\n\tAfter adding the Queue, the ArrayList now contains:");

                        // Displaying the elements with looping
                        foreach (string info_P in P_data4)
                        {
                            Console.WriteLine(info_P);
                        }
                    }
                    else if (changeData4 == "Gender" || changeData4 == "gender")
                    {
                        // Removing the element present at index 1 
                        P_data4.RemoveAt(1);

                        Console.Write("\n\tPlease write gender exactly (Female/Male)        : ");
                        string gender = Console.ReadLine();

                        // Search for "Patient Id..." and add "Gender..." before it.
                        P_data4.Insert(P_data4.IndexOf("\tPatient Id (6 numbers)      : 000123879000"), "\tGender (Female/Male)        : " + gender);

                        // Displaying the elements in ArrayList 
                        Console.WriteLine("\n\t-----------------------------------------------------------------");
                        Console.WriteLine("\n\tThis is patient data after modified :");
                        // Displaying the elements with looping
                        foreach (string info_P in P_data4)
                        {
                            Console.WriteLine(info_P);
                        }
                    }
                    else if (changeData4 == "Patient Id" || changeData4 == "Patient id" || changeData4 == "patient id")
                    {
                        // Removing the element present at index 2 
                        P_data4.RemoveAt(2);

                        Console.Write("\n\tPlease write Patient Id exactly (6 numbers)      : ");
                        float id_P = float.Parse(Console.ReadLine());

                        // Search for "BPJS Class..." and add "Patient Id..." before it.
                        P_data4.Insert(P_data4.IndexOf("\tBpjs Class (1/2/3)          : Class-1"), "\tPatient Id (6 numbers)      : " + "000" + id_P + "000");

                        // Displaying the elements in ArrayList 
                        Console.WriteLine("\n\t-----------------------------------------------------------------");
                        Console.WriteLine("\n\tThis is patient data after modified :");
                        // Displaying the elements with looping
                        foreach (string info_P in P_data4)
                        {
                            Console.WriteLine(info_P);
                        }
                    }
                    else if (changeData4 == "BPJS Class" || changeData4 == "BPJS class" || changeData4 == "Bpjs Class" || changeData4 == "Bpjs class" || changeData4 == "bpjs class")
                    {
                        // Removing the element present at index 3 
                        P_data4.RemoveAt(3);

                        Console.Write("\n\tPlease write BPJS Class(Class - 1 / Class - 2 / Class - 3) exactly : ");
                        string Bpjs_C = Console.ReadLine();

                        // Search for "No.Room..." and add "BPJS Class..." before it.
                        P_data4.Insert(P_data4.IndexOf("\tNo.Room (3 numbers)         : 078"), "\tBpjs Class (1/2/3)          : Class-" + Bpjs_C);

                        // Displaying the elements in ArrayList 
                        Console.WriteLine("\n\t-----------------------------------------------------------------");
                        Console.WriteLine("\n\tThis is patient data after modified :");

                        // Displaying the elements with looping
                        foreach (string info_P in P_data4)
                        {
                            Console.WriteLine(info_P);
                        }
                    }
                    else if (changeData4 == "No Room" || changeData4 == "No room" || changeData4 == "no room")
                    {
                        // Removing the element present at index 4 
                        P_data4.RemoveAt(4);

                        Console.Write("\n\tPlease write No.Room (3 numbers) exactly : ");
                        int No_room = int.Parse(Console.ReadLine());

                        // Search for "Region..." and add "No.Room..." before it.
                        P_data4.Insert(P_data4.IndexOf("\tRegion (city/district)      : Bandung"), "\tNo.Room (3 numbers)         : " + No_room);

                        // Displaying the elements in ArrayList 
                        Console.WriteLine("\n\t-----------------------------------------------------------------");
                        Console.WriteLine("\n\tThis is patient data after modified :");

                        // Displaying the elements with looping
                        foreach (string info_P in P_data4)
                        {
                            Console.WriteLine(info_P);
                        }
                    }
                    else if (changeData4 == "Region" || changeData4 == "region")
                    {
                        // Removing the element present at index 5 
                        P_data4.RemoveAt(5);

                        Console.Write("\n\tPlease write Region(city/district) exactly : ");
                        string region = Console.ReadLine();

                        // Search for "Check in..." and add "Region..." before it.
                        P_data4.Insert(P_data4.IndexOf("\tCheck in (month/date/year)  : 05/07/2020"), "\tRegion (city/district)      : " + region);

                        // Displaying the elements in ArrayList 
                        Console.WriteLine("\n\t-----------------------------------------------------------------");
                        Console.WriteLine("\n\tThis is patient data after modified :");

                        // Displaying the elements with looping
                        foreach (string info_P in P_data4)
                        {
                            Console.WriteLine(info_P);
                        }
                    }
                    else if (changeData4 == "Check In" || changeData4 == "Check in" || changeData4 == "check in")
                    {
                        // Removing the element present at index 6 
                        P_data4.RemoveAt(6);

                        // Add "new check in" at the end.
                        Console.Write("\n\tPlease write Check in (month/date/year) exactly : ");
                        string check_i = Console.ReadLine();
                        string check_in = "Check in (month/date/year)  : " + check_i;
                        P_data4.Insert(P_data4.Count, "\t" + check_in);

                        // Displaying the elements in ArrayList 
                        Console.WriteLine("\n\t-----------------------------------------------------------------");
                        Console.WriteLine("\n\tThis is patient data after modified :");

                        // Displaying the elements with looping
                        foreach (string info_P in P_data4)
                        {
                            Console.WriteLine(info_P);
                        }
                    }
                    break;
                case 000123175000:
                    Console.Clear();

                    // ArrayList and adding elements to ArrayList  
                    // Creates and initializes a new ArrayList using Insert instead of Add.
                    ArrayList P_data5 = new ArrayList(10);
                    P_data5.Insert(0, "\tPatient Name                : Deona Dion");
                    P_data5.Insert(1, "\tGender (Female/Male)        : Male ");
                    P_data5.Insert(2, "\tPatient Id (6 numbers)      : 000123175000");
                    P_data5.Insert(3, "\tBpjs Class (1/2/3)          : Class-3");
                    P_data5.Insert(4, "\tNo.Room (3 numbers)         : 098");
                    P_data5.Insert(5, "\tRegion (city/district)      : North Jakarta");
                    P_data5.Insert(6, "\tCheck in (month/date/year)  : 03/30/2019");

                    // Displaying the elements in ArrayList 
                    Console.WriteLine("\n\tThe following is patient data on behalf of Deona Dion:\n");
                    // Displaying the elements with looping
                    foreach (string info_P in P_data5)
                    {
                        Console.WriteLine(info_P);
                    }

                    Console.WriteLine();
                    Console.Write("\tWhich data you want to change?\n\tPlease enter (\"Patient Name\", or \"Gender\", or \"Patient Id\", or etc ...) without punctuation here: ");
                    string changeData5 = Console.ReadLine();

                    if (changeData5 == "Patient Name" || changeData5 == "Patient name" || changeData5 == "patient name")
                    {
                        // Removing the element present at index 0 
                        P_data5.RemoveAt(0);

                        // Creates and initializes a new Queue.
                        Console.Write("\n\tPlease write patient name exactly        : ");
                        string Name = Console.ReadLine();
                        Queue P_name = new Queue();
                        P_name.Enqueue("\tPatient Name                : " + Name);

                        // Copies the Queue elements to the ArrayList at index 0.
                        P_data5.InsertRange(0, P_name);

                        // Displays the ArrayList.
                        Console.WriteLine("\n\tAfter adding the Queue, the ArrayList now contains:");

                        // Displaying the elements with looping
                        foreach (string info_P in P_data5)
                        {
                            Console.WriteLine(info_P);
                        }
                    }
                    else if (changeData5 == "Gender" || changeData5 == "gender")
                    {
                        // Removing the element present at index 1 
                        P_data5.RemoveAt(1);

                        Console.Write("\n\tPlease write gender exactly (Female/Male)        : ");
                        string gender = Console.ReadLine();

                        // Search for "Patient Id..." and add "Gender..." before it.
                        P_data5.Insert(P_data5.IndexOf("\tPatient Id (6 numbers)      : 000123175000"), "\tGender (Female/Male)        : " + gender);

                        // Displaying the elements in ArrayList 
                        Console.WriteLine("\n\t-----------------------------------------------------------------");
                        Console.WriteLine("\n\tThis is patient data after modified :");

                        // Displaying the elements with looping
                        foreach (string info_P in P_data5)
                        {
                            Console.WriteLine(info_P);
                        }
                    }
                    else if (changeData5 == "Patient Id" || changeData5 == "Patient id" || changeData5 == "patient id")
                    {
                        // Removing the element present at index 2 
                        P_data5.RemoveAt(2);

                        Console.Write("\n\tPlease write Patient Id exactly (6 numbers)      : ");
                        float id_P = float.Parse(Console.ReadLine());

                        // Search for "BPJS Class..." and add "Patient Id..." before it.
                        P_data5.Insert(P_data5.IndexOf("\tBpjs Class (1/2/3)          : Class-3"), "\tPatient Id (6 numbers)      : " + "000" + id_P + "000");

                        // Displaying the elements in ArrayList 
                        Console.WriteLine("\n\t-----------------------------------------------------------------");
                        Console.WriteLine("\n\tThis is patient data after modified :");
                        // Displaying the elements with looping
                        foreach (string info_P in P_data5)
                        {
                            Console.WriteLine(info_P);
                        }
                    }
                    else if (changeData5 == "BPJS Class" || changeData5 == "BPJS class" || changeData5 == "Bpjs Class" || changeData5 == "Bpjs class" || changeData5 == "bpjs class")
                    {
                        // Removing the element present at index 3 
                        P_data5.RemoveAt(3);

                        Console.Write("\n\tPlease write BPJS Class(Class - 1 / Class - 2 / Class - 3) exactly : ");
                        string Bpjs_C = Console.ReadLine();

                        // Search for "No.Room..." and add "BPJS Class..." before it.
                        P_data5.Insert(P_data5.IndexOf("\tNo.Room (3 numbers)         : 098"), "\tBpjs Class (1/2/3)          : Class-" + Bpjs_C);

                        // Displaying the elements in ArrayList 
                        Console.WriteLine("\n\t-----------------------------------------------------------------");
                        Console.WriteLine("\n\tThis is patient data after modified :");
                        // Displaying the elements with looping
                        foreach (string info_P in P_data5)
                        {
                            Console.WriteLine(info_P);
                        }
                    }
                    else if (changeData5 == "No Room" || changeData5 == "No room" || changeData5 == "no room")
                    {
                        // Removing the element present at index 4 
                        P_data5.RemoveAt(4);

                        Console.Write("\n\tPlease write No.Room (3 numbers) exactly : ");
                        int No_room = int.Parse(Console.ReadLine());

                        // Search for "Region..." and add "No.Room..." before it.
                        P_data5.Insert(P_data5.IndexOf("\tRegion (city/district)      : North Jakarta"), "\tNo.Room (3 numbers)         : " + No_room);

                        // Displaying the elements in ArrayList 
                        Console.WriteLine("\n\t-----------------------------------------------------------------");
                        Console.WriteLine("\n\tThis is patient data after modified :");
                        // Displaying the elements with looping
                        foreach (string info_P in P_data5)
                        {
                            Console.WriteLine(info_P);
                        }
                    }
                    else if (changeData5 == "Region" || changeData5 == "region")
                    {
                        // Removing the element present at index 5 
                        P_data5.RemoveAt(5);

                        Console.Write("\n\tPlease write Region (city/district) exactly : ");
                        string region = Console.ReadLine();

                        // Search for "Check in..." and add "Region..." before it.
                        P_data5.Insert(P_data5.IndexOf("\tCheck in (month/date/year)  : 03/30/2019"), "\tRegion (city/district)      : " + region);

                        // Displaying the elements in ArrayList 
                        Console.WriteLine("\n\t-----------------------------------------------------------------");
                        Console.WriteLine("\n\tThis is patient data after modified :");
                        // Displaying the elements with looping
                        foreach (string info_P in P_data5)
                        {
                            Console.WriteLine(info_P);
                        }
                    }
                    else if (changeData5 == "Check In" || changeData5 == "Check in" || changeData5 == "check in")
                    {
                        // Removing the element present at index 6 
                        P_data5.RemoveAt(6);

                        // Add "new check in" at the end.
                        Console.Write("\n\tPlease write Check in (month/date/year) exactly : ");
                        string check_i = Console.ReadLine();
                        string check_in = "Check in (month/date/year)  : " + check_i;
                        P_data5.Insert(P_data5.Count, "\t" + check_in);

                        // Displaying the elements in ArrayList 
                        Console.WriteLine("\n\t-----------------------------------------------------------------");
                        Console.WriteLine("\n\tThis is patient data after modified :");
                        // Displaying the elements with looping
                        foreach (string info_P in P_data5)
                        {
                            Console.WriteLine(info_P);
                        }
                    }
                    break;
                case 000123477000:
                    Console.Clear();

                    // ArrayList and adding elements to ArrayList  
                    // Creates and initializes a new ArrayList using Insert instead of Add.
                    ArrayList P_data3 = new ArrayList(10);
                    P_data3.Insert(0, "\tPatient Name                : Lino Sihite");
                    P_data3.Insert(1, "\tGender (Female/Male)        : Male ");
                    P_data3.Insert(2, "\tPatient Id (6 numbers)      : 000123477000");
                    P_data3.Insert(3, "\tBpjs Class (1/2/3)          : Class-3");
                    P_data3.Insert(4, "\tNo.Room (3 numbers)         : 068");
                    P_data3.Insert(5, "\tRegion (city/district)      : Medan");
                    P_data3.Insert(6, "\tCheck in (month/date/year)  : 01/21/2019");

                    // Displaying the elements in ArrayList 
                    Console.WriteLine("\n\tThe following is patient data on behalf of Lino Sihite:\n");
                    foreach (string info_P in P_data3)
                    {
                        Console.WriteLine(info_P);
                    }

                    Console.WriteLine();
                    Console.Write("\tWhich data you want to change?\n\tPlease enter (\"Patient Name\", or \"Gender\", or \"Patient Id\", or etc ...) without punctuation here: ");
                    string changeData3 = Console.ReadLine();

                    if (changeData3 == "Patient Name" || changeData3 == "Patient name" || changeData3 == "patient name")
                    {
                        // Removing the element present at index 0 
                        P_data3.RemoveAt(0);

                        // Creates and initializes a new Queue.
                        Console.Write("\n\tPlease write patient name exactly        : ");
                        string Name = Console.ReadLine();
                        Queue P_name = new Queue();
                        P_name.Enqueue("\tPatient Name                : " + Name);

                        // Copies the Queue elements to the ArrayList at index 0.
                        P_data3.InsertRange(0, P_name);

                        // Displays the ArrayList.
                        Console.WriteLine("\n\tAfter adding the Queue, the ArrayList now contains:");

                        foreach (string info_P in P_data3)
                        {
                            Console.WriteLine(info_P);
                        }
                    }
                    else if (changeData3 == "Gender" || changeData3 == "gender")
                    {
                        // Removing the element present at index 1 
                        P_data3.RemoveAt(1);

                        Console.Write("\n\tPlease write gender exactly (Female/Male)        : ");
                        string gender = Console.ReadLine();

                        // Search for "Patient Id..." and add "Gender..." before it.
                        P_data3.Insert(P_data3.IndexOf("\tPatient Id (6 numbers)      : 000123477000"), "\tGender (Female/Male)        : " + gender);

                        // Displaying the elements in ArrayList 
                        Console.WriteLine("\n\t-----------------------------------------------------------------");
                        Console.WriteLine("\n\tThis is patient data after modified :");

                        foreach (string info_P in P_data3)
                        {
                            Console.WriteLine(info_P);
                        }
                    }
                    else if (changeData3 == "Patient Id" || changeData3 == "Patient id" || changeData3 == "patient id")
                    {
                        // Removing the element present at index 2 
                        P_data3.RemoveAt(2);

                        Console.Write("\n\tPlease write Patient Id exactly (6 numbers)      : ");
                        float id_P = float.Parse(Console.ReadLine());

                        // Search for "BPJS Class..." and add "Patient Id..." before it.
                        P_data3.Insert(P_data3.IndexOf("\tBpjs Class (1/2/3)          : Class-3"), "\tPatient Id (6 numbers)      : " +"000"+ id_P+"000");

                        // Displaying the elements in ArrayList 
                        Console.WriteLine("\n\t-----------------------------------------------------------------");
                        Console.WriteLine("\n\tThis is patient data after modified :");

                        foreach (string info_P in P_data3)
                        {
                            Console.WriteLine(info_P);
                        }
                    }
                    else if (changeData3 == "BPJS Class" || changeData3 == "BPJS class" || changeData3 == "Bpjs Class" || changeData3 == "Bpjs class" || changeData3 == "bpjs class")
                    {
                        // Removing the element present at index 3 
                        P_data3.RemoveAt(3);

                        Console.Write("\n\tPlease write BPJS Class(Class - 1 / Class - 2 / Class - 3) exactly : ");
                        string Bpjs_C = Console.ReadLine();

                        // Search for "No.Room..." and add "BPJS Class..." before it.
                        P_data3.Insert(P_data3.IndexOf("\tNo.Room (3 numbers)         : 068"), "\tBpjs Class (1/2/3)          : Class-" + Bpjs_C);

                        // Displaying the elements in ArrayList 
                        Console.WriteLine("\n\t-----------------------------------------------------------------");
                        Console.WriteLine("\n\tThis is patient data after modified :");

                        foreach (string info_P in P_data3)
                        {
                            Console.WriteLine(info_P);
                        }
                    }
                    else if (changeData3 == "No Room" || changeData3 == "No room" || changeData3 == "no room")
                    {
                        // Removing the element present at index 4 
                        P_data3.RemoveAt(4);

                        Console.Write("\n\tPlease write No.Room (3 numbers) exactly : ");
                        int No_room = int.Parse(Console.ReadLine());

                        // Search for "Region..." and add "No.Room..." before it.
                        P_data3.Insert(P_data3.IndexOf("\tRegion (city/district)      : Medan"), "\tNo.Room (3 numbers)         : " + No_room);

                        // Displaying the elements in ArrayList 
                        Console.WriteLine("\n\t-----------------------------------------------------------------");
                        Console.WriteLine("\n\tThis is patient data after modified :");

                        foreach (string info_P in P_data3)
                        {
                            Console.WriteLine(info_P);
                        }
                    }
                    else if (changeData3 == "Region" || changeData3 == "region")
                    {
                        // Removing the element present at index 5 
                        P_data3.RemoveAt(5);

                        Console.Write("\n\tPlease write Region(city/district) exactly : ");
                        string region = Console.ReadLine();

                        // Search for "Check in..." and add "Region..." before it.
                        P_data3.Insert(P_data3.IndexOf("\tCheck in (month/date/year)  : 01/21/2019"), "\tRegion (city/district)      : " + region);

                        // Displaying the elements in ArrayList 
                        Console.WriteLine("\n\t-----------------------------------------------------------------");
                        Console.WriteLine("\n\tThis is patient data after modified :");

                        foreach (string info_P in P_data3)
                        {
                            Console.WriteLine(info_P);
                        }
                    }
                    else if (changeData3 == "Check In" || changeData3 == "Check in" || changeData3 == "check in")
                    {
                        // Removing the element present at index 6 
                        P_data3.RemoveAt(6);

                        // Add "new check in" at the end.
                        Console.Write("\n\tPlease write Check in (month/date/year) exactly : ");
                        string check_i = Console.ReadLine();
                        string check_in = "Check in (month/date/year)  : " + check_i;
                        P_data3.Insert(P_data3.Count, "\t" + check_in);

                        // Displaying the elements in ArrayList 
                        Console.WriteLine("\n\t-----------------------------------------------------------------");
                        Console.WriteLine("\n\tThis is patient data after modified :");

                        foreach (string info_P in P_data3)
                        {
                            Console.WriteLine(info_P);
                        }
                    }
                    break;
                
                case 000123874000:
                    Console.Clear();

                    // ArrayList and adding elements to ArrayList  
                    // Creates and initializes a new ArrayList using Insert instead of Add.
                    ArrayList P_data6 = new ArrayList(10);
                    P_data6.Insert(0, "\tPatient Name                : Maheswara");
                    P_data6.Insert(1, "\tGender (Female/Male)        : Male ");
                    P_data6.Insert(2, "\tPatient Id (6 numbers)      : 000123874000");
                    P_data6.Insert(3, "\tBpjs Class (1/2/3)          : Class-1");
                    P_data6.Insert(4, "\tNo.Room (3 numbers)         : 003");
                    P_data6.Insert(5, "\tRegion (city/district)      : Yogyakarta");
                    P_data6.Insert(6, "\tCheck in (month/date/year)  : 12/09/2019");

                    // Displaying the elements in ArrayList 
                    Console.WriteLine("\n\tThe following is patient data on behalf of Maheswara:\t");
                    foreach (string info_P in P_data6)
                    {
                        Console.WriteLine(info_P);
                    }

                    Console.WriteLine();
                    Console.Write("\tWhich data you want to change?\n\tPlease enter (\"Patient Name\", or \"Gender\", or \"Patient Id\", or etc ...) without punctuation here: ");
                    string changeData6 = Console.ReadLine();

                    if (changeData6 == "Patient Name" || changeData6 == "Patient name" || changeData6 == "patient name")
                    {
                        // Removing the element present at index 0 
                        P_data6.RemoveAt(0);

                        // Creates and initializes a new Queue.
                        Console.Write("\n\tPlease write patient name exactly        : ");
                        string Name = Console.ReadLine();
                        Queue P_name = new Queue();
                        P_name.Enqueue("\tPatient Name                : " + Name);

                        // Copies the Queue elements to the ArrayList at index 0.
                        P_data6.InsertRange(0, P_name);

                        // Displays the ArrayList.
                        Console.WriteLine("\n\tAfter adding the Queue, the ArrayList now contains:");

                        foreach (string info_P in P_data6)
                        {
                            Console.WriteLine(info_P);
                        }
                    }
                    else if (changeData6 == "Gender" || changeData6 == "gender")
                    {
                        // Removing the element present at index 1 
                        P_data6.RemoveAt(1);

                        Console.Write("\n\tPlease write gender exactly (Female/Male)        : ");
                        string gender = Console.ReadLine();

                        // Search for "Patient Id..." and add "Gender..." before it.
                        P_data6.Insert(P_data6.IndexOf("\tPatient Id (6 numbers)      : 000123874000"), "\tGender (Female/Male)        : " + gender);

                        // Displaying the elements in ArrayList 
                        Console.WriteLine("\n\t-----------------------------------------------------------------");
                        Console.WriteLine("\n\tThis is patient data after modified :");

                        foreach (string info_P in P_data6)
                        {
                            Console.WriteLine(info_P);
                        }
                    }
                    else if (changeData6 == "Patient Id" || changeData6 == "Patient id" || changeData6 == "patient id")
                    {
                        // Removing the element present at index 2 
                        P_data6.RemoveAt(2);

                        Console.Write("\n\tPlease write Patient Id exactly (6 numbers)      : ");
                        float id_P = float.Parse(Console.ReadLine());

                        // Search for "BPJS Class..." and add "Patient Id..." before it.
                        P_data6.Insert(P_data6.IndexOf("\tBpjs Class (1/2/3)          : Class-1"), "\tPatient Id (6 numbers)      : " + id_P);

                        // Displaying the elements in ArrayList 
                        Console.WriteLine("\n\t-----------------------------------------------------------------");
                        Console.WriteLine("\n\tThis is patient data after modified :");

                        foreach (string info_P in P_data6)
                        {
                            Console.WriteLine(info_P);
                        }
                    }
                    else if (changeData6 == "BPJS Class" || changeData6 == "BPJS class" || changeData6 == "Bpjs Class" || changeData6 == "Bpjs class" || changeData6 == "bpjs class")
                    {
                        // Removing the element present at index 3 
                        P_data6.RemoveAt(3);

                        Console.Write("\n\tPlease write BPJS Class(Class - 1 / Class - 2 / Class - 3) exactly : ");
                        string Bpjs_C = Console.ReadLine();

                        // Search for "No.Room..." and add "BPJS Class..." before it.
                        P_data6.Insert(P_data6.IndexOf("\tNo.Room (3 numbers)         : 003"), "\tBpjs Class (1/2/3)          : Class-" + Bpjs_C);

                        // Displaying the elements in ArrayList 
                        Console.WriteLine("\n\t-----------------------------------------------------------------");
                        Console.WriteLine("\n\tThis is patient data after modified :");

                        foreach (string info_P in P_data6)
                        {
                            Console.WriteLine(info_P);
                        }
                    }
                    else if (changeData6 == "No Room" || changeData6 == "No room" || changeData6 == "no room")
                    {
                        // Removing the element present at index 4 
                        P_data6.RemoveAt(4);

                        Console.Write("\n\tPlease write No.Room (3 numbers) exactly : ");
                        int No_room = int.Parse(Console.ReadLine());

                        // Search for "Region..." and add "No.Room..." before it.
                        P_data6.Insert(P_data6.IndexOf("\tRegion (city/district)      : Yogyakarta"), "\tNo.Room (3 numbers)         : " + No_room);

                        // Displaying the elements in ArrayList 
                        Console.WriteLine("\n\t-----------------------------------------------------------------");
                        Console.WriteLine("\n\tThis is patient data after modified :");

                        foreach (string info_P in P_data6)
                        {
                            Console.WriteLine(info_P);
                        }
                    }
                    else if (changeData6 == "Region" || changeData6 == "region")
                    {
                        // Removing the element present at index 5 
                        P_data6.RemoveAt(5);

                        Console.Write("\n\tPlease write Region(city/district) exactly : ");
                        string region = Console.ReadLine();

                        // Search for "Check in..." and add "Region..." before it.
                        P_data6.Insert(P_data6.IndexOf("\tCheck in (month/date/year)  : 12/09/2019"), "\tRegion (city/district)      : " + region);

                        // Displaying the elements in ArrayList 
                        Console.WriteLine("\n\t-----------------------------------------------------------------");
                        Console.WriteLine("\n\tThis is patient data after modified :");

                        foreach (string info_P in P_data6)
                        {
                            Console.WriteLine(info_P);
                        }
                    }
                    else if (changeData6 == "Check In" || changeData6 == "Check in" || changeData6 == "check in")
                    {
                        // Removing the element present at index 6 
                        P_data6.RemoveAt(6);

                        // Add "new check in" at the end.
                        Console.Write("\n\tPlease write Check in (month/date/year) exactly : ");
                        string check_i = Console.ReadLine();
                        string check_in = "Check in (month/date/year)  : " + check_i;
                        P_data6.Insert(P_data6.Count, "\t" + check_in);

                        // Displaying the elements in ArrayList 
                        Console.WriteLine("\n\t-----------------------------------------------------------------");
                        Console.WriteLine("\n\tThis is patient data after modified :");

                        foreach (string info_P in P_data6)
                        {
                            Console.WriteLine(info_P);
                        }
                    }
                    break; 
                case 000123672000:
                    Console.Clear();
                    // ArrayList and adding elements to ArrayList  
                    // Creates and initializes a new ArrayList using Insert instead of Add.
                    ArrayList P_data7 = new ArrayList(10);
                    P_data7.Insert(0, "\tPatient Name                : Oca Maheswari");
                    P_data7.Insert(1, "\tGender (Female/Male)        : Male ");
                    P_data7.Insert(2, "\tPatient Id (6 numbers)      : 000123672000");
                    P_data7.Insert(3, "\tBpjs Class (1/2/3)          : Class-2");
                    P_data7.Insert(4, "\tNo.Room (3 numbers)         : 019");
                    P_data7.Insert(5, "\tRegion (city/district)      : Malang");
                    P_data7.Insert(6, "\tCheck in (month/date/year)  : 02/11/2020");

                    // Displaying the elements in ArrayList 
                    Console.WriteLine("\n\tThe following is patient data on behalf of Oca Maheswari:\n");
                    foreach (string info_P in P_data7)
                    {
                        Console.WriteLine(info_P);
                    }

                    Console.WriteLine();
                    Console.Write("\tWhich data you want to change?\n\tPlease enter (\"Patient Name\", or \"Gender\", or \"Patient Id\", or etc ...) without punctuation here: ");
                    string changeData7 = Console.ReadLine();

                    if (changeData7 == "Patient Name" || changeData7 == "Patient name" || changeData7 == "patient name")
                    {
                        // Removing the element present at index 0 
                        P_data7.RemoveAt(0);

                        // Creates and initializes a new Queue.
                        Console.Write("\n\tPlease write patient name exactly        : ");
                        string Name = Console.ReadLine();
                        Queue P_name = new Queue();
                        P_name.Enqueue("\tPatient Name                : " + Name);

                        // Copies the Queue elements to the ArrayList at index 0.
                        P_data7.InsertRange(0, P_name);

                        // Displays the ArrayList.
                        Console.WriteLine("\n\tAfter adding the Queue, the ArrayList now contains:");

                        foreach (string info_P in P_data7)
                        {
                            Console.WriteLine(info_P);
                        }
                    }
                    else if (changeData7 == "Gender" || changeData7 == "gender")
                    {
                        // Removing the element present at index 1 
                        P_data7.RemoveAt(1);

                        Console.Write("\n\tPlease write gender exactly (Female/Male)        : ");
                        string gender = Console.ReadLine();

                        // Search for "Patient Id..." and add "Gender..." before it.
                        P_data7.Insert(P_data7.IndexOf("\tPatient Id (6 numbers)      : 000123672000"), "\tGender (Female/Male)        : " + gender);

                        // Displaying the elements in ArrayList 
                        Console.WriteLine("\n\t-----------------------------------------------------------------");
                        Console.WriteLine("\n\tThis is patient data after modified :");

                        foreach (string info_P in P_data7)
                        {
                            Console.WriteLine(info_P);
                        }
                    }
                    else if (changeData7 == "Patient Id" || changeData7 == "Patient id" || changeData7 == "patient id")
                    {
                        // Removing the element present at index 2 
                        P_data7.RemoveAt(2);

                        Console.Write("\n\tPlease write Patient Id exactly (6 numbers)      : ");
                        float id_P = float.Parse(Console.ReadLine());

                        // Search for "BPJS Class..." and add "Patient Id..." before it.
                        P_data7.Insert(P_data7.IndexOf("\tBpjs Class (1/2/3)          : Class-2"), "Patient Id (6 numbers)      : " + "000" + id_P + "000");

                        // Displaying the elements in ArrayList 
                        Console.WriteLine("\n\t-----------------------------------------------------------------");
                        Console.WriteLine("\n\tThis is patient data after modified :");

                        foreach (string info_P in P_data7)
                        {
                            Console.WriteLine(info_P);
                        }
                    }
                    else if (changeData7 == "BPJS Class" || changeData7 == "BPJS class" || changeData7 == "Bpjs Class" || changeData7 == "Bpjs class" || changeData7 == "bpjs class")
                    {
                        // Removing the element present at index 3 
                        P_data7.RemoveAt(3);

                        Console.Write("\n\tPlease write BPJS Class(Class - 1 / Class - 2 / Class - 3) exactly : ");
                        string Bpjs_C = Console.ReadLine();

                        // Search for "No.Room..." and add "BPJS Class..." before it.
                        P_data7.Insert(P_data7.IndexOf("\tNo.Room (3 numbers)         : 019"), "\tBpjs Class (1/2/3)          : Class-" + Bpjs_C);

                        // Displaying the elements in ArrayList 
                        Console.WriteLine("\n\t-----------------------------------------------------------------");
                        Console.WriteLine("\n\tThis is patient data after modified :");

                        foreach (string info_P in P_data7)
                        {
                            Console.WriteLine(info_P);
                        }
                    }
                    else if (changeData7 == "No Room" || changeData7 == "No room" || changeData7 == "no room")
                    {
                        // Removing the element present at index 4 
                        P_data7.RemoveAt(4);

                        Console.Write("\n\tPlease write No.Room (3 numbers) exactly : ");
                        int No_room = int.Parse(Console.ReadLine());

                        // Search for "Region..." and add "No.Room..." before it.
                        P_data7.Insert(P_data7.IndexOf("\tRegion (city/district)      : Malang"), "\tNo.Room (3 numbers)         : " + No_room);

                        // Displaying the elements in ArrayList 
                        Console.WriteLine("\n\t-----------------------------------------------------------------");
                        Console.WriteLine("\n\tThis is patient data after modified :");

                        foreach (string info_P in P_data7)
                        {
                            Console.WriteLine(info_P);
                        }
                    }
                    else if (changeData7 == "Region" || changeData7 == "region")
                    {
                        // Removing the element present at index 5 
                        P_data7.RemoveAt(5);

                        Console.Write("\n\tPlease write Region(city/district) exactly : ");
                        string region = Console.ReadLine();

                        // Search for "Check in..." and add "Region..." before it.
                        P_data7.Insert(P_data7.IndexOf("\tCheck in (month/date/year)  : 02/11/2020"), "\tRegion (city/district)      : " + region);

                        // Displaying the elements in ArrayList 
                        Console.WriteLine("\n\t-----------------------------------------------------------------");
                        Console.WriteLine("\n\tThis is patient data after modified :");

                        foreach (string info_P in P_data7)
                        {
                            Console.WriteLine(info_P);
                        }
                    }
                    else if (changeData7 == "Check In" || changeData7 == "Check in" || changeData7 == "check in")
                    {
                        // Removing the element present at index 6 
                        P_data7.RemoveAt(6);

                        // Add "new check in" at the end.
                        Console.Write("\n\tPlease write Check in (month/date/year) exactly : ");
                        string check_i = Console.ReadLine();
                        string check_in = "Check in (month/date/year)  : " + check_i;
                        P_data7.Insert(P_data7.Count, "\t" + check_in);

                        // Displaying the elements in ArrayList 
                        Console.WriteLine("\n\t-----------------------------------------------------------------");
                        Console.WriteLine("\n\tThis is patient data after modified :");

                        foreach (string info_P in P_data7)
                        {
                            Console.WriteLine(info_P);
                        }
                    }
                    break;
                case 000123457000:
                    Console.Clear();

                    // ArrayList and adding elements to ArrayList  
                    // Creates and initializes a new ArrayList using Insert instead of Add.
                    ArrayList P_data8 = new ArrayList(10);
                    P_data8.Insert(0, "\tPatient Name                : Wisnu Surya");
                    P_data8.Insert(1, "\tGender (Female/Male)        : Male ");
                    P_data8.Insert(2, "\tPatient Id (6 numbers)      : 000123457000");
                    P_data8.Insert(3, "\tBpjs Class (1/2/3)          : Class-1");
                    P_data8.Insert(4, "\tNo.Room (3 numbers)         : 082");
                    P_data8.Insert(5, "\tRegion (city/district)      : Klungkung");
                    P_data8.Insert(6, "\tCheck in (month/date/year)  : 05/28/2019");

                    // Displaying the elements in ArrayList 
                    Console.WriteLine("\n\tThe following is patient data on behalf of Wisnu Surya:\n");
                    foreach (string info_P in P_data8)
                    {
                        Console.WriteLine(info_P);
                    }

                    Console.WriteLine();
                    Console.Write("\tWhich data you want to change?\n\tPlease enter (\"Patient Name\", or \"Gender\", or \"Patient Id\", or etc ...) without punctuation here: ");
                    string changeData8 = Console.ReadLine();

                    if (changeData8 == "Patient Name" || changeData8 == "Patient name" || changeData8 == "patient name")
                    {
                        // Removing the element present at index 0 
                        P_data8.RemoveAt(0);

                        // Creates and initializes a new Queue.
                        Console.Write("\n\tPlease write patient name exactly        : ");
                        string Name = Console.ReadLine();
                        Queue P_name = new Queue();
                        P_name.Enqueue("\tPatient Name                : " + Name);

                        // Copies the Queue elements to the ArrayList at index 0.
                        P_data8.InsertRange(0, P_name);

                        // Displays the ArrayList.
                        Console.WriteLine("\n\tAfter adding the Queue, the ArrayList now contains:");

                        foreach (string info_P in P_data8)
                        {
                            Console.WriteLine(info_P);
                        }
                    }
                    else if (changeData8 == "Gender" || changeData8 == "gender")
                    {
                        // Removing the element present at index 1 
                        P_data8.RemoveAt(1);

                        Console.Write("\n\tPlease write gender exactly (Female/Male)        : ");
                        string gender = Console.ReadLine();

                        // Search for "Patient Id..." and add "Gender..." before it.
                        P_data8.Insert(P_data8.IndexOf("\tPatient Id (6 numbers)      : 000123457000"), "\tGender (Female/Male)        : " + gender);

                        // Displaying the elements in ArrayList 
                        Console.WriteLine("\n\t-----------------------------------------------------------------");
                        Console.WriteLine("\n\tThis is patient data after modified :");

                        foreach (string info_P in P_data8)
                        {
                            Console.WriteLine(info_P);
                        }
                    }
                    else if (changeData8 == "Patient Id" || changeData8 == "Patient id" || changeData8 == "patient id")
                    {
                        // Removing the element present at index 2 
                        P_data8.RemoveAt(2);

                        Console.Write("\n\tPlease write Patient Id exactly (6 numbers)      : ");
                        float id_P = float.Parse(Console.ReadLine());

                        // Search for "BPJS Class..." and add "Patient Id..." before it.
                        P_data8.Insert(P_data8.IndexOf("\tBpjs Class (1/2/3)          : Class-1"), "\tPatient Id (6 numbers)      : " + "000" + id_P + "000");

                        // Displaying the elements in ArrayList 
                        Console.WriteLine("\n\t-----------------------------------------------------------------");
                        Console.WriteLine("\n\tThis is patient data after modified :");

                        foreach (string info_P in P_data8)
                        {
                            Console.WriteLine(info_P);
                        }
                    }
                    else if (changeData8 == "BPJS Class" || changeData8 == "BPJS class" || changeData8 == "Bpjs Class" || changeData8 == "Bpjs class" || changeData8 == "bpjs class")
                    {
                        // Removing the element present at index 3 
                        P_data8.RemoveAt(3);

                        Console.Write("\n\tPlease write BPJS Class(Class - 1 / Class - 2 / Class - 3) exactly : ");
                        string Bpjs_C = Console.ReadLine();

                        // Search for "No.Room..." and add "BPJS Class..." before it.
                        P_data8.Insert(P_data8.IndexOf("\tNo.Room (3 numbers)         : 082"), "\tBpjs Class (1/2/3)          : Class-" + Bpjs_C);

                        // Displaying the elements in ArrayList 
                        Console.WriteLine("\n\t-----------------------------------------------------------------");
                        Console.WriteLine("\n\tThis is patient data after modified :");

                        foreach (string info_P in P_data8)
                        {
                            Console.WriteLine(info_P);
                        }
                    }
                    else if (changeData8 == "No Room" || changeData8 == "No room" || changeData8 == "no room")
                    {
                        // Removing the element present at index 4 
                        P_data8.RemoveAt(4);

                        Console.Write("\n\tPlease write No.Room (3 numbers) exactly : ");
                        int No_room = int.Parse(Console.ReadLine());

                        // Search for "Region..." and add "No.Room..." before it.
                        P_data8.Insert(P_data8.IndexOf("\tRegion (city/district)      : Klungkung"), "\tNo.Room (3 numbers)         : " + No_room);

                        // Displaying the elements in ArrayList 
                        Console.WriteLine("\n\t-----------------------------------------------------------------");
                        Console.WriteLine("\n\tThis is patient data after modified :");

                        foreach (string info_P in P_data8)
                        {
                            Console.WriteLine(info_P);
                        }
                    }
                    else if (changeData8 == "Region" || changeData8 == "region")
                    {
                        // Removing the element present at index 5 
                        P_data8.RemoveAt(5);

                        Console.Write("\n\tPlease write Region(city/district) exactly : ");
                        string region = Console.ReadLine();

                        // Search for "Check in..." and add "Region..." before it.
                        P_data8.Insert(P_data8.IndexOf("\tCheck in (month/date/year)  : 05/28/2019"), "\tRegion (city/district)      : " + region);

                        // Displaying the elements in ArrayList 
                        Console.WriteLine("\n\t-----------------------------------------------------------------");
                        Console.WriteLine("\n\tThis is patient data after modified :");

                        foreach (string info_P in P_data8)
                        {
                            Console.WriteLine(info_P);
                        }
                    }
                    else if (changeData8 == "Check In" || changeData8 == "Check in" || changeData8 == "check in")
                    {
                        // Removing the element present at index 6 
                        P_data8.RemoveAt(6);

                        // Add "new check in" at the end.
                        Console.Write("\n\tPlease write Check in (month/date/year) exactly : ");
                        string check_i = Console.ReadLine();
                        string check_in = "Check in (month/date/year)  : " + check_i;
                        P_data8.Insert(P_data8.Count, "\t" + check_in);

                        // Displaying the elements in ArrayList 
                        Console.WriteLine("\n\t-----------------------------------------------------------------");
                        Console.WriteLine("\n\tThis is patient data after modified :");

                        foreach (string info_P in P_data8)
                        {
                            Console.WriteLine(info_P);
                        }
                    }
                    break;
                case 000123671000:
                    Console.Clear();

                    // ArrayList and adding elements to ArrayList  
                    // Creates and initializes a new ArrayList using Insert instead of Add.
                    ArrayList P_data9 = new ArrayList(10);
                    P_data9.Insert(0, "\tPatient Name                : Lan Wangji");
                    P_data9.Insert(1, "\tGender (Female/Male)        : Male ");
                    P_data9.Insert(2, "\tPatient Id (6 numbers)      : 000123671000");
                    P_data9.Insert(3, "\tBpjs Class (1/2/3)          : Class-2");
                    P_data9.Insert(4, "\tNo.Room (3 numbers)         : 041");
                    P_data9.Insert(5, "\tRegion (city/district)      : Pontianak");
                    P_data9.Insert(6, "\tCheck in (month/date/year)  : 06/29/2019");

                    // Displaying the elements in ArrayList 
                    Console.WriteLine("\n\tThe following is patient data on behalf of Lan Wangji:\n");
                    foreach (string info_P in P_data9)
                    {
                        Console.WriteLine(info_P);
                    }

                    Console.WriteLine();
                    Console.Write("\tWhich data you want to change?\n\tPlease enter (\"Patient Name\", or \"Gender\", or \"Patient Id\", or etc ...) without punctuation here: ");
                    string changeData9 = Console.ReadLine();

                    if (changeData9 == "Patient Name" || changeData9 == "Patient name" || changeData9 == "patient name")
                    {
                        // Removing the element present at index 0 
                        P_data9.RemoveAt(0);

                        // Creates and initializes a new Queue.
                        Console.Write("\n\tPlease write patient name exactly        : ");
                        string Name = Console.ReadLine();
                        Queue P_name = new Queue();
                        P_name.Enqueue("\tPatient Name                : " + Name);

                        // Copies the Queue elements to the ArrayList at index 0.
                        P_data9.InsertRange(0, P_name);

                        // Displays the ArrayList.
                        Console.WriteLine("\n\tAfter adding the Queue, the ArrayList now contains:");

                        foreach (string info_P in P_data9)
                        {
                            Console.WriteLine(info_P);
                        }
                    }
                    else if (changeData9 == "Gender" || changeData9 == "gender")
                    {
                        // Removing the element present at index 1 
                        P_data9.RemoveAt(1);

                        Console.Write("\n\tPlease write gender exactly (Female/Male)        : ");
                        string gender = Console.ReadLine();

                        // Search for "Patient Id..." and add "Gender..." before it.
                        P_data9.Insert(P_data9.IndexOf("\tPatient Id (6 numbers)      : 000123671000"), "\tGender (Female/Male)        : " + gender);

                        // Displaying the elements in ArrayList 
                        Console.WriteLine("\n\t-----------------------------------------------------------------");
                        Console.WriteLine("\n\tThis is patient data after modified :");

                        foreach (string info_P in P_data9)
                        {
                            Console.WriteLine(info_P);
                        }
                    }
                    else if (changeData9 == "Patient Id" || changeData9 == "Patient id" || changeData9 == "patient id")
                    {
                        // Removing the element present at index 2 
                        P_data9.RemoveAt(2);

                        Console.Write("\n\tPlease write Patient Id exactly (6 numbers)      : ");
                        float id_P = float.Parse(Console.ReadLine());

                        // Search for "BPJS Class..." and add "Patient Id..." before it.
                        P_data9.Insert(P_data9.IndexOf("\tBpjs Class (1/2/3)          : Class-2"), "\tPatient Id (6 numbers)      : " + "000" + id_P + "000");

                        // Displaying the elements in ArrayList 
                        Console.WriteLine("\n\t-----------------------------------------------------------------");
                        Console.WriteLine("\n\tThis is patient data after modified :");

                        foreach (string info_P in P_data9)
                        {
                            Console.WriteLine(info_P);
                        }
                    }
                    else if (changeData9 == "BPJS Class" || changeData9 == "BPJS class" || changeData9 == "Bpjs Class" || changeData9== "Bpjs class" || changeData9 == "bpjs class")
                    {
                        // Removing the element present at index 3 
                        P_data9.RemoveAt(3);

                        Console.Write("\n\tPlease write BPJS Class(Class - 1 / Class - 2 / Class - 3) exactly : ");
                        string Bpjs_C = Console.ReadLine();

                        // Search for "No.Room..." and add "BPJS Class..." before it.
                        P_data9.Insert(P_data9.IndexOf("\tNo.Room (3 numbers)         : 041"), "\tBpjs Class (1/2/3)          : Class-" + Bpjs_C);

                        // Displaying the elements in ArrayList 
                        Console.WriteLine("\n\t-----------------------------------------------------------------");
                        Console.WriteLine("\n\tThis is patient data after modified :");

                        foreach (string info_P in P_data9)
                        {
                            Console.WriteLine(info_P);
                        }
                    }
                    else if (changeData9 == "No Room" || changeData9 == "No room" || changeData9 == "no room")
                    {
                        // Removing the element present at index 4 
                        P_data9.RemoveAt(4);

                        Console.Write("\n\tPlease write No.Room (3 numbers) exactly : ");
                        int No_room = int.Parse(Console.ReadLine());

                        // Search for "Region..." and add "No.Room..." before it.
                        P_data9.Insert(P_data9.IndexOf("\tRegion (city/district)      : Pontianak"), "\tNo.Room (3 numbers)         : " + No_room);

                        // Displaying the elements in ArrayList 
                        Console.WriteLine("\n\t-----------------------------------------------------------------");
                        Console.WriteLine("\n\tThis is patient data after modified :");

                        foreach (string info_P in P_data9)
                        {
                            Console.WriteLine(info_P);
                        }
                    }
                    else if (changeData9 == "Region" || changeData9 == "region")
                    {
                        // Removing the element present at index 5 
                        P_data9.RemoveAt(5);

                        Console.Write("\n\tPlease write Region(city/district) exactly : ");
                        string region = Console.ReadLine();

                        // Search for "Check in..." and add "Region..." before it.
                        P_data9.Insert(P_data9.IndexOf("\tCheck in (month/date/year)  : 06/29/2019"), "\tRegion (city/district)      : " + region);

                        // Displaying the elements in ArrayList 
                        Console.WriteLine("\n\t-----------------------------------------------------------------");
                        Console.WriteLine("\n\tThis is patient data after modified :");

                        foreach (string info_P in P_data9)
                        {
                            Console.WriteLine(info_P);
                        }
                    }
                    else if (changeData9 == "Check In" || changeData9 == "Check in" || changeData9 == "check in")
                    {
                        // Removing the element present at index 6 
                        P_data9.RemoveAt(6);

                        // Add "new check in" at the end.
                        Console.Write("\n\tPlease write Check in (month/date/year) exactly : ");
                        string check_i = Console.ReadLine();
                        string check_in = "Check in (month/date/year)  : " + check_i;
                        P_data9.Insert(P_data9.Count, "\t" + check_in);

                        // Displaying the elements in ArrayList 
                        Console.WriteLine("\n\t-----------------------------------------------------------------");
                        Console.WriteLine("\n\tThis is patient data after modified :");

                        foreach (string info_P in P_data9)
                        {
                            Console.WriteLine(info_P);
                        }
                    }
                    break;
                case 000143172000:
                    Console.Clear();
                    // ArrayList and adding elements to ArrayList 
                    // Creates and initializes a new ArrayList using Insert instead of Add.
                    ArrayList P_data = new ArrayList(10);
                    P_data.Insert(0, "\tPatient Name                : Zafra Manik");
                    P_data.Insert(1, "\tGender (Female/Male)        : Male ");
                    P_data.Insert(2, "\tPatient Id (6 numbers)      : 000143172000");
                    P_data.Insert(3, "\tBpjs Class (1/2/3)          : Class-1");
                    P_data.Insert(4, "\tNo.Room (3 numbers)         : 079");
                    P_data.Insert(5, "\tRegion (city/district)      : South Jakarta");
                    P_data.Insert(6, "\tCheck in (month/date/year)  : 11/30/2018");
                    // Displaying the elements in ArrayList 
                    Console.WriteLine("\n\tThe following is patient data on behalf of Zafra Manik:\n");

                    foreach (string info_P in P_data)
                    {
                        Console.WriteLine(info_P);
                    }

                    Console.WriteLine();
                    Console.Write("\tWhich data do you want to change?\n\tPlease enter (\"Patient Name\", or \"Gender\", or \"Patient Id\", or etc ...) without punctuation here: ");
                    string changeData = Console.ReadLine();

                    if (changeData == "Patient Name" || changeData == "Patient name" || changeData == "patient name")
                    {
                        // Removing the element present at index 0 
                        P_data.RemoveAt(0);

                        // Creates and initializes a new Queue.
                        Console.Write("\n\tPlease write patient name exactly        : ");
                        string Name = Console.ReadLine();
                        Queue P_name = new Queue();
                        P_name.Enqueue("\tPatient Name                : " + Name);

                        // Copies the Queue elements to the ArrayList at index 0.
                        P_data.InsertRange(0, P_name);

                        // Displays the ArrayList.
                        Console.WriteLine("\n\tAfter adding the Queue, the ArrayList now contains:");

                        foreach (string info_P in P_data)
                        {
                            Console.WriteLine(info_P);
                        }
                    }
                    else if (changeData == "Gender" || changeData == "gender")
                    {
                        // Removing the element present at index 1 
                        P_data.RemoveAt(1);

                        Console.Write("\n\tPlease write gender exactly (Female/Male)        : ");
                        string gender = Console.ReadLine();

                        // Search for "Patient Id..." and add "Gender..." before it.
                        P_data.Insert(P_data.IndexOf("\tPatient Id (6 numbers)      : 000143172000"), "\tGender (Female/Male)        : " + gender);

                        // Displaying the elements in ArrayList 
                        Console.WriteLine("\n\t-----------------------------------------------------------------");
                        Console.WriteLine("\n\tThis is patient data after modified :");

                        foreach (string info_P in P_data)
                        {
                            Console.WriteLine(info_P);
                        }
                    }
                    else if (changeData == "Patient Id" || changeData == "Patient id" || changeData == "patient id")
                    {
                        // Removing the element present at index 2 
                        P_data.RemoveAt(2);

                        Console.Write("\n\tPlease write Patient Id exactly (6 numbers)      : ");
                        float id_P = float.Parse(Console.ReadLine()); 

                        // Search for "BPJS Class..." and add "Patient Id..." before it.
                        P_data.Insert(P_data.IndexOf("\tBpjs Class (1/2/3)          : Class-1"), "\tPatient Id (6 numbers)      : " + "000" + id_P + "000");

                        // Displaying the elements in ArrayList 
                        Console.WriteLine("\n\t-----------------------------------------------------------------");
                        Console.WriteLine("\n\tThis is patient data after modified :");

                        foreach (string info_P in P_data)
                        {
                            Console.WriteLine(info_P);
                        }
                    }
                    else if (changeData == "BPJS Class" || changeData == "BPJS class" || changeData == "Bpjs Class" || changeData == "Bpjs class" || changeData == "bpjs class")
                    {
                        // Removing the element present at index 3 
                        P_data.RemoveAt(3);

                        Console.Write("\n\tPlease write BPJS Class(Class - 1 / Class - 2 / Class - 3) exactly : ");
                        string Bpjs_C = Console.ReadLine();

                        // Search for "No.Room..." and add "BPJS Class..." before it.
                        P_data.Insert(P_data.IndexOf("\tNo.Room (3 numbers)         : 079"), "\tBpjs Class (1/2/3)          : Class-" + Bpjs_C);

                        // Displaying the elements in ArrayList 
                        Console.WriteLine("\n\t-----------------------------------------------------------------");
                        Console.WriteLine("\n\tThis is patient data after modified :");

                        foreach (string info_P in P_data)
                        {
                            Console.WriteLine(info_P);
                        }
                    }
                    else if (changeData == "No Room" || changeData == "No room" || changeData == "no room")
                    {
                        // Removing the element present at index 4 
                        P_data.RemoveAt(4);

                        Console.Write("\n\tPlease write No.Room (3 numbers) exactly : ");
                        int No_room = int.Parse(Console.ReadLine());

                        // Search for "Region..." and add "No.Room..." before it.
                        P_data.Insert(P_data.IndexOf("\tRegion (city/district)      : South Jakarta"), "\tNo.Room (3 numbers)         : " + No_room);

                        // Displaying the elements in ArrayList 
                        Console.WriteLine("\n\t-----------------------------------------------------------------");
                        Console.WriteLine("\n\tThis is patient data after modified :");

                        foreach (string info_P in P_data)
                        {
                            Console.WriteLine(info_P);
                        }
                    }
                    else if (changeData == "Region" || changeData == "region")
                    {
                        // Removing the element present at index 5 
                        P_data.RemoveAt(5);

                        Console.Write("\n\tPlease write Region(city/district) exactly : ");
                        string region = Console.ReadLine();

                        // Search for "Check in..." and add "Region..." before it.
                        P_data.Insert(P_data.IndexOf("\tCheck in (month/date/year)  : 11/30/2018"), "\tRegion (city/district)      : " + region);

                        // Displaying the elements in ArrayList 
                        Console.WriteLine("\n\t-----------------------------------------------------------------");
                        Console.WriteLine("\n\tThis is patient data after modified :");

                        foreach (string info_P in P_data)
                        {
                            Console.WriteLine(info_P);
                        }
                    }
                    else if (changeData == "Check In" || changeData == "Check in" || changeData == "check in")
                    {
                        // Removing the element present at index 6 
                        P_data.RemoveAt(6);

                        // Add "new check in" at the end.
                        Console.Write("\n\tPlease write Check in (month/date/year) exactly : ");
                        string check_i = Console.ReadLine();
                        string check_in = "Check in (month/date/year)  : " + check_i;
                        P_data.Insert(P_data.Count, "\t" + check_in);

                        // Displaying the elements in ArrayList 
                        Console.WriteLine("\n\t-----------------------------------------------------------------");
                        Console.WriteLine("\n\tThis is patient data after modified :");

                        foreach (string info_P in P_data)
                        {
                            Console.WriteLine(info_P);
                        }
                    }
                    break;

            }
            
        }
    }
    class RemovePatient
    {
        public void Menu4()
        {
            RemovePatient:
            Console.Write("\n\t-----------------------Delete File and Directory------------------------\n");
            Console.WriteLine("\tA. Delete File 1 \"Patient-List\"");
            Console.WriteLine("\tB. Delete File 2\"Patient-List-2\"");
            Console.WriteLine("\tC. Delete All File\"Patient-List\" and \"Patient-List-2\"");
            Console.Write("\tEnter letter here: ");char Let = char.Parse(Console.ReadLine());

            if (Let == 'A')
            {
                Console.Clear(); 
                Console.WriteLine("\n\t>>-----------------------------------------------------------<<");
                Console.WriteLine("\n\t>>-----Your file \"Patient-List\" already deleted!-------<<");
                Console.WriteLine("\n\t>>-----------------------------------------------------------<<");
                //deleting the file
                string File2 = @"C:\File_data\Patient-List.txt";File.Delete(File2);
                Console.ReadLine();
            } 
            else if (Let == 'B')
            {
                Console.Clear(); 
                Console.WriteLine("\n\t>>-----------------------------------------------------------<<");
                Console.WriteLine("\n\t>>-----Your file \"Patient-List-2\" already deleted!-----<<");
                Console.WriteLine("\n\t>>-----------------------------------------------------------<<");
                //deleting the file
                string File3 = @"C:\File_data\Patient-List-2.txt";File.Delete(File3);
                Console.ReadLine();
            } 
            else if (Let == 'C')
            {
                Console.Clear();
                Console.WriteLine("\n\t>>-----------------------------------------------------------<<");
                Console.WriteLine("\n\t>>---------Your file \"Patient-List\" already deleted!--------<<");
                Console.WriteLine("\n\t>>--------Your file \"Patient-List-2\" already deleted!-------<<");
                Console.WriteLine("\n\t>>-----------------------------------------------------------<<");
                //deleting the file
                string File2 = @"C:\File_data\Patient-List.txt";
                string File3 = @"C:\File_data\Patient-List-2.txt";
                File.Delete(File2); File.Delete(File3);
                Console.ReadLine();
            }
            else
            {
                goto RemovePatient;
            }
        }
    }

    //
    //--------------------------------------------X----------------------------------X------------------------------------//
    //--------------------------------------------X----------------------------------X------------------------------------//
    //

    class Program
    {
        static void Main()
        {
            mainMenu: Console.Clear()/*clear screen*/;Console.WriteLine();
            Console.WriteLine("\t=============-Wellcome to Sunshine Children Hospital-==============");
            Console.WriteLine("\t-------------------------------------------------------------------");
            Console.WriteLine("\tSection 1: You are on the menu page.");
            Console.WriteLine("\t1. Display Patient List ");
            Console.WriteLine("\t2. Add New Patient ");
            Console.WriteLine("\t3. Change The Data ");
            Console.WriteLine("\t4. Remove Data ");
            Console.WriteLine("\t5. Exit ");

            try //---Exception handled---
            {
              menu://---label Definition "goto"---
                Console.Write("\tPlease select menu one through five! Enter Number: ");
                //---convert string to integer---
                int num = int.Parse(Console.ReadLine());
                Console.WriteLine("\t########################################################################\n");
                if (num > 5 || num < 1)
                {
                    Console.Write("\n\t------------- ERROR! You can only enter menu number 1-5 -----------------\n"+"\t>>");
                    // back to on the top
                    goto menu;
                }
                else
                {
                    //---control statement, according to menu selected---
                    switch (num)
                    {
                        case 1:
                            Console.Clear(); Console.WriteLine("\n\tSection 2: You are on the Display Patient List");
                            DisplayList obj = new DisplayList();
                            // Call object "menu1" from class 'displayList'
                            obj.Menu1();
                            //---back to on the top (menu)---
                            Console.WriteLine("\n\t>> Press enter to back to menu <<");
                            Console.ReadLine(); Console.Clear();
                            goto mainMenu;
                        case 2:
                            Console.Clear(); Console.WriteLine("\n\tSection 2: You are on the Add New Patient");
                            AddPatient objct = new AddPatient();
                            // Call object "menu2" from class 'addPatient'
                            objct.Menu2();                          
                            //---back to on the top (menu)---
                            Console.WriteLine("\n\t>> Press enter to back to menu <<");
                            Console.ReadLine(); Console.Clear();
                            goto mainMenu;
                        case 3:
                            Console.Clear(); Console.WriteLine("\n\tSection 2: You are on the Copying The Data");
                            Changedata objec = new Changedata();
                            // Call object "menu3" from class 'changedata'
                            objec.Menu3();
                            //---back to on the top (menu)---
                            Console.WriteLine("\n\t>> Press enter to back to menu <<");
                            Console.ReadLine(); Console.Clear();
                            goto mainMenu;
                        case 4:
                            Console.Clear(); Console.WriteLine("\n\tSection 2: You are on the Removing Patient Data");
                            RemovePatient objectt = new RemovePatient();
                            // Call object "menu4" from class 'remove patient'
                            objectt.Menu4();
                            //---back to on the top (menu)---
                            Console.WriteLine("\n\t>> Press enter to back to menu <<");
                            Console.ReadLine(); Console.Clear();
                            // Back to Main Menu
                            goto mainMenu;
                        case 5:
                            Console.Clear(); Console.WriteLine("\n\tSection 2:");
                            //---back to on the top (menu)---
                            Console.WriteLine("\n\t>> Press enter to exit <<");
                            Console.ReadKey(); 
                            break; 

                    }//---x---end_switch---x---

                }//---x---end_if_else_try---x---
            }
            /* Base class from all exceptions, all of the error will be handled by this exception type >> "Exception" */
            catch (Exception e)
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("\t---------------------------------ERROR---------------------------------");
                Console.WriteLine("\t______________" + e.Message+ "______________");
                Console.WriteLine("\t-----------------------------------------------------------------------");
                Console.ReadLine(); Menu2:
                Console.WriteLine("\tA. Continue \n\tB. Exit");
                Console.Write("\tClick \'A\' to continue or click \'B\' to exit: ");
                string ab = Console.ReadLine();
                // This program will be excuted if user enter "A" or "a"
                if (ab == "A" || ab=="a") 
                {
                    Console.WriteLine();
                    goto mainMenu;
                }
                // This program will be excuted if user enter "B" or "b"
                else if (ab == "B" || ab == "b") 
                {
                    //--------------------_STOP_THE_PROGRAM_---------------------.
                    Console.WriteLine("\n\t>>>>>Please click anykey or enter to exit<<<<<");
                    Console.ReadKey();
                }
                // This program will be excuted if user isn't enter "A" or "B" or "a" or "b"
                else if (ab == " " || ab != "A" || ab != "B" || ab != "a" || ab != "b")
                {
                    Console.WriteLine("\n\tPlease enter and choose one.");
                    goto Menu2;

                }//---x---end_if_else_catch_last---x---

            }//---x---end_TryCatch_last---x---

        }//---x---end_MainProgram---x---

    }//---x---end_classProgram---x---

 }//---x---end_namespace_DataProject---x---
