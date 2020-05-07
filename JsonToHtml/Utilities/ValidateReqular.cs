using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JsonToHtml.Utilities
{
    public static class ValidateReqular
    {
        public static string Validate(string item)
        {

            switch (item)
            {
                case "text":
                    break;

                case "tel":
                    return
                        "(^\\+\\d{1,2})?((\\(\\d{3}\\))|(\\-?\\d{3}\\-)|(\\d{3}))((\\d{3}\\-\\d{4})|(\\d{3}\\-\\d\\d\\\r\n-\\d\\d)|(\\d{7})|(\\d{3}\\-\\d\\-\\d{3}))";


                case "email":
                    return "^([a-z0-9_-]+\\.)*[a-z0-9_-]+@[a-z0-9_-]+(\\.[a-z0-9_-]+)*\\.[a-z]{2,6}$";

                case "select":
                    break;

                case "radio":
                    break;

                case "checkbox":
                    break;

            }

            return null;


        }
    }
}