using OxyPlot.Series;
using OxyPlot;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using NPOI.SS.Formula.Functions;

namespace Lab1
{
    public partial class IntegralForm : Form, IIntegralView
    {
        private Regex regex = new Regex(@"^[\d,-]+$");
        public IntegralForm()
        {
            InitializeComponent();
            Presenter presenter = new Presenter(this);
        }

        double IIntegralView.Interval()
        {
            bool matches;
            if (string.IsNullOrEmpty(interval.Text) || (matches = regex.IsMatch(interval.Text)) == false)
            {
                MessageBox.Show("Ошибка ввода числа построения осей", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
                
            }
            else 
            {
                return Convert.ToDouble(interval.Text);
            }
            
        }

        double IIntegralView.upLimit()
        {
            bool matches;
            if (string.IsNullOrEmpty(upBorder.Text) || (matches = regex.IsMatch(upBorder.Text)) == false)
            {
                MessageBox.Show("Ошибка ввода верхнего значения интеграла", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;               
            }
            else
            {
                
                return Convert.ToDouble(upBorder.Text);
            }
            
        }

        double IIntegralView.lowLimit()
        {
            bool matches;
            if (string.IsNullOrEmpty(lowBorder.Text) || (matches = regex.IsMatch(lowBorder.Text)) == false)
            {
                MessageBox.Show("Ошибка ввода нижнего значения интеграла", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            else
            {                
                return Convert.ToDouble(lowBorder.Text);               
            }
        }

        double IIntegralView.Accuracy()
        {
            bool matches;
            if (string.IsNullOrEmpty(formatBox.Text) || (matches = regex.IsMatch(formatBox.Text)) == false)
            {
                MessageBox.Show("Ошибка ввода значения точности", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 2;
                
            }
            else
            {
                return Convert.ToDouble(formatBox.Text);
            }
        }

        int IIntegralView.IntegralIntervalCount()
        {
            bool matches;
            if (string.IsNullOrEmpty(IntervalLimitation.Text) || (matches = regex.IsMatch(IntervalLimitation.Text)) == false)
            {
                MessageBox.Show("Ошибка ввода значения количества интервалов", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 2;
                
            }
            else
            {
                return Convert.ToInt32(IntervalLimitation.Text);
            }
        }

        void IIntegralView.UpdateGraph(List<double[]> inputArr, byte choice)
        {
            var plotModel = this.pvGraph.Model;
            if (choice == 0)
            {
                var lineSeries = new LineSeries {
                    Title = "Метод прямоугольников",
                    Color = OxyColor.FromRgb(0, 128, 0)
                };
                foreach (var line in inputArr)
                {
                    lineSeries.Points.Add(new DataPoint(line[0], line[1]));
                }
                plotModel.Series.Add(lineSeries);
                this.pvGraph.Model = plotModel;
            }
            else if (choice == 1)
            {
                var lineSeries = new LineSeries {
                    Title = "Метод трапеций",
                    Color = OxyColor.FromRgb(0, 0, 0)
                };
                foreach (var line in inputArr)
                {
                    lineSeries.Points.Add(new DataPoint(line[0], line[1]));
                }
                plotModel.Series.Add(lineSeries);
                this.pvGraph.Model = plotModel;
            }
            else if (choice == 2) 
            {
                var lineSeries = new LineSeries {
                    Title = "Метод Симпсона",
                    Color = OxyColor.FromRgb(153, 50, 204)
                };
                foreach (var line in inputArr)
                {
                    lineSeries.Points.Add(new DataPoint(line[0], line[1]));
                }
                plotModel.Series.Add(lineSeries);
                this.pvGraph.Model = plotModel;
            }
            
        }
        bool IIntegralView.IsRectangleActive()
        {
            if (rectangle.Checked)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        bool IIntegralView.IsTrapezoidActive()
        {
            if (trapezoid.Checked)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        bool IIntegralView.IsSimpsonActive()
        {
            if (simpson.Checked)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        void IIntegralView.ShowResult(double[] inputArray)
        {
            if (formatBox.Text.Length != 0)
            {
                inputArray[0] = Math.Truncate(inputArray[0] * Math.Pow(10, Convert.ToInt32(formatBox.Text))) / Math.Pow(10, Convert.ToInt32(formatBox.Text));
                inputArray[1] = Math.Truncate(inputArray[1] * Math.Pow(10, Convert.ToInt32(formatBox.Text))) / Math.Pow(10, Convert.ToInt32(formatBox.Text));
                inputArray[2] = Math.Truncate(inputArray[2] * Math.Pow(10, Convert.ToInt32(formatBox.Text))) / Math.Pow(10, Convert.ToInt32(formatBox.Text));
            }
            rectangleResult.Text = inputArray[0].ToString();
            trapezoidResult.Text = inputArray[1].ToString();
            simpsonResult.Text = inputArray[2].ToString();

        }

        void IIntegralView.ReverseResult(int countOfIterations)
        {
            MessageBox.Show("Необходимое n = " + countOfIterations, "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        string IIntegralView.returnFunction()
        {
            if (function.Text.Contains("x"))
            {
                return function.Text;
            }
            else
            {
                MessageBox.Show("Нет функции", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "x";
            }
        }

        void IIntegralView.ShowGraph(PlotModel plotModel)
        {
            this.pvGraph.Model = plotModel;
        }

        public event EventHandler<EventArgs> CreateIntegralGraph;
        public event EventHandler<EventArgs> Calculate;
        public event EventHandler<EventArgs> ReverseMode;

        private void toolStripTextBox1_Click(object sender, EventArgs inputEvent)
        {
            CreateIntegralGraph(sender, inputEvent);
        }

        private void toolStripTextBox2_Click(object sender, EventArgs inputEvent)
        {
            Calculate(sender, inputEvent);
        }

        private void toolStripTextBox3_Click(object sender, EventArgs inputEvent)
        {
            ReverseMode(sender, inputEvent);
        }
    }
}
