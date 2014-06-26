using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstrakteFabrik
    {

    public class HTMLFactory : AbstractFactory
        {

        public override Table createTable()
            {
            //throw new NotImplementedException ();
            return new HTMLTable ();
            }

        public override Header createHeader()
            {
            //throw new NotImplementedException ();
            return new HTMLHeader ();
            }

        public override Row createRow()
            {
            //throw new NotImplementedException ();
            return new HTMLRow ();
            }

        public override Cell createCell( String content )
            {
            //throw new NotImplementedException ();
            return new HTMLCell ( content );
            }
        }
    }
