using System.Collections.Generic;
using System.Linq;

namespace FontAwesomeHtmlHelper
{
    public class Tag
    {
        private string _tag;
        private char _quote = '"';
        private bool _ariaHidden = true;
        private Icon _icon;
        private Size _size;
        private Animation _animation;
        private Rotation _rotation;
        private Flip _flip;


        private bool _fixedWidth;
        private bool _bordered;

        public Tag(string tag, Icon icon)
        {
            _tag = tag;
            _icon = icon;
        }

        public Tag Quote(char quote)
        {
            _quote = quote;
            return this;
        }

        public Tag AriaHidden(bool ariaHidden)
        {
            _ariaHidden = ariaHidden;
            return this;
        }

        public Tag FixedWidth(bool fixedWidth)
        {
            _fixedWidth = fixedWidth;
            return this;
        }

        public Tag Bordered(bool bordered)
        {
            _bordered = bordered;
            return this;
        }

        public Tag Size(Size size)
        {
            _size = size;
            return this;
        }

        public Tag Animation(Animation animation)
        {
            _animation = animation;
            return this;
        }

        public Tag Rotation(Rotation rotation)
        {
            _rotation = rotation;
            return this;
        }

        public Tag Flip(Flip flip)
        {
            _flip = flip;
            return this;
        }

        public override string ToString()
        {
            var properties = new List<string>();

            properties.Add(GetClass());
            properties.Add(GetAriaHidden());

            properties = properties
                .Where(w => !string.IsNullOrEmpty(w))
                .ToList();

            return $"<{_tag} {string.Join(" ", properties)}></{_tag}>";
        }

        private string GetClass()
        {
            var classes = new List<FontAwesomeBase>();

            if (_icon != null) classes.Add(_icon);
            if (_size != null) classes.Add(_size);
            if (_animation != null) classes.Add(_animation);
            if (_rotation != null) classes.Add(_rotation);
            if (_flip != null) classes.Add(_flip);
            if (_fixedWidth) classes.Add(FontAwesomeBase.FixedWidth);
            if (_bordered) classes.Add(FontAwesomeBase.Bordered);

            if (classes.Count > 0) return $"class={_quote}fa {string.Join(" ", classes)}{_quote}";

            return string.Empty;
        }

        private string GetAriaHidden()
        {
            if (_ariaHidden) return $"aria-hidden={_quote}true{_quote}";

            return string.Empty;
        }
    }
}
