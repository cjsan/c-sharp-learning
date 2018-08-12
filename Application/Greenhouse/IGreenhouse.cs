using System;
using System.Collections.Generic;

namespace Application
{
    public interface IGreenhouse
    {
        void SetSquareMeters(int sqm);
        int GetSquareMeters();
        IEnumerable<string> GetPlantsTallerThan(double height);
    }
}
