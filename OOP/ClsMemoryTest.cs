using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class ClsMemoryTest
    {
        public static int count = 0;
        public ClsMemoryTest()
        {
            count += 1;
        }
        ~ClsMemoryTest()
        {
            count -= 1;
        }

        
    }
}
