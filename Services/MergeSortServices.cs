using BIT265_MergeSort.Models;
using Castle.Core.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BIT265_MergeSort.Services
{
    public class MergeSortServices : IMergeSortServices
    {
        public List<IQueryable<WifiHotspotsModel>> MergeSort(List<IQueryable<WifiHotspotsModel>> unsorted)
        {
            if (unsorted.Count <= 1)
                return unsorted;

            List<IQueryable<WifiHotspotsModel>> left = new List<IQueryable<WifiHotspotsModel>>();

            List<IQueryable<WifiHotspotsModel>> right = new List<IQueryable<WifiHotspotsModel>>();

            int middle = unsorted.Count / 2;
            for (int i = 0; i < middle; i++)  //Dividing the unsorted list
            {
                left.Add(unsorted[i]);
            }
            for (int i = middle; i < unsorted.Count; i++)
            {
                right.Add(unsorted[i]);
            }

            left = MergeSort(left);
            right = MergeSort(right);
            return Merge(left, right);
        }

        public List<IQueryable<WifiHotspotsModel>> Merge(List<IQueryable<WifiHotspotsModel>> left, List<IQueryable<WifiHotspotsModel>> right)
        {
            List<IQueryable<WifiHotspotsModel>> result = new List<IQueryable<WifiHotspotsModel>>();

            while (left.Count > 0 || right.Count > 0)
            {
                if (left.Count > 0 && right.Count > 0)
                {
                    if (left.FirstOrDefault().Select(l => l.Id)  <= right.FirstOrDefault().Select(l => l.Id))  //Comparing First two elements to see which is smaller
                    {
                        result.Add(left.First());
                        left.Remove(left.First());      //Rest of the list minus the first element
                    }
                    else
                    {
                        result.Add(right.First());
                        right.Remove(right.First());
                    }
                }
                else if (left.Count > 0)
                {
                    result.Add(left.First());
                    left.Remove(left.First());
                }
                else if (right.Count > 0)
                {
                    result.Add(right.First());

                    right.Remove(right.First());
                }
            }
            return result;
        }
    }
}
