using System.Reflection;
using System.Text;

namespace HarvestingFields
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command;

            while ((command = Console.ReadLine()) != "HARVEST")
            {
                Type classType = typeof(RichSoilLand);

                switch (command)
                {
                    case "private":
                        var privateFields = classType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance).Where(f => f.IsPrivate);
                        PrintPrivateFields(privateFields);
                        break;

                    case "protected":
                        var protectedFields = classType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance).Where(f => f.IsFamily);
                        PrintProtectedFields(protectedFields);
                        break;

                    case "public":
                        var publicFields = classType.GetFields(BindingFlags.Public | BindingFlags.Instance);
                        PrintPublicFields(publicFields);
                        break;

                    case "all":
                        var allFields = classType.GetFields(BindingFlags.Public | BindingFlags.NonPublic |
                            BindingFlags.Instance | BindingFlags.Static);
                        PrintAllField(allFields);
                        break;

                    default:
                        break;
                }
            }
        }
        public static void PrintPrivateFields(IEnumerable<FieldInfo> fields)
        {
            foreach (var field in fields)
            {
                Console.WriteLine($"private {field.FieldType.Name} {field.Name}");
            }
        }

        public static void PrintProtectedFields(IEnumerable<FieldInfo> fields)
        {
            foreach (var field in fields)
            {
                Console.WriteLine($"protected {field.FieldType.Name} {field.Name}");
            }
        }

        public static void PrintPublicFields(IEnumerable<FieldInfo> fields)
        {
            foreach (var field in fields)
            {
                Console.WriteLine($"public {field.FieldType.Name} {field.Name}");
            }
        }

        public static void PrintAllField(IEnumerable<FieldInfo> fields)
        {
            foreach (var field in fields)
            {
                string accessModifier = field.IsPublic ? "public" : field.IsPrivate ? "private" : "protected";
                Console.WriteLine($"{accessModifier} {field.FieldType.Name} {field.Name}");
            }
        }
    }
}