﻿
namespace My_WebShop4
{
    public class Menu
    {
        public static void MenuChoice()
        {
            Console.WriteLine("Hej och välkommen till WebShop 4");
            Console.WriteLine("Vänligen ange om du vill logga in eller registrera dig som ny användare.");
            Console.WriteLine("För att logga in som befintlig användare ange | L | för att registrera dig som ny ange | R |");
            Console.WriteLine("Är du admin och vill logga in som admin ange | A |");

            string? userInput = Console.ReadLine().ToLower();

            bool run = true;
            while (run)
            {

                switch (userInput)
                {
                    case "l":
                        UserLogin.Login();
                        run = false;
                        break;
                    case "r":
                        Register.RegisterNewUser();
                        run = false;
                        break;
                    case "a":
                        AdminLogin.AdminUser();
                        AdminChoice();
                        run = false;
                        break;

                }

            }

        }

        public static void AdminChoice()
        {
            bool run = true;

            string adminChoice;

            Console.WriteLine("Vad vill du göra? ");
            Console.WriteLine("Välj ett av följande alternativ. ");
            Console.WriteLine("1. Lägga till en produkt i sortimentet");
            Console.WriteLine("2. Tabort en produkt i sortimentet");
            Console.WriteLine("3. Visa och redigera kundinfo");
            Console.WriteLine("4. Visa transaktioner");
            adminChoice = Console.ReadLine();

            while (run)
            {

                switch (adminChoice)
                {
                    case "1":

                        AdminChoice();
                        run = false;
                        break;
                    case "2":

                        AdminChoice();
                        run = false;
                        break;
                    case "3":

                        AdminChoice();
                        run = false;
                        break;
                    case "4":
                        AdminChoice();
                        run = false;
                        break;
                    case "5":
                        Console.WriteLine("Du loggas nu ut.");
                        MenuChoice();
                        run = false;
                        break;
                    default:
                        break;

                }

            }

        }

        public static void UserChoice()
        {

        }
    }
}
