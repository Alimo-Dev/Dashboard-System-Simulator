using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard_System_Simulator
{
    internal class Tool
    {
        public static bool ToExist(List<string> list, string value)
        {
            bool ToExist = false;
            for (int i = 0; i < list.Count; i++)
            {
                if(value == list[i])
                {
                    ToExist = true;
                    break;
                }    
            }
            return ToExist;
        }
    }
}
