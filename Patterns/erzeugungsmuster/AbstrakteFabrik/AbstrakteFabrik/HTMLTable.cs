using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstrakteFabrik
    {
    public class HTMLTable : Table
        {
        public override void display()
            {
            // throw new NotImplementedException ();

            // Anfang der Tabelle
            Console.WriteLine ( "<table>" );

            // Darstellung des Headers
            this.header.display ();

            foreach ( Row row in this.rows )
                {
                // die Zeilen sollen sich selber zeichnen
                row.display ();
                }

            // Ende der Tabelle
            Console.WriteLine ( "</table>" );

            }
        }
    }
