namespace CSharp9._2
{
    public interface ISort
    {
        void SortAsc();
        void SortDesc();
        void SortByParam(bool isAsc);
    }

    public class CustomArray : ISort
    {
        private int[] elements;

        public CustomArray(int[] elements)
        {
            this.elements = elements;
        }

        public void SortAsc()
        {
            Array.Sort(elements);
        }

        public void SortDesc()
        {
            Array.Sort(elements);
            Array.Reverse(elements);
        }

        public void SortByParam(bool isAsc)
        {
            if (isAsc)
            {
                SortAsc();
            }
            else
            {
                SortDesc();
            }
        }

        public void Print()
        {
            Console.WriteLine(string.Join(", ", elements));
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 5, 2, 7, 1, 3 };

            CustomArray array = new CustomArray(numbers);

            Console.WriteLine("Original array:");
            array.Print();

            Console.WriteLine("\nSorting in ascending order:");
            array.SortAsc();
            array.Print();

            Console.WriteLine("\nSorting in descending order:");
            array.SortDesc();
            array.Print();

            Console.WriteLine("\nSorting by parameter (ascending):");
            array.SortByParam(true);
            array.Print();

            Console.WriteLine("\nSorting by parameter (descending):");
            array.SortByParam(false);
            array.Print();
        }
    }
}

