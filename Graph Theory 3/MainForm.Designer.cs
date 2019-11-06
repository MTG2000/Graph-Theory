namespace Graph_Theory_3
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabsContainer = new System.Windows.Forms.TabControl();
            this.MainTab = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.numOfComponentsLabel = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.isRegularLabel = new System.Windows.Forms.Label();
            this.degreesSeqLabel = new System.Windows.Forms.Label();
            this.oddCycleLabel = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.matrixPower = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pathLength = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.pathEnd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pathBegin = new System.Windows.Forms.TextBox();
            this.messageLabel = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.verticesInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.edgesInput = new System.Windows.Forms.RichTextBox();
            this.paintPage = new System.Windows.Forms.TabPage();
            this.reDrawBtn = new System.Windows.Forms.Button();
            this.paintBox = new System.Windows.Forms.PictureBox();
            this.isomorphismPage = new System.Windows.Forms.TabPage();
            this.sameNumberOfKCycles = new System.Windows.Forms.Label();
            this.sameDegressSequence = new System.Windows.Forms.Label();
            this.sameNOfComponents = new System.Windows.Forms.Label();
            this.sameNOfEdges = new System.Windows.Forms.Label();
            this.sameNOfVerticesLabel = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.isomorphicGraphInput2 = new System.Windows.Forms.RichTextBox();
            this.isomorphicGraphInput1 = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.tabsContainer.SuspendLayout();
            this.MainTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.matrixPower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pathLength)).BeginInit();
            this.paintPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paintBox)).BeginInit();
            this.isomorphismPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabsContainer
            // 
            this.tabsContainer.Controls.Add(this.MainTab);
            this.tabsContainer.Controls.Add(this.paintPage);
            this.tabsContainer.Controls.Add(this.isomorphismPage);
            this.tabsContainer.Location = new System.Drawing.Point(-2, 1);
            this.tabsContainer.Name = "tabsContainer";
            this.tabsContainer.SelectedIndex = 0;
            this.tabsContainer.Size = new System.Drawing.Size(1132, 789);
            this.tabsContainer.TabIndex = 0;
            this.tabsContainer.SelectedIndexChanged += new System.EventHandler(this.tabsContainer_SelectedIndexChanged);
            // 
            // MainTab
            // 
            this.MainTab.BackColor = System.Drawing.Color.WhiteSmoke;
            this.MainTab.Controls.Add(this.button2);
            this.MainTab.Controls.Add(this.label13);
            this.MainTab.Controls.Add(this.numOfComponentsLabel);
            this.MainTab.Controls.Add(this.label14);
            this.MainTab.Controls.Add(this.isRegularLabel);
            this.MainTab.Controls.Add(this.degreesSeqLabel);
            this.MainTab.Controls.Add(this.oddCycleLabel);
            this.MainTab.Controls.Add(this.label12);
            this.MainTab.Controls.Add(this.label11);
            this.MainTab.Controls.Add(this.label10);
            this.MainTab.Controls.Add(this.matrixPower);
            this.MainTab.Controls.Add(this.label9);
            this.MainTab.Controls.Add(this.label8);
            this.MainTab.Controls.Add(this.pathLength);
            this.MainTab.Controls.Add(this.label7);
            this.MainTab.Controls.Add(this.pathEnd);
            this.MainTab.Controls.Add(this.label6);
            this.MainTab.Controls.Add(this.label5);
            this.MainTab.Controls.Add(this.label4);
            this.MainTab.Controls.Add(this.label3);
            this.MainTab.Controls.Add(this.pathBegin);
            this.MainTab.Controls.Add(this.messageLabel);
            this.MainTab.Controls.Add(this.saveBtn);
            this.MainTab.Controls.Add(this.verticesInput);
            this.MainTab.Controls.Add(this.label2);
            this.MainTab.Controls.Add(this.label1);
            this.MainTab.Controls.Add(this.edgesInput);
            this.MainTab.Location = new System.Drawing.Point(4, 25);
            this.MainTab.Name = "MainTab";
            this.MainTab.Padding = new System.Windows.Forms.Padding(3);
            this.MainTab.Size = new System.Drawing.Size(1124, 760);
            this.MainTab.TabIndex = 0;
            this.MainTab.Text = "Main";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.DarkGreen;
            this.label13.Location = new System.Drawing.Point(6, 733);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(95, 18);
            this.label13.TabIndex = 27;
            this.label13.Text = "Made By Mtg";
            // 
            // numOfComponentsLabel
            // 
            this.numOfComponentsLabel.AutoSize = true;
            this.numOfComponentsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numOfComponentsLabel.Location = new System.Drawing.Point(919, 448);
            this.numOfComponentsLabel.Name = "numOfComponentsLabel";
            this.numOfComponentsLabel.Size = new System.Drawing.Size(37, 29);
            this.numOfComponentsLabel.TabIndex = 26;
            this.numOfComponentsLabel.Text = "---";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(605, 448);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(301, 29);
            this.label14.TabIndex = 25;
            this.label14.Text = "Number Of Components :";
            // 
            // isRegularLabel
            // 
            this.isRegularLabel.AutoSize = true;
            this.isRegularLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isRegularLabel.Location = new System.Drawing.Point(752, 291);
            this.isRegularLabel.Name = "isRegularLabel";
            this.isRegularLabel.Size = new System.Drawing.Size(37, 29);
            this.isRegularLabel.TabIndex = 24;
            this.isRegularLabel.Text = "---";
            // 
            // degreesSeqLabel
            // 
            this.degreesSeqLabel.AutoSize = true;
            this.degreesSeqLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.degreesSeqLabel.Location = new System.Drawing.Point(785, 398);
            this.degreesSeqLabel.Name = "degreesSeqLabel";
            this.degreesSeqLabel.Size = new System.Drawing.Size(37, 29);
            this.degreesSeqLabel.TabIndex = 23;
            this.degreesSeqLabel.Text = "---";
            // 
            // oddCycleLabel
            // 
            this.oddCycleLabel.AutoSize = true;
            this.oddCycleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oddCycleLabel.Location = new System.Drawing.Point(862, 344);
            this.oddCycleLabel.Name = "oddCycleLabel";
            this.oddCycleLabel.Size = new System.Drawing.Size(37, 29);
            this.oddCycleLabel.TabIndex = 22;
            this.oddCycleLabel.Text = "---";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(605, 398);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(174, 29);
            this.label12.TabIndex = 21;
            this.label12.Text = "Degrees Seq :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(605, 344);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(252, 29);
            this.label11.TabIndex = 20;
            this.label11.Text = "Contains Odd Cycle :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(605, 291);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(141, 29);
            this.label10.TabIndex = 19;
            this.label10.Text = "Is Regular :";
            // 
            // matrixPower
            // 
            this.matrixPower.Location = new System.Drawing.Point(1007, 208);
            this.matrixPower.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.matrixPower.Name = "matrixPower";
            this.matrixPower.Size = new System.Drawing.Size(75, 22);
            this.matrixPower.TabIndex = 17;
            this.matrixPower.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.matrixPower.ValueChanged += new System.EventHandler(this.matrixPower_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(605, 208);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(342, 29);
            this.label9.TabIndex = 16;
            this.label9.Text = "+) Adjacency Matrix to Power";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(884, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 25);
            this.label8.TabIndex = 15;
            this.label8.Text = "With Length";
            // 
            // pathLength
            // 
            this.pathLength.Location = new System.Drawing.Point(1007, 136);
            this.pathLength.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.pathLength.Name = "pathLength";
            this.pathLength.Size = new System.Drawing.Size(75, 22);
            this.pathLength.TabIndex = 14;
            this.pathLength.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.pathLength.ValueChanged += new System.EventHandler(this.pathLength_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(755, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "To";
            // 
            // pathEnd
            // 
            this.pathEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pathEnd.Location = new System.Drawing.Point(797, 133);
            this.pathEnd.Name = "pathEnd";
            this.pathEnd.Size = new System.Drawing.Size(81, 26);
            this.pathEnd.TabIndex = 12;
            this.pathEnd.TextChanged += new System.EventHandler(this.pathEnd_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(605, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "From";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label5.Location = new System.Drawing.Point(572, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(294, 33);
            this.label5.TabIndex = 10;
            this.label5.Text = "Operations On Graph";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label4.Location = new System.Drawing.Point(33, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 33);
            this.label4.TabIndex = 9;
            this.label4.Text = "Insert Graph";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(600, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "+) All Walks";
            // 
            // pathBegin
            // 
            this.pathBegin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pathBegin.Location = new System.Drawing.Point(668, 132);
            this.pathBegin.Name = "pathBegin";
            this.pathBegin.Size = new System.Drawing.Size(81, 26);
            this.pathBegin.TabIndex = 6;
            this.pathBegin.TextChanged += new System.EventHandler(this.pathBegin_TextChanged);
            // 
            // messageLabel
            // 
            this.messageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageLabel.Location = new System.Drawing.Point(69, 596);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(390, 48);
            this.messageLabel.TabIndex = 5;
            this.messageLabel.Text = "---";
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(292, 487);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(165, 51);
            this.saveBtn.TabIndex = 4;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // verticesInput
            // 
            this.verticesInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verticesInput.Location = new System.Drawing.Point(70, 120);
            this.verticesInput.Name = "verticesInput";
            this.verticesInput.Size = new System.Drawing.Size(387, 34);
            this.verticesInput.TabIndex = 3;
            this.verticesInput.TextChanged += new System.EventHandler(this.verticesInput_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(66, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Vertices";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Edges";
            // 
            // edgesInput
            // 
            this.edgesInput.BackColor = System.Drawing.SystemColors.Info;
            this.edgesInput.ForeColor = System.Drawing.SystemColors.MenuText;
            this.edgesInput.Location = new System.Drawing.Point(70, 216);
            this.edgesInput.Name = "edgesInput";
            this.edgesInput.Size = new System.Drawing.Size(387, 244);
            this.edgesInput.TabIndex = 0;
            this.edgesInput.Text = "";
            this.edgesInput.TextChanged += new System.EventHandler(this.edgesInput_TextChanged);
            // 
            // paintPage
            // 
            this.paintPage.Controls.Add(this.reDrawBtn);
            this.paintPage.Controls.Add(this.paintBox);
            this.paintPage.Location = new System.Drawing.Point(4, 25);
            this.paintPage.Name = "paintPage";
            this.paintPage.Padding = new System.Windows.Forms.Padding(3);
            this.paintPage.Size = new System.Drawing.Size(1124, 760);
            this.paintPage.TabIndex = 1;
            this.paintPage.Text = "Paint";
            this.paintPage.UseVisualStyleBackColor = true;
            // 
            // reDrawBtn
            // 
            this.reDrawBtn.Image = global::Graph_Theory_3.Properties.Resources.icons8_color_96;
            this.reDrawBtn.Location = new System.Drawing.Point(3, 3);
            this.reDrawBtn.Name = "reDrawBtn";
            this.reDrawBtn.Size = new System.Drawing.Size(64, 59);
            this.reDrawBtn.TabIndex = 1;
            this.reDrawBtn.UseVisualStyleBackColor = true;
            this.reDrawBtn.Click += new System.EventHandler(this.reDrawBtn_Click);
            // 
            // paintBox
            // 
            this.paintBox.BackColor = System.Drawing.Color.LightGray;
            this.paintBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paintBox.Location = new System.Drawing.Point(3, 3);
            this.paintBox.Name = "paintBox";
            this.paintBox.Size = new System.Drawing.Size(1118, 754);
            this.paintBox.TabIndex = 0;
            this.paintBox.TabStop = false;
            // 
            // isomorphismPage
            // 
            this.isomorphismPage.Controls.Add(this.sameNumberOfKCycles);
            this.isomorphismPage.Controls.Add(this.sameDegressSequence);
            this.isomorphismPage.Controls.Add(this.sameNOfComponents);
            this.isomorphismPage.Controls.Add(this.sameNOfEdges);
            this.isomorphismPage.Controls.Add(this.sameNOfVerticesLabel);
            this.isomorphismPage.Controls.Add(this.label21);
            this.isomorphismPage.Controls.Add(this.label20);
            this.isomorphismPage.Controls.Add(this.label19);
            this.isomorphismPage.Controls.Add(this.label18);
            this.isomorphismPage.Controls.Add(this.label17);
            this.isomorphismPage.Controls.Add(this.button1);
            this.isomorphismPage.Controls.Add(this.label16);
            this.isomorphismPage.Controls.Add(this.label15);
            this.isomorphismPage.Controls.Add(this.isomorphicGraphInput2);
            this.isomorphismPage.Controls.Add(this.isomorphicGraphInput1);
            this.isomorphismPage.Location = new System.Drawing.Point(4, 25);
            this.isomorphismPage.Name = "isomorphismPage";
            this.isomorphismPage.Padding = new System.Windows.Forms.Padding(3);
            this.isomorphismPage.Size = new System.Drawing.Size(1124, 760);
            this.isomorphismPage.TabIndex = 2;
            this.isomorphismPage.Text = "isomorphic";
            this.isomorphismPage.UseVisualStyleBackColor = true;
            // 
            // sameNumberOfKCycles
            // 
            this.sameNumberOfKCycles.AutoSize = true;
            this.sameNumberOfKCycles.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sameNumberOfKCycles.Location = new System.Drawing.Point(451, 694);
            this.sameNumberOfKCycles.Name = "sameNumberOfKCycles";
            this.sameNumberOfKCycles.Size = new System.Drawing.Size(37, 29);
            this.sameNumberOfKCycles.TabIndex = 14;
            this.sameNumberOfKCycles.Text = "---";
            // 
            // sameDegressSequence
            // 
            this.sameDegressSequence.AutoSize = true;
            this.sameDegressSequence.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sameDegressSequence.Location = new System.Drawing.Point(446, 643);
            this.sameDegressSequence.Name = "sameDegressSequence";
            this.sameDegressSequence.Size = new System.Drawing.Size(37, 29);
            this.sameDegressSequence.TabIndex = 13;
            this.sameDegressSequence.Text = "---";
            // 
            // sameNOfComponents
            // 
            this.sameNOfComponents.AutoSize = true;
            this.sameNOfComponents.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sameNOfComponents.Location = new System.Drawing.Point(493, 589);
            this.sameNOfComponents.Name = "sameNOfComponents";
            this.sameNOfComponents.Size = new System.Drawing.Size(37, 29);
            this.sameNOfComponents.TabIndex = 12;
            this.sameNOfComponents.Text = "---";
            // 
            // sameNOfEdges
            // 
            this.sameNOfEdges.AutoSize = true;
            this.sameNOfEdges.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sameNOfEdges.Location = new System.Drawing.Point(426, 539);
            this.sameNOfEdges.Name = "sameNOfEdges";
            this.sameNOfEdges.Size = new System.Drawing.Size(37, 29);
            this.sameNOfEdges.TabIndex = 11;
            this.sameNOfEdges.Text = "---";
            // 
            // sameNOfVerticesLabel
            // 
            this.sameNOfVerticesLabel.AutoSize = true;
            this.sameNOfVerticesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sameNOfVerticesLabel.Location = new System.Drawing.Point(449, 487);
            this.sameNOfVerticesLabel.Name = "sameNOfVerticesLabel";
            this.sameNOfVerticesLabel.Size = new System.Drawing.Size(37, 29);
            this.sameNOfVerticesLabel.TabIndex = 10;
            this.sameNOfVerticesLabel.Text = "---";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(138, 694);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(307, 29);
            this.label21.TabIndex = 9;
            this.label21.Text = "Same Number of K Cycles :";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(139, 643);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(301, 29);
            this.label20.TabIndex = 8;
            this.label20.Text = "Same Degress Sequence :";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(138, 589);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(349, 29);
            this.label19.TabIndex = 7;
            this.label19.Text = "Same Number Of Components:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(138, 539);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(282, 29);
            this.label18.TabIndex = 6;
            this.label18.Text = "Same Number Of Edges:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(138, 487);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(305, 29);
            this.label17.TabIndex = 5;
            this.label17.Text = "Same Number Of Vertices :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(499, 396);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 54);
            this.button1.TabIndex = 4;
            this.button1.Text = "Compare";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(700, 61);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(226, 24);
            this.label16.TabIndex = 3;
            this.label16.Text = "Graph 2 Adjacency Matrix";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(140, 61);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(226, 24);
            this.label15.TabIndex = 2;
            this.label15.Text = "Graph 1 Adjacency Matrix";
            // 
            // isomorphicGraphInput2
            // 
            this.isomorphicGraphInput2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isomorphicGraphInput2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.isomorphicGraphInput2.Location = new System.Drawing.Point(703, 93);
            this.isomorphicGraphInput2.Name = "isomorphicGraphInput2";
            this.isomorphicGraphInput2.Size = new System.Drawing.Size(292, 247);
            this.isomorphicGraphInput2.TabIndex = 1;
            this.isomorphicGraphInput2.Text = "";
            // 
            // isomorphicGraphInput1
            // 
            this.isomorphicGraphInput1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isomorphicGraphInput1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.isomorphicGraphInput1.Location = new System.Drawing.Point(143, 93);
            this.isomorphicGraphInput1.Name = "isomorphicGraphInput1";
            this.isomorphicGraphInput1.Size = new System.Drawing.Size(292, 247);
            this.isomorphicGraphInput1.TabIndex = 0;
            this.isomorphicGraphInput1.Text = "";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(949, 697);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(165, 51);
            this.button2.TabIndex = 28;
            this.button2.Text = "Terminal";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 786);
            this.Controls.Add(this.tabsContainer);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Graph Theory";
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.tabsContainer.ResumeLayout(false);
            this.MainTab.ResumeLayout(false);
            this.MainTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.matrixPower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pathLength)).EndInit();
            this.paintPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.paintBox)).EndInit();
            this.isomorphismPage.ResumeLayout(false);
            this.isomorphismPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabsContainer;
        private System.Windows.Forms.TabPage MainTab;
        private System.Windows.Forms.TabPage paintPage;
        private System.Windows.Forms.RichTextBox edgesInput;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.TextBox verticesInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.PictureBox paintBox;
        private System.Windows.Forms.Button reDrawBtn;
        private System.Windows.Forms.TextBox pathBegin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown pathLength;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox pathEnd;
        private System.Windows.Forms.NumericUpDown matrixPower;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label oddCycleLabel;
        private System.Windows.Forms.Label degreesSeqLabel;
        private System.Windows.Forms.Label isRegularLabel;
        private System.Windows.Forms.Label numOfComponentsLabel;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TabPage isomorphismPage;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.RichTextBox isomorphicGraphInput2;
        private System.Windows.Forms.RichTextBox isomorphicGraphInput1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label sameNumberOfKCycles;
        private System.Windows.Forms.Label sameDegressSequence;
        private System.Windows.Forms.Label sameNOfComponents;
        private System.Windows.Forms.Label sameNOfEdges;
        private System.Windows.Forms.Label sameNOfVerticesLabel;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button button2;

    }
}

