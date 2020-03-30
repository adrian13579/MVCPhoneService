namespace Data.Models
{
    public class MobilePhoneEmployee
    {
        public long IMEI { get; set; }
        public  MobilePhone MobilePhone { get; set; }
        
        public  int EmployeeId { get; set; }
        public Employee Employee { get; set; }
    }
}