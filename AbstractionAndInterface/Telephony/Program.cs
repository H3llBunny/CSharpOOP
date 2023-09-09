namespace Telephony
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Smartphone smartPhone = new Smartphone();
            var phoneBook = new List<string>(Console.ReadLine().Split());
            var webSites = new List<string>(Console.ReadLine().Split());

            foreach (var phoneNumber in phoneBook)
            {
                smartPhone.PhoneNumber(phoneNumber);
            }

            foreach (var webSite in webSites)
            {
                smartPhone.WebSite(webSite);
            }
        }
    }
}