namespace aprel17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IntArrayList list = new IntArrayList();
            list.Add(1);
            list.Add(22);
            list.Add(31);
            list.Add(21);
            list.Add(25);
            list.Add(28);

            list.GetElements();
            list.LastIndex(0);
            list.IndexOf(1);
            list.Remove(2);

        }
        class IntArrayList
        {
            //public int[] _arr;
            //public int Capacity { get; set; }
            //public int Count { get; set; }

            //public IntArrayList()
            //{
            //    _arr = new int[Capacity];
            //}
            //public IntArrayList(int capacity)
            //{
            //    Capacity = capacity;
            //    _arr = new int[Capacity];
            //}
            //public void Add(int value)
            //{
            //    if (_arr.Length==Count)
            //    {
            //        Array.Resize(ref _arr,Count+Capacity);
            //    }
            //    _arr[Count] = value;
            //    Count++;
            //}
            //public void GetElements()
            //{
            //    for (int i = 0; i < Count; i++)
            //    {
            //        Console.WriteLine(_arr[i]);
            //    }

            //}



            public int[] _arr;
            public int Capacity { get; set; } 
            public int Count { get; private set; }


            public IntArrayList()
            {
                Capacity = 7;
                _arr = new int[Capacity];
            }

            public IntArrayList(int capacity)
            {
                Capacity = capacity;
                _arr = new int[Capacity];
            }

            public void Add(int value)
            {
                if (_arr.Length == Count)
                {
                    Array.Resize(ref _arr, Count + Capacity);
                }
                _arr[Count] = value;
                Count++;
            }
            public void GetElements()
            {
                for (int i = 0; i < Count; i++)
                {
                    Console.WriteLine(_arr[i]);
                }
            }



            public void LastIndex(int index)
            {
                for (int i = 0; i < Count; i++)
                {
                    if (_arr[i] == Count - 1)
                    {
                        Console.WriteLine(_arr[i]);
                    }
                }
            }


            public int this[int index]
            {
                get { return _arr[index]; }
                set { _arr[index] = value; }
            }

            public void IndexOf(int value)
            {
                bool index = false;

                for (int i = 0; i < Count; i++)
                {
                    if (_arr[i]==value)
                    {
                        Console.WriteLine(_arr[i]);
                        break;
                    }
                }
                if (!index)
                {
                    Console.WriteLine("daxil olunan indeks yoxdur");
                }
            }

            public void Remove(int index)
            {
                for (int i = 0; i < Count; i++)
                {
                    if (index==i)
                    {
                        _arr[i] = 0;
                        Console.WriteLine($"{_arr[i]} siyahidan silindi");
                    }
                }
            }
        }
    }
}
