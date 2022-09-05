using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anu.Constants.ServiceModel.BaseInfo
{
    public class BaseInfoConstants
    {
        public static class SystemObjectId
        {
            /// <summary>
            /// ردیف مربوط به آبجکت اشياء سيستم
            /// آبجکت شکوائیه
            /// PGravamen
            /// </summary>
            public const string PGravamenSystemObjectId = "ce9703c9bfac402a9c5a56525581dcf8";
            /// <summary>
            /// دريافت مکاتبات مکانيزه
            /// </summary>
            public const string RecieveMechanizedLetterSystemObjectId = "8fc11d43c5a24efa8e209b3cc05ca450";

        }

        public static class SystemObjectCode
        {
            /// <summary>
            /// کد مربوط به آبجکت اشياء سيستم
            /// آبجکت شکوائیه
            /// PGravamen
            /// </summary>
            public const string PGravamenSystemObjectCode = "1098";

            /// <summary>
            /// دريافت مکاتبات مکانيزه
            /// </summary>
            public const string RecieveMechanizedLetterSystemObjectCode = "4829";

        }

        public static class SystemFormId
        {
            /// <summary>
            /// ردیف مربوط به آبجکت فرم هاي سيستم
            /// آبجکت شکوائیه
            /// PGravamen
            /// </summary>
            public const string PGravamenSystemFormId = "635500FA253D498796B61C6F65DC942F";

            /// <summary>
            /// دريافت مکاتبات مکانيزه
            /// </summary>
            public const string RecieveMechanizedLetterSystemFormId = "9003239250EA48C3A583FA2DAC0D0E2C";

        }

        public static class SystemFormCode
        {
            /// <summary>
            /// کد مربوط به آبجکت فرم هاي سيستم
            /// آبجکت شکوائیه
            /// PGravamen
            /// </summary>
            public const string PGravamenSystemFormCode = "0059";

            /// <summary>
            /// دريافت مکاتبات مکانيزه
            /// </summary>
            public const string RecieveMechanizedLetterSystemFormCode = "0048";

        }

        public static class NoticeResultTypeCode
        {
            /// <summary>
            /// ابلاغ از طریق میز خدمت سازمان تعزیرات انجام شده است
            /// </summary>
            public const string NotificationThroughTheSite = "026";

        }
    }
}
