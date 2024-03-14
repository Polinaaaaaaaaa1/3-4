using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_3
{
     abstract class BaseArray<T>
    {
        protected abstract void user_fill();
        protected abstract void random_fill();
        protected IValue<T> value;
        protected BaseArray(IValue<T> value)
        {
            this.value = value;
        }
        public void fill_select(bool id)
        { if (id == true)
            {
                this.user_fill();
            }

            else
            {
                this.random_fill();
            }
        }

    }
}
