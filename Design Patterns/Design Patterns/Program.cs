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
            public abstract void Login();
            public abstract void Register();
            public abstract void Validation();
            public abstract void Payment();
            public abstract void Logout();

            public Registration()
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
            public override void Login()
            {
                Console.WriteLine($"Login to {this.GetType().Name}");
            }

            public override void Logout()
            {
                Console.WriteLine($"Logout from {this.GetType().Name}");
            }

            public override void Register()
            {
                Console.WriteLine($"Registration starts for {this.GetType().Name}");
            }

            public override void Validation()
            {
                Console.WriteLine($"Validation starts for {this.GetType().Name}");
            }

            public override void Payment()
            {
                Console.WriteLine($"Payment starts for {this.GetType().Name}");
            }

        }

        public class CollegeRegistration : Registration
        {
            public override void Login()
            {
                Console.WriteLine($"Login to {this.GetType().Name}");
            }

            public override void Logout()
            {
                Console.WriteLine($"Logout from {this.GetType().Name}");
            }

            public override void Register()
            {
                Console.WriteLine($"Registration starts for {this.GetType().Name}");
            }

            public override void Validation()
            {
                Console.WriteLine($"Validation starts for {this.GetType().Name}");
            }

            public override void Payment()
            {
                Console.WriteLine($"Payment starts for {this.GetType().Name}");
            }

        }

    }

}