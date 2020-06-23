using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace REST_API_CALL
{
    class csFields
    {
        private csFields() { }
        public static readonly csFields fields = new csFields();

        public struct project
        {
            public string key { get; set; }
            
        }
        private string description;
        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
            }
        }
        public class issuetype
        {
            public string name { get; set; }
            
        }
        public string summary { get; set; }
        public class assignee
        {
            public string name { get; set; }
        }

        public class component
        {
            public string name { get; set; }
        }

        public class ComponentCollection
        {
            public ICollection<component> components { get; set; }

            //public ComponentCollection()
            //{

            //}
        }

        
        public class customfield_10324
        {
            public string value { get; set; }
        }
        public class priority
        {
            public string name { get; set; }
        }
        public string labels { get; set; }
      
        public string serializeJSON()
        {
            //string output = JsonConvert.SerializeObject(new { description, summary, new project().key, issuetype = new issuetype().name, assigne = new assignee().name, components = new[] { new component().name }, customfield_10324 = new customfield_10324().value, priority  = new priority().name});
            return null;
        }

        
    }

    
}
