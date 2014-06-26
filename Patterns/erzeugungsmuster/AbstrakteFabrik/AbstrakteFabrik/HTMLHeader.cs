using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstrakteFabrik
    {

    public class HTMLHeader : Header
        {
        public override void display()
            {
            // throw new NotImplementedException ();
            // Beginn des Headers
            Console.WriteLine ( "\t<tr>" );

            // Zellen der Kopfzeile
            foreach ( Cell cell in this.cells )
                {
                // die Zellen sollen sich selber zeichnen
                cell.display ();
                }

            // Ende des Headers
            Console.WriteLine ( "\t</tr>" );
            }
        }
    }
