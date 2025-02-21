﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UID.Core.CSS.Constants;

namespace UID.Core.CSS.CSSElements.Layout
{
    public class BorderWidthElement : CSSElement
    {
        public BorderWidthElement(string value) : base(CSSProperties.BorderWidth, value) { }
    }
}
