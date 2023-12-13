using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    interface ISearchable
    {
        bool MatchesCriteria(decimal minPrice, decimal maxPrice, string targetCategory, int minRating);
    }
}
