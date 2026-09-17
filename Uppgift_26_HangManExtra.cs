namespace HangManExtra
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Hänga gubbe - Extrauppgift";

            // --- SPELVARIABLER ---
            string secretWord = "PROGRAMMERING";
            string shownWord = "_____________"; // Lika många understreck som bokstäver
            string guessedLetters = "";
            int numErrors = 0; 
            const int maxErrors = 6;
            bool won = false;

            // =========================================================
            // TODO: SKRIV DIN SPELLOOP HÄR UNDER (while-loop)
            // =========================================================

            DrawHangMan(numErrors); //Ritar upp grunden av galgen (antalFel är just nu 0)



            // =========================================================
            // Slut på din kod
            // =========================================================
        }

        /// <summary>
        /// FÄRDIG METOD: Anropa denna med DrawHangMan(numErrors) för att visa grafiken!
        /// Skapa INGA egna metoder utöver denna.
        /// </summary>
        static void DrawHangMan(int errors)
        {
            Console.WriteLine();
            switch (errors)
            {
                case 0:
                    Console.WriteLine("  +---+\n  |   |\n      |\n      |\n      |\n      |\n=========");
                    break;
                case 1:
                    Console.WriteLine("  +---+\n  |   |\n  O   |\n      |\n      |\n      |\n=========");
                    break;
                case 2:
                    Console.WriteLine("  +---+\n  |   |\n  O   |\n  |   |\n      |\n      |\n=========");
                    break;
                case 3:
                    Console.WriteLine("  +---+\n  |   |\n  O   |\n /|   |\n      |\n      |\n=========");
                    break;
                case 4:
                    Console.WriteLine("  +---+\n  |   |\n  O   |\n /|\\  |\n      |\n      |\n=========");
                    break;
                case 5:
                    Console.WriteLine("  +---+\n  |   |\n  O   |\n /|\\  |\n /    |\n      |\n=========");
                    break;
                case 6:
                    Console.WriteLine("  +---+\n  |   |\n  O   |\n /|\\  |\n / \\  |\n      |\n=========");
                    Console.WriteLine("\nGAME OVER!");
                    break;
            }
            Console.WriteLine();
        }
    }
}
