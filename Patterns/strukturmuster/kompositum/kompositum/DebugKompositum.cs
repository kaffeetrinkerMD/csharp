using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace kompositum
    {
    /**
* implementiert ein Kompositum
*/
    public class DebugKompositum : Debugger
        {
        // dient der Einbindung beliebig vieler Debug-Komponenten
        private List<Debugger> debugger = new List<Debugger> ();

        public override void debug( string nachricht )
            {
            //throw new NotImplementedException ();
            foreach ( Debugger kind in this.debugger )
                {
                kind.debug ( nachricht );
                }
            }

        // einen Debugger aggregieren
        public void addDebugger( Debugger deb )
            {
            this.debugger.Add ( deb );
            }

        // einen Debugger aus dem Kompositum entfernen
        public void removeDebugger( Debugger deb )
            {
            this.debugger.Remove ( deb );
            }

        // entfernt alle Debugger aus dem Kompositum
        public void removeAllDebugger( Debugger deb )
            {
            }

        } // Ende Klasse
}
