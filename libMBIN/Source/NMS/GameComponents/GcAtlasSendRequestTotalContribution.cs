﻿using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents {

	[NMS(Size = 0x8, GUID = 0xDC9B438A409E6F01, Alignment = 0x8)]
    public class GcAtlasSendRequestTotalContribution : NMSTemplate {
        /* 0x0000 */ public long ClientUserData;
    }

}
