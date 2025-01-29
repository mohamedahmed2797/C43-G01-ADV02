using System.Collections;

namespace C43_G01_ADV02

{
    internal class Program
    {
        #region 1. Given an array  consists of  numbers with size N and number of queries, in each query you will be given an integer X, and you should print how many numbers in array that is greater than  X.

        //static void Sequence(int[] arr, int n, int[] query, int q, int m)
        //{
        //    for (int i = 0; i < q; i++)
        //    {
        //        int count = 0;
        //        for (int j = 0; j < n; j++)
        //        {
        //            if (arr[j] >= query[i])
        //            {
        //                arr[j] -= m;
        //                count++;
        //            }
        //        }

        //        Console.Write(count + " ");
        //    }
        //}
                
        #endregion

        #region 2.Given a number N and an array of N numbers. Determine if it's palindrome or not.
        //static void Palindrome(int[] numbers, int n)
        //{
        //    int flag = 0;

        //    for (int i = 0; i <= n / 2 && n != 0; i++)
        //    {

        //        if (numbers[i] != numbers[n - i - 1])
        //        {
        //            flag = 1;
        //            break;
        //        }
        //    }
        //    if (flag == 1)
        //    {
        //        Console.WriteLine("Not Palindrome");
        //    }
        //    else
        //        Console.WriteLine("Palindrome");
        //}
        #endregion
        #region 3.Given a Queue, implement a function to reverse the elements of a queue using a stack.
        //static void Reverse(Queue<int> queue)
        //{
        //    Stack<int> stack = new Stack<int>();
        //    while (queue.Count > 0)
        //    {
        //        stack.Push(queue.Dequeue());
        //    }

        //    while (stack.Count > 0)
        //    {
        //        queue.Enqueue(stack.Pop());
        //    }
        //}

        #endregion
        #region 4.Given a Stack, implement a function to check if a string of parentheses is balanced using a stack.
        //static bool IsBalanced(string parancesses)
        //{
        //    Stack<char> stack = new Stack<char>();
        //    foreach (char c in parancesses)
        //    {
        //        if (c == '(')
        //        {
        //            stack.Push(c);
        //        }

        //        else if (c == ')')
        //        {
        //            if (stack.Count == 0 || stack.Peek() != '(')
        //            {
        //                return false;
        //            }
        //            stack.Pop();
        //        }
        //    }
        //    return stack.Count == 0;
        //}

        #endregion
        #region 6. Given an array list , implement a function to remove all odd numbers from it.
        //static void Removing(List<int> numbers)
        //{
        //    for (int i = numbers.Count - 1; i >= 0; i--)
        //    {
        //        if (numbers[i] % 2 != 0)
        //        {
        //            numbers.RemoveAt(i);
        //        }
        //    }

        //}
        #endregion
        #region Q8
        //static void Search(List<int> numbers, int target)
        //{
        //    Stack<int> stack = new Stack<int>();
        //    foreach (int i in numbers)
        //    {
        //        stack.Push(i);
        //    }
        //    int count = 0;
        //    bool found = false;

        //    while (stack.Count > 0)
        //    {
        //        count++;
        //        int current = stack.Pop();
        //        if (current == target)
        //        {
        //            found = true;
        //            break;
        //        }
        //    }
        //    if (found)
        //    {
        //        Console.WriteLine($"Target was found successfully and the count = {count}");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Target was not found");
        //    }
        //}

        #endregion
        #region 9. Given two arrays, find their intersection. Each element in the result should appear as many times as it shows in both arrays.
        //static List<int> intersection(int[] a, int[] b)
        //{
        //    List<int> result = new List<int>();
        //    for (int i = 0; i < a.Length; i++)
        //    {
        //        for (int j = 0; j < b.Length; j++)
        //        {
        //            if (a[i] == b[j] && !result.Contains(a[i]))
        //            {
        //                result.Add(a[i]);
        //            }
        //        }
        //    }
        //    return result;
        //}
        #endregion
        #region 10.Given an ArrayList of integers and a target sum, find if there is a contiguous sub list that sums up to the target.
        //static bool HasContiguous(ArrayList arrList, int target)
        //{
        //    int n = arrList.Count;
        //    int currentSum = 0;
        //    int start = 0;
        //    int[] arr = (int[])arrList.ToArray(typeof(int));
        //    for (int end = 0; end < n; end++)
        //    {
        //        currentSum += arr[end];
        //        while (currentSum > target && start <= end)
        //        {
        //            currentSum -= arr[start];
        //            start++;
        //        }
        //        if (currentSum == target)
        //        {
        //            return true;
        //        }
        //    }
        //    return false;
        //}
        #endregion
        #region 11. Given a queue reverse first K elements of a queue, keeping the remaining elements in the same order 
        //public static LinkedList<int> queue;
        //public static void solve(int k)
        //{
        //    if (k == 0)
        //    {
        //        return;
        //    }
        //    int e = queue.First.Value;
        //    queue.RemoveFirst();
        //    solve(k - 1);
        //    queue.AddLast(e);
        //}
        //public static void reverseFirstK(int k)
        //{
        //    solve(k);
        //    int s = queue.Count - k;
        //    while (s > 0)
        //    {
        //        int x = queue.First.Value;
        //        queue.RemoveFirst();
        //        queue.AddLast(x);
        //        s = s - 1;
        //    }
        //}

        #endregion
        static void Main(string[] args)
        {
        #region 1. Given an array  consists of  numbers with size N and number of queries, in each query you will be given an integer X, and you should print how many numbers in array that is greater than  X.

            //int[] arr = { 1, 2, 3, 4 };
            //int[] query = { 4, 3, 1 };
            //int m = 1;
            //int n = arr.Length;
            //int q = query.Length;


            //Sequence(arr, n, query, q, m);
        #endregion
        #region Q2
        //int[] numbers = { 3, 2, 1, 2, 3 };
        //int n = numbers.Length;
        //Palindrome(numbers, n); 
        #endregion
        #region Q3
        //Queue<int> queue = new Queue<int>();
        //queue.Enqueue(1);
        //queue.Enqueue(2);
        //queue.Enqueue(3);
        //queue.Enqueue(4);
        //queue.Enqueue(5);

        //Console.WriteLine("before reversing");
        //foreach (int i in queue)
        //{
        //    Console.WriteLine(i);
        //}
        //Console.WriteLine("after reversing");
        //Reverse(queue);
        //foreach (int i in queue)
        //{
        //    Console.WriteLine(i);
        //}

        #endregion
        #region Q4
        //string p1 = "()";
        //string p2 = "(";
        //string p3 = ")";
        //string p4 = ")(";
        //Console.WriteLine($"p1 = {IsBalanced(p1)}\n p2 = {IsBalanced(p2)}\n p3 = {IsBalanced(p3)}\n p4 = {IsBalanced(p4)}\n ");
        #endregion
        #region 5. Given an array, implement a function to remove duplicate elements from an array.
        //int[] arr = { 7, 7, 5, 3, 1, 4, 5, 3, 6, 1 };
        //Console.WriteLine("before removing duplicates");
        //foreach (int x in arr) 
        //    Console.WriteLine(x);
        //int[] distinct = arr.Distinct().ToArray();
        //Console.WriteLine("after removing duplicates");

        //foreach (int i in distinct)
        //{

        //    Console.WriteLine(i);
        //}
        #endregion
        #region 6.Given an array list , implement a function to remove all odd numbers from it.
        //List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        //Removing(numbers);
        //foreach (int i in numbers)
        //{
        //    Console.WriteLine(i);
        //}

        #endregion
        #region 7. Implement a queue that can hold different data types. 
        //Queue<object> queue = new Queue<object>();
        //queue.Enqueue(1);
        //queue.Enqueue("Apple");
        //queue.Enqueue(5.28);
        //while (queue.Count > 0)
        //{
        //    object item = queue.Dequeue(); 
        //    Console.WriteLine(item);
        //}

        #endregion
        #region Q8
        //List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7 };
        //Console.Write("Enter the target integer to search for: ");
        //int target = int.Parse(Console.ReadLine());
        //Search(numbers, target);

        #endregion
        #region 9. Given two arrays, find their intersection. Each element in the result should appear as many times as it shows in both arrays.
        //int[] a = { 1, 2, 3, 4, 1,2 };
        //int[] b = { 1, 4, 9 };
        //List<int> result = intersection(a, b);
        //foreach (int i in result)
        //{
        //    Console.WriteLine(i);
        //}
        #endregion
        #region 10. Given an ArrayList of integers and a target sum, find if there is a contiguous sub list that sums up to the target
        //ArrayList arrList = new ArrayList { 1, 2, 3, 7, 5 };
        //int targetSum = 12;
        //bool result = HasContiguous(arrList, targetSum);
        //if (result)
        //{
        //    Console.WriteLine("A contiguous sublist with the target sum exists.");
        //}
        //else
        //{
        //    Console.WriteLine("No contiguous sublist with the target sum found.");
        //}
        #endregion
        #region 11. Given a queue reverse first K elements of a queue, keeping the remaining elements in the same order 

        //queue = new LinkedList<int>();
        //queue.AddLast(1);
        //queue.AddLast(2);
        //queue.AddLast(3);
        //queue.AddLast(4);
        //queue.AddLast(5);
        //queue.AddLast(6);
        //queue.AddLast(7);
        //int k = 5;
        //reverseFirstK(k);
        //while (queue.Count > 0)
        //{
        //    Console.Write(queue.First.Value + " ");
        //    queue.RemoveFirst();
        //}
        #endregion
        }
    }
    }



