using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JsonToHtml.Models
{
    public class ItemsModel
    {
        public string type { get; set;  }
        public string name { get; set; }
        public string placeholder { get; set; }
        public bool required { get; set; }
        public string validationRules { get; set; }
        public string value { get; set; }
        public string label { get; set; }
        public string htmlClass { get; set; }
        public bool disabled { get; set; }
        public string text { get; set; }
        public SelectItems[] options { get; set; }
        public bool selected { get; set; }
        public RadioItems[] items { get; set; }
        public bool checkedBox { get; set; }

    }
}