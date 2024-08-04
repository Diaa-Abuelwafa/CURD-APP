using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CURD
{
    internal class ManagedUsers
    {
        int Size;
        User[] Users;

        public ManagedUsers()
        {
            Size = 0;
            Users = new User[1000];
        }

        // Add User [C]
        public void AddUser(int id, string name, string email, long phonenumber)
        {
            Users[Size] = new User(id, name, email, phonenumber);
            Size += 1;
        }

        public void PrintUser(int id)
        {
            for (int i = 0; i < Size; ++i)
            {
                if (Users[i].ID == id)
                {
                    Console.WriteLine($"User ID : {Users[i].ID}\nUser Name : {Users[i].Name}\nUser Email : {Users[i].Email}\nUser Phone Number : {Users[i].PhoneNumber}");
                    return;
                }
            }

            Console.WriteLine("This User Not Exsists");
        }

        // Print All Users [R]
        public void PrintAllUsers()
        {
            if (Size > 0)
            {
                for (int i = 0; i < Size; ++i)
                {
                    if (Users[i] is not null)
                    {
                        Console.WriteLine("-----------------------");
                        Console.WriteLine($"User {i + 1} :");
                        Console.WriteLine($"User ID : {Users[i].ID}\nUser Name : {Users[i].Name}\nUser Email : {Users[i].Email}\nUser Phone Number : {Users[i].PhoneNumber}");
                        Console.WriteLine("-----------------------");
                    }
                }
            }
            else
            {
                Console.WriteLine("Sorry : No Users Here");
                Console.WriteLine(Size);
            }
        }

        // Update User Data [U]
        public void UpdateUserData(int id, int choice, string newvalue)
        {
            for (int i = 0; i < Size; ++i)
            {
                if (Users[i].ID == id)
                {
                    switch (choice)
                    {
                        case 1:
                            Users[i].ID = int.Parse(newvalue);
                            PrintUser(id);
                            break;

                        case 2:
                            Users[i].Name = newvalue;
                            PrintUser(id);
                            break;

                        case 3:
                            Users[i].Email = newvalue;
                            PrintUser(id);
                            break;

                        case 4:
                            Users[i].PhoneNumber = int.Parse(newvalue);
                            PrintUser(id);
                            break;

                        default:
                            Console.WriteLine("Wrong Choice");
                            break;
                    }

                    return;
                }
            }

            Console.WriteLine($"We Dont Have User With ID : {id}");
        }

        // Delete User [D]
        public int DeleteUser(int id)
        {
            for(int i = 0; i < Size; ++i)
            {
                if (Users[i].ID == id)
                {
                    for(int j = i; j < Size - 1; ++j)
                    {
                        Users[j] = (User) Users[j + 1].Clone();
                    }

                    Size--;

                    return 1;
                }
            }

            return -1;
        }
    }
}
