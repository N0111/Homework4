class StaticClass
{
    int[] storage;
    public StaticClass(string path)
    {

        string[] data = File.ReadAllLines(path);
        int a = data.Length;
        for (int i = 0; i < data.Length; i++)
        {
            Console.WriteLine(data[i]);
        }
        storage = new int[a];
    }


    public int Count()
    {
        int c = 0;

        for (int i = 0; i < storage.Length; i++)
        {
            int k = storage[i];
            int n = storage[i++];

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