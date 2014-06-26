using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace kompositum
    {

    public class DebugLog : Debugger
        {
        private String className = "DebugLog";

        public override void debug( string nachricht )
            {
            //throw new NotImplementedException ();
            Console.WriteLine ( className + ": " + nachricht );
            }
        }
}
