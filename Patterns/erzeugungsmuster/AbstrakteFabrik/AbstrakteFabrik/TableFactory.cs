using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstrakteFabrik
    {

    public abstract class TableFactory
        {
        abstract public void createTable();
        abstract public void createRow();
        abstract public void createHeader();
        abstract public void createCell();
        }
    }
