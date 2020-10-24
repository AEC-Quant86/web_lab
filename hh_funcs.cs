using System;
using System.Net.Http;
using System.Net;
using System.IO;
using System.Text;
using Newtonsoft.Json;
using System.Linq;

namespace hh_parser
{
    public class hh_func
    {
        public static string getDataFrom(string url)
        {
            HttpWebRequest request =
            (HttpWebRequest)WebRequest.Create(url);

            request.Method = "GET";
            request.Accept = "application/json";
            request.UserAgent = "Mozilla/5.0 ....";

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream());
            StringBuilder output = new StringBuilder();
            output.Append(reader.ReadToEnd());
            response.Close();
            return output.ToString();
        }

        public static int calcMediumSalary(Item itmem)
        {
            if (itmem.salary != null)
            {
                if (itmem.salary.from != null && itmem.salary.to != null)
                {
                    return (int)(itmem.salary.from + itmem.salary.to) / 2;
                }
                else
                {
                    if (itmem.salary.from == null)
                        return (int)itmem.salary.to;
                    else
                        return (int)itmem.salary.from;
                }
            }
            return -1; //error
        }

        public static int calcCurencySalary(Item itmem, hh_dictionary dictionary, int salary)
        {
            if (itmem.salary != null)
            {
                if (itmem.salary.currency != "RUR")
                {
                    var curency = dictionary.currency.First(x => x.code == itmem.salary.currency);
                    return (int)(salary / curency.rate);
                }
                else
                    return salary;
            }
            return -1; //error
        }
    }
}