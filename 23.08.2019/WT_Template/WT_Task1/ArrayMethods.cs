using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WT_Task1
{
    class ArrayMethods
    {
        public string[] arr { get; set; }
        public ArrayMethods(string array)
        {
            arr = array.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        }
    }
}
