using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZohoCrmConnector.Entities
{
    public class Fields
    {
        public List<Section> listSections { get; set; }

        public Fields()
        {
            listSections = new List<Section>();
        }

        public class Section
        {
            public string name { get; set; }
            public string dv { get; set; }
            public List<Field> listFields { get; set; }

            public Section()
            {
                listFields = new List<Field>();
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
