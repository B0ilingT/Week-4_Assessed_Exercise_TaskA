using System;

namespace InsertionSort
{
    class Program
    {
        static public void InsertionSortGen<T>(T[] a) where T : IComparable
        {
            for (int i = 1; i < a.Length; i++)
            {
                T value = a[i];
                int j = i;

                for (; j > 0 && (value.CompareTo(a[j - 1]) < 0); j--)
                {
                    a[j] = a[j - 1];
                }
                a[j] = value;
            }
     
        }
        static void Main(string[] args)
        {
            string[] name = {"Bob","Stuart","Tom","Jack","John","Weezil"};
            int[] id = { 1223,1835,1676,8847,1288,1239 };

            Student[] school = new Student[6];
            for (int i = 0;i<school.Length;i++)
            {
                school[i] = new Student(id[i], name[i]);
            }
            Console.WriteLine("BEFORE SORT");
            foreach (Student z in school)
            { 
                Console.WriteLine(z); 
            }
            InsertionSortGen(school);
            Console.WriteLine("AFTER SORT");
            foreach (Student z in school)
            { 
                Console.WriteLine(z); 
            }
            int[] testInt = { 1, 2, 7, 3, 4, 6, 5 };
            Console.WriteLine("BEFORE SORT");
            foreach (int z in testInt)
            {
                Console.WriteLine(z);
            }
            InsertionSortGen(testInt);
            Console.WriteLine("AFTER SORT");
            foreach (int z in testInt)
            {
                Console.WriteLine(z);
            }
            //Console.WriteLine("Please Input a Number: ");
           // int n = Convert.ToInt32(Console.ReadLine()); // 
           // int r = 20;
          //  int dummy = 0;

           // Console.WriteLine(" \nCreating a nested loop:");
          //  for (int i = 0; i < n; i++)                               //n+1
          //  {
          //      dummy++;                                              //n
          //      int j = 0;                                            //n
         //       while (j < n)                                         //n+1
          //      {
         //           j++;                                              //n^2
         //           r = r + dummy;                                    //n^2
         //           Console.WriteLine("Inside the second loop " + r); //n^2                                                                       
         //       }                                                     //3n^2 + 4n + 2  
         //                                                             //clearing co-efficients: n^2 + n
         //                                                             //picking most significant term: n^2 
         //   }

        }


    }
        
}

