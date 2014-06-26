using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace observer
    {

    public class Auto : Vehicle, Opfer
        {

        public override void attach()
            {
            throw new System.NotImplementedException ();
            }

        public override void deatch()
            {
            throw new System.NotImplementedException ();
            }

        public override void informiere()
            {
            throw new System.NotImplementedException ();
            }

        public override void moveForward( int km)
            {
            throw new System.NotImplementedException ();
            }

        public override void startEngine()
            {
            throw new System.NotImplementedException ();
            }

        public override void stopEngine()
            {
            throw new System.NotImplementedException ();
            }
    }
}
