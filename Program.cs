using Newtonsoft.Json;

namespace Lab9_LINQInManhattan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string json = File.ReadAllText("../../../data.json");
            Root root = JsonConvert.DeserializeObject<Root>(json)!;
            Console.WriteLine("Please do the following:\n");
            // 1. Output all of the neighborhoods in this data list
            Console.WriteLine("1.Output all of the neighborhoods in this data list.\n");
            var allNeighborhoods = root.features?.Select(f => f.properties?.neighborhood).ToList();
            Console.WriteLine($"******************** All Neighborhoods ({allNeighborhoods?.Count} neighborhoods) ********************\n");
            allNeighborhoods?.ForEach(Console.WriteLine);
            Console.WriteLine($"***************************************************************************************************************\n");

            // 2. Filter out all the neighborhoods that do not have any names
            Console.WriteLine("2.Filter out all the neighborhoods that do not have any names\n");
            var neighborhoodsWithNames = allNeighborhoods?.Where(n => !string.IsNullOrEmpty(n)).ToList();
            Console.WriteLine($"******************** Neighborhoods that do not have any names ({neighborhoodsWithNames?.Count} neighborhoods) ********************\n");
            neighborhoodsWithNames?.ForEach(Console.WriteLine);
            Console.WriteLine($"***************************************************************************************************************\n");

            // 3. Remove the duplicates
            Console.WriteLine("3.Remove the duplicates.\n");
            var distinctNeighborhoods = neighborhoodsWithNames?.Distinct().ToList();
            Console.WriteLine($"******************** Distinct Neighborhoods ({distinctNeighborhoods?.Count} neighborhoods) ********************\n");
            distinctNeighborhoods?.ForEach(Console.WriteLine);
            Console.WriteLine($"***************************************************************************************************************\n");

            // 4. Rewrite the queries from above and consolidate all into one single query
            Console.WriteLine("4.Rewrite the queries from above and consolidate all into one single query.\n");
            var consolidatedQuery = root.features?
                .Select(f => f.properties?.neighborhood)
                .Where(n => !string.IsNullOrEmpty(n))
                .Distinct()
                .ToList();
            Console.WriteLine($"******************** Consolidated Query ({consolidatedQuery?.Count} neighborhoods) ********************\n");
            consolidatedQuery?.ForEach(Console.WriteLine);
            Console.WriteLine($"***************************************************************************************************************\n");

            // 5. Rewrite at least one of these questions only using the opposing method
            Console.WriteLine("5. Rewrite at least one of these questions only using the opposing method (example: Use LINQ method calls instead of LINQ Query statements and vice versa).\n");
            var rewrittenQuery = root.features
                .Select(f => f.properties?.neighborhood)
                .Where(n => !string.IsNullOrEmpty(n))
                .Distinct()
                .ToList();
            Console.WriteLine($"********************Rewritten Query ({rewrittenQuery.Count} neighborhoods)********************\n");
            rewrittenQuery.ForEach(Console.WriteLine);
        }
    }

}