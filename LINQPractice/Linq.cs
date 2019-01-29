using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQPractice
{
    class Linq
    {
        List<string> words = new List<string> { "the", "bike", "this", "it", "tenth", "mathematics" };
        List<string> newList = new List<string>();

        

        public List<string> RemoveTH()
        {
            foreach(string el in words)
            {
                if (el.Contains("th"))
                {
                    newList.Add(el);
                }
                
            }
            return newList;
        }



        



    }


}
