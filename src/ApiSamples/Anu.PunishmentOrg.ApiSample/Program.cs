﻿

using Anu.PunishmentOrg.ApiSample.PBillStore;
using Anu.PunishmentOrg.ApiSample.PDiscoveryMinutes;
using Anu.PunishmentOrg.ApiSample.PInspectionReport;

namespace Anu.PunishmentOrg.ApiSample;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        //var _SendPDiscoveryMinutesStateSample = new SendPDiscoveryMinutesStateSample();
        //_SendPDiscoveryMinutesStateSample.Send();

        //var receivePBillStoreFromScmsSample = new ReceivePBillStoreFromScmsSample();
        //receivePBillStoreFromScmsSample.Send();

        //var _SendPInspectionReportState = new SendPInspectionReportStateSample();
        //_SendPInspectionReportState.Send();
        var recieveGravamenSample = new RecieveGravamenSample();
        recieveGravamenSample.Send();

    }
}


