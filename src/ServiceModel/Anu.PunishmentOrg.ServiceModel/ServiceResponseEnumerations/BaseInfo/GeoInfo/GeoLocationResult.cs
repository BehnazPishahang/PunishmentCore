﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anu.PunishmentOrg.ServiceModel.ServiceResponseEnumerations.BaseInfo.GeoInfo;

public enum GeoLocationResult
{
    //زمانی که بدنه درخواست خالی باشد
    GeoLocation_Request_IsNull = -30231,
    //زمانی که بدنه درخواست فیلدهای لازم را نداشته باشد و معتبر نباشد
    GeoLocation_Request_NotValid = -30232
}
