using Anu.Commons.ServiceModel.ServiceCaptcha;
using System.Drawing;

namespace Anu.PunishmentOrg.Api.Authentication.Captcha
{

    public static class Captcha
    {
        private static Dictionary<Guid, string> cashedCaptchas = new();

        public static bool ValidateCaptchaCode(CaptchaInputContract captcha)
        {
            if (cashedCaptchas.Count<=0)
                return false;

            var isValid = captcha.CaptchaCode == cashedCaptchas.Where(a => a.Key == Guid.Parse(captcha.CaptchaID.ToString())).SingleOrDefault().Value;
            cashedCaptchas.Remove(Guid.Parse(captcha.CaptchaID));
            return isValid;
        }
        public static string GenerateCaptchaCode(int Length = 4)
        {
            //if (System.Diagnostics.Debugger.IsAttached)
            //{
            //    return "1";
            //}

            Random rnd = new Random();
            string temp = rnd.Next(1, 9).ToString();
            for (int i = 1; i < Length; i++)
            {
                temp += rnd.Next(0, 9).ToString();
            }

            return temp.ToString();
        }
        public static CaptchaResult GenerateCaptchaImage(string captchaNumber, int width = 80, int height = 25)
        {
            Random random = new Random();
            var arabicCaptcha = ReplaceDigitsWithArabic(captchaNumber.ToString());

            System.Drawing.Font font = new System.Drawing.Font("Tahoma", random.Next(12, 20), FontStyle.Bold | FontStyle.Italic);
            using (System.Drawing.Bitmap captchaImage = new System.Drawing.Bitmap(width, height))
            {
                using (System.Drawing.Graphics graphic = System.Drawing.Graphics.FromImage(captchaImage))
                {
                    graphic.Clear(Color.White);

                    int cwidth, cx, cy;
                    for (int i = 0; i < 15; i++)
                    {
                        cx = random.Next(0, width);
                        cy = random.Next(0, height) - 10;
                        cwidth = random.Next(10, width / 4);
                        var hatchBrush = new System.Drawing.Drawing2D.HatchBrush(System.Drawing.Drawing2D.HatchStyle.Horizontal, Color.White, Color.FromArgb(random.Next(200, 255), random.Next(200, 255), random.Next(200, 255)));
                        graphic.FillEllipse(hatchBrush, cx, cy, cwidth, cwidth);
                    }

                    SizeF size = graphic.MeasureString(arabicCaptcha, font);
                    float xstart = (width - size.Width) / 2;
                    float ystart = (height - size.Height) / 2;

                    int j = 0;
                    int yStartRandom = 0;
                    foreach (var item in arabicCaptcha.ToCharArray())
                    {
                        j += 9;
                        yStartRandom = random.Next(8);
                        var hatchBrushNew = new System.Drawing.Drawing2D.HatchBrush(System.Drawing.Drawing2D.HatchStyle.Vertical, Color.Black, Color.FromArgb(random.Next(1, 255), random.Next(1, 100), random.Next(1, 100)));
                        var hatchBrushNewShadow = new System.Drawing.Drawing2D.HatchBrush(System.Drawing.Drawing2D.HatchStyle.Plaid, Color.YellowGreen, Color.FromArgb(random.Next(180, 200), random.Next(180, 200), random.Next(180, 200)));
                        graphic.DrawString((((int)item) - 1584).ToString(), font, hatchBrushNewShadow, new PointF(xstart + (j * 2), ystart + (yStartRandom - 5)));/*تولید یک سایه برای کپچا جهت ارتقا امنیت و کارایی کپچا*/
                        graphic.DrawString(item.ToString(), font, hatchBrushNew, new PointF(xstart + j, ystart + yStartRandom));
                    }

                    graphic.Flush();

                    using (MemoryStream ms = new MemoryStream())
                    {
                        captchaImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

                        var captcha = new CaptchaResult { CaptchaID = Guid.NewGuid(), CaptchaCode = captchaNumber, CaptchaByteData = ms.ToArray(), Timestamp = DateTime.Now };

                        cashedCaptchas.Add(captcha.CaptchaID, captcha.CaptchaCode);

                        return captcha;
                    }
                }
            }
        }
        private static string ReplaceDigitsWithArabic(string input)
        {
            var str = "";
            foreach (var item in input)
            {
                str += (char)(((int)item) + 1584);
            }
            return str;
        }
    }
}
