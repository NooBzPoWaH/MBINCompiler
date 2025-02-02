﻿using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x120, Alignment = 0x8, GUID = 0xA214A4B55D725F57, SubGUID = 0x677779252EE27773)]
    public class GcMissionSequenceWaitForConditions : NMSTemplate
    {
        [NMS(Size = 0x80)]
        /* 0x000 */ public string Message;
        /* 0x080 */ public GcMissionConditionTest ConditionTest;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x084 */ public byte[] Padding84;
        /* 0x088 */ public List<NMSTemplate> Conditions;
        [NMS(Size = 0x80)]
        /* 0x098 */ public string DebugText;
        /* 0x118 */ public GcStatusMessageMissionMarkup StatusMessageMissionMarkup;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x11C */ public byte[] EndPadding;
    }
}
