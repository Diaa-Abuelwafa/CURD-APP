namespace CURD
{
    class Program
    {
        public static void Main()
        {

            /*
                ==> CURD Project <==

                Operations:-
                1 - Add User
                2 - Print All User Data
                3 - Update User Data
                4 - Delete User
             */

            Console.WriteLine("===================== CURD Project ===================");

            // Create Class To Manage All Users
            ManagedUsers All = new ManagedUsers();

            while (true)
            {
                Console.WriteLine("Please Choose Number From 1 To 4");
                Console.WriteLine("1 - Add User");
                Console.WriteLine("2 - Print All User Data");
                Console.WriteLine("3 - Update User Data");
                Console.WriteLine("4 - Delete User");
                Console.WriteLine("=====================");
                Console.Write("Enter Your Choice : ");
                int Choice = int.Parse(Console.ReadLine());

                if (Choice > 0 && Choice <= 4)
                {
                    switch (Choice)
                    {
                        case 1:
                            Console.Write("Enter Your ID : ");
                            int UserID1 = int.Parse(Console.ReadLine());

                            Console.Write("Enter Your Name : ");
                            string Name = Console.ReadLine();

                            Console.Write("Enter Your Email : ");
                            string Email = Console.ReadLine();

                            Console.Write("Enter Your Phone Number : ");
                            long PhoneNumber = long.Parse(Console.ReadLine());

                            All.AddUser(UserID1, Name, Email, PhoneNumber);
                            Console.WriteLine("-------- User Info -----------");
                            All.PrintUser(UserID1);
                            Console.WriteLine("-------------------");

                            break;

                        case 2:
                            All.PrintAllUsers();

                            break;

                        case 3:
                            Console.Write("Enter User ID : ");
                            int UserID2 = int.Parse(Console.ReadLine());
                            Console.WriteLine("1 - Edit ID");
                            Console.WriteLine("2 - Edit Name");
                            Console.WriteLine("3 - Edit Email");
                            Console.WriteLine("4 - Edit PhoneNumber");
                            int Choice1 = int.Parse(Console.ReadLine());
                            Console.Write("Enter New Value : ");
                            string NewValue = Console.ReadLine();

                            All.UpdateUserData(UserID2, Choice1, NewValue);

                            break;

                        case 4:
                            Console.Write("Enter User ID : ");
                            int UserID3 = int.Parse(Console.ReadLine());
                            int Result = All.DeleteUser(UserID3);

                            if(Result == 1)
                            {
                                Console.WriteLine("Done : User Is Deleted");
                            }
                            else
                            {
                                Console.WriteLine($"We Dont Have User With ID : {UserID3}");
                            }

                            break;
                    }

                    Console.WriteLine("Are You Want To Make Another Operation ?");
                    Console.WriteLine("Enter y For Yes");
                    Console.WriteLine("Enter Any Press For No");
                    char Ch = char.Parse(Console.ReadLine());

                    if(Ch != 'y')
                    {
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Wrong Choice Please Try Again :)");
                    Console.WriteLine("--------------------");
                }
            }

        }
    }
}