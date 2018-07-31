namespace FontAwesomeHtmlHelper
{
    public sealed class Icon : FontAwesomeBase
    {
        public static readonly Icon AddressBook = new Icon("address-book");
        public static readonly Icon AddressBookO = new Icon("address-book-o");

        private Icon(string value) : base(value)
        {
        }
    }
}
