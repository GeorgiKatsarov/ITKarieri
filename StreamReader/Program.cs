namespace StreamReader1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, int> dict = new SortedDictionary<string, int>();
            using (
                var reader = new StreamReader("words.txt"))
            {
                using (var reader2 = new StreamReader("text.txt"))
                {
                    using (var writer = new StreamWriter("result.txt"))
                    {
                        List<string> listWords = reader.ReadLine().ToLower().Split(' ', ',', '.', '-').ToList();
                        List<string> listText = reader2.ReadLine().ToLower().Split(' ', ',', '.', '-').ToList();
                        foreach (var item in listWords)
                        {
                            int count = 0;
                                for (int i = 0; i < listText.Count; i++)
                                {
                                    if (listText[i].Equals(item))
                                    {
                                        count++;
                                    }
                                }
                               
                            dict.Add(item, count);
                        }
                        foreach (var element in dict)
                        {
                            writer.WriteLine($"{element.Key} : {element.Value}");
                        }
                    }
                    
                }
            }
            
        }
    }
}