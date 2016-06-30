using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressYourself
{
    public class Parser
    {
        /// <summary>
        /// Looks for a title in a Media file string.
        /// </summary>
        /// <param name="str">The string to search</param>
        /// <returns>the title string if it exists</returns>
        public static string GetTitle(string str)
        {
            var titleExpression = new Regex(@"Title\: (.*),+");
            var match = titleExpression.Match(str);
            if (!match.Success)
            {
                return "Title Not Found";
            }
            else
            {
                return match.Groups[1].Value;
            }
        }
    public static string GetType(string str)
        {
            var titleExpression = new Regex(@"Type\: (.*),Title");
            var match = titleExpression.Match(str);
            if (!match.Success)
            {
                return "Type Not Found";
            }
            else
            {
                return match.Groups[1].Value;
            }
        }

        public static string GetLength(string str)
        {
            var lengthExpression = new Regex(@",Length\: (.*)");
            var match = lengthExpression.Match(str);
            if (!match.Success)
            {
                return "No type found";
            }
            else
            {
                return match.Groups[1].Value;
            }
        }

        public static bool IsValidLine(string str)
        {
            var validLineExpression = new Regex(@"Type: ([a-zA-z]+),Title\: (.*),+Length\: ([0-9a-zA-Z a-z]+)");
            var match = validLineExpression.Match(str);
            if (match.Success)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
