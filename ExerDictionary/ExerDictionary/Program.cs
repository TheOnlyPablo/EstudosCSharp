using System;

namespace ExerDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();

            Dictionary<string, int> cookies = new Dictionary<string, int>();

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(',');
                        string name = line[0];
                        int votes = int.Parse(line[1]);

                        if(cookies.ContainsKey(name))
                        {
                            cookies[name] += votes;
                        }
                        else
                        {
                            cookies[name] = votes;
                        }
                    }

                    foreach(KeyValuePair<string, int> item in cookies)
                    {
                        Console.WriteLine(item.Key + ": " + item.Value );
                    }
                    
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
