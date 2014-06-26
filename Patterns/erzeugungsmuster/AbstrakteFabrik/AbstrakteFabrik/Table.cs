using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstrakteFabrik
    {

    /// <summary>
    /// Abstrakte Produktklasse (abstraktes Produkt a)
    /// </summary>
    /// <remarks>
    /// Diese Klasse wird benötigt, damit der Nutzer (z.B. die Client-Klasse) die Tabelle referenzieren kann.
    /// 
    /// </remarks>
    public abstract class Table
        {

        // eine Kopfzeile
        protected Header header = null;

        // beliebig viele Kopfzeilen
        protected List<Row> rows = new List<Row> ();

        /// <summary>
        /// Methode, um zur Tabelle eine Kopfzeile hinzuzufügen
        /// </summary>
        /// <param name="h">Objekt vom Typ Header</param>
        public void setHeader( Header h )
            {

            this.header = h;
            }

        /// <summary>
        /// Methode, um zur Tabelle eine Datenzeile hinzuzufügen
        /// </summary>
        /// <param name="r">Objekt vom Typ Header</param>
        public void addRow( Row r )
            {

            this.rows.Add ( r );
            }

        /// <summary>
        /// abstrakte Methode zum Zeichnen der Tabelle
        /// </summary>
        public abstract void display();
        }
    }
