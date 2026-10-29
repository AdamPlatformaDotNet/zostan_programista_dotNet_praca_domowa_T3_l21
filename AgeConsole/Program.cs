namespace AgeConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wpisz swoje imię: ");
            var name = GetInputString();

            Console.WriteLine("Wpisz swoje miasto: ");
            var town = GetInputString();


            var ageDay = GetInputNumber("Wpisz dzień swoich urodzin");
            var ageMonth = GetInputNumber("Wpisz miesiąc swoich urodzin w formacie liczbowym np. 1, 2");
            var ageYear = GetInputNumber("Wpisz rok swoich urodzin w formacie liczbowym np 1992, 2000");

            var dateOfBirth = BuildDateBirth(ageYear, ageMonth, ageDay);

            Console.WriteLine(BuildMessage(name, town, dateOfBirth));
        }

        private static int BuildDateBirth(int year, int month, int day)
        {
            var ageOfBirth = new DateTime(year, month, day);
            var currentAge = DateTime.Today.Year - ageOfBirth.Year;
            return currentAge;
        }

        private static string GetInputString()
        {
            return Console.ReadLine();
        }

        private static int GetInputNumber(string prompt)
        {
            while (true)
            {
                Console.WriteLine(prompt);
                int result;
                if (int.TryParse(Console.ReadLine(), out result))
                    return result;

                Console.WriteLine("Wartość nie jest Liczbą! spróbuj ponownie");
            }
        }

        private static string BuildMessage(string name, string town, int dateOfBirth)
        {
            return $"Cześć {name} urodziłeś się w {town} i masz {dateOfBirth} lat";
        }
    }
}