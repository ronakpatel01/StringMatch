using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringMatch
{
    public class StringCompares
    {
        private string inputText;
        private const string NOMATCHES = "<no matches>";
        
        public StringCompares(string inputText)
        {
            this.inputText = inputText;
        }

        private bool isMatch(string a, string b)
        {
            // I don't know if this is allowed
            //return a == b;

            if (a.Length != b.Length)
                return false;

            for (int i = 0; i < a.Length; i++)
            {
                if (a.ToLower()[i] != b.ToLower()[i])
                    return false;
            }

            return true;
        }

        private string Substring(string text, int start, int len)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = start; i < start + len; i++)
            {
                sb.Append(text[i]);
            }

            return sb.ToString();
        }

        private string Substring(string text, int start)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = start; i < text.Length; i++)
            {
                sb.Append(text[i]);
            }

            return sb.ToString();
        }

        //private int IndexOf(string text, string subText)
        //{
        //    if (text.Length < subText.Length)
        //        return -1;

        //    for (int i = 0; i <= text.Length - subText.Length; i++)
        //    {
        //        if (isMatch(Substring(text, i, subText.Length), subText))
        //            return i;
        //    }

        //    return -1;

        //}

        private int[] GetMatchLocations(string subText)
        {
            List<int> matchPositions = new List<int>();

            if (inputText.Length >= subText.Length)
            {
                for (int i = 0; i <= inputText.Length - subText.Length; i++)
                {
                    if (isMatch(Substring(inputText, i, subText.Length), subText))
                        matchPositions.Add(i+1);
                }
            }

            return matchPositions.ToArray();
        }

        public string FindMatches(string subText)
        {
            if (inputText.Length < subText.Length)
                return NOMATCHES;

            int[] matchLocations = GetMatchLocations(subText);
            if (matchLocations.Length == 0)
                return NOMATCHES;

            StringBuilder sb = new StringBuilder();
            
            foreach (int i in matchLocations)
            {
                if (sb.Length > 0)
                    sb.Append(", ");

                sb.Append(i);
            }

            return sb.ToString();
        }
    }
}
