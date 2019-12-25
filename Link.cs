using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kruskal
{
    class Link : IComparable
    {
        #region Members
        Node v1, v2;
        int nCost;
        System.Drawing.Point pStringPosition;
        #endregion

        #region Properties
        public Node V1
        {
            get
            {
                return v1;
            }
        }
        public Node V2
        {
            get
            {
                return v2;
            }
        }
        public int Cost
        {
            get
            {
                return nCost;
            }
        }
        public System.Drawing.Point StringPosition
        {
            get
            {
                return pStringPosition;
            }
        }
        #endregion

        public Link(Node v1, Node v2, int nCost, System.Drawing.Point pStringPosition)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.nCost = nCost;
            this.pStringPosition = pStringPosition;
        }

        #region IComparable Members

        public int CompareTo(object obj)
        {
            Link e = (Link)obj;
            return this.nCost.CompareTo(e.nCost);
        }

        #endregion

        internal static void QuickSort(List<Link> lstEdgesInitial, int nLeft, int nRight)
        {
            int i, j, x;
            i = nLeft;
            j = nRight;
            x = lstEdgesInitial[(nLeft + nRight) / 2].Cost;

            do
            {
                while ((lstEdgesInitial[i].Cost < x) && (i < nRight))
                    i++;

                while ((x < lstEdgesInitial[j].Cost) && (j > nLeft))
                    j--;

                if (i <= j)
                {
                    Link y = lstEdgesInitial[i];
                    lstEdgesInitial[i] = lstEdgesInitial[j];
                    lstEdgesInitial[j] = y;
                    i++;
                    j--;
                }

            }
            while (i <= j);

            if (nLeft < j) 
                QuickSort(lstEdgesInitial, nLeft, j);

            if (i < nRight) 
                QuickSort(lstEdgesInitial, i, nRight);
        }
    }
}
