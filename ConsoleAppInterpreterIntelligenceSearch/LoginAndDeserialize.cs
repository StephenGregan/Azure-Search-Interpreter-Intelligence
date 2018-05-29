using ConsoleAppInterpreterIntelligence;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInterpreterIntelligenceSearch
{
    class LoginAndDeserialize
    {
        private static string LoginAndDeserializeJson()
        {

            using (var client = new WebClientEx())
            {
                var values = new NameValueCollection
            {
                { "j_username", "stephenG@translation.ie" },
                { "j_password", "3m3Fogz3" },
            };
                Console.WriteLine("Validating username and password....\n");

                // Authenticate
                client.UploadValues("https://tie.interpreterintelligence.com/j_spring_security_check", values);
                Console.WriteLine("Successfully logged in to ii.....");
                Console.WriteLine();
                // Download desired page
                var json = client.DownloadString("https://tie.interpreterintelligence.com:443/api/customer/1347");

                //Not Working...
                //var token = JToken.Parse(json);

                //if (token.Type == JTokenType.Object)
                //    token = new JArray(token);

                //var a = token.ToObject<DataTable>();

                var deserializedWelcomeClass = JsonConvert.DeserializeObject<Welcome>(json);
                //var deserializedAddressClass = JsonConvert.DeserializeObject<Address>(json);
                //var deserializedStatusClass = JsonConvert.DeserializeObject<Status>(json);
                //var deserializedEligibilityClass = JsonConvert.DeserializeObject<Eligibility>(json);
                //var deserializedEmailClass = JsonConvert.DeserializeObject<Email>(json);
                //var deserailizedLanguageMappingClass = JsonConvert.DeserializeObject<LanguageMapping>(json);
                //var deserializedLanguageClass = JsonConvert.DeserializeObject<Language>(json);
                //var DeserializedNumberClass = JsonConvert.DeserializeObject<Number>(json);

                //Console.WriteLine("Deserialized Json : " + json);
                //Console.WriteLine("Id : " + results.Id);
                //Console.WriteLine("Last modified by : " + results.LastModifiedBy);
                //Console.WriteLine("Name : " + results.Name);
                //Console.WriteLine("Number : " + results.Number);
                //Console.WriteLine("Uuid : " + results.Uuid);
                //Console.WriteLine("VersionValue : " + results.VersionValue);
                //Console.WriteLine("Address : " + results.Address);
                //Console.WriteLine("Company Id : " + results.CompanyId);
                //Console.WriteLine("Created By : " + results.CreatedBy);
                //Console.WriteLine();

                Welcome welcome = new Welcome();
                JsonConvert.PopulateObject(json, welcome);
                Console.WriteLine("This is the welcome populated object : " + welcome);

                //Address address = new Address();
                //JsonConvert.PopulateObject(json, address);
                //Console.WriteLine("This is the address populated object : " + address);

                //Status status = new Status();
                //JsonConvert.PopulateObject(json, status);
                //Console.WriteLine("This is the staus populated object : " + status);

                //Eligibility eligibility = new Eligibility();
                //JsonConvert.PopulateObject(json, eligibility);
                //Console.WriteLine("This is the eligibility populated object : " + eligibility);

                //Email email = new Email();
                //JsonConvert.PopulateObject(json, email);
                //Console.WriteLine("Thisn is the email populated object : " + email);

                //LanguageMapping languageMapping = new LanguageMapping();
                //JsonConvert.PopulateObject(json, languageMapping);
                //Console.WriteLine("This is the Language mapping populated object : " + languageMapping);

                //Language language = new Language();
                //JsonConvert.PopulateObject(json, language);
                //Console.WriteLine("This is the language populated object : " + language);

                //Number number = new Number();
                //JsonConvert.PopulateObject(json, number);
                //Console.WriteLine("This is the number populated object : " + number);



                return json;
            }

        }

    }
}
