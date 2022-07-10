namespace Design_Patterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Registration Schoolregistration = new SchoolRegistration();
            Console.WriteLine("--------------------------");
            Registration Collegeregistration = new CollegeRegistration();

        }

        public abstract class Registration
        {
            public static void TemplateMethod(Action Login, Action Register, Action Validation, Action Payment, Action Logout)
            {
                Login();
                Register();
                Validation();
                Payment();
                Logout();
            }
        }

        public class SchoolRegistration : Registration
        {
            public void Login()
            {
                Console.WriteLine($"Login to {this.GetType().Name}");
            }

            public void Logout()
            {
                Console.WriteLine($"Logout from {this.GetType().Name}");
            }

            public void Register()
            {
                Console.WriteLine($"Registration starts for {this.GetType().Name}");
            }

            public void Validation()
            {
                Console.WriteLine($"Validation starts for {this.GetType().Name}");
            }

            public void Payment()
            {
                Console.WriteLine($"Payment starts for {this.GetType().Name}");
            }

            public SchoolRegistration()
            {
                TemplateMethod(Login, Register, Validation, Payment, Logout);
            }


        }

        public class CollegeRegistration : Registration
        {
            public void Login()
            {
                Console.WriteLine($"Login to {this.GetType().Name}");
            }

            public void Logout()
            {
                Console.WriteLine($"Logout from {this.GetType().Name}");
            }

            public void Register()
            {
                Console.WriteLine($"Registration starts for {this.GetType().Name}");
            }

            public void Validation()
            {
                Console.WriteLine($"Validation starts for {this.GetType().Name}");
            }

            public void Payment()
            {
                Console.WriteLine($"Payment starts for {this.GetType().Name}");
            }

            public CollegeRegistration()
            {
                TemplateMethod(Login, Register, Validation, Payment, Logout);
            }


        }

    }

}