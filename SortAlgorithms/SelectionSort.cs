using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.SortAlgorithms
{
    //选择排序：找出最小的值 然后与头部交换
    public class SelectionSort
    {
        public static List<int> Sort(List<int> lists)
        {
            //List<int> returnList = new List<int>();
            for (int outer = 0; outer < lists.Count; outer++)
            {
                int min = lists[outer];
                for (int inner = outer + 1; inner < lists.Count; inner++)
                {
                    if (lists[inner] < min)
                    {
                        min = lists[inner];
                    }
                }
                lists[outer] = min;
            }

            return lists;

        }

    }
}
