﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0xF8, GUID = 0x11E0D5838A369621, SubGUID = 0xA29EE4D703004484)]
    public class GcMissionSequenceDetailMessage : NMSTemplate
    {
        [NMS(Size = 0x20)]
        public string Title;
        [NMS(Size = 0x20)]
        public string Description;
        [NMS(Size = 0x20)]
        public string Image;
        public GcAudioWwiseEvents AudioEvent;
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] Padding64;
        public List<GcMissionSequenceDetailMessagePoint> Points;
        [NMS(Size = 0x80)]
        public string DebugText;
    }
}
