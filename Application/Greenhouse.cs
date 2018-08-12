using System;
using System.Collections.Generic;
using System.Linq;

namespace Application
{
    public class Greenhouse : IGreenhouse
    {
        private int? squareMeters = null;
        private List<Plant> plants = new List<Plant>();

        public Greenhouse()
        {
            plants.Add(new Plant("Rose",        5, 1.2));
            plants.Add(new Plant("Tulip",      12, 0.3));
            plants.Add(new Plant("Apple tree",  2, 1.7));
        }

        public IEnumerable<string> GetPlantsTallerThan(double height)
        {
            IEnumerable<string> plantsQuery =
                from plant in plants
                where plant._height > height
                select plant._name;

            return plantsQuery;
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
-Exceptions
Generics
-LINQ
Async/Await
Return types/data binding
db/Entity framework

(Swagger/swashbuckle, obs applikation ej grundkunskap)

*/
  