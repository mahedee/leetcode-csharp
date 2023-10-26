// Solved without IDE
// 884. Uncommon Words from Two Sentences


public class Solution {
    public string[] UncommonFromSentences(string s1, string s2) {

        // Convert a string to string array by space
        var words1 = s1.Split(' ');
        var words2 = s2.Split(' ');
        
        // Here string or word is key and count is value
        Dictionary<string, int> uniqueWords = new Dictionary<string, int>();

        List<string> uncommonWords = new List<string>();
        
        foreach(string word in words1)
        {
            // if word contains in the dictionary increase its value
            if(!uniqueWords.ContainsKey(word))
                    uniqueWords.Add(word, 0);
            else
                // Increase value of word if exists in the current dictionary
                uniqueWords[word]++;
        }

        // Same as previous
        foreach(string word in words2)
        {
            if(!uniqueWords.ContainsKey(word))
                uniqueWords.Add(word, 0);
            else
                uniqueWords[word]++;
        }

        foreach(var word in uniqueWords)
        {
            // Unique words with value 0
            if(word.Value == 0)
                uncommonWords.Add(word.Key);
        }

        // Following line to check or debug
        // Console.WriteLine(uniqueWords.Count());
  
        // Convert a list to an array
        return uncommonWords.ToArray();
    }
}