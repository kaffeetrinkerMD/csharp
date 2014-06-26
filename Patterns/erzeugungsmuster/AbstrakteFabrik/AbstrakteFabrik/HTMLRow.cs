using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstrakteFabrik
    {

    public class HTMLRow : Row
        {
        public override void display()
            {
            //throw new NotImplementedException ();

            // Beginn der Zeile
            Console.WriteLine ( "\t<tr>" );

            // alle Datenzeilen
            foreach ( Cell cell in this.cells )
                {
                // die Zellen sollen sich selber zeichnen
                cell.display ();
                }

            // Ende der Zeile
            Console.WriteLine ( "\t</tr>" );
            }
        }
    }
