using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JsonToHtml.Models
{
    public class FormModel
    {
        public Dictionary<string, string> form { get; set; }
        public string  name { get; set; }
        public ItemsModel[] items { get; set; }
       public string postmessage { get; set; }


    }
}