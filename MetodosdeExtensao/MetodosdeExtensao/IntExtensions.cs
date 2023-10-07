using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosdeExtensao
{
    internal static class IntExtensions
    {
        public static bool IsEven(this int value) =>  value % 2 == 0;
        public static bool IsOdd(this int value) => !IsEven(value);
    }
}
