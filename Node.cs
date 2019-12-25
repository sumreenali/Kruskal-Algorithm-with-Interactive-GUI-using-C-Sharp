using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kruskal
{
    class Node
    {
        #region Members
        int nName;
        public int nRank;
        public Node vRoot;
        public System.Drawing.Point pPosition;
        #endregion

        #region Properties
        public int Name
        {
            get
            {
                return nName;
            }
        }
        #endregion

        public Node(int nName, System.Drawing.Point pPosition)
        {
            this.nName = nName;
            nRank = 0;
            this.vRoot = this;
            this.pPosition = pPosition;
        }

        #region Methods
        internal Node GetRoot()
        {
            if (this.vRoot != this)
            {
                this.vRoot = this.vRoot.GetRoot();
            }
            return this.vRoot;
        }

        internal static void Join(Node vRoot1, Node vRoot2)
        {

            if (vRoot2.nRank < vRoot1.nRank)
            {
                vRoot2.vRoot = vRoot1;
            }
            else 
            {
                vRoot1.vRoot = vRoot2;
                if (vRoot1.nRank == vRoot2.nRank)
                {
                    vRoot1.nRank++;
                }
            }
        }
        #endregion
    }
}
