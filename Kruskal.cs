using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kruskal
{
    public partial class Kruskal : Form
    {
        public Kruskal()
        {
            InitializeComponent();
            Reset();
        }

        #region Member Variables
        const int nRadius = 24;
        const int nHalfRadius = (nRadius / 2);

        Color colVertex = Color.Aqua;
        Color colEdge = Color.Red;

        List<Node> lstVertices;
        List<Link> lstEdgesInitial, lstEdgesFinal;

        Node FirstVertex, SecondVertex;

        bool bDrawEdge, bSolved;

        #endregion

        #region Events

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            Point pClicked = new Point(e.X - nHalfRadius, e.Y - nHalfRadius);
            if (Control.ModifierKeys == Keys.Control)//if Ctrl is pressed
            {
                if (!bDrawEdge)
                {
                    FirstVertex = GetSelectedVertex(pClicked);
                    bDrawEdge = true;
                }
                else
                {
                    SecondVertex = GetSelectedVertex(pClicked);
                    bDrawEdge = false;
                    if (FirstVertex != null && SecondVertex != null && FirstVertex.Name != SecondVertex.Name)
                    {
                        Cost formCost = new Cost();
                        formCost.ShowDialog();

                        Point pStringPoint = GetStringPoint(FirstVertex.pPosition, SecondVertex.pPosition);
                        lstEdgesInitial.Add(new Link(FirstVertex,SecondVertex, formCost.nCost, pStringPoint));
                        panelKruskal.Invalidate();
                    }
                }
            }
            else
            {
                lstVertices.Add(new Node(lstVertices.Count, pClicked));
                panelKruskal.Invalidate();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            DrawVertices(g);
            DrawEdges(g);
            g.Dispose();
        }

        // Find Minimal spanning tree using Kruskal
        private void Solve_Click(object sender, EventArgs e)
        {
            if (lstVertices.Count > 2)
            {
                if (lstEdgesInitial.Count < lstVertices.Count - 1)
                {
                    MessageBox.Show("Missing Edges", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    Solve.Enabled = false;
                    int nTotalCost = 0;
                    lstEdgesFinal = SolveGraph(ref nTotalCost);
                    bSolved = true;
                    panelKruskal.Invalidate();
                    MessageBox.Show("Total Cost:" + nTotalCost.ToString(), "Solution", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        // Clear the drawing area
        private void Clear_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Clear form ?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dr == DialogResult.Yes)
            {
                Solve.Enabled = true;
                Graphics g = panelKruskal.CreateGraphics();
                g.Clear(panelKruskal.BackColor);
                Reset();
            }
        }

        #endregion

        #region Methods

        #region Drawing

        private void DrawEdges(Graphics g)
        {
            Pen P = new Pen(colEdge);
            List<Link> lstEdges = bSolved ? lstEdgesFinal : lstEdgesInitial;
            foreach (Link e in lstEdges)
            {
                Point pV1 = new Point(e.V1.pPosition.X + nHalfRadius, e.V1.pPosition.Y + nHalfRadius);
                Point pV2 = new Point(e.V2.pPosition.X + nHalfRadius, e.V2.pPosition.Y + nHalfRadius);
                g.DrawLine(P, pV1, pV2);
                DrawString(e.Cost.ToString(), e.StringPosition, g);
            }
        }

        private void DrawString(string strText, Point pDrawPoint, Graphics g)
        {
            Font drawFont = new Font("Snap ITC", 13);
            SolidBrush drawBrush = new SolidBrush(Color.Black);
            g.DrawString(strText, drawFont, drawBrush, pDrawPoint);
        }

        private void DrawVertices(Graphics g)
        {
            Pen P = new Pen(colVertex);
            Brush B = new SolidBrush(colVertex);
            foreach (Node v in lstVertices)
            {
                g.DrawEllipse(P, v.pPosition.X, v.pPosition.Y, nRadius, nRadius);
                g.FillEllipse(B, v.pPosition.X, v.pPosition.Y, nRadius, nRadius);
                DrawString(v.Name.ToString(), v.pPosition, g);
            }
        }

        private Node GetSelectedVertex(Point pClicked)
        {
            Node vReturn = null;
            double dDistance;
            foreach (Node v in lstVertices)
            {
                dDistance = GetDistance(v.pPosition, pClicked);
                if (dDistance <= nRadius)
                {
                    vReturn = v;
                    break;
                }
            }
            return vReturn;
        }

        private double GetDistance(Point pStart, Point pFinish)
        {
            return Math.Sqrt(Math.Pow(pStart.X - pFinish.X, 2) + Math.Pow(pStart.Y - pFinish.Y, 2));
        }

        private Point GetStringPoint(Point pStart, Point pFinish)
        {
            int X = (pStart.X + pFinish.X) / 2;
            int Y = (pStart.Y + pFinish.Y) / 2;
            return new Point(X, Y);
        }
        #endregion

        private void Reset()
        {
            lstVertices = new List<Node>();
            lstEdgesInitial = new List<Link>();
            bSolved = false;
            FirstVertex =SecondVertex = null;
        }

        private List<Link> SolveGraph(ref int nTotalCost)
        {
            Link.QuickSort(lstEdgesInitial, 0, lstEdgesInitial.Count - 1);
            List<Link> lstEdgesRetun = new List<Link>(lstEdgesInitial.Count);
            foreach (Link ed in lstEdgesInitial)
            {
                Node vRoot1, vRoot2;
                vRoot1 = ed.V1.GetRoot();
                vRoot2 = ed.V2.GetRoot();
                if (vRoot1.Name != vRoot2.Name)
                {
                    nTotalCost += ed.Cost;
                    Node.Join(vRoot1, vRoot2);
                    lstEdgesRetun.Add(new Link(ed.V1, ed.V2, ed.Cost, ed.StringPosition));
                }
            }
            return lstEdgesRetun;
        }

        #endregion

        private void Kruskal_Load(object sender, EventArgs e)
        {

        }
    }
}
