using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstrakteFabrik
    {

    public class HTMLCell : Cell
        {
        // Konstruktor
        public HTMLCell( String s )
            : base ( s )
            {
            this.content = s;
            }
        public override void display()
            {
            // throw new NotImplementedException ();
            // Beginn der Zelle
            Console.WriteLine ( "\t\t<td>" );

            // Inhalt der Zelle
            Console.WriteLine ( this.content );

            // Ende der Zelle
            Console.WriteLine ( "\t\t</td>" );
            }
        }
    }
