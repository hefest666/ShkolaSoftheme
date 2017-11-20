using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_12
{
    class Program
    {
        static void Main(string[] args)
        {            
            Start();
        }       

        static void Start()
        {
            User[] users = new User[100];
            IUser iUser;

            string tempName;
            string tempEmail;
            string tempPass;           

            do
            {
                Console.ResetColor();
                Console.Write("\nEnter user name: ");
                tempName = Console.ReadLine();
                Console.Write("Enter user email: ");
                tempEmail = Console.ReadLine();
                Console.Write("Enter user password: ");
                tempPass = Console.ReadLine();

                //Проверка на выход из программы
                if (tempName == "exit" && tempEmail == "exit" && tempPass == "exit")
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("\n      ----------------------");
                    Console.WriteLine("      | CLOSE THE PROGRAM! |");
                    Console.WriteLine("      ----------------------");
                    Console.ReadKey();
                }
                else
                {
                    //Есть ли данный пользователь в системе? Если нет, то зарегистрировать, если да - проверить его данные на валидность.
                    if (!CheckUser(users, tempName, tempEmail, tempPass))
                    {
                        int countUs = CountUsers(users);

                        users[countUs] = new User();
                        iUser = users[countUs];
                        iUser.Name = tempName;
                        iUser.Email = tempEmail;
                        iUser.Password = tempPass;

                        users[countUs].AuthenticateUser(iUser);

                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine(" ----------------------");
                        Console.WriteLine(" |User was registered!|");
                        Console.WriteLine(" ----------------------");
                    }                                  
                }

            } while (tempName != "exit" || tempEmail != "exit" || tempPass != "exit");
        }        

        static bool CheckUser(User[] users, string tempName, string tempEmail, string tempPass)
        {
            int i = 0;
            while(users[i] != null)
            {
                if (users[i].Name.Equals(tempName))
                {                
                    if (!users[i].Password.Equals(tempPass))
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(" ----------------------------");
                        Console.WriteLine(" User name: {0}", users[i].Name);
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(" User pass: Incorrect pass!");
                        Console.WriteLine(" ----------------------------");
                        return true;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\n ---------------------------------------");
                        Console.WriteLine(" User {0} is already registred!\n", users[i].Name);
                        Console.WriteLine(users[i].GetFullInfo());
                        Console.WriteLine(" ---------------------------------------");
                        return true;
                    }
                }
                i++;
            }

            return false;
        }

        static int CountUsers(User[] users)
        {
            int count = 0;

            while (users[count] != null)
            {
                count++;
            }

            return count;
        }
    }
}
