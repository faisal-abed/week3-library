
namespace week3_library
{
    public class Member
    {
        private int memberId;
        private string name;
        private string address;
        private string phone;

        public int MemberId
        {
            get { return memberId; }
            private set
            {
                if (value > 0)
                {
                    memberId = value;
                }
                else
                {
                    Console.WriteLine("Error: Member ID must be greater than zero.");
                }
            }
        }
        public string Name
        {
            get { return name; }
            set
            {
                if (!value.Any(char.IsDigit))
                {
                    name = value;
                }
                else
                {
                    Console.WriteLine("Error: Member name cannot contain numbers or be blank.");
                }
            }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        
        public Member(int memberId, string name, string address, string phone)
        {
            this.MemberId = memberId;
            this.Name = name;
            this.Address = address;
            this.Phone = phone;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Member ID: {MemberId}");
            Console.WriteLine($"Member Name: {Name}");
            Console.WriteLine($"Member Address: {Address}");
            Console.WriteLine($"Member Phone: {Phone}");
            Console.WriteLine();
        }
    }
}
