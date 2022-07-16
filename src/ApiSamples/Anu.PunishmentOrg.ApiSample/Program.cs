

using Anu.PunishmentOrg.ApiSample.PBillStore;
using Anu.PunishmentOrg.ApiSample.PDiscoveryMinutes;

namespace Anu.PunishmentOrg.ApiSample;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        //var _SendPDiscoveryMinutesStateSample = new SendPDiscoveryMinutesStateSample();
        //_SendPDiscoveryMinutesStateSample.Send();

        var receivePBillStoreFromScmsSample = new ReceivePBillStoreFromScmsSample();
        receivePBillStoreFromScmsSample.Send();

    }
}


