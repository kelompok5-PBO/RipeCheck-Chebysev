using System;
using System.Collections.Generic;

namespace RipeCheck.Web.Models
{
    public class ResultRepository<T> where T : Fruit
    {
        private readonly List<T> _results = new List<T>();

        public void Add(T item)
        {
            _results.Add(item);
        }

        public List<T> GetAll()
        {
            return _results;
        }

        public List<T> Filter(Func<T, bool> condition)
        {
            var filtered = new List<T>();
            foreach (T item in _results)
            {
                if (condition(item))
                    filtered.Add(item);
            }
            return filtered;
        }

        // Dictionary: jumlah hasil per label kematangan
        public Dictionary<string, int> CountByRipeness()
        {
            var counts = new Dictionary<string, int>();
            foreach (T item in _results)
            {
                if (counts.ContainsKey(item.Ripeness))
                    counts[item.Ripeness]++;
                else
                    counts[item.Ripeness] = 1;
            }
            return counts;
        }
    }
}