namespace InventoryAPI
{
    public class Users
    {
        public int UserId { get; set; }
        public string UserNames { get; set; }
        public string UserLastName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public long UserPhone { get; set; }
        public bool UserStatus { get; set; }
    }
}
