using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApplicationParceAttribute
{
    class Program
    {
        static void Main(string[] args)
        {
            var exampleAttr = @"[Map(Name = ""test"")]";
            var exampleAttr2 = @"[Check(    ""12, 12"", Enum.aaa, ""sas, as""  , arg1: 23, Prop1 = 12, Prop2 =   ""sad,das"")]" + "\r\n";
            var exampleAttr3 = @"[Adress(PrimaryKey = ""AvailabilityId, TimeFrom, Days, TimeTo"", Queryes = QueryType.Select | QueryType.Delete)]" + "\r\n";
            var exampleAttr4 = @"[Glue(Name=""MenuItem"")]" + "\r\n";

            var exampleAttrs = exampleAttr + exampleAttr2 + exampleAttr3 + exampleAttr4;

            var attributeCollection = new List<AttributeAndPropeperties>();
            var listOfStringProperties = new List<string>();
            var charity = "";

            Regex attributes = new Regex(@"\[\s*(?<Name>\w*)\s*(\((?<arguments>.*)\))?\s*\]", RegexOptions.IgnoreCase | RegexOptions.Multiline);
            MatchCollection matchesAttrs = attributes.Matches(exampleAttrs);

            foreach (Match match in matchesAttrs)
            {
                var properties = match.Groups[match.Groups.Count - 1].ToString();
                var dictionaryOfAttributes = new Dictionary<string, string>();
                var countProperties = 0;

                attributes = new Regex(@"(""(?:\\""|\\r|\\n|\\t|\\\\|[^""\\])*"")", RegexOptions.IgnoreCase | RegexOptions.Multiline);
                MatchCollection matchesProperties = attributes.Matches(properties);

                foreach (var property in matchesProperties)
                {
                    properties = properties.Replace(property.ToString(), "%%string" + countProperties + "%%");
                    listOfStringProperties.Add(property.ToString());
                    countProperties++;
                }

                countProperties = 0;
                foreach (string property in properties.Split(',').ToList())
                {
                    if (property.Contains("%%string"))
                    {
                        if (property.Split(':', '=').Count() == 2)
                        {
                            if (property.Split(':', '=')[1].Contains("%%string"))
                                dictionaryOfAttributes.Add(property.Split(':', '=')[0], listOfStringProperties[Convert.ToInt32(property.Split(':', '=')[1].Replace("%%string", "").Replace("%", ""))]);
                        }
                        else
                            dictionaryOfAttributes.Add(countProperties.ToString(CultureInfo.InvariantCulture), listOfStringProperties[Convert.ToInt32(property.Replace("%%string", "").Replace("%", ""))]);
                    }
                    else
                    {
                        if (property.Split(':', '=').Count() == 2)
                            dictionaryOfAttributes.Add(property.Split(':', '=')[0], property.Split(':', '=')[1]);
                        else
                            dictionaryOfAttributes.Add(countProperties.ToString(CultureInfo.InvariantCulture), property);
                    }

                    countProperties++;
                }

                attributeCollection.Add(new AttributeAndPropeperties
                {
                    Name = match.Groups[match.Groups.Count - 2].ToString(),
                    Patameters = dictionaryOfAttributes
                });
            }
        }

        public class AttributeAndPropeperties
        {
            public string Name { get; set; }
            public Dictionary<string, string> Patameters { get; set; }

            public string GetParameterByKeyName(string key)
            {
                return Patameters.FirstOrDefault(x => x.Key.ToString(CultureInfo.InvariantCulture).Trim() == key).Value;
            }
        }
    }
}
