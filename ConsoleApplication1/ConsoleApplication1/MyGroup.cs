using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class MyGroup
    {
        public List<int> GroupSum(List<int> values, int group)
        {
            List<int> GroupSum = new List<int>();
            int div = values.Count / group;
            if (values.Count % group > 0)
            {
                div++;
            }

            for (int i = 1; i <= div; i++)
            {
                GroupSum.Add(values.Skip((i - 1) * group).Take(group).Sum());
            }

            return GroupSum;
        }
    }
}
