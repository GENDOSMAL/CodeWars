using System;
using System.Collections.Generic;
using System.Linq;

namespace Tasks.Permutations
{
    public static class Impl
    {
        public static List<string> SinglePermutations(string s)
        {
            if (string.IsNullOrEmpty(s))
                return null;

            if (s.Length == 1)
                return new List<string>(1) { s };
            var res = new List<string>() /*{s}*/;
            Permute(s, "", res);
            
            return res.Distinct().ToList();
        }

        static void Permute(string s, string answer, List<string> answerList)
        {
            if (s.Length == 0)
            {
                answerList.Add(answer);
                return;
            }

            for (var i = 0; i < s.Length; i++)
            {
                var ch = s[i];
                var leftSubstr = s.Substring(0, i);
                var rightSubstr = s.Substring(i + 1);
                var rest = leftSubstr + rightSubstr;
                Permute(rest, answer + ch, answerList);
            }
        }
    }
}