public class Solution {
    public int CountGoodSubstrings(string s) {

        int goodString = 0; 
        for(int i = 0; i < s.Length - 2; i++)
        {
            if(s[i] != s[i+1] && s[i+1] != s[i+2] && s[i+2] != s[i])
            {
                goodString++;
            }
        }
        return goodString;
    }
}

        /* Old solution
        // Console.WriteLine(s.Length);
        int goodString = 0;
   

        int i = 0;
        while(i + 3 <= s.Length)
        {
            var subStrings = s.Substring(i, 3);
            bool isGoodString = true;
            Dictionary<char, int> charDict = new Dictionary<char, int>();
            //charDict.Clear();

            foreach(char c in subStrings)
            {
                //Console.WriteLine(c);

                if(!charDict.ContainsKey(c))
                    charDict.Add(c, 0);
                else
                {
                    isGoodString = false;
                    break;
                }
            }

            if(isGoodString) goodString++;
            i ++;
        }
        return goodString;
    }
    }
    */