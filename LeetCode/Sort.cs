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
        public static void Show(int[] array)
        {
            string str = String.Empty;
            for (int i = 0; i < array.Length; i++)
            {
                str += $"{array[i]}  ";
            }

            Console.WriteLine(str);
        }
        public static void Swap(int[] array, int a, int b)
        {
            var temp = array[a];
            array[a] = array[b];
            array[b] = temp;
            Show(array);
        }
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

                Swap(array, min, i);
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
                    Swap(array, ii, ii - 1);
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
                        Swap(array, j, j - gap);
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

        public void MyHeapSort(int[] array)
        {
            BuildHeap(array);

            var len = array.Length - 1;
            while (len >= 0)
            {
                Swap(array, 0, len);
                len--;
                int i = 0;
                while (i <= len / 2 - 1)
                {
                    i = Heapify(array, i, len);
                }
            }
        }

        private void BuildHeap(int[] array)
        {
            for (int i = array.Length / 2 - 1; i >= 0; i--)
            {
                Heapify(array, i, array.Length);
            }
        }

        private int Heapify(int[] array, int index, int len)
        {
            int leftChild = index * 2 + 1;
            int rightChild = leftChild + 1;
            bool isHaveLeft = leftChild < len;
            bool isHaveRight = rightChild < len;
            if (!(isHaveRight || isHaveLeft))
                return -1;
            int temp = leftChild;
            if (isHaveRight && isHaveLeft && array[leftChild] < array[rightChild])
                temp = rightChild;
            if (array[index] < array[temp])
                Swap(array, temp, index);
            return temp;
        }

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

        #region 快排

        public void MyQuickSort(int[] nums, int left, int right)
        {
            if (left >= right)
                return;

            int i = left;
            int j = right;
            int mid = nums[(left + right) / 2];
            while (true)
            {
                while (i < right && nums[i] < mid)
                    i++;
                while (j > 0 && nums[j] > mid)
                    j--;
                if (i == j)
                    break;

                Swap(nums, i, j);
            }
            MyQuickSort(nums, left, i);
            MyQuickSort(nums, i + 1, right);
        }
        #endregion
    }
}
