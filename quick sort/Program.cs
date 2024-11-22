namespace quick_sort;

class Program
{
    static void Main(string[] args)
    {
        List<int> list = new List<int> {};
        Random rand = new Random();
        
        for (int i = 0; i < 100; i++)
        {
            list.Add(rand.Next(0, 101));
        }
        
        int[] arr = list.ToArray();
        
        Console.WriteLine("Unsorted Array");
        Console.WriteLine(string.Join(",", arr));
        Console.WriteLine("Sorted Array");
        Console.WriteLine(string.Join(",", QuickSort(arr)));
    }
    
    static int[] QuickSort(int[] arr)
    {
        // Base case
        if (arr.Length < 2)
        {
            return arr;
        }
        
        // Recursive case
        int pivot = arr[0];
        List<int> sorted = new List<int>();
        List<int> less = arr.Skip(1).Where(x => x <= pivot).ToList();
        List<int> greater = arr.Skip(1).Where(x => x > pivot).ToList();

        
        sorted.AddRange(QuickSort(less.ToArray()));
        sorted.Add(pivot);
        sorted.AddRange(QuickSort(greater.ToArray()));
        
        return sorted.ToArray();

    }
}