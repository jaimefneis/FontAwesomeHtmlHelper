namespace FontAwesomeHtmlHelper
{
    public class FontAwesomeBase
    {
        public static readonly FontAwesomeBase FixedWidth = new FontAwesomeBase("fw");
        public static readonly FontAwesomeBase Bordered = new FontAwesomeBase("border");

        protected FontAwesomeBase(string value)
        {
            Value = value;
        }

        public string Value { get; protected set; }

        public override string ToString()
        {
            return $"fa-{Value}";
        }
    }
}
