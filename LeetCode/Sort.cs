﻿using System;

namespace LeetCode
{
    public class Sort
    {
        public static void Show(int[] array)
        {
            var str = string.Empty;
            for (var i = 0; i < array.Length; i++) str += $"{i}:{array[i]} ";

            Console.WriteLine(str);
        }

        public static void Swap(int[] array, int a, int b)
        {
            Console.WriteLine($"swap index:{a} value:{array[a]} index:{b} value:{array[b]}");

            (array[a], array[b]) = (array[b], array[a]);
            Show(array);
        }

        //选择排序
        public int[] SelectSort(int[] array)
        {
            for (var i = 0; i < array.Length; i++)
            {
                var min = i;
                for (var ii = i + 1; ii < array.Length; ii++)
                    if (array[ii] < array[min])
                        min = ii;

                Swap(array, min, i);
            }

            return array;
        }

        //插入排序
        public int[] InsertSort(int[] array)
        {
            for (var i = 0; i < array.Length; i++)
            for (var ii = i; ii > 0 && array[ii] < array[ii - 1]; ii--)
                Swap(array, ii, ii - 1);

            return array;
        }

        //希尔排序
        public int[] ShellSort(int[] array)
        {
            var len = array.Length;
            var gap = 1;
            while (gap < len / 3)
                gap = gap * 3 + 1;
            while (gap >= 1)
            {
                for (var i = gap; i < len; i++)
                for (var j = i; j >= gap && array[j] < array[j - gap]; j -= gap)
                    Swap(array, j, j - gap);

                gap /= 3;
            }

            return array;
        }

        #region 归并排序

        public void MergeSort(int[] array)
        {
            var temp = new int[array.Length];
            MSort(array, 0, array.Length - 1, temp);
        }

        private void MSort(int[] array, int left, int right, int[] temp)
        {
            if (left >= right)
                return;
            var mid = left + (right - left) / 2;
            MSort(array, left, mid, temp);
            MSort(array, mid + 1, right, temp);
            Merge(array, left, mid, right, temp);
        }

        private void Merge(int[] array, int left, int mid, int right, int[] temp)
        {
            var i = left;
            var j = mid + 1;
            var t = 0;
            while (i <= mid && j <= right)
                if (array[i] < array[j])
                    temp[t++] = array[i++];
                else
                    temp[t++] = array[j++];

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
                var i = 0;
                while (i <= len / 2 - 1) i = Heapify(array, i, len);
            }
        }

        private void BuildHeap(int[] array)
        {
            for (var i = array.Length / 2 - 1; i >= 0; i--) Heapify(array, i, array.Length);
        }

        private int Heapify(int[] array, int index, int len)
        {
            var leftChild = index * 2 + 1;
            var rightChild = leftChild + 1;
            var isHaveLeft = leftChild < len;
            var isHaveRight = rightChild < len;
            if (!(isHaveRight || isHaveLeft))
                return -1;
            var temp = leftChild;
            if (isHaveRight && isHaveLeft && array[leftChild] < array[rightChild])
                temp = rightChild;
            if (array[index] < array[temp])
                Swap(array, temp, index);
            return temp;
        }

        public void HeapSort(int[] array)
        {
            for (var i = array.Length / 2 - 1; i >= 0; i--) AdjustHeap(array, i, array.Length);

            for (var i = array.Length - 1; i > 0; i--)
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
            for (var k = i * 2 + 1; k < len; k = k * 2 + 1)
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

        //public void MyQuickSort2(int[] nums, int left, int right)
        //{
        //    if (left >= right)
        //        return;

        //    int i = left;
        //    int j = right;
        //    int mid = nums[(left + right) / 2];
        //    while (true)
        //    {
        //        while (i < right && nums[i] < mid)
        //            i++;
        //        while (j > 0 && nums[j] > mid)
        //            j--;
        //        if (i == j)
        //            break;

        //        Swap(nums, i, j);
        //    }
        //    MyQuickSort2(nums, left, i);
        //    MyQuickSort2(nums, i + 1, right);
        //}


        public void MyQuickSort(int[] nums)
        {
            QuickSort(nums, 0, nums.Length - 1);
        }

        public void QuickSort(int[] nums, int left, int right)
        {
            if (left >= right) return;

            var point = Partition(nums, left, right);

            QuickSort(nums, left, point - 1);
            QuickSort(nums, point + 1, right);
        }

        public int Partition(int[] nums, int left, int right)
        {
            var i = left;
            var j = right;
            Console.WriteLine($"[Partition] point:{nums[left]}");

            while (i < j)
            {
                while (i < j && nums[j] >= nums[left]) j--;
                while (i < j && nums[i] <= nums[left]) i++;
                Swap(nums, i, j);
            }

            Swap(nums, left, i);

            Console.WriteLine($"[Partition] point:{i}");

            return i;
        }

        #endregion
    }
}