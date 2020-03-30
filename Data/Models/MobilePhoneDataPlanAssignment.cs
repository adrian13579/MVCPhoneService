using System;

namespace Data.Models
{
    public class MobilePhoneDataPlanAssignment
    {
        public int PhoneNumber { get; set; }
        public PhoneLine PhoneLine { get; set; }
        
        public DateTime DataPlanAssignmentDateTime { get; set; }
        
        public int DataPlanId { get; set; }
        public DataPlan DataPlan { get; set; }
        
        public float NationalDataUsage { get; set; }
        public float InternationalDataUsage { get; set; }
    }
}