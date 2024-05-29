using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCare_Plus
{
    internal class Medical_History
    {
        public string MedicalHistory_Id { get; set; }

        public string PateintName { get; set; }

        public DateTime Date { get;set; }

        public string Condition { get; set; }

        public string DiaggnosisDetails { get; set; }

        //create constructor

        public Medical_History(string MedicalHistory_Id, string PateintName, DateTime Date, string Condition, string DiaggnosisDetails) 
        {
            this.MedicalHistory_Id = MedicalHistory_Id;
            this.PateintName = PateintName;
            this.Date = Date;
            this.Condition = Condition;
            this.DiaggnosisDetails = DiaggnosisDetails;
        }

        public Medical_History()
        {
        }
    }
}
