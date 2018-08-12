using System;
using System.Collections.Generic;
namespace Application
{
    public class Greenhouse : IGreenhouse
    {
        private int? squareMeters = null;

        public Greenhouse()
        {
        }

        public void SetSquareMeters(int sqm)
        {
            if (sqm < 1)
                throw new ArgumentOutOfRangeException();

            squareMeters = sqm;
        }

        public int GetSquareMeters()
        {
            if (squareMeters == null)
                throw new NullReferenceException();

            return (int) squareMeters;    
        }
    }
}


/* Todo

-Unit test
Exceptions
Generics
LINQ
Async/Await
Return types/data binding

(Swagger/swashbuckle, obs applikation ej grundkunskap)

*/
  