using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace World_Countries;

public class Country
{
    public CountryName name { get; set; }
    public List<string> capital { get; set; }
    public List<string> tld { get; set; }
    public string subregion { get; set; }
    public double area { get; set; }
    public string flag { get; set; }
    public int population { get; set; }
    public string fifa { get; set; }
    public List<string> timezones { get; set; }
    public Flags flags { get; set; }
    // public CoatOfArms coatOfArms { get; set; }
    public string startOfWeek { get; set; }
}