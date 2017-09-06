using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace djikstra
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] graph = new int[6,6] {{0, 10, 20, 1000, 1000, 1000},
                { 10, 0, 5, 16, 1000, 1000},
                { 20, 5, 0, 20, 1000, 1000},
                { 1000, 16, 20, 0, 1000, 1000},
                { 1000, 1000, 1000, 1000, 0, 5},
                { 1000, 1000, 1000, 1000, 5, 0},
                     };
            dijkstra(graph, 0);

        }

        static int minDistance(int[] d, bool[] s)
        {
            // Initialize min value
            int min = 1000;
            int min_index=0;

            for (int v = 0; v < 6; v++)
            {
                if (s[v] == false && d[v] <= min)
                { min = d[v]; min_index = v; }
            }
            return min_index;
        }

        static void dijkstra(int[,] graph, int src)
        {
            int[] d = new int[6];    // the output array (each entri in this array are distance from vertex src to the other vertices)

            bool[] s = new bool[6]; // s[i] will true if distance from vertex src to i has been found

            // Initialize all distances as INFINITE and s[] as false
            for (int i = 0; i < 6; i++)
            { d[i] = 1000; s[i] = false; }

            // Distance of source vertex from itself is always 0
            d[src] = 0;

            // Find shortest path for all vertices
            for (int count = 0; count < 6 - 1; count++)
            {
                // Pick the minimum distance vertex from the set of vertices not
                // yet processed. u is always equal to src in first iteration.
                int u = minDistance(d, s);

                // Mark the picked vertex as processed
                s[u] = true;

                // Update dist value of the adjacent vertices of the picked vertex.
                for (int v = 0; v < 6; v++)
                {
                    // Update dist[v] only if is not in s, there is an edge from 
                    // u to v, and total weight of path from src to  v through u is 
                    // smaller than current value of dist[v]
                    if (!s[v] && d[u] != 1000 && (d[u] + graph[u,v]) < d[v])
                        d[v] = d[u] + graph[u, v];
                }
            }


        }

    }
}
