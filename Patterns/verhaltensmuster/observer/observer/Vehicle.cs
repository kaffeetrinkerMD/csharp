using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace observer
    {

    public interface Vehicle
        {
        public void startEngine();

        public void stopEngine();

        public void moveForward( int km );
        }
}
