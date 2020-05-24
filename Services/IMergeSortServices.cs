using System.Collections.Generic;

namespace BIT265_MergeSort.Services
{
    public interface IMergeSortServices
    {
        public List<int> MergeSort(List<int> unsorted);
        public List<int> Merge(List<int> left, List<int> right);
    }
}