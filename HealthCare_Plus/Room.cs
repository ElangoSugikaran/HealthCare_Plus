using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCare_Plus
{
    internal class Room
    {
        public string RoomID { get; set; }

        public string RoomType { get; set; }

        public string PatientName { get; set; }

        public string BuildingFloorNo { get; set; }

        public string AwardNo { get; set; }

        public string BedNo { get; set; }

        public string Status { get; set; }

        public string PatientCheckIn { get; set; }

        public string RoomCharge { get; set; }

        public string PatientCheckOut { get; set; }

        // craete constructor

        public Room(string RoomID, string RoomType, string PatientName, string BuildingFloorNo, string AwardNo,
           string BedNo, string Status, string PatientCheckIn, string RoomCharge, string PatientCheckOut)
        {
            this.RoomID = RoomID;
            this.RoomType = RoomType;
            this.PatientName = PatientName;
            this.BuildingFloorNo = BuildingFloorNo;
            this.AwardNo = AwardNo;
            this.BedNo = BedNo;
            this.Status = Status;
            this.PatientCheckIn = PatientCheckIn;
            this.RoomCharge = RoomCharge;
            this.PatientCheckOut = PatientCheckOut;
        }

        public Room()
        {
        }
    }
}
