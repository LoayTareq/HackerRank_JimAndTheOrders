using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{
    /// Test commit from Git ///
    /*
     * Complete the 'jimOrders' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts 2D_INTEGER_ARRAY orders as parameter.
     */

    public static List<int> jimOrders(List<List<int>> orders)
    {
        Dictionary<int,int> orderTime = new Dictionary<int, int>();
        List<int> result = new List<int>();

		for (int i = 0; i < orders.Count; i++)
		{
            // get order time
            int time = orders[i].Sum(x => Convert.ToInt32(x));

            // add to ordersTime list 
            orderTime.Add(i + 1, time);
        }

		foreach (var item in orderTime.OrderBy(x => x.Value))
		{
            result.Add(item.Key);
        } 

        return result;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
       
       // TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<List<int>> orders = new List<List<int>>();

        for (int i = 0; i < n; i++)
        {
            orders.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(ordersTemp => Convert.ToInt32(ordersTemp)).ToList());
        }

        List<int> result = Result.jimOrders(orders);

        Console.WriteLine(String.Join(" ", result));

        //textWriter.Flush();
        //textWriter.Close();
    }
}
