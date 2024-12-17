namespace Fetch.Models
{
    public class UserSession
    {
        public User User { get; set; }
        public long Time { get; set; }

        public UserSession(User currentUser, DateTime time)
        {
            User = currentUser;
            Time = time.ToBinary();
        }

        // Returns true is the users are the same and the datetime is within the given threshold in seconds
        public bool Compare(UserSession other, long threshold)
        {
            if (!User.Equals(other.User))
            {
                return false;
            }

            if( (DateTime.FromBinary(Time) - DateTime.FromBinary(other.Time)) > TimeSpan.FromSeconds(threshold))
            {
                return true;
            }

            return false;
        }
    }
}
