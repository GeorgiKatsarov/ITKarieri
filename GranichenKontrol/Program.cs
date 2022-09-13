List<string> input = Console.ReadLine().Split(' ').ToList();
List<string> numbers = new List<string>();
while (input[0] != "END")
{
    if (input.Count == 3)
    {
        numbers.Add(input[2]);
    }   
    else if (input.Count == 2)
    {
        numbers.Add(input[1]);
    }
    input = Console.ReadLine().Split(' ').ToList();
}
string badNumber = Console.ReadLine();
string x = "";
foreach (string number in numbers)
{
    x = number.Substring(number.Length - 3);
    if ( x == badNumber)
    {
        Console.WriteLine(number);
    }
}
