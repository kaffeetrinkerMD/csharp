using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstrakteFabrik
    {

    public abstract class Row
        {

        /// <summary>
        /// beliebig viele Zeilen
        /// </summary>
        protected List<Cell> cells = new List<Cell> ();

        /// <summary>
        /// Methode, um Zellen zu einer Zeile inzuzufügen
        /// </summary>
        /// <param name="c">Objekt vom Typ Cell</param>
        public void addCell( Cell c )
            {
            this.cells.Add ( c );
            }

        /// <summary>
        /// abstrakte Methode zum Zeichnen der Zeile
        /// </summary>
        public abstract void display();

        }
    }
