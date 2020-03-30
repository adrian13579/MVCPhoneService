using System.Collections.Generic;

namespace Data.Models
{
    public class DataPlan
    {
        public int DataPlanId { get; set; }
        public float NationalData { get; set; }
        public float InternationalData { get; set; }
        public List<MobilePhoneDataPlanAssignment> MobilePhoneDataPlanAssignments { get; set; }
    }
}