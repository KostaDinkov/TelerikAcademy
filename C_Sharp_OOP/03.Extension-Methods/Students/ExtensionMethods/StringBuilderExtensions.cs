using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.ExtensionMethods
{
    public static class StringBuilderExtensions
    {
        public static StringBuilder Substring(this StringBuilder sb, int index, int length)
        {
            return new StringBuilder(sb.ToString().Substring(index, length));
        }
    }
}
