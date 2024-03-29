﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstrakteFabrik
    {

    public abstract class AbstractFactory
        {

        // muss eine Tabelle liefern
        public abstract Table createTable();

        // muss einen Header liefern
        public abstract Header createHeader();

        // muss eine Zeile liefern
        public abstract Row createRow();

        // muss eine Zelle liefern
        public abstract Cell createCell( String content );
        }
}
