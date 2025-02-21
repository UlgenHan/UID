using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UID.Core.CSS.Constants;

namespace UID.Core.CSS.CSSElements.Layout
{
    public class MarginLeftElement : CSSElement
    {
        public MarginLeftElement(string value) : base(CSSProperties.MarginLeft, value) { }
    }
}
