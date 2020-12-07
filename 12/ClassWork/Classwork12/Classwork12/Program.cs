using System;

namespace Classwork12
{
    public class BaseDocument
    {
        public string DocName
        {
            get;
            set;
        }

        public string DocNumber
        {
            get; set;
        }

        public DateTimeOffset IssueDate
        {
            get; set;
        }

        virtual public string PropertiesString
        {
            get
            {
                return $"Docname:{DocName}\n" + $"DocNumber:{DocNumber}\n" + $"IssueDate:{IssueDate}";
            }
        }

        virtual public void WriteToConsole()
        {
            Console.WriteLine(PropertiesString);
        }
        
        public BaseDocument(string docName, string docNumber, DateTimeOffset issueDate)
        {
            DocName = docName;
            DocNumber = docNumber;
            IssueDate = issueDate;
        }
        
    }

    public class Passport : BaseDocument
    {
        public string Country { get; set; }
        public string PersonName { get; set; }

        override public string PropertiesString
        {
            get
            {
                return $"Docname:{DocName} \n" + $"DocNumber:{DocNumber}\n" + $"IssueDate:{IssueDate}\n" + $"Country:{Country}\n" +
                    $"" + $"PersonName:{PersonName}";
            }
        }

        override public void WriteToConsole()
        {
            Console.WriteLine(PropertiesString);
        }
        public Passport (string docName, string docNumber, DateTimeOffset issueDate):base("Passport", docNumber, issueDate)
        {
 
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            BaseDocument Visum = new BaseDocument("1", "2", DateTimeOffset.Parse("22/07/2018"));
            /*
            {
                DocName = "1",
                DocNumber = "2",
                IssueDate = DateTimeOffset.Parse("
            22/07/2018")
            };
            */
            var Pass1 = new Passport("5", "6", DateTimeOffset.Parse("22/10/2018"));
            /*
            {
                Pass1.DocName = "5",
                Pass1.DocNumber = "6",
                Pass1.IssueDate = DateTimeOffset.Parse("22/10/2018"),
                Pass1.Country = "Russia",
                Pass1.PersonName = "Oleg"
            };
            */


            Visum.WriteToConsole();
            Pass1.WriteToConsole();


        }
    }

}
