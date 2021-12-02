using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;

namespace digital_signal_processing_lab1_winform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DrawGraphTask1();
            DrawGraphTask2();
            DrawGraphTask3();
            DrawGraphTask4();
            DrawGraphTask5();
        }

        private void zedGraphControl1_Load(object sender, EventArgs e)
        {
            
        }
        private void DrawGraphTask1() {
            PointPairList pointArrayForGrap1,
                pointArrayForGrap2,
                pointArrayForGrap3,
                pointArrayForGrap4,
                pointArrayForGrap5;
            Generator generator = new Generator();
            pointArrayForGrap1 = generator.GeneratePointArray(8, 4, 512, Math.PI / 6);
            pointArrayForGrap2 = generator.GeneratePointArray(8, 4, 512, Math.PI / 3);
            pointArrayForGrap3 = generator.GeneratePointArray(8, 4, 512, 2  * Math.PI / 3);
            pointArrayForGrap4 = generator.GeneratePointArray(8, 4, 512, Math.PI / 4);
            pointArrayForGrap5 = generator.GeneratePointArray(8, 4, 512, 0);
            GraphPane pane = zedGraphControl1.GraphPane;
            pane.CurveList.Clear();
            LineItem curve1 = pane.AddCurve("signal1", pointArrayForGrap1, Color.Blue, SymbolType.None);
            LineItem curve2 = pane.AddCurve("signal2", pointArrayForGrap2, Color.Red, SymbolType.None);
            LineItem curve3 = pane.AddCurve("signal3", pointArrayForGrap3, Color.Green, SymbolType.None);
            LineItem curve4 = pane.AddCurve("signal4", pointArrayForGrap4, Color.Yellow, SymbolType.None);
            LineItem curve5 = pane.AddCurve("signal5", pointArrayForGrap5, Color.HotPink, SymbolType.None);
            zedGraphControl1.AxisChange();
            zedGraphControl1.Invalidate();
        }

        private void DrawGraphTask2() 
        {
            PointPairList pointArrayForGrap1,
                pointArrayForGrap2,
                pointArrayForGrap3,
                pointArrayForGrap4,
                pointArrayForGrap5;
            Generator generator = new Generator();
            pointArrayForGrap1 = generator.GeneratePointArray(4, 8, 512, 0);
            pointArrayForGrap2 = generator.GeneratePointArray(4, 1, 512, 0);
            pointArrayForGrap3 = generator.GeneratePointArray(4, 5, 512, 0);
            pointArrayForGrap4 = generator.GeneratePointArray(4, 4, 512, 0);
            pointArrayForGrap5 = generator.GeneratePointArray(4, 9, 512, 0);
            GraphPane pane = zedGraphControl2.GraphPane;
            pane.CurveList.Clear();
            LineItem curve1 = pane.AddCurve("signal1", pointArrayForGrap1, Color.Blue, SymbolType.None);
            LineItem curve2 = pane.AddCurve("signal2", pointArrayForGrap2, Color.Red, SymbolType.None);
            LineItem curve3 = pane.AddCurve("signal3", pointArrayForGrap3, Color.Green, SymbolType.None);
            LineItem curve4 = pane.AddCurve("signal4", pointArrayForGrap4, Color.Yellow, SymbolType.None);
            LineItem curve5 = pane.AddCurve("signal5", pointArrayForGrap5, Color.HotPink, SymbolType.None);
            zedGraphControl2.AxisChange();
            zedGraphControl2.Invalidate();
        }
        private void DrawGraphTask3()
        {
            PointPairList pointArrayForGrap1,
                pointArrayForGrap2,
                pointArrayForGrap3,
                pointArrayForGrap4,
                pointArrayForGrap5;
            Generator generator = new Generator();
            pointArrayForGrap1 = generator.GeneratePointArray(8, 2, 512, 0);
            pointArrayForGrap2 = generator.GeneratePointArray(3, 2, 512, 0);
            pointArrayForGrap3 = generator.GeneratePointArray(2, 2, 512, 0);
            pointArrayForGrap4 = generator.GeneratePointArray(1, 2, 512, 0);
            pointArrayForGrap5 = generator.GeneratePointArray(4, 2, 512, 0);
            GraphPane pane = zedGraphControl3.GraphPane;
            pane.CurveList.Clear();
            LineItem curve1 = pane.AddCurve("signal1", pointArrayForGrap1, Color.Blue, SymbolType.None);
            LineItem curve2 = pane.AddCurve("signal2", pointArrayForGrap2, Color.Red, SymbolType.None);
            LineItem curve3 = pane.AddCurve("signal3", pointArrayForGrap3, Color.Green, SymbolType.None);
            LineItem curve4 = pane.AddCurve("signal4", pointArrayForGrap4, Color.Yellow, SymbolType.None);
            LineItem curve5 = pane.AddCurve("signal5", pointArrayForGrap5, Color.HotPink, SymbolType.None);
            zedGraphControl3.AxisChange();
            zedGraphControl3.Invalidate();
        }
        private void DrawGraphTask4()
        {
            PointPairList pointArrayForGrap1;
            GeneratorPoly generator = new GeneratorPoly();
            pointArrayForGrap1 = generator.GeneratePointArray(8, 2, 512, 0);
            GraphPane pane = zedGraphControl4.GraphPane;
            pane.CurveList.Clear();
            LineItem curve1 = pane.AddCurve("signal1", pointArrayForGrap1, Color.Blue, SymbolType.None);
            zedGraphControl4.AxisChange();
            zedGraphControl4.Invalidate();
        }

        private void DrawGraphTask5()
        {
            PointPairList pointArrayForGrap1;
            GeneratorPolyNormal generator = new GeneratorPolyNormal();
            pointArrayForGrap1 = generator.GeneratePointArray(8, 2, 512, 0);
            GraphPane pane = zedGraphControl5.GraphPane;
            pane.CurveList.Clear();
            LineItem curve1 = pane.AddCurve("signal1", pointArrayForGrap1, Color.Blue, SymbolType.None);
            zedGraphControl5.AxisChange();
            zedGraphControl5.Invalidate();
        }
    }
}
