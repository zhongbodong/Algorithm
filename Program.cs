using Algorithm.SortAlgorithms;
using System;
using System.Collections.Generic;

namespace Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sortList = new List<int> { 12, 23, 53, 54, 96, 54, 75, 23, 46, 25 };
            #region 冒泡排序
            //var list= BubbleSort.Sort(sortList);
            #endregion

            #region 选择排序
            var list = SelectionSort.Sort(sortList);
            #endregion


            //二叉查找树

            //红黑树：自平衡的二叉查找树
            //五大原则：
            //(1)节点为黑色或者红的





            foreach (var item in list)
            {
                System.Console.Write(item + " ");
            }
            Console.WriteLine("Hello World!");
            Console.Read();
        }
    }
}
