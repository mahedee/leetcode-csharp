using System;
using System.Collections.Generic;

public class Solution
{
    public int CalPoints(string[] operations)
    {
        List<int> scores = new List<int>();
        int sum = 0;

        foreach (var item in operations)
        {
            if (item.Equals("+"))
            {
                //int newScore = score[score.Count - 1] + score[score.Count - 2];
                scores.Add(scores[scores.Count - 1] + scores[scores.Count - 2]);
            }
            else if (item.Equals("D"))
            {
                // double the score
                scores.Add(scores[scores.Count - 1] * 2);
            }
            else if (item.Equals("C"))
            {
                // remove the last item
                scores.RemoveAt(scores.Count - 1);
            }
            else
            {
                scores.Add(Convert.ToInt32(item));
            }
        }

        foreach (var score in scores)
        {
            sum += score;
        }

        return sum;
    }

}