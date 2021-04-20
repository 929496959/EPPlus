﻿/*************************************************************************************************
  Required Notice: Copyright (C) EPPlus Software AB. 
  This software is licensed under PolyForm Noncommercial License 1.0.0 
  and may only be used for noncommercial purposes 
  https://polyformproject.org/licenses/noncommercial/1.0.0/

  A commercial license to use this software can be purchased at https://epplussoftware.com
 *************************************************************************************************
  Date               Author                       Change
 *************************************************************************************************
  04/16/2021         EPPlus Software AB       EPPlus 5.7
 *************************************************************************************************/

namespace OfficeOpenXml.Core.ExternalReferences
{
    public class ExcelExternalDefinedName : IExcelNamedItem
    {
        public string Name { get; internal set; }
        public string RefersTo { get; internal set; }
        public int SheetId { get; internal set; }
        public override string ToString()
        {
            return Name;
        }
    }
}
