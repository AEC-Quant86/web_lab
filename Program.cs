using System;
using System.Threading.Tasks;
using System.Collections.Generic;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;
using System.Reflection;

using System.IO;
using System.Text;

namespace hh_parser
{
    class Program
    {
        static void Main(string[] args)
        {


            for (int i = 0; i < 20; i++)
            {
                string myJsonResponse = hh_func.getDataFrom("https://api.hh.ru/vacancies?per_page=100&page=" + i);
                ResponseData tmp = JsonConvert.DeserializeObject<ResponseData>(myJsonResponse);
                string myJsonResponseDict = hh_func.getDataFrom("https://api.hh.ru/dictionaries"); ;
                hh_dictionary dictionary = JsonConvert.DeserializeObject<hh_dictionary>(myJsonResponseDict);

                foreach (Item itm in tmp.items)
                {
                    int salary = hh_func.calcMediumSalary(itm);
                    salary = hh_func.calcCurencySalary(itm, dictionary, salary);

                    if (salary < 0)
                        continue;

                    if (salary >= 120000 || salary <= 15000)
                    {
                        Console.WriteLine(itm.name + " ЗП = " + salary);
                        string myJsonResponseSkill = hh_func.getDataFrom("https://api.hh.ru/vacancies/" + itm.id);
                        VacData vac = JsonConvert.DeserializeObject<VacData>(myJsonResponseSkill);
                        if (vac.key_skills.Length > 0)
                        {
                            foreach (Key_skills key in vac.key_skills)
                            {
                                Console.WriteLine("####" + key.name);
                            }
                        }
                        else
                        {
                            Console.WriteLine("-----Навыки не указаны");
                        }
                    }


                }
            }
        }
    }
}
