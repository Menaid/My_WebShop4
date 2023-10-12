
namespace My_WebShop4
{
    public class User
    {
        public static void LogIn()
        {

        }

        public static void SignUp()
        {
            Dictionary<string?, string?> users = new Dictionary<string?, string?>();
            Console.WriteLine("Vänligen ange ett användarnamn: ");
            string userName = Console.ReadLine();
            Console.WriteLine("Vänligen ange ett lösenord: ");
            string passWord = Console.ReadLine();

            users.Add(userName, passWord);
        }


    }
}
