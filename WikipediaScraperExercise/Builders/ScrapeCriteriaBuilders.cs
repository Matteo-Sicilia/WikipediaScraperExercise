using System.Text.RegularExpressions;
using System.Collections.Generic;
using WikipediaScraperExercise.Data;

namespace WikipediaScraperExercise.Builders;

public class ScrapeCriteriaBuilders
{
    private string _data = null!;
    private string _regex = null!;
    private RegexOptions _regexOptions;
    private List<ScrapeCriteriaParts> _parts = null!;

    public ScrapeCriteriaBuilders()
    {
        SetDefaults();

    }

    private void SetDefaults()
    {
        _data = string.Empty;
        _regex = string.Empty;
        _regexOptions = RegexOptions.None;
        _parts = new List<ScrapeCriteriaParts>();
    }
    public ScrapeCriteriaBuilders WithData(string data)
    {
        _data = data;
        return this;
    }
}