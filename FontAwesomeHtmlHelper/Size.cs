namespace FontAwesomeHtmlHelper
{
    public sealed class Size : FontAwesomeBase
    {
        public static readonly Size Lg = new Size("lg");
        public static readonly Size x2 = new Size("2x");
        public static readonly Size x3 = new Size("3x");
        public static readonly Size x4 = new Size("4x");
        public static readonly Size x5 = new Size("5x");

        private Size(string value) : base(value)
        {
        }
    }
}
