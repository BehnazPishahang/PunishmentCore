using Anu.BaseInfo.Enumerations;
using Anu.Commons.ServiceModel.ServiceAuthentication;
using Anu.Commons.ServiceModel.ServiceResponseEnumerations;
using Anu.Utility;
using Utility.Exceptions;
using Utility.Guard;

namespace Anu.PunishmentOrg.Api.Authentication.Utility
{
    public static class SabteahvalAuthentication
    {
        private static IConfiguration _configuration;

        public static void GetConfiguration(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public static async Task SabteahvalAuthenticate(UserRegisterRequest request)
        {
            var SabtAhvalCanUsed = _configuration.GetSection("StatusServices:SabtAhval").Value;
            if (!Convert.ToBoolean(SabtAhvalCanUsed))
            {
                return;
            }

            var result = await CallSabteAhval(request.UserName, request.BirthDate);

            if (!result.name.ConvertToByte().UTF8().NormalizeTextChars().Trim().Equals(request.FirstName.NormalizeTextChars()))
            {
                throw new AnuExceptions(AnuResult.SabteAhval_Data_Not_Match_Entered_Data);
            }
            if (!result.family.ConvertToByte().UTF8().NormalizeTextChars().Trim().Equals(request.LastName.NormalizeTextChars()))
            {
                throw new AnuExceptions(AnuResult.SabteAhval_Data_Not_Match_Entered_Data);
            }
            SexType sexTye = (int.Parse(result.gender.ToString()) == 1) ? SexType.Male : SexType.Female;
            if (sexTye != request.Sex)
            {
                throw new AnuExceptions(AnuResult.SabteAhval_Data_Not_Match_Entered_Data);
            }
        }

        private static async Task<@return> CallSabteAhval(string nationalCode, string birthDateShamsi)
        {
            birthDateShamsi = birthDateShamsi.Replace("/", "");

            string Url = "http://gsbservices.iran.gov.ir/sabteahval/proxy/SabteAhvalPS";

            string input = @"<soapenv:Envelope xmlns:soapenv=" + '\u0022' + "http://schemas.xmlsoap.org/soap/envelope/" + '\u0022' + " xmlns:est=" + '\u0022' + "http://est" + '\u0022' + " ><soapenv:Header/><soapenv:Body><est:getEstelam3><arg0>StAh</arg0><arg1>S*t-(Ah)</arg1><arg2>36668</arg2><arg3>4D4C3FBD313A</arg3><arg4><birthDate>{0}</birthDate><bookNo>0</bookNo><bookRow>0</bookRow><dateHasPostfix>0</dateHasPostfix><family></family><familyHasPerfix></familyHasPerfix><familyHasPostfix></familyHasPostfix><fatherName></fatherName><gender>0</gender><name></name><nameHasPerfix></nameHasPerfix><nameHasPostfix></nameHasPostfix><nin>{1}</nin><officeCode>0</officeCode><officeName></officeName><shenasnameNo></shenasnameNo><shenasnameSeri></shenasnameSeri><shenasnameSerial>0</shenasnameSerial></arg4></est:getEstelam3></soapenv:Body></soapenv:Envelope>";
            input = string.Format(input, birthDateShamsi, nationalCode);

            var Authorization = new Dictionary<string, string>() { { "Username", "tazirat_gsb" }, { "Password", "7@2irAt&96#%" } };

            var Result = (await Url.CallApi(input, AnuResult.SabteAhval_Unkhown_Error, authorization: Authorization, IsJson: false)).XmlDeserialize<Envelope>();

            Result.Body.getEstelam3Response.@return.name.Null(AnuResult.SabteAhval_Not_Validate_NationalCode);

            return Result.Body.getEstelam3Response.@return;
        }
    }
}


// NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.xmlsoap.org/soap/envelope/", IsNullable = false)]
public partial class Envelope
{

    private EnvelopeBody bodyField;

    /// <remarks/>
    public EnvelopeBody Body
    {
        get
        {
            return this.bodyField;
        }
        set
        {
            this.bodyField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
public partial class EnvelopeBody
{

    private getEstelam3Response getEstelam3ResponseField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://est")]
    public getEstelam3Response getEstelam3Response
    {
        get
        {
            return this.getEstelam3ResponseField;
        }
        set
        {
            this.getEstelam3ResponseField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://est")]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://est", IsNullable = false)]
public partial class getEstelam3Response
{

    private @return returnField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "")]
    public @return @return
    {
        get
        {
            return this.returnField;
        }
        set
        {
            this.returnField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
public partial class @return
{

    private uint birthDateField;

    private byte bookNoField;

    private byte bookRowField;

    private byte deathStatusField;

    private string familyField;

    private string fatherNameField;

    private byte genderField;

    private object messageField;

    private string nameField;

    private uint ninField;

    private ushort officeCodeField;

    private string officeNameField;

    private byte shenasnameNoField;

    private string shenasnameSeriField;

    private uint shenasnameSerialField;

    private object deathDateField;

    private object exceptionMessageField;

    /// <remarks/>
    public uint birthDate
    {
        get
        {
            return this.birthDateField;
        }
        set
        {
            this.birthDateField = value;
        }
    }

    /// <remarks/>
    public byte bookNo
    {
        get
        {
            return this.bookNoField;
        }
        set
        {
            this.bookNoField = value;
        }
    }

    /// <remarks/>
    public byte bookRow
    {
        get
        {
            return this.bookRowField;
        }
        set
        {
            this.bookRowField = value;
        }
    }

    /// <remarks/>
    public byte deathStatus
    {
        get
        {
            return this.deathStatusField;
        }
        set
        {
            this.deathStatusField = value;
        }
    }

    /// <remarks/>
    public string family
    {
        get
        {
            return this.familyField;
        }
        set
        {
            this.familyField = value;
        }
    }

    /// <remarks/>
    public string fatherName
    {
        get
        {
            return this.fatherNameField;
        }
        set
        {
            this.fatherNameField = value;
        }
    }

    /// <remarks/>
    public byte gender
    {
        get
        {
            return this.genderField;
        }
        set
        {
            this.genderField = value;
        }
    }

    /// <remarks/>
    public object message
    {
        get
        {
            return this.messageField;
        }
        set
        {
            this.messageField = value;
        }
    }

    /// <remarks/>
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    /// <remarks/>
    public uint nin
    {
        get
        {
            return this.ninField;
        }
        set
        {
            this.ninField = value;
        }
    }

    /// <remarks/>
    public ushort officeCode
    {
        get
        {
            return this.officeCodeField;
        }
        set
        {
            this.officeCodeField = value;
        }
    }

    /// <remarks/>
    public string officeName
    {
        get
        {
            return this.officeNameField;
        }
        set
        {
            this.officeNameField = value;
        }
    }

    /// <remarks/>
    public byte shenasnameNo
    {
        get
        {
            return this.shenasnameNoField;
        }
        set
        {
            this.shenasnameNoField = value;
        }
    }

    /// <remarks/>
    public string shenasnameSeri
    {
        get
        {
            return this.shenasnameSeriField;
        }
        set
        {
            this.shenasnameSeriField = value;
        }
    }

    /// <remarks/>
    public uint shenasnameSerial
    {
        get
        {
            return this.shenasnameSerialField;
        }
        set
        {
            this.shenasnameSerialField = value;
        }
    }

    /// <remarks/>
    public object deathDate
    {
        get
        {
            return this.deathDateField;
        }
        set
        {
            this.deathDateField = value;
        }
    }

    /// <remarks/>
    public object exceptionMessage
    {
        get
        {
            return this.exceptionMessageField;
        }
        set
        {
            this.exceptionMessageField = value;
        }
    }
}



