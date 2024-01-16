using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _048_yield
{
    public class EvenNumberGenerator
    {
        public IEnumerable<int> GenerateEvenNumbers()
        {
            for (int i = 0;i>-1;i+=2)
                yield return i;

        }
    }
}
