namespace Graph_Theory_3
{
    partial class TerminalForm
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
            this.output = new System.Windows.Forms.RichTextBox();
            this.panel = new System.Windows.Forms.Panel();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // output
            // 
            this.output.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.output.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.output.Dock = System.Windows.Forms.DockStyle.Fill;
            this.output.Font = new System.Drawing.Font("Kozuka Gothic Pro L", 13F, System.Drawing.FontStyle.Bold);
            this.output.ForeColor = System.Drawing.SystemColors.Info;
            this.output.Location = new System.Drawing.Point(10, 10);
            this.output.Name = "output";
            this.output.ReadOnly = true;
            this.output.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.output.Size = new System.Drawing.Size(810, 588);
            this.output.TabIndex = 0;
            this.output.Text = "Hello World !!";
            this.output.TextChanged += new System.EventHandler(this.output_TextChanged);
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.SystemColors.WindowText;
            this.panel.Controls.Add(this.output);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Padding = new System.Windows.Forms.Padding(10, 10, 2, 10);
            this.panel.Size = new System.Drawing.Size(822, 608);
            this.panel.TabIndex = 1;
            // 
            // TerminalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 608);
            this.ControlBox = false;
            this.Controls.Add(this.panel);
            this.Location = new System.Drawing.Point(20, 20);
            this.Name = "TerminalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Terminal";
            this.Resize += new System.EventHandler(this.TerminalForm_Resize);
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox output;
        private System.Windows.Forms.Panel panel;
    }
}