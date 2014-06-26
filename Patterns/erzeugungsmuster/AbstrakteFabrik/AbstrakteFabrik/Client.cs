using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstrakteFabrik
    {

    /// <summary>
    /// Der Client verwaltet die Assoziation (unidirektional) zu einer abstrakten Tabellenfabrik
    /// </summary>
    public class Client
        {
        private AbstractFactory tableFactory = null;

        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="fab"></param>
        public Client( AbstractFactory fab )
            {

            // die konkrete Fabrik wird via dependency injection
            // zur Laufzeit des Programms festgelegt
            this.tableFactory = fab;
            }

        public void showData( String[][] data )
            {

            // falls noch keine Fabrik geimpft wurde, dann Ausnahme schmeißen
            if ( this.tableFactory == null )
                throw new Exception ( "Erst eine Fabrik injizieren!" );

            // eine Tabelle erzeugen
            Table table = this.tableFactory.createTable ();

            // eine Kopfzeile erzeugen
            Header header = this.tableFactory.createHeader ();

            // die erste Zeile aus dem Datenfeld enthält die Überschriften
            String[] headline = data[ 0 ];

            for ( int i = 0; i < headline.Length; i++ )
                {

                Cell cell = this.tableFactory.createCell ( headline[ i ] );

                // wir fügen die neue Zelle zur Kopfzeile hinzu
                header.addCell ( cell );
                }

            // die fertige Kopfzeile tragen wir in die Tabelle ein
            table.setHeader ( header );

            // nun noch die Datenzeilen zur Tabelle hinzufügen
            for ( int i = 1; i < data.Length; i++ )
                {

                // die Zeile in einem String-Array speichern
                String[] values = data[ i ];

                // für die Daten brauchen wir eine neue Zeile in der Tabelle
                Row row = this.tableFactory.createRow ();

                // für jeden einzelnen Wert aus values
                foreach ( String s in values )
                    {

                    // .. erzeugen wir eine neue Zelle
                    Cell c = this.tableFactory.createCell ( values[ i ] );

                    // .. und fügen diese zur Zeile hinzu
                    row.addCell ( c );
                    }

                // die fertige Datenzeile zur Tabelle hinzufügen
                table.addRow ( row );
                }

            // fertig mit der Tabelle, dann Tabelle zeichnen
            table.display ();
            }
        }
    }
