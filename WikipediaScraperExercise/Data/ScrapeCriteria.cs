using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace WikipediaScraperExercise.Data
{
    class ScrapeCriteria
    {
        public ScrapeCriteria()
        {
            Parts = new List<ScrapeCriteriaParts>();
        }

        public string? Data { get; set; }
        public string? Regex { get; set; }
        public RegexOptions RegexOptions { get; set; }

        public List<ScrapeCriteriaParts> Parts { get; set; }
    }
}