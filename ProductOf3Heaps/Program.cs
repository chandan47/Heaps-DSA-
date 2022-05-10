using System;
using System.Collections.Generic;

namespace ProductOf3Heaps
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            List<int> input = new List<int>() { 1, 2, 3, 4, 5 };
            solve(input);
        }
       
            public static List<int> solve(List<int> A)
            {
                List<int> res = new List<int>();
                List<int> nodeCreation = new List<int>();
                for (int i = 0; i < A.Count; i++)
                {
                    if (i < 2)
                    {
                        res.Add(-1);
                        nodeCreation.Add(A[i]);
                    }
                    else if (i == 2)
                    {
                    res.Add(AddNode(nodeCreation, A[i]));
                    }
                    else
                    {
                        res.Add(AddNode(nodeCreation, A[i]));
                    }

                }
                return res;
            }
            public static void HeapifyMax(List<int> A, int i)
            {
                while (i>-1 && A[i] > A[(i / 2)])
                {
                    int temp = A[(i / 2)];
                    A[(i / 2)] = A[i];
                    A[i] = temp;
                    i = (i / 2);
                }
            }
            public static void BuildMaxHeap(List<int> A)
            {
                for (int i = A.Count - 1; i >= (A.Count / 2); i--)
                {
                    HeapifyMax(A, i);
                }
            }
            public static int AddNode(List<int> A, int i)
            {
                A.Add(i);
                BuildMaxHeap(A);
                return A[0] * A[1] * A[2];
            }
        

    }
}
