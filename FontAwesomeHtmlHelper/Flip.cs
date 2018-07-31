namespace FontAwesomeHtmlHelper
{
    public sealed class Flip : FontAwesomeBase
    {
        public static readonly Flip Horizontal = new Flip("flip-horizontal");
        public static readonly Flip Vertical = new Flip("flip-vertical");

        private Flip(string value) : base(value)
        {
        }
    }
}
