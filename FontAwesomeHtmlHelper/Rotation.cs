namespace FontAwesomeHtmlHelper
{
    public sealed class Rotation : FontAwesomeBase
    {
        public static readonly Rotation Rotate90 = new Rotation("rotate-90");
        public static readonly Rotation Rotate180 = new Rotation("rotate-180");
        public static readonly Rotation Rotate270 = new Rotation("rotate-270");

        private Rotation(string value) : base(value)
        {
        }
    }
}
