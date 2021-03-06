using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace LeetCode
{
    public class Sort
    {
        //选择排序
        public int[] SelectSort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int min = i;
                for (int ii = i + 1; ii < array.Length; ii++)
                {
                    if (array[ii] < array[min])
                        min = ii;
                }

                var temp = array[min];
                array[min] = array[i];
                array[i] = temp;
            }

            return array;
        }

        //插入排序
        public int[] InsertSort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int ii = i; ii > 0 && array[ii] < array[ii - 1]; ii--)
                {
                    var temp = array[ii];
                    array[ii] = array[ii - 1];
                    array[ii - 1] = temp;
                }
            }
            return array;
        }

        //希尔排序
        public int[] ShellSort(int[] array)
        {
            int len = array.Length;
            int gap = 1;
            while (gap < len / 3)
                gap = gap * 3 + 1;
            while (gap >= 1)
            {
                for (int i = gap; i < len; i++)
                {
                    for (int j = i; j >= gap && array[j] < array[j - gap]; j -= gap)
                    {
                        var temp = array[j];
                        array[j] = array[j - gap];
                        array[j - gap] = temp;
                    }
                }
                gap /= 3;
            }
            return array;
        }

        #region 归并排序
        public void MergeSort(int[] array)
        {
            int[] temp = new int[array.Length];
            MSort(array, 0, array.Length - 1, temp);
        }

        private void MSort(int[] array, int left, int right, int[] temp)
        {
            if (left >= right)
                return;
            int mid = left + (right - left) / 2;
            MSort(array, left, mid, temp);
            MSort(array, mid + 1, right, temp);
            Merge(array, left, mid, right, temp);
        }

        private void Merge(int[] array, int left, int mid, int right, int[] temp)
        {
            int i = left;
            int j = mid + 1;
            int t = 0;
            while (i <= mid && j <= right)
            {
                if (array[i] < array[j])
                    temp[t++] = array[i++];
                else
                    temp[t++] = array[j++];
            }

            while (i <= mid)
                temp[t++] = array[i++];

            while (j <= right)
                temp[t++] = array[j++];

            t = 0;

            while (left <= right)
                array[left++] = temp[t++];
        }
        #endregion

        #region 堆排序
        public void HeapSort(int[] array)
        {
            for (int i = array.Length / 2 - 1; i >= 0; i--)
            {
                AdjustHeap(array, i, array.Length);
            }

            for (int i = array.Length - 1; i > 0; i--)
            {
                var temp = array[i];
                array[i] = array[0];
                array[0] = temp;
                AdjustHeap(array, 0, i);
            }
        }

        private void AdjustHeap(int[] array, int i, int len)
        {
            var temp = array[i];
            for (int k = i * 2 + 1; k < len; k = k * 2 + 1)
            {
                if (k + 1 < len && array[k] < array[k + 1])
                    k++;
                if (array[k] > temp)
                {
                    array[i] = array[k];
                    i = k;
                }
                else
                {
                    break;
                }
            }

            array[i] = temp;
        }
        #endregion

    }
}
