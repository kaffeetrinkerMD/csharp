using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kompositum
    {
    class Program
        {
        static void Main( string[] args )
            {
            DebugKompositum kompositum = new DebugKompositum ();

            DebugLog debLog = new DebugLog ();

            DebugMail debMail = new DebugMail ();

            DebugSMS debSMS = new DebugSMS ();

            kompositum.addDebugger ( debLog );
            kompositum.addDebugger ( debMail );
            kompositum.addDebugger ( debSMS );

            kompositum.debug ( "C# ist gut!" );

            Console.ReadKey ();
            }
        }
    }
