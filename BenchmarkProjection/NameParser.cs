using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenchmarkProjection
{
    public class NameParser
    {
        public string GetLastName(string fullName)
        {
            var names = fullName.Split(' ');
            return names.LastOrDefault() ?? string.Empty;
        }
    }
}
