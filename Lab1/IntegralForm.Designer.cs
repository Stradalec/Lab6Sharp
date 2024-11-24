namespace Lab1
{
    partial class IntegralForm
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
            pvGraph = new OxyPlot.WindowsForms.PlotView();
            MethodDesignLabel = new System.Windows.Forms.Label();
            GraphDesignLabel = new System.Windows.Forms.Label();
            textBox1 = new System.Windows.Forms.TextBox();
            label7 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            functionLimitBox = new System.Windows.Forms.TextBox();
            interval = new System.Windows.Forms.TextBox();
            countOfIterations = new System.Windows.Forms.Label();
            functionLabel = new System.Windows.Forms.Label();
            FirstIntervalLimitation = new System.Windows.Forms.TextBox();
            function = new System.Windows.Forms.TextBox();
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            dx = new System.Windows.Forms.Label();
            lowBorder = new System.Windows.Forms.TextBox();
            upBorder = new System.Windows.Forms.TextBox();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pvGraph
            // 
            pvGraph.Location = new System.Drawing.Point(361, 15);
            pvGraph.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pvGraph.Name = "pvGraph";
            pvGraph.PanCursor = System.Windows.Forms.Cursors.Hand;
            pvGraph.Size = new System.Drawing.Size(555, 422);
            pvGraph.TabIndex = 103;
            pvGraph.Text = "plotView1";
            pvGraph.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            pvGraph.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            pvGraph.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // MethodDesignLabel
            // 
            MethodDesignLabel.AutoSize = true;
            MethodDesignLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            MethodDesignLabel.Location = new System.Drawing.Point(27, 289);
            MethodDesignLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            MethodDesignLabel.Name = "MethodDesignLabel";
            MethodDesignLabel.Size = new System.Drawing.Size(213, 20);
            MethodDesignLabel.TabIndex = 101;
            MethodDesignLabel.Text = "Настройка работы метода";
            // 
            // GraphDesignLabel
            // 
            GraphDesignLabel.AutoSize = true;
            GraphDesignLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            GraphDesignLabel.Location = new System.Drawing.Point(31, 27);
            GraphDesignLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            GraphDesignLabel.Name = "GraphDesignLabel";
            GraphDesignLabel.Size = new System.Drawing.Size(254, 20);
            GraphDesignLabel.TabIndex = 100;
            GraphDesignLabel.Text = "Настройка построения графика";
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(35, 254);
            textBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(80, 23);
            textBox1.TabIndex = 96;
            textBox1.Text = "5";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(31, 234);
            label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(155, 15);
            label7.TabIndex = 95;
            label7.Text = "функции (полож. сторона)";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(31, 178);
            label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(151, 15);
            label6.TabIndex = 94;
            label6.Text = "функции (отриц. сторона)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(204, 178);
            label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(33, 15);
            label5.TabIndex = 93;
            label5.Text = "осей";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(93, 147);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(144, 15);
            label4.TabIndex = 92;
            label4.Text = "Число точек построения";
            // 
            // functionLimitBox
            // 
            functionLimitBox.Location = new System.Drawing.Point(35, 197);
            functionLimitBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            functionLimitBox.Name = "functionLimitBox";
            functionLimitBox.Size = new System.Drawing.Size(80, 23);
            functionLimitBox.TabIndex = 91;
            functionLimitBox.Text = "5";
            // 
            // interval
            // 
            interval.Location = new System.Drawing.Point(204, 200);
            interval.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            interval.Name = "interval";
            interval.Size = new System.Drawing.Size(80, 23);
            interval.TabIndex = 90;
            interval.Text = "5";
            // 
            // countOfIterations
            // 
            countOfIterations.AutoSize = true;
            countOfIterations.Location = new System.Drawing.Point(28, 328);
            countOfIterations.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            countOfIterations.Name = "countOfIterations";
            countOfIterations.Size = new System.Drawing.Size(91, 15);
            countOfIterations.TabIndex = 84;
            countOfIterations.Text = "Число делений";
            // 
            // functionLabel
            // 
            functionLabel.AutoSize = true;
            functionLabel.Location = new System.Drawing.Point(31, 84);
            functionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            functionLabel.Name = "functionLabel";
            functionLabel.Size = new System.Drawing.Size(87, 15);
            functionLabel.TabIndex = 83;
            functionLabel.Text = "Ваш интеграл:";
            // 
            // FirstIntervalLimitation
            // 
            FirstIntervalLimitation.Location = new System.Drawing.Point(31, 347);
            FirstIntervalLimitation.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            FirstIntervalLimitation.Name = "FirstIntervalLimitation";
            FirstIntervalLimitation.Size = new System.Drawing.Size(80, 23);
            FirstIntervalLimitation.TabIndex = 81;
            FirstIntervalLimitation.Text = "0";
            // 
            // function
            // 
            function.Location = new System.Drawing.Point(126, 81);
            function.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            function.Name = "function";
            function.Size = new System.Drawing.Size(129, 23);
            function.TabIndex = 80;
            function.Text = "-x^3+3*x^2+4";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { toolStripTextBox1, toolStripTextBox2 });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            menuStrip1.Size = new System.Drawing.Size(924, 27);
            menuStrip1.TabIndex = 97;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripTextBox1
            // 
            toolStripTextBox1.Name = "toolStripTextBox1";
            toolStripTextBox1.ReadOnly = true;
            toolStripTextBox1.Size = new System.Drawing.Size(116, 23);
            toolStripTextBox1.Text = "Построить";
            toolStripTextBox1.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            toolStripTextBox1.Click += toolStripTextBox1_Click;
            // 
            // toolStripTextBox2
            // 
            toolStripTextBox2.Name = "toolStripTextBox2";
            toolStripTextBox2.ReadOnly = true;
            toolStripTextBox2.Size = new System.Drawing.Size(116, 23);
            toolStripTextBox2.Text = "Искать";
            toolStripTextBox2.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dx
            // 
            dx.AutoSize = true;
            dx.Location = new System.Drawing.Point(262, 85);
            dx.Name = "dx";
            dx.Size = new System.Drawing.Size(20, 15);
            dx.TabIndex = 104;
            dx.Text = "dx";
            // 
            // lowBorder
            // 
            lowBorder.Location = new System.Drawing.Point(116, 110);
            lowBorder.Name = "lowBorder";
            lowBorder.Size = new System.Drawing.Size(48, 23);
            lowBorder.TabIndex = 105;
            // 
            // upBorder
            // 
            upBorder.Location = new System.Drawing.Point(116, 52);
            upBorder.Name = "upBorder";
            upBorder.Size = new System.Drawing.Size(48, 23);
            upBorder.TabIndex = 106;
            // 
            // IntegralForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(924, 519);
            Controls.Add(upBorder);
            Controls.Add(lowBorder);
            Controls.Add(dx);
            Controls.Add(pvGraph);
            Controls.Add(MethodDesignLabel);
            Controls.Add(GraphDesignLabel);
            Controls.Add(textBox1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(functionLimitBox);
            Controls.Add(interval);
            Controls.Add(countOfIterations);
            Controls.Add(functionLabel);
            Controls.Add(FirstIntervalLimitation);
            Controls.Add(function);
            Controls.Add(menuStrip1);
            Name = "IntegralForm";
            Text = "IntegralForm";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public OxyPlot.WindowsForms.PlotView pvGraph;
        private System.Windows.Forms.Label MethodDesignLabel;
        private System.Windows.Forms.Label GraphDesignLabel;
        internal System.Windows.Forms.Label IterationLabel;
        private System.Windows.Forms.TextBox IterationBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox functionLimitBox;
        private System.Windows.Forms.TextBox interval;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox LimitationBox;
        private System.Windows.Forms.TextBox epsilonBox;
        private System.Windows.Forms.Label rightLabel;
        private System.Windows.Forms.Label countOfIterations;
        private System.Windows.Forms.Label functionLabel;
        private System.Windows.Forms.TextBox SecondIntervalLimitation;
        private System.Windows.Forms.TextBox FirstIntervalLimitation;
        private System.Windows.Forms.TextBox function;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.Label dx;
        private System.Windows.Forms.TextBox lowBorder;
        private System.Windows.Forms.TextBox upBorder;
    }
}