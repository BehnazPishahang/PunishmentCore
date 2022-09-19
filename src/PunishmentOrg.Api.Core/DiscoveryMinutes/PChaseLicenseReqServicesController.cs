
using Anu.BaseInfo.DataAccess.FrontEndSecurity;
using Anu.BaseInfo.DataAccess.GeoInfo;
using Anu.BaseInfo.DataAccess.SystemObject;
using Anu.BaseInfo.DataModel.FrontEndSecurity;
using Anu.Commons.ServiceModel.ServiceResponseEnumerations;
using Anu.Constants.ServiceModel.PunishmentOrg;
using Anu.PunishmentOrg.Api.Authentication;
using Anu.PunishmentOrg.DataAccess.DiscoveryMinutes;
using Anu.PunishmentOrg.DataModel.DiscoveryMinutes;
using Anu.PunishmentOrg.ServiceModel.DiscoveryMinutes;
using Anu.PunishmentOrg.ServiceModel.ServiceResponseEnumerations;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Utility;
using Utility.Guard;
using Utility.CalendarHelper;
using Anu.PunishmentOrg.DataAccess.BaseInfo;
using Utility.Exceptions;
using Anu.BaseInfo.Domain.GeoInfo;
using Anu.BaseInfo.Domain.SystemObject;
using Anu.PunishmentOrg.Domain.BaseInfo;
using Anu.PunishmentOrg.Domain.DiscoveryMinutes;

namespace Anu.PunishmentOrg.Api.DiscoveryMinutes
{
    public class PChaseLicenseReqServicesController : PChaseLicenseReqServicesControllerBase
    {
        protected readonly Anu.DataAccess.IUnitOfWork _unitOfWork;

        #region Constructor
        public PChaseLicenseReqServicesController(Anu.DataAccess.IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        #endregion Constructor

        #region Properties
        #endregion Properties

        #region Overrides
        bool HasChaseLicensePlace;
        string UniqueNo = "-1";
        //[PermissionAttribute(PunishmentOrgConstants.GFESUserAccessType.SendPChaseLicenseReqList)]
        [AllowAnonymous]
        public override async Task<PChaseLicenseReqResponse> SendPChaseLicenseReqList([FromBody] PChaseLicenseReqRequest request)
        {
            var response = new PChaseLicenseReqResponse();
            try
            {
                response.ThePChaseLicenseReqContract = new PChaseLicenseReqContract()
                {
                    UniqueNo = UniqueNo
                };

                #region Validation

                request.ThePChaseLicenseReqContract.Null(PChaseLicenseReqResult.PChaseLicenseReq_IsNull);
                request.ThePChaseLicenseReqContract?.ChaseTitle.NullOrWhiteSpace(PChaseLicenseReqResult.PChaseLicenseReq_ChaseTitle_IsNull);
                request.ThePChaseLicenseReqContract?.ChaseLicenseRequestText.NullOrWhiteSpace(PChaseLicenseReqResult.PChaseLicenseReq_ChaseLicenseRequestText_IsNull);
                request.ThePChaseLicenseReqContract?.ThePChaseLicenseReqSuspectContractList.Null(PChaseLicenseReqResult.PChaseLicenseReq_PChaseLicenseReqSuspectList_IsNull);
                request.ThePChaseLicenseReqContract?.ThePChaseLicenseReqPlacesContractList.Null(PChaseLicenseReqResult.PChaseLicenseReq_PChaseLicenseReqPlacesList_IsNull);
                request.ThePChaseLicenseReqContract?.TheGeoLocation.Null(PChaseLicenseReqResult.PChaseLicenseReq_TheJudicialUnit_IsNull);
                request.ThePChaseLicenseReqContract?.TheGeoLocation?.LocationCode.NullOrWhiteSpace(PChaseLicenseReqResult.PChaseLicenseReq_TheJudicialUnit_Code_IsNull);

                if (request.ThePChaseLicenseReqContract?.InstitutionExporter == Enumerations.DiscoveryMinutesCompetenceReference.None)
                {
                    return Respond(PChaseLicenseReqResult.PChaseLicenseReq_PChaseLicenseReqPlacesList_IsNull);
                }

                foreach(var onePChaseLicenseReqSuspectContract in request.ThePChaseLicenseReqContract.ThePChaseLicenseReqSuspectContractList)
                {
                    onePChaseLicenseReqSuspectContract.Name.NullOrWhiteSpace(PChaseLicenseReqResult.PChaseLicenseReq_PChaseLicenseReqSuspectList_Name_IsNull);
                }

                #endregion Validation

                SavePChaseLicenseReq(request);
                _unitOfWork.Complete();
               
                return Respond(AnuResult.Successful,UniqueNo);
            }
            catch (AnuExceptions ex)
            {
                response.Result = ex.result;
                return response;
            }
            catch (Exception ex)
            {
                response.Result = AnuResult.Error.GetResult(ex);
                return response;
            }
        }

        #endregion Overrides

        #region Methods
        private PChaseLicenseReqResponse Respond(AnuResult result ,string UniqueNo)
        {
            var response = new PChaseLicenseReqResponse()
            {
                Result                      = result.GetResult(),
                ThePChaseLicenseReqContract = new PChaseLicenseReqContract() { UniqueNo = UniqueNo }
            };
            return response;
        }
        private PChaseLicenseReqResponse Respond(PChaseLicenseReqResult result)
        {
            var response = new PChaseLicenseReqResponse()
            {
                Result = result.GetResult()
            };
            return response;
        }

        #region Save Methods
        private async void SavePChaseLicenseReq(PChaseLicenseReqRequest request)
        {
            PChaseLicenseReq onePChaseLicenseReq = new()
            {
                Id                             = Guid.NewGuid().ToString("N"),
                Timestamp                      = 1,
                ChaseLicenseRequestText        = request.ThePChaseLicenseReqContract?.ChaseLicenseRequestText,
                ChaseResult                    = request.ThePChaseLicenseReqContract?.ChaseResult,
                ChaseTitle                     = request.ThePChaseLicenseReqContract?.ChaseTitle,
                ConclusionRequest              = request.ThePChaseLicenseReqContract?.ConclusionRequest,
                CreateDateTime                 = CalendarHelper.GetCurrentDateTime(),
                TheGeoLocation                 = await _unitOfWork.Repositorey<IGeoLocationRepository>().GetGeoLocationWithLocationCode(request.ThePChaseLicenseReqContract?.TheGeoLocation?.LocationCode),
                InstitutionCode                = request.ThePChaseLicenseReqContract?.InstitutionCode,
                InstitutionExporter            = request.ThePChaseLicenseReqContract?.InstitutionExporter,
                InstitutionTitle               = request.ThePChaseLicenseReqContract?.InstitutionTitle,
                TheJudicialUnit                = null,
                LetterRequestDateTime          = request.ThePChaseLicenseReqContract?.LetterRequestDateTime,
                LetterRequestNo                = request.ThePChaseLicenseReqContract?.LetterRequestNo,
                LicensorRequestText            = request.ThePChaseLicenseReqContract?.LicensorRequestText,
                TheObjectState                 = await _unitOfWork.Repositorey<IObjectStateRepository>().GetById("000770"),//ToDo n.kord //Use Constant
                ThePBExchangeUnit              = await _unitOfWork.Repositorey<IPBExchangeUnitRepository>().GetById("007001000771"),//ToDo n.kord //Use Constant
                ThePrvReq                      = null,
                ReceiveDateTime                = request.ThePChaseLicenseReqContract?.ReceiveDateTime,
                RepSendDateTime                = request.ThePChaseLicenseReqContract?.RepSendDateTime,
                RepText                        = request.ThePChaseLicenseReqContract?.RepText,
                SendDateTime                   = request.ThePChaseLicenseReqContract?.SendDateTime,
                SubNo                          = 1,
                UniqueNo                       = GetRandomNumber(18),
                TheUnit                        = null,
                ValidityDays                   = request.ThePChaseLicenseReqContract?.ValidityDays,
                WrittenOrOral                  = request.ThePChaseLicenseReqContract?.WrittenOrOral,
                ThePChaseLicenseReqPlacesList  = SavePChaseLicenseReqPlacesList(request.ThePChaseLicenseReqContract),
                ThePChaseLicenseReqSuspectList = SavePChaseLicenseReqSuspectList(request.ThePChaseLicenseReqContract),
                ThePChaseLicenseReqVehicleList = SavePChaseLicenseReqVehicleList(request.ThePChaseLicenseReqContract),
                ThePChaseLicenseReqDocList     = SavaPChaseLicenseReqDocList(request.ThePChaseLicenseReqContract),
                ThePChaseLicenseReqTypeList    = SavePChaseLicenseReqType(request)
            };

            UniqueNo = onePChaseLicenseReq.UniqueNo;

            await _unitOfWork.Repositorey<IPChaseLicenseReqRepository>().Add(onePChaseLicenseReq);
        }

        private List<PChaseLicenseReqType> SavePChaseLicenseReqType(PChaseLicenseReqRequest request)
        {
            var thePChaseLicenseReqType = new List<PChaseLicenseReqType>();

            if (HasChaseLicensePlace)
            {
                PChaseLicenseReqType onePChaseLicenseReqType = new()
                {
                    Id               = Guid.NewGuid().ToString("N"),
                    ChaseLicenseType = Enumerations.PUChaseLicenseType.ChaseLicensePlace
                };

                thePChaseLicenseReqType.Add(onePChaseLicenseReqType);
            }

            return thePChaseLicenseReqType;
        }

        private List<PChaseLicenseReqDoc> SavaPChaseLicenseReqDocList(PChaseLicenseReqContract? thePChaseLicenseReqContract)
        {
            var thePChaseLicenseReqDoc = new List<PChaseLicenseReqDoc>();

            foreach (var onePChaseLicenseReqDocContract in thePChaseLicenseReqContract.ThePChaseLicenseReqDocContractList)
            {
                PChaseLicenseReqDoc onePChaseLicenseReqDoc = new()
                {
                    Id                  = Guid.NewGuid().ToString("N"),
                    Timestamp           = 1,
                    //ConclusionRequest = onePChaseLicenseReqDocContract.ConclusionRequest, //ToDo n.kord
                    RowNumber           = onePChaseLicenseReqDocContract.RowNumber,
                    DocNo               = onePChaseLicenseReqDocContract.DocNo,
                    DocTitle            = onePChaseLicenseReqDocContract.DocTitle,
                    DocDate             = onePChaseLicenseReqDocContract.DocDate,
                    IssuerUnit          = onePChaseLicenseReqDocContract.IssuerUnit,
                    IssueType           = onePChaseLicenseReqDocContract.IssueType,
                    OwnershipType       = onePChaseLicenseReqDocContract.OwnershipType
                };

                thePChaseLicenseReqDoc.Add(onePChaseLicenseReqDoc);
            }

            HasChaseLicensePlace = thePChaseLicenseReqDoc.Count == 0 ? true : false;

            return thePChaseLicenseReqDoc;
        }

        private List<PChaseLicenseReqVehicle> SavePChaseLicenseReqVehicleList(PChaseLicenseReqContract? thePChaseLicenseReqContract)
        { 
            var thePChaseLicenseReqVehicle = new List<PChaseLicenseReqVehicle>();

            foreach (var onePChaseLicenseReqVehicleContract in thePChaseLicenseReqContract.ThePChaseLicenseReqVehicleContractList)
            {
                PChaseLicenseReqVehicle onePChaseLicenseReqVehicle = new()
                {
                    Id               = Guid.NewGuid().ToString("N"),
                    Timestamp        = 1,
                    Color            = onePChaseLicenseReqVehicleContract.Color,
                    DriverFamily     = onePChaseLicenseReqVehicleContract.DriverFamily,
                    DriverName       = onePChaseLicenseReqVehicleContract.DriverName,
                    IranNumber       = onePChaseLicenseReqVehicleContract.IranNumber,
                    Model            = onePChaseLicenseReqVehicleContract.Model,
                    OtherInfo        = onePChaseLicenseReqVehicleContract.OtherInfo,
                    OwnerFamily      = onePChaseLicenseReqVehicleContract.OwnerFamily,
                    OwnerName        = onePChaseLicenseReqVehicleContract.OwnerName,
                    PlaqueNumber     = onePChaseLicenseReqVehicleContract.PlaqueNumber,
                    PlaqueScript     = onePChaseLicenseReqVehicleContract.PlaqueScript,
                    PlaqueThreeDigit = onePChaseLicenseReqVehicleContract.PlaqueThreeDigit,
                    PlaqueTwoDigit   = onePChaseLicenseReqVehicleContract.PlaqueTwoDigit,
                    PlaqueType       = onePChaseLicenseReqVehicleContract.PlaqueType,
                    RowNumber        = onePChaseLicenseReqVehicleContract.RowNumber,
                    VehicleType      = onePChaseLicenseReqVehicleContract.VehicleType
                };

                thePChaseLicenseReqVehicle.Add(onePChaseLicenseReqVehicle);
            }

            HasChaseLicensePlace = thePChaseLicenseReqVehicle.Count == 0 ? true : false;

            return thePChaseLicenseReqVehicle;
        }

        private List<PChaseLicenseReqSuspect> SavePChaseLicenseReqSuspectList(PChaseLicenseReqContract? thePChaseLicenseReqContract)
        {
            var thePChaseLicenseReqSuspect = new List<PChaseLicenseReqSuspect>();

            foreach (var onePChaseLicenseReqSuspectContract in thePChaseLicenseReqContract.ThePChaseLicenseReqSuspectContractList)
            {
                PChaseLicenseReqSuspect onePChaseLicenseReqSuspect = new()
                {
                    Id             = Guid.NewGuid().ToString("N"),
                    Timestamp      = 1,
                    Address        = onePChaseLicenseReqSuspectContract.Address,
                    BirthDate      = onePChaseLicenseReqSuspectContract.BirthDate,
                    Family         = onePChaseLicenseReqSuspectContract.Family,
                    FatherName     = onePChaseLicenseReqSuspectContract.FatherName,
                    IdentityNumber = onePChaseLicenseReqSuspectContract.IdentityNumber,
                    MobilNumber    = onePChaseLicenseReqSuspectContract.MobilNumber,
                    Name           = onePChaseLicenseReqSuspectContract.Name,
                    NationalCode   = onePChaseLicenseReqSuspectContract.NationalCode,
                    Nationality    = onePChaseLicenseReqSuspectContract.Nationality,
                    PassportNo     = onePChaseLicenseReqSuspectContract.PassportNo,
                    PhoneNumber    = onePChaseLicenseReqSuspectContract.PhoneNumber,
                    PostType       = onePChaseLicenseReqSuspectContract.PostType
                };

                thePChaseLicenseReqSuspect.Add(onePChaseLicenseReqSuspect);
            }

            HasChaseLicensePlace = thePChaseLicenseReqSuspect.Count == 0 ? true : false;

            return thePChaseLicenseReqSuspect;
        }

        private List<PChaseLicenseReqPlaces> SavePChaseLicenseReqPlacesList(PChaseLicenseReqContract? thePChaseLicenseReqContract)
        {
            var thePChaseLicenseReqPlaces = new List<PChaseLicenseReqPlaces>();

            foreach (var onePChaseLicenseReqPlacesContract in thePChaseLicenseReqContract.ThePChaseLicenseReqPlacesContractList)
            {
                PChaseLicenseReqPlaces onePChaseLicenseReqPlaces = new()
                {
                    Id            = Guid.NewGuid().ToString("N"),
                    Timestamp     = 1,
                    PlaceAddress  = onePChaseLicenseReqPlacesContract.PlaceAddress,
                    PlacePhoneNum = onePChaseLicenseReqPlacesContract.PlacePhoneNum,
                    PlacePlaque   = onePChaseLicenseReqPlacesContract.PlacePlaque,
                    PlacePostCode = onePChaseLicenseReqPlacesContract.PlacePostCode,
                    PlaceUnitName = onePChaseLicenseReqPlacesContract.PlaceUnitName,
                    RowNumber     = onePChaseLicenseReqPlacesContract.RowNumber,
                };

                thePChaseLicenseReqPlaces.Add(onePChaseLicenseReqPlaces);
            }

            HasChaseLicensePlace = thePChaseLicenseReqPlaces.Count == 0 ? true : false;

            return thePChaseLicenseReqPlaces;
        }

        #endregion Save Methods

        public string GetRandomNumber(int length)
        {
            string AllowChars = "0123456789";
            char[] chars = new char[length];
            Random rd = new Random();
            for (int i = 0; i < length; i++)
            {
                chars[i] = AllowChars[rd.Next(0, AllowChars.Length)];
            }

            return new string(chars);
        }

        #endregion Methods
    }
}