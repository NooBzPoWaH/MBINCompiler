﻿using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xEE43876427F39D95, SubGUID = 0x7A13912B545C6365)]
    public class GcInventoryGenerationBaseStatData : NMSTemplate     // size: 0x40
    {
        [NMS(Size = 0x4, EnumValue = new[] { "C", "B", "A", "S" })]
        public GcInventoryGenerationBaseStatClassData[] BaseStatsPerClass;

    }
}
