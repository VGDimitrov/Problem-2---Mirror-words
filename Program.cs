/*
 * Dictinary zad 1 dom 
 */

string[] inputString=Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).ToArray();
Dictionary<char,int>   countWords = new Dictionary<char,int>();
int count = 0;
for (int i = 0; i < inputString.Length; i++)
{
 
        foreach (char c in inputString[i])
        {
            if (countWords.ContainsKey(c))
            {
                if (countWords.ContainsKey(c)) 
                {
                countWords[c]+=1;

                }
                
            }
            else
            {
                countWords.Add(c, 1);
            }

        }
    
}
foreach (var c in countWords)
{
    Console.WriteLine($"{c.Key} -> {c.Value}");
}
