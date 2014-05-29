using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZohoCrmConnector.Entities
{
    public class Fields
    {
        public Dictionary<string, Section> listSections { get; set; }

        public Fields()
        {
            listSections = new Dictionary<string,Section>();
        }

        public class Section
        {
            public string name { get; set; }
            public string dv { get; set; }
            public Dictionary<string, Field> listFields { get; set; }

            public Section()
            {
                listFields = new Dictionary<string, Field>();
            }

            public class Field
            {
                public string req { get; set; }
                public string type { get; set; }
                public string isreadonly { get; set; }
                public string maxlength { get; set; }
                public string label { get; set; }
                public string dv { get; set; }
                public string customfield { get; set; }
                public List<Value> listValues { get; set; }

                public Field()
                {
                    listValues = new List<Value>();
                }

                public class Value
                {
                    public string val { get; set; }
                }
            }
        }
    }
}