using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsLab2
{
    public class RadixSorting
    {
        public static void Sorting(List<string> listForSorting, int maxWordLen, int alphabetLen)
        {
            var lists = new List<List<string>>();
            for (int i = 0; i < alphabetLen; i++)
                lists.Add(new List<string>());

            for (int step = maxWordLen - 1; step >= 0; --step)
            {
                for (int i = 0; i < listForSorting.Count; ++i)
                {
                    int temp;
                    if (listForSorting[i].Length <= step)
                        temp = listForSorting[i][listForSorting[i].Length - 1] - 'a';
                    else
                        temp = listForSorting[i][step] - 'a';

                    lists[temp].Add(listForSorting[i]);
                }

                listForSorting.Clear();

                foreach (var list in lists)
                {
                    foreach (var str in list)
                        listForSorting.Add(str);
                    list.Clear();
                }
            }
        }
    }
}
