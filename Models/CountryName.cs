using System.Collections.Generic;

namespace World_Countries;

public class CountryName
{
    public string common { get; set; }
    public string official { get; set; }
    public Dictionary<string, NativeName> nativeName { get; set; }
}