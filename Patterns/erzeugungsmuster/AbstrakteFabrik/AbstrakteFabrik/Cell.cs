using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstrakteFabrik
    {

    public abstract class Cell
        {

        /// <summary>
        /// Der Inhalt einer Zelle
        /// </summary>
        protected String content = null;

        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="c">Objekt vom Typ Cell</param>
        public Cell( String content )
            {

            this.content = content;
            }

        /// <summary>
        /// abstrakte Methode, die eine Zelle Zeichnet
        /// </summary>
        public abstract void display();
        }
    }
