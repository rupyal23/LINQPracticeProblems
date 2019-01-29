using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQPractice
{
    class Program
    {
        //Creating Own Delegate
        public delegate List<string> RemoveSubstringFunction(List<string> list);

        static void Main(string[] args)
        {
            //Problem No 1 - Return words that contain 'th' from a list
            List<string> words = new List<string> { "the", "bike", "this", "it", "tenth", "mathematics" };
            var newList = words.Where(m => m.Contains("th"));
            foreach (var el in newList)
            {
                Console.WriteLine(el);
            }
            Console.ReadLine();

            //Problem No 2 - Remove Duplicate values from a List
            //Used Built in Delegate
            //Func<List<T>, List<T>> removeDuplicatesDelegate;
            //List<string> names = new List<string> { "Mike", "Brad", "Nevin", "Ian", "Mike", "Kim" };
            //removeDuplicatesDelegate = WithoutDuplicates;


            //Alternate for Problem 2 --without delegate
            List<string> names = new List<string> { "Mike", "Brad", "Nevin", "Ian", "Mike", "Kim" };
            var resultList = names.Distinct();

            //Problem No 3
            //split one index -- which would be string[]
            //convert to int
            //compare each value - delete min
            //do average
            //save the average value in a list
            //do above steps for all indexes
            //average out the new list

            List<string> classGrades = new List<string>()
                {
                    "80,100,92,89,65",
                    "93,81,78,84,69",
                    "73,88,83,99,64",
                    "98,100,66,74,55"
                };

            List<double> averageOfaveragesList = new List<double>();

            for (int i = 0; i < classGrades.Count; i++)
            {
                var averageOfGrades = classGrades[i].Split(',').Select(m => Int32.Parse(m)).OrderBy(l => l).Skip(1).Average();
                averageOfaveragesList.Add(averageOfGrades);
            }
            var averageOfaverages = averageOfaveragesList.Average();
            Console.WriteLine(averageOfaverages);
            Console.ReadLine();


            //Problem No 4
            //DID THIS WITH GROUPBY, by reading documentation and just randomly changing code, IT WORKED BUT HAVE NO UNDERSTANDING HOW
            string input = "Terrill";
            var result = input.ToUpper().ToArray().OrderBy(a => a);
            var result2 = result.GroupBy(x => x, (key, values) => new { key, values = values.Count()});
            var resultString = "";
            foreach(var el in result2)
            {
                resultString += el.key.ToString() + el.values;
            }
            Console.WriteLine(resultString);
            Console.ReadLine();
        }
    }
}
