using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graph_Theory_3
{
    class GraphUtils
    {

        static List<List<string>> adjacencyList;
        static Dictionary<string, int> vertices;
        private static bool[] visisted;


        static List<Stack<string>> paths;

        public static List<Stack<string>> FindAllPathsWithLength(List<List<string>> _adjacencyList, Dictionary<string, int> _vertices, string begin, string end, int length)
        {

            paths = new List<Stack<string>>();
            adjacencyList = _adjacencyList;
            vertices = _vertices;
            Stack<string> nodesSoFar = new Stack<string>();
            nodesSoFar.Push(begin);
            // traverse(ver, end, length-1, nodesSoFar);
            foreach (var neighbor in adjacencyList[vertices[begin]])
            {
                traverse(neighbor, end, length - 1, nodesSoFar);
            }
            return paths;
        }

        private static void traverse(string currentVertex, string end, int length, Stack<string> nodesSoFar)
        {
            nodesSoFar.Push(currentVertex);
            if (length == 0)
            {
                if (currentVertex == end)
                    paths.Add(new Stack<string>(nodesSoFar));//Make Sure this here works

                nodesSoFar.Pop();
                return;
            }

            foreach (var item in adjacencyList[vertices[currentVertex]])
            {
                traverse(item, end, length - 1, nodesSoFar);
            }
            nodesSoFar.Pop();
        }

        private static bool[] visited;

        public static int GetNumberOfComponents(List<List<string>> _adjacencyList, Dictionary<string, int> _vertices)
        {
            int numOfComponents =0;
            adjacencyList = _adjacencyList;
            vertices = _vertices;
            visited = new bool[adjacencyList.Count];
            for (int i = 0; i < visited.Length; i++)
            {
                if (!visited[i]) {
                    numOfComponents++;
                    Bfs(i);
                }

            }
            return numOfComponents;   
        }

        private static void Bfs(int root) {

            visited[root] = true;
            Queue<int> q = new Queue<int>();
            q.Enqueue(root);
            while (q.Count > 0)
            {

                int current = q.Dequeue();

                foreach (var item in adjacencyList[current])
                {
                    int neighbor = vertices[item];

                    if (!visited[neighbor])
                    {
                        visited[neighbor] = true;
                        q.Enqueue(neighbor);
                    }
                }
            }

        }

        public static bool ContiansOddCycle(List<List<string>> _adjacencyList, Dictionary<string, int> _vertices)
        {
            adjacencyList = _adjacencyList;
            vertices = _vertices;
            visited = new bool[adjacencyList.Count];

            int[] colorArr = new int[adjacencyList.Count];
            for (int i = 0; i < adjacencyList.Count; ++i)
                colorArr[i] = -1;
            for (int i = 0; i < colorArr.Length; i++)
            {
                if (colorArr[i]==-1)
                {
                    colorArr[i] = 1;
                    Queue<int> q = new Queue<int>();
                    q.Enqueue(i);
                    while (q.Count > 0)
                    {

                        int current = q.Dequeue();

                     

                        foreach (var item in adjacencyList[current])
                        {
                            int neighbor = vertices[item];

                            if (neighbor == current) return true; //Self Loop

                            if (colorArr[neighbor]==-1)
                            {
                                colorArr[neighbor] = 1 - colorArr[current];
                                q.Enqueue(neighbor);
                            }
                            else if (colorArr[neighbor] == colorArr[current]) {
                                return true;
                            }
                        }
                    } 
                }

            }

            return false;
        }

        public static int[] DrawGraph(int[,] adjacencyMatrix, Dictionary<string, int> vertices,  int[] verticesLabels, Graphics g, Control control, int canvasWidth = 200, int canvasHeight = 200)
        {
            int VerticesCount = vertices.Count;
            if (VerticesCount == 0) return null;


            Pen p = new Pen(Color.Blue, 2);
            Random random = new Random();
            int vertexRadius = 4;
            Point[] points = new Point[VerticesCount];
            int canvasPartW = canvasWidth / 7;
            int canvasPartH = canvasHeight / 7;

            for (int i = 0; i < VerticesCount; i++)
            {
                points[i].X = random.Next(5 * canvasPartW) + canvasPartW;
                points[i].Y = random.Next(5 * canvasPartH) + canvasPartH;
            }

            if (verticesLabels != null)
                for (int i = verticesLabels.Length - 1; i >= 0; i--)
                {
                    control.Controls.RemoveAt(verticesLabels[i]);
                }

            control.Refresh();
            verticesLabels = new int[VerticesCount];

            //Drawing The Vertecies
            for (int i = 0; i < VerticesCount; i++)
            {
                var vertexLabel = new Label();
                vertexLabel.Left = points[i].X + 20;
                vertexLabel.Top = points[i].Y;
                vertexLabel.Text = vertices.ElementAt(i).Key;
                vertexLabel.AutoSize = true;
                vertexLabel.Font = new Font("Arial", 9, FontStyle.Bold);
                verticesLabels[i] = control.Controls.Count;
                control.Controls.Add(vertexLabel);
                g.DrawEllipse(p, points[i].X - vertexRadius, points[i].Y - vertexRadius, 2 * vertexRadius, 2 * vertexRadius);

            }


            //Drawing The Edges
            p = new Pen(Color.Red, 2);
            int loopRadius = 20;
            for (int i = 0; i < VerticesCount; i++)
            {
                for (int j = i; j < VerticesCount; j++)
                {
                    if (adjacencyMatrix[i, j] >= 1)
                    {
                        if (i == j) //Its a Loop
                            g.DrawEllipse(p, points[j].X - loopRadius, points[j].Y, 2 * loopRadius, 2 * loopRadius);
                        else        //Normal Edge
                            g.DrawLine(p, points[i], points[j]);
                    }

                }
            }

            return verticesLabels;
        }

        public static List<int> GetDegreeSequence(List<List<string>> _adjacencyList){

            var result = new List<int>();
            for (int i = 0; i < _adjacencyList.Count; i++)
            {
                result.Add(_adjacencyList[i].Count);
            }

            return result;
        }


        private static List<int> cycles;//They Contains Duplication
      
        public static List<int> GetAllCycles(List<List<string>> _adjacencyList, Dictionary<string, int> _vertices)
        {
            visisted = new bool[_vertices.Count];
            cycles = new List<int>();
            adjacencyList = _adjacencyList;
            vertices = _vertices;
            foreach (var vertex in vertices)
            {
                CountCycles(vertex.Key, vertex.Key, 0);
                visisted[vertex.Value] = true;
            }
            cycles = cycles.OrderBy(v => v).ToList();
            //After Removing the duplocation
            List<int> cyclesFinal = new List<int>();
            for (int i = 0; i < cycles.Count; i += 2)
            {
                cyclesFinal.Add(cycles[i]);
            }
            return cyclesFinal;
        }

        //Using DFS 
        private static void CountCycles(string vertex, string Begin, int length)
        {
            int vertexIndex = vertices[vertex];
            if (visisted[vertexIndex])
            {
                if (vertex == Begin && length > 2)
                {
                    cycles.Add(length);
                    return;
                }
                return;
            }
            visisted[vertexIndex] = true;

            foreach (var neighbor in adjacencyList[vertexIndex])
            {
                CountCycles(neighbor, Begin, length + 1);
            }
            visisted[vertexIndex] = false;

        }
    }
}
