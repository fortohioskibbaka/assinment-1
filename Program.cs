namespace assinment_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fristName = "John";
            string favmovie = "MATRIX";
            string favquote = "you need guys like me";



            Console.WriteLine($"my name is {fristName.ToLower()} and my fav movie is {favmovie.ToLower()}");
            Console.WriteLine(favmovie.Contains("the"));

            // Replace all vowels in favquote with '*'
            
            favquote=(favquote.Replace("a", " "));
            favquote = (favquote.Replace("i", " "));
            favquote = (favquote.Replace("e", " "));
            favquote = (favquote.Replace("o", " "));
            favquote = (favquote.Replace("u", " "));
            Console.WriteLine(favquote.Replace("a'e'i'o'u ", " "));
            Console.WriteLine(favquote);

           
            
           
            Console.WriteLine("         .';:;'.");
            Console.WriteLine("        /_' _' /\\   __");
            Console.WriteLine("        ;a/ e= J/-'\"  '.'");
            Console.WriteLine("        \\ ~_   (  -'  ( ;_ ,.");
            Console.Write("         L~\"'_.    -.  \\ ./  )");       Console.WriteLine("            />_________________________________");
            Console.Write("         ,'-' '-._  _;  )'   (");         Console.WriteLine("    [########[]_________________________________>");
            Console.Write("       .' .'   _.'\")  \\  \\(  |");      Console.WriteLine("          ___");
            Console.WriteLine("      /  (  .-'   __\\{`', \\  |");
            Console.WriteLine("     / .'  /  _.-'   \"  ; /  |");
            Console.WriteLine("    / /    '-._'-,     / / \\ (");
            Console.WriteLine(" __/ (_    ,;' .-'    / /  /_'-._");
            Console.WriteLine("`\"-'` ~`  ccc.'   __.','     \\j\\L\\");
            Console.WriteLine("                 .=\'/|\\7      ");
            Console.WriteLine("     snd           ' `");

        }
       
    }
}
