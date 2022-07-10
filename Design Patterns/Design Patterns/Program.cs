namespace Design_Patterns
{
    internal class Program
    {
        /// <summary>
        /// Template Design Patterns defines the skeleton of an algo in a operation deferring some steps to subclasses
        /// Subclasses redefine the steps of an algo without changing algo structure
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            new SchoolRegistration();
            Console.WriteLine("--------------------------");
            new CollegeRegistration();

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