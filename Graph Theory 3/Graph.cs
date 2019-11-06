using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graph_Theory_3
{
    class Graph : GraphBase
    {

         public Graph() { }

         public Graph(int[,] _adjacencyMatrix)
             :base()
         {
             var lengthDouble = Math.Sqrt(_adjacencyMatrix.Length);
             if (lengthDouble % 1 != 0) return;
             int length = (int)lengthDouble;

             adjacencyMatrix = _adjacencyMatrix;
           

             vertices = new Dictionary<string, int>();
             for (int i = 0; i < length; i++)
             {
                 vertices.Add(i.ToString(), i);
             }
             CreateAdjacencyList();
             isValidated = true;
             isGraphValid = true;
         }
        

        private List<string> edgeBegins = new List<string>();
        private List<string> edgeEnds = new List<string>();

        private int[,] incidencesMatrix;

        private int numberOfEdges;

        private bool isGraphValid;
        private bool isValidated;//If this is true then we check whether the graph is valid or not


        public int[,] IncidencMatrix
        {
            get
            {
                if (incidencesMatrix == null)
                    return CreateIncidencesMatrix();
                return incidencesMatrix;
            }
        }


        public int EdgesCount
        {
            get
            {
                if (edgeBegins.Count > 1)
                    return edgeBegins.Count;
                return numberOfEdges;
            }
        }

        public void AddEdge(string edgeBegin, string edgeEnd)
        {
            edgeBegins.Add(edgeBegin.ToUpper());
            edgeEnds.Add(edgeEnd.ToUpper());
            edgesVertices.Add(edgeBegin.ToUpper());
            edgesVertices.Add(edgeEnd.ToUpper());
            isValidated = false;
        }

        public bool IsValid()
        {
            if (isValidated) return isGraphValid;
            //Lets check if the graph is valid or not
            foreach (var edgeVertex in edgesVertices)
            {
                if (!vertices.ContainsKey(edgeVertex))
                {
                    isValidated = true;
                    isGraphValid = false;
                    return false;
                }
            }
            isValidated = true;
            isGraphValid = true;
            return true;

        }

        private int[,] CreateIncidencesMatrix()
        {
            if (!IsValid())
                return null;
            incidencesMatrix = new int[vertices.Count, edgeBegins.Count];
            for (int i = 0; i < EdgesCount; i++)
            {
                if (edgeBegins[i] == edgeEnds[i])
                {
                    incidencesMatrix[vertices[edgeBegins[i]], i] = 2;
                    continue;
                }

                incidencesMatrix[vertices[edgeBegins[i]], i] = 1;
                incidencesMatrix[vertices[edgeEnds[i]], i] = 1;

            }
            return incidencesMatrix;

        }

        protected override int[,] CreateAdjacencyMatrix()
        {
            if (!IsValid())
                return null;

            adjacencyMatrix = new int[VerticesCount, VerticesCount];
            for (int i = 0; i < EdgesCount; i++)
            {
                int v1 = vertices[edgeBegins[i]];
                int v2 = vertices[edgeEnds[i]];
                adjacencyMatrix[v1, v2] ++;
                adjacencyMatrix[v2, v1] ++;
                if (adjacencyMatrix[v1, v2] > 1 ) {
                    isRegular = false;
                }
            }
            return adjacencyMatrix;
        }

        protected override List<List<string>> CreateAdjacencyList()
        {
            if (!IsValid())
                return null;
            //Initialize The Lists
            adjacencyList = new List<List<string>>();
            for (int i = 0; i < VerticesCount; i++)
            {
                adjacencyList.Add(new List<string>());
                for (int j = 0; j < VerticesCount; j++)
                {
                    if (adjacencyMatrix[i, j] >= 1)
                    { adjacencyList[i].Add(vertices.ElementAt(j).Key);
                    numberOfEdges += adjacencyMatrix[i, j] ;
                    }
                }
            }
            numberOfEdges /= 2;


            return adjacencyList;
        }

        public override void Clear()
        {
            base.Clear();
            edgeBegins.Clear();
            edgeEnds.Clear();
            incidencesMatrix = null;
        }

       
    }
}
