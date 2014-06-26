using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace kompositum
    {

    public class DebugSMS : Debugger
        {
        private String className = "DebugSMS";

        public override void debug( string nachricht )
            {
            //throw new NotImplementedException ();

            Console.WriteLine ( className + ": " + nachricht );
            }
        }
}
