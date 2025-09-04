namespace assinment_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fristName = "John";
            string favmovie = "MATRIX";



            Console.WriteLine($"my name is {fristName.ToLower()} and my fav movie is {favmovie.ToLower()}");
            Console.WriteLine(favmovie.Contains("the"));
        }
    }
}
