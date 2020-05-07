using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using JsonToHtml.Models;
using System.Text.Json;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using JsonSerializer = System.Text.Json.JsonSerializer;


namespace JsonToHtml.Utilities
{
    public class JsonToModel
    {
        public FormModel Distribute()
        {
            

               string jsonString = File.ReadAllText("C:\\Users\\Бог\\source\\repos\\JsonToHtml\\JsonToHtml\\example1.json");
            //string jsonString = File.ReadAllText("~/Resources/example1.json");
            FormModel model = JsonSerializer.Deserialize<FormModel>(jsonString);
            
            
            return model;
        }



    }

  
}