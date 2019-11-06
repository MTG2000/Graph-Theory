using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graph_Theory_3
{
    public abstract class GraphBase
    {
        protected Dictionary<string, int> vertices = new Dictionary<string, int>();
        protected HashSet<string> edgesVertices = new HashSet<string>();


        protected int[,] adjacencyMatrix;
        protected List<List<string>> adjacencyList;

        protected bool isRegular = true;

        public int[] verticesLabels;     //For Drawing Purposes


              public GraphBase() { }



        public int[,] AdjacencyMatrix
        {
            get
            {
                if (adjacencyMatrix == null)
                    return CreateAdjacencyMatrix();
                return adjacencyMatrix;
            }
        }



        public List<List<string>> AdjacenceyList
        {
            get
            {
                if (adjacencyList == null)
                    return CreateAdjacencyList();
                return adjacencyList;
            }
        }

        public Dictionary<string, int> Vertices
        {
            get
            {
                return this.vertices;
            }
        }

        public int VerticesCount
        {
            get
            {
                return vertices.Count;
            }
        }
        public bool IsRegular
        {
            get {
                return isRegular;
            }
        }

        public void AddVertices(string[] _vertices)
        {

            adjacencyMatrix = null;
            adjacencyList = null;

            for (int i = 0; i < _vertices.Length; i++)
            {
                var vertex = _vertices[i].ToUpper();

                if (!vertices.ContainsKey(vertex))
                    vertices.Add(vertex, i);
            }
        }

        public string GetVertex(int i)
        {
            if (i < 0 || i >= vertices.Count) return null;
            return vertices.ElementAtOrDefault(i).Key;
        }




        protected virtual int[,] CreateAdjacencyMatrix()
        {
            return null;
        }

        protected virtual List<List<string>> CreateAdjacencyList()
        {
            return null;
        }

        public virtual void Clear()
        {
            vertices = new Dictionary<string, int>();
            edgesVertices = new HashSet<string>();
            adjacencyMatrix = null;
            adjacencyList = null;
        }

      


    }
}
