﻿using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0xF0, Alignment = 0x8, GUID = 0xE0A38ABCE241BEF8, SubGUID = 0x369AF9F4E4E055D0)]
    public class GcBiomeFileList : NMSTemplate
    {
        [NMS(Size = 0xD, EnumValue = new[] { "Lush", "Toxic", "Scorched", "Radioactive", "Frozen", "Barren", "Dead", "Weird", "Red", "Green", "Blue", "Test", "All" })]
        /* 0x00 */ public GcBiomeFileListOptions[] BiomeFiles;

        /* 0xD0 */ public List<GcExternalObjectListOptions> CommonExternalObjectLists;
        /* 0xE0 */ public List<GcExternalObjectFileList> OptionalExternalObjectLists;
    }
}
