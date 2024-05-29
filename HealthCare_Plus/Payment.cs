using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCare_Plus
{
    internal class Payment
    {
        public string PaymentID { get; set; }

        public string PatientName { get; set; }

        public DateTime PaymentDate { get; set; }

        public string PaymnetMethod { get; set; }

        public string PaymentInvoiceNo { get; set; }

        public string Status { get; set; }

        public string MedicineCharge { get; set; }

        public string RoomCharge { get; set; }

        public string AppointmentCharge { get; set; }

        public string PaymentAmount { get; set; }

        public Payment(string PaymentID, string PatientName, DateTime PaymentDate, string PaymnetMethod, string PaymentInvoiceNo,
           string Status, string MedicineCharge, string RoomCharge, string AppointmentCharge, string PaymentAmount)
        {
            this.PaymentID = PaymentID;
            this.PatientName = PatientName;
            this.PaymentDate = PaymentDate;
            this.PaymnetMethod = PaymnetMethod;
            this.PaymentInvoiceNo = PaymentInvoiceNo;
            this.Status = Status;
            this.MedicineCharge = MedicineCharge;
            this.RoomCharge = RoomCharge;
            this.AppointmentCharge = AppointmentCharge;
            this.PaymentAmount = PaymentAmount;
        }

        public Payment()
        {
        }
    }
}
