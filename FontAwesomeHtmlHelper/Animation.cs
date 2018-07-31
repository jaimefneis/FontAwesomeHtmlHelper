namespace FontAwesomeHtmlHelper
{
    public sealed class Animation : FontAwesomeBase
    {
        public static readonly Animation Pulse = new Animation("pulse");
        public static readonly Animation Spin = new Animation("spin");

        private Animation(string value) : base(value)
        {
        }
    }
}
