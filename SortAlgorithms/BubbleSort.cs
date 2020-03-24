using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.SortAlgorithms
{

    /// <summary>
    /// 冒泡排序
    /// </summary>
    public static class BubbleSort
    {

        public static List<int> Sort(List<int> sortList)
        {
            int tem;
            for (int outer = 0; outer < sortList.Count; outer++)
            {
                for (int inner = outer + 1; inner < sortList.Count; inner++)
                {
                    if (sortList[inner] < sortList[outer])
                    {
                        tem = sortList[inner];
                        sortList[inner] = sortList[outer];
                        sortList[outer] = tem;
                    }
                }
            }
            return sortList;
        }
    }
}
