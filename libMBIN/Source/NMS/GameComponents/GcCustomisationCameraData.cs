﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x34, GUID = 0xC758EE0D67375E80, SubGUID = 0x50A80E365BD08E24)]
    public class GcCustomisationCameraData : NMSTemplate
    {
        public int InteractionCameraIndex;
        [NMS(Size = 0x20)]
        public string InteractionCameraFocusJoint;
        public float MinPitch;
        public float MaxPitch;
        public float MinYaw;
        public float MaxYaw;
    }
}
