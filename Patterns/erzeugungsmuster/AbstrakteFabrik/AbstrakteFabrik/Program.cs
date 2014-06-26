using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstrakteFabrik
    {
    class Program
        {
        static void Main( string[] args )
            {
            String[][] tabelle = new String[ 3 ][];
            HTMLFactory fabrik = new HTMLFactory ();

            // Kopfzeile
            tabelle[ 0 ] = new String[ 3 ];
            // 1. Datenzeile
            tabelle[ 1 ] = new String[ 3 ];
            // 2. Datenzeile
            tabelle[ 2 ] = new String[ 3 ];

            // Daten Kopfzeile
            tabelle[ 0 ][ 0 ] = "U1";
            tabelle[ 0 ][ 1 ] = "U2";
            tabelle[ 0 ][ 2 ] = "U3";

            // Daten 1. Zeile
            tabelle[ 1 ][ 0 ] = "10";
            tabelle[ 1 ][ 1 ] = "20";
            tabelle[ 1 ][ 2 ] = "30";

            // Daten 2. Zeile
            tabelle[ 2 ][ 0 ] = "100";
            tabelle[ 2 ][ 1 ] = "200";
            tabelle[ 2 ][ 2 ] = "300";

            // ... der Client
            Client client = new Client ( fabrik );

            // Ausgabe
            client.showData ( tabelle );
            Console.ReadKey ();
            }
        }
    }
