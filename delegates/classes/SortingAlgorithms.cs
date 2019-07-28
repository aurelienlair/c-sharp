public enum SortingTypes
{
    BubbleSort,
    QuickSort,
    InsertionSort
}

public delegate string[] SortingMethod(string[] data);

public static class SortingAlgorithms
{
    public static string[] ComputeArrayWithoutDelegate(string[] data, SortingTypes sortingType)
    {
        // Do some stuff on the array

        // Order the array
        switch (sortingType)
        {
            case SortingTypes.BubbleSort:
                data = SortingAlgorithms.BubbleSort(data);
                break;
            case SortingTypes.QuickSort:
                data = SortingAlgorithms.QuickSort(data);
                break;
            case SortingTypes.InsertionSort:
                data = SortingAlgorithms.InsertionSort(data);
                break;
        }

        // Do other stuff on the array

        return data;
    }

    public static string[] ComputeArrayWithDelegates(string[] data, SortingMethod sortingMethod)
    {
        // Do some stuff on the array

        // Order the array
        data = sortingMethod(data);

        // Do other stuff on the array

        return data;
    }

    public static string[] BubbleSort(string[] data)
    {
        var n = data.Length;

        // Sorting strings using bubble sort 
        for (int j = 0; j < n - 1; j++)
        {
            for (int i = j + 1; i < n; i++)
            {
                if (data[j].CompareTo(data[i]) > 0)
                {
                    var temp = data[j];
                    data[j] = data[i];
                    data[i] = temp;
                }
            }
        }

        return data;
    }

    public static string[] QuickSort(string[] data)
    {
        return new string[] { "mike", "dustin", "will", "lukas" };
    }

    public static string[] InsertionSort(string[] data)
    {
        // do some stuff then return...
        return data;
    }
}