using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Graph_Theory_3
{
    public partial class MainForm : Form
    {
        TerminalForm terminalForm;
        Graph graph;
        Graphics graphics;

        public MainForm()
        {
            InitializeComponent();
            terminalForm = new TerminalForm();
            terminalForm.Show();
            terminalForm.PrintLn("Hello World");
            tabsContainer.Size = this.Size;

            graphics = paintBox.CreateGraphics();
            

            
        }


        private void Form1_Resize(object sender, EventArgs e)
        {
            tabsContainer.Size = this.Size;
            graphics = paintBox.CreateGraphics();

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            WriteFile();
            RefreshOutput();
        }

        private void RefreshOutput()
        {

            terminalForm.Clear();
            ReadFile();

            if (graph == null || graph.VerticesCount == 0)
            {
                terminalForm.PrintLn( "No Graph Yet !!");
                return;
            }
            if (!graph.IsValid())
            {
                terminalForm.PrintLn( "Graph Not Valid , Check The edges to see if there is a missing vertex !!");
                return;
            }

            PrintIncidenceMatrix();
            PrintAdjacencyMatrix();
            PrintAdjacencyList();
            // PrintBfs();
            PrintContainsOdd();
            PrintDegressSequence();
            PrintIsRegular();
            DrawGraph();

            //Halt Saving until user changes something
           saveBtn.Enabled = false;
           // PrintCyclesCount();
           PrintNumOfComponents();

        }


        private void PrintIncidenceMatrix()
        {
            int[,] incidencesMatrix = graph.IncidencMatrix;
            if (incidencesMatrix == null)
            {
                terminalForm.PrintLn("Not Valid Graph !! Check The Edges & Make Sure all edges endpoints have a vertex");
                return;
            }

            if (graph == null || graph.VerticesCount == 0)
            {
                terminalForm.PrintLn("No Graph Yet !!:");
                return;
            }
            terminalForm.PrintLn();
            terminalForm.PrintLn("Incidence Matrix:");

            for (int i = 0; i < graph.VerticesCount; i++)
            {
                terminalForm.PrintLn( graph.GetVertex(i) + " : ");
                for (int j = 0; j < graph.EdgesCount; j++)
                {
                    terminalForm.Print(incidencesMatrix[i, j] + " ");
                }
            }
        }

        private void PrintAdjacencyMatrix()
        {
            int[,] adjacencyMatrix = graph.AdjacencyMatrix;
            if (adjacencyMatrix == null)
            {
                terminalForm.PrintLn("Not Valid Graph !! Check The Edges & Make Sure all edges endpoints have a vertex");
                return;
            }

            if (graph == null || graph.VerticesCount == 0)
            {
                terminalForm.PrintLn("No Graph Yet !!:\n");
                return;
            }
            terminalForm.PrintLn();
            terminalForm.PrintLn("Adjacency Matrix:");

            for (int i = 0; i < graph.VerticesCount; i++)
            {
                terminalForm.PrintLn(  graph.GetVertex(i)+" : ");
                for (int j = 0; j < graph.VerticesCount; j++)
                {
                    terminalForm.Print( adjacencyMatrix[i, j] + " ");
                }
            }
        }

        private void PrintAdjacencyList()
        {
            List<List<string>> adjacencyList = graph.AdjacenceyList;
            if (adjacencyList == null)
            {
                terminalForm.PrintLn("Not Valid Graph !! Check The Edges & Make Sure all edges endpoints have a vertex");
                return;
            }

            terminalForm.PrintLn();
            terminalForm.PrintLn("Adjacency List:");
            for (int i = 0; i < adjacencyList.Count; i++)
            {
                terminalForm.PrintLn( graph.GetVertex(i) + " : ");

                foreach (var item in adjacencyList[i])
                {
                    terminalForm.Print( item + "  ");
                }


            }
        }

        public void PrintAllPaths()
        {
            if (graph == null) return;
            string begin = pathBegin.Text.ToUpper(), end = pathEnd.Text.ToUpper();
            if (begin == null || end == null || !graph.Vertices.ContainsKey(begin) || !graph.Vertices.ContainsKey(end)) return;
            var result = GraphUtils.FindAllPathsWithLength(graph.AdjacenceyList, graph.Vertices, begin, end, (int)pathLength.Value);
           
            terminalForm.PrintLn();
            terminalForm.PrintLn("All Paths from " + begin + " to " + end + " :");
            terminalForm.PrintLn();


            foreach (var path in result)
            {
                foreach (var v in path)
                {
                    terminalForm.Print( v + " ");
                }
                terminalForm.PrintLn();
            }

        }

        private void PrintContainsOdd()
        {
            if(GraphUtils.ContiansOddCycle(graph.AdjacenceyList,graph.Vertices))
            {
                oddCycleLabel.ForeColor = Color.Green;
                oddCycleLabel.Text = "Yes";
            }
            else
            {
                oddCycleLabel.ForeColor = Color.Red;
                oddCycleLabel.Text = "No";
            }
        }

        private void PrintIsRegular()
        {
            if (graph.IsRegular)
            {
                isRegularLabel.ForeColor = Color.Green;
                isRegularLabel.Text = "Yes";
            }
            else
            {
                isRegularLabel.ForeColor = Color.Red;
                isRegularLabel.Text = "No";
            }
        }

        private void DrawGraph()
        {
            if (graph == null || !graph.IsValid()) return;
            //Clear The Previous drawing

            graph.verticesLabels =  GraphUtils.DrawGraph(graph.AdjacencyMatrix, graph.Vertices, graph.verticesLabels, graphics, paintBox, paintBox.Size.Width, paintBox.Size.Height);
        }

        private void WriteFile()
        {
            string path = "xmlfile.xml";

            if (!File.Exists(path)) {
                XDocument xmlDocument = new XDocument(
                                               new XDeclaration("1.0", "utf-8", "yes"),
                                               new XElement("Graph",
                                                   new XElement("Vertices"),
                                                   new XElement("Edges")
                                                   )
                                               );

                xmlDocument.Save(path);
            }
            try
            {
                XElement graphFile = XElement.Load(path);
                var verticesElement = graphFile.Element("Vertices");
                verticesElement.RemoveAll();
                foreach (var v in verticesInput.Text.ToString().ToUpper().Split(','))
                {
                    verticesElement.Add(new XElement("Vertex", v));
                }
                var edges = edgesInput.Text.ToString()
                                        .Split('\n')
                                        .Where(line =>
                                               (line.Length >= 3 && line.Contains('-'))
                                               );

                var edgesElement = graphFile.Element("Edges");
                edgesElement.RemoveAll();
                foreach (var edge in edges)
                {
                      string edgeBegin = edge.Split('-')[0].ToUpper();
                      string edgeEnd = edge.Split('-')[1].ToUpper();
                      edgesElement.Add(new XElement("Edge",
                                            new XElement("Begin", edgeBegin),
                                            new XElement("End", edgeEnd)
                          ));
                }
                graphFile.Save(path);



            }
            catch (Exception err)
            {
                messageLabel.Text = ("Error Writing to the file !!!");
            }
            finally
            {
               
                    ReadFile();
                
            }


        }

        private void ReadFile()
        {
            string path = "xmlfile.xml";
           
            paintBox.Controls.Clear();
            
            graph = new Graph();


            if (File.Exists(path))
            {
                bool graphValid = false;

                try
                {

                    XElement graphFile = XElement.Load(path);
                    var verticesList = (from vertex in graphFile.Descendants("Vertices").Elements("Vertex")
                                        select vertex.Value).Where(v => v.Length >= 1);
                    

                    if (verticesList.Count() > 0)
                    {

                        graph.AddVertices(verticesList.ToArray());
                        verticesInput.Text = String.Join(",", verticesList);
                        graphValid = true;
                        edgesInput.Text = "";

                        var edgesList = from edge in graphFile.Descendants("Edges").Elements("Edge")
                                        select edge;
                        foreach (var edge in edgesList)
                        {
                            string edgeBegin = edge.Element("Begin").Value;
                            string edgeEnd =  edge.Element("End").Value;
                            graph.AddEdge(edgeBegin, edgeEnd);
                            edgesInput.Text += edgeBegin + '-' + edgeEnd + '\n';

                        }
                    }
                    else
                    {
                        messageLabel.Text = ("There is no Graph inserted!!");
                    }
                }catch (Exception err)
                {
                    messageLabel.Text = ("File Graph.txt Could Not Be Read !!");
                }
            }
            else
            {
                messageLabel.Text = ("No Graph Yet ...");
            }
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            RefreshOutput();
        }

      
      

        private void tabsContainer_SelectedIndexChanged(object sender, EventArgs e)
        {
            DrawGraph();
        }

        private void reDrawBtn_Click(object sender, EventArgs e)
        {
            DrawGraph();
        }

        private void pathEnd_TextChanged(object sender, EventArgs e)
        {

            PrintAllPaths();
        }

        private void pathBegin_TextChanged(object sender, EventArgs e)
        {
            PrintAllPaths();
        }

        private void pathLength_ValueChanged(object sender, EventArgs e)
        {
            PrintAllPaths();
        }

        private void matrixPower_ValueChanged(object sender, EventArgs e)
        {
            var result = Utils.MultiplyArrayNTime(graph.AdjacencyMatrix, (int) matrixPower.Value);
            if (result == null) return;


            terminalForm.PrintLn();
            terminalForm.PrintLn("Adjacency Matrix ^ "+matrixPower.Value+" :");

            for (int i = 0; i < graph.VerticesCount; i++)
            {
                terminalForm.PrintLn(graph.GetVertex(i) + " : ");
                for (int j = 0; j < graph.VerticesCount; j++)
                {
                    terminalForm.Print(result[i, j] + " ");
                }
            }
        }

        private void PrintDegressSequence()
        {

            var result = GraphUtils.GetDegreeSequence(graph.AdjacenceyList);

            degreesSeqLabel.Text = "";
            for (int i = 0; i < graph.VerticesCount; i++)
            {
                degreesSeqLabel.Text += result[i] + " ";
            }
        }

        private void PrintNumOfComponents() {
            var numOfComponents = GraphUtils.GetNumberOfComponents(graph.AdjacenceyList,graph.Vertices);
            numOfComponentsLabel.Text = numOfComponents.ToString();
        }

        private void verticesInput_TextChanged(object sender, EventArgs e)
        {
            saveBtn.Enabled = true;
        }

        private void edgesInput_TextChanged(object sender, EventArgs e)
        {
            saveBtn.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var adjacencyMatrix1 = CreateAdjacencyMatrixFromText(isomorphicGraphInput1.Text);
            var adjacencyMatrix2 = CreateAdjacencyMatrixFromText(isomorphicGraphInput2.Text);
            if (adjacencyMatrix1 == null || adjacencyMatrix2 == null) {
                MessageBox.Show("Make Sure The Adjacency matrices are Valid and doesn't contains extra spaces", "Not Valid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Graph graph1 = new Graph(adjacencyMatrix1);
            Graph graph2 = new Graph(adjacencyMatrix2);

            //Is The Same Number Of Vertices
            if (graph1.VerticesCount == graph2.VerticesCount)
            {
                sameNOfVerticesLabel.ForeColor = Color.Green;
                sameNOfVerticesLabel.Text = "Yes";
            }
            else {
                sameNOfVerticesLabel.ForeColor = Color.Red;
                sameNOfVerticesLabel.Text = "No";
            }

            //Is The Same Number Of Edges
            if (graph1.EdgesCount == graph2.EdgesCount)
            {
                sameNOfEdges.ForeColor = Color.Green;
                sameNOfEdges.Text = "Yes";
            }
            else
            {
                sameNOfEdges.ForeColor = Color.Red;
                sameNOfEdges.Text = "No";
            }
            //Is The Same Number Of Components
            if (GraphUtils.GetNumberOfComponents(graph1.AdjacenceyList, graph1.Vertices) == GraphUtils.GetNumberOfComponents(graph2.AdjacenceyList, graph2.Vertices))
            {
                sameNOfComponents.ForeColor = Color.Green;
                sameNOfComponents.Text = "Yes";
            }
            else
            {
                sameNOfComponents.ForeColor = Color.Red;
                sameNOfComponents.Text = "No";
            }
            //Is The Same Degrees Sequence
            var degreeSequence1 = GraphUtils.GetDegreeSequence(graph1.AdjacenceyList).OrderBy(n => n).ToList();
            var degreeSequence2 = GraphUtils.GetDegreeSequence(graph2.AdjacenceyList).OrderBy(n => n).ToList();
            if (degreeSequence2.Count == degreeSequence1.Count)
            {
                bool success = true;
                for (int i = 0; i < degreeSequence1.Count; i++)
                {
                    if (degreeSequence1[i] != degreeSequence2[i])
                    {
                        sameDegressSequence.ForeColor = Color.Red;
                        sameDegressSequence.Text = "No";
                        success = false;
                        break;
                    }
                }
                if (success)
                {
                    sameDegressSequence.ForeColor = Color.Green;
                    sameDegressSequence.Text = "Yes";
                }
            }
            else {
                sameDegressSequence.ForeColor = Color.Red;
                sameDegressSequence.Text = "No";
            }


            //Is The Same Number of K Cycles
            var graphCycles1 = GraphUtils.GetAllCycles(graph1.AdjacenceyList, graph1.Vertices);
            var graphCycles2 = GraphUtils.GetAllCycles(graph2.AdjacenceyList, graph2.Vertices);

            if (graphCycles1.Count == graphCycles2.Count)
            {
                bool success = true;
                for (int i = 0; i < graphCycles1.Count; i++)
                {
                    if (graphCycles1[i] != graphCycles2[i])
                    {
                        sameNumberOfKCycles.ForeColor = Color.Red;
                        sameNumberOfKCycles.Text = "No";
                        success = false;
                        break;
                    }
                }
                if (success)
                {
                    sameNumberOfKCycles.ForeColor = Color.Green;
                    sameNumberOfKCycles.Text = "Yes";
                }
            }
            else
            {
                sameNumberOfKCycles.ForeColor = Color.Red;
                sameNumberOfKCycles.Text = "No";
            }
          
            
        }

        private int[,] CreateAdjacencyMatrixFromText(string text) { 
             var lines = text.Split('\n')
                              .Where(line=>string.IsNullOrWhiteSpace(line)==false).ToList();
            int i = 0;
            int[,] result = new int[lines.Count, lines.Count];
            try
            {
                foreach (var line in lines)
                {
                    var values = line.Split(' ').Where(v=>string.IsNullOrWhiteSpace(v)==false).ToArray();
                    if (values.Length != lines.Count) return null;
                    for (int j = 0; j < values.Length; j++)
                    {
                        result[i, j] = int.Parse(values[j]);
                    }
                    i++;
                }

                return result;
            }
            catch (Exception e)
            {
                
             return null;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            terminalForm.Focus() ;
        }

    
   
    
    }
}
