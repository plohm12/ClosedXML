using System.Linq;

namespace ClosedXML.Excel
{
    internal class XLTheme : IXLTheme
    {
        public XLColor Background1 { get; set; }
        public XLColor Text1 { get; set; }
        public XLColor Background2 { get; set; }
        public XLColor Text2 { get; set; }
        public XLColor Accent1 { get; set; }
        public XLColor Accent2 { get; set; }
        public XLColor Accent3 { get; set; }
        public XLColor Accent4 { get; set; }
        public XLColor Accent5 { get; set; }
        public XLColor Accent6 { get; set; }
        public XLColor Hyperlink { get; set; }
        public XLColor FollowedHyperlink { get; set; }

        public XLColor ResolveThemeColor(XLThemeColor themeColor)
        {
            
            var tc = themeColor.ToString();
            var type = GetType();
            var members = type.GetMembers();
            if (members.Any(m => m.Name.Equals(tc)))
                return type.GetProperty(tc).GetValue(this) as XLColor;
            else
                return null;
        }
    }
}
