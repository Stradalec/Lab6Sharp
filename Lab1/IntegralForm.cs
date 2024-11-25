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

namespace Lab1
{
    public partial class IntegralForm : Form, IIntegralView
    {

        public IntegralForm()
        {
            InitializeComponent();
            Presenter presenter = new Presenter(this);
        }

        double IIntegralView.Interval()
        {
            return Convert.ToDouble(interval.Text);
        }

        double IIntegralView.upLimit()
        {
            return Convert.ToDouble(upBorder.Text);
        }

        double IIntegralView.lowLimit()
        {
            return Convert.ToDouble(lowBorder.Text);
        }

        int IIntegralView.IntegralIntervalCount()
        {
            return Convert.ToInt32(IntervalLimitation.Text);
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
            rectangleResult.Text = inputArray[0].ToString();
            trapezoidResult.Text = inputArray[1].ToString();
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

        private void toolStripTextBox1_Click(object sender, EventArgs inputEvent)
        {
            CreateIntegralGraph(sender, inputEvent);
        }

        private void toolStripTextBox2_Click(object sender, EventArgs inputEvent)
        {
            Calculate(sender, inputEvent);
        }
    }
}
