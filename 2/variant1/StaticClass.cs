class StaticClass
{
    public void FillArray(int[] arr)
    {
        Random rand = new();
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = rand.Next(-10000, 10001);
        }
    }

    public string PrintArray(int[] arr)
    {
        string output = String.Empty;
        for (int i = 0; i < arr.Length; i++)
        {
            output += $"arr[{i}] = {arr[i]} \n";
        }
        return output;
    }

    public int Count(int[] arr)
    {
        int c = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            int k = arr[i];
            int n = arr[i++];

            if (k % 3 == 0 & n % 3 != 0)
            {
                c++;
            }
            else if (k % 3 != 0 & n % 3 == 0)
            {
                c++;
            }
        }

        return c;
    }

}