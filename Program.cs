namespace FindCombos;

class Program
{
    static void Main()
    {
        List<char> symbols = new List<char>() { 'A', 'B', 'C', 'A' }; 

        List<string> combinations = GenerateCombinations(symbols);

        foreach (var combination in combinations)
        {
            Console.WriteLine(combination);
        }
    }

    static List<string> GenerateCombinations(List<char> symbols)
    {
        List<string> combinations = new List<string>();

        GenerateCombinationsRecursive(symbols, "", combinations);

        return combinations;
    }

    static void GenerateCombinationsRecursive(List<char> symbols, string currentCombination, List<string> combinations)
    {
        if (symbols.Count == 0)
        {
            combinations.Add(currentCombination);
            return;
        }

        for (int i = 0; i < symbols.Count; i++)
        {
            char symbol = symbols[i];
            List<char> remainingSymbols = new List<char>(symbols);
            remainingSymbols.RemoveAt(i);

            string updatedCombination = currentCombination + symbol;

            GenerateCombinationsRecursive(remainingSymbols, updatedCombination, combinations);
        }
    }
}