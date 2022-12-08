namespace UserRegistrationExceptionHandling
{
    public class Program
    {
        static void Main(string[] args)
        {
            string userInput = "ab";
            string output = UserDetails.FirstName(userInput);
            Console.WriteLine(output);
        }
    }
}