using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;

namespace Fetch.Models
{
    public class UserData
    {
        public enum AccountType
        {
            User,
            Shelter
        }


        public int Id { get; set; }

        public AccountType? Role { get; set; }
        public Image? AccountPicture { get; set; }
    }
}
