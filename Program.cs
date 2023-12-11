namespace GIK299_HT23_Vili_Mujkanovic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string FirstName = "Pablo";
            string LastName = "Escobar";
            int Age = 44;
            string Eyecolor = "Brown";
            Gender gender = Gender.Man;
            Hair hair = new Hair {hairColor = "Brown", hairLength = "6 cm long"};
            DateTime birthDay = new DateTime( 1949, 12, 1);
        

            Person person = new Person (FirstName, LastName, Age, gender, hair, birthDay, Eyecolor);

            Console.WriteLine(person.ToString());
        }
    }
}
