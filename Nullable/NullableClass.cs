using System;
using System.Collections.Generic;
using System.Text;

namespace Nullable
{
    class NullableClass
    {
        public int? Number = null;

        public NullableClass(int? number)
        {
            Number = number;
        }
    }
}
