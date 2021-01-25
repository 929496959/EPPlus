/*************************************************************************************************
  Required Notice: Copyright (C) EPPlus Software AB. 
  This software is licensed under PolyForm Noncommercial License 1.0.0 
  and may only be used for noncommercial purposes 
  https://polyformproject.org/licenses/noncommercial/1.0.0/

  A commercial license to use this software can be purchased at https://epplussoftware.com
 *************************************************************************************************
  Date               Author                       Change
 *************************************************************************************************
  01/27/2020         EPPlus Software AB       Initial release EPPlus 5
 *************************************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace OfficeOpenXml.Style.Dxf
{
    /// <summary>
    /// The border style of a drawing in a differential formatting record
    /// </summary>
    public class ExcelDxfBorderBase : DxfStyleBase
    {
        internal ExcelDxfBorderBase(ExcelStyles styles)
            : base(styles)
        {
            Left=new ExcelDxfBorderItem(_styles);
            Right = new ExcelDxfBorderItem(_styles);
            Top = new ExcelDxfBorderItem(_styles);
            Bottom = new ExcelDxfBorderItem(_styles);
            Vertical = new ExcelDxfBorderItem(_styles);
            Horizontal = new ExcelDxfBorderItem(_styles);
        }
        /// <summary>
        /// Left border style
        /// </summary>
        public ExcelDxfBorderItem Left
        {
            get;
            internal set;
        }
        /// <summary>
        /// Right border style
        /// </summary>
        public ExcelDxfBorderItem Right
        {
            get;
            internal set;
        }
        /// <summary>
        /// Top border style
        /// </summary>
        public ExcelDxfBorderItem Top
        {
            get;
            internal set;
        }
        /// <summary>
        /// Bottom border style
        /// </summary>
        public ExcelDxfBorderItem Bottom
        {
            get;
            internal set;
        }
        /// <summary>
        /// Horizontal border style
        /// </summary>
        public ExcelDxfBorderItem Horizontal
        {
            get;
            internal set;
        }
        /// <summary>
        /// Vertical border style
        /// </summary>
        public ExcelDxfBorderItem Vertical
        {
            get;
            internal set;
        }

        /// <summary>
        /// The Id
        /// </summary>
        protected internal override string Id
        {
            get
            {
                return Top.Id + Bottom.Id + Left.Id + Right.Id + Vertical.Id + Horizontal.Id;
            }
        }

        /// <summary>
        /// Creates the the xml node
        /// </summary>
        /// <param name="helper">The xml helper</param>
        /// <param name="path">The X Path</param>
        protected internal override void CreateNodes(XmlHelper helper, string path)
        {
            Left.CreateNodes(helper, path + "/d:left");
            Right.CreateNodes(helper, path + "/d:right");
            Top.CreateNodes(helper, path + "/d:top");
            Bottom.CreateNodes(helper, path + "/d:bottom");
            Vertical.CreateNodes(helper, path + "/d:vertical");
            Horizontal.CreateNodes(helper, path + "/d:horizontal");
        }
        /// <summary>
        /// If the object has a value
        /// </summary>
        public override bool HasValue
        {
            get 
            {
                return Left.HasValue ||
                    Right.HasValue ||
                    Top.HasValue ||
                    Bottom.HasValue||
                    Vertical.HasValue ||
                    Horizontal.HasValue;
            }
        }
        public override void Clear()
        {
            Left.Clear();
            Right.Clear();
            Top.Clear();
            Bottom.Clear();
            Vertical.Clear();
            Horizontal.Clear();
        }
        /// <summary>
        /// Clone the object
        /// </summary>
        /// <returns>A new instance of the object</returns>
        protected internal override DxfStyleBase Clone()
        {
            return new ExcelDxfBorderBase(_styles) 
            { 
                Bottom = (ExcelDxfBorderItem)Bottom.Clone(), 
                Top= (ExcelDxfBorderItem)Top.Clone(), 
                Left= (ExcelDxfBorderItem)Left.Clone(), 
                Right= (ExcelDxfBorderItem)Right.Clone(),
                Vertical = (ExcelDxfBorderItem)Vertical.Clone(),
                Horizontal = (ExcelDxfBorderItem)Horizontal.Clone(),
            };
        }
    }
}
