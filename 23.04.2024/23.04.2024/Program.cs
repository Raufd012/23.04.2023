


using Newtonsoft.Json;

namespace _23._04._2024
{
    class Program
    {
        static void Main(string[] args)
        {
            Add("Rauf");
        }
        public static List<string> Deserialize(string path)
        {
            string result;


            using (StreamReader sr = new StreamReader(path))
            {
                result = sr.ReadToEnd();
            }
            List<string> names = JsonConvert.DeserializeObject<List<string>>(result);
            return names;
        }
        public static void Serialize<T>(string path, T obj)
        {
            string result = JsonConvert.SerializeObject(obj);
            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.Write(result);
            }
        }
        public static void Add(string name)
        {
            string path = @"C:\Users\user\Desktop\23.04.2024\23.04.2024\json1.json";
            List<string> names = Deserialize(path);
            names.Add(name);

            Serialize<List<string>>(path, names);

        }
        public static void Delete(string name)
        {
            string path = @"C:\Users\user\Desktop\23.04.2024\23.04.2024\json1.json";
            List<string> names = Deserialize(path);
            if (names.Contains(name))
            {
                names.Remove(name);

                Console.WriteLine($"{name}-This user has been deleted!");
            }
            else 
            {
                Console.WriteLine("Not found so far!");
            }

            Serialize<List<string>>(path, names);

        }
        public static bool Searc(string name)
        {
            string path = @"C:\Users\user\Desktop\23.04.2024\23.04.2024\json1.json";
            List<string> names = Deserialize(path);
            if (names.Contains(name)) 
            {
                return true;
            }
            else 
            {
                return false; 
            }
            Serialize<List<string>>(path, names);


        }


    }
}
