using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;

namespace digital_signal_processing_lab1_winform
{
    class Drawer
    {
        public void drawGrap(PointPairList pointsArray, ZedGraphControl zedGraph, Color color)
        {
            GraphPane pane = zedGraph.GraphPane;
            pane.CurveList.Clear();
            LineItem curve = pane.AddCurve("signal", pointsArray, color, SymbolType.None);
            zedGraph.AxisChange();
            zedGraph.Invalidate();

        }
    }
    class Generator
    {
        private PointPair  GeneratePoint(double A, double f, double N, int n, double fi)
        {
            double xn = A * Math.Sin((2 * Math.PI * f * n) / N + fi);
            PointPair result = new PointPair(n, xn);
            return result;
        }

        public PointPairList GeneratePointArray(double A, double f, double N, double fi)
        {
            PointPairList pointPairList = new();
            for (int n = 0; n < N; n++)
            {
                pointPairList.Add(GeneratePoint(A, f, N, n, fi));
            }
            return pointPairList;
        }
    }

    class GeneratorPoly 
    {
        private double GenerateHarmonic(double A, double f, double N, int n, double fi)
        {
            double harmonic = A * Math.Sin((2 * Math.PI * f * n) / N + fi);
            return harmonic;
        }

        private PointPair GeneratePoint(double A, double f, double N, int n, double fi)
        {
            double xn = GenerateHarmonic(3, 1, N, n, Math.PI / 4) + GenerateHarmonic(3, 2, N, n, 3 * Math.PI / 4) +
                GenerateHarmonic(3, 3, N, n, 2 * Math.PI / 4) + GenerateHarmonic(3, 4, N, n, Math.PI / 2) + GenerateHarmonic(3, 5, N, n, Math.PI / 2);
            PointPair result = new PointPair(n, xn);
            return result;
        }

        public PointPairList GeneratePointArray(double A, double f, double N, double fi)
        {
            PointPairList pointPairList = new();
            for (int n = 0; n < N; n++)
            {
                pointPairList.Add(GeneratePoint(A, f, N, n, fi));
            }
            return pointPairList;
        }
    }

    class GeneratorPolyNormal
    {
        private double GenerateHarmonic(double A, double f, double N, int n, double fi)
        {
            double harmonic = A * Math.Sin((2 * Math.PI * f * n) / N + fi);
            return harmonic;
        }

        private PointPair GeneratePoint(double A, double f, double N, int n, double fi)
        {
            double xn = GenerateHarmonic(0.5, 0.5, N, n, 0.5) + GenerateHarmonic(0.519, 0.519, N, n, 0.519) +
                GenerateHarmonic(0.539, 0.539, N, n, 0.539) + GenerateHarmonic(0.559, 0.559, N, n, 0.559) + GenerateHarmonic(0.579, 0.579, N, n, 0.579);
            PointPair result = new PointPair(n, xn);
            return result;
        }

        public PointPairList GeneratePointArray(double A, double f, double N, double fi)
        {
            PointPairList pointPairList = new();
            for (int n = 0; n < N; n++)
            {
                pointPairList.Add(GeneratePoint(A, f, N, n, fi));
            }
            return pointPairList;
        }
    }
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
