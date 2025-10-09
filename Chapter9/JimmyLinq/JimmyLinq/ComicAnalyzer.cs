using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace JimmyLinq
{
    public static class ComicAnalyzer
    {
        private static PriceRange CalculatePriceRange(Comic comic, IReadOnlyDictionary<int, decimal> prices)
        {
            if (prices[comic.Issue] < 100)
                return PriceRange.Cheap;
            return PriceRange.Expensive;
        }
        public static IEnumerable<IGrouping<PriceRange, Comic>> GroupComicsByPrice(IEnumerable<Comic> Catalog, IReadOnlyDictionary<int, decimal> prices)
        {
            var GroupByPrice = Catalog.OrderBy(c => c.Issue).GroupBy(c => CalculatePriceRange(c, prices));
            return GroupByPrice;
        }
        public static IEnumerable<string> GetReviews(IEnumerable<Comic> Catalog, IEnumerable<Review> Reviews)
        {
            var ReviewList = Catalog.OrderBy(c => c.Issue).Join(Reviews, c => c.Issue, r => r.Issue,
                (c,r) => $"{r.Critic} rated #{c.Issue} '{c.Name}' {r.Score:0.00}");
            return ReviewList;
        }
    }
}
