using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCare_Plus
{
    internal class LabResult
    {
        public string LabResult_Id { get;set;}

        public string PatientName { get; set; }

        public string TestType { get;set;}

        public DateTime Date {get;set;}

        public string LabResult_Details { get;set;}

        //create Constructor

        public LabResult(string LabResult_Id, string PatientName, string TestType, DateTime Date, string LabResult_Details)
        {
            this.LabResult_Id = LabResult_Id;
            this.PatientName = PatientName;
            this.TestType = TestType;
            this.Date = Date;
            this.LabResult_Details = LabResult_Details;
        }

        public LabResult()
        {
        }
    }
}
