using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anu.Captcha.Effects
{
    public static class RippleEffect
    {
        public static Bitmap Ripple(this Bitmap baseMap)
        {

            short nWave = 6;
            int nWidth = baseMap.Width;
            int nHeight = baseMap.Height;

            Point[,] pt = new Point[nWidth, nHeight];

            for (int x = 0; x < nWidth; ++x)
            {
                for (int y = 0; y < nHeight; ++y)
                {
                    var xo = nWave * Math.Sin(2.0 * 3.1415 * y / 128.0);
                    var yo = nWave * Math.Cos(2.0 * 3.1415 * x / 128.0);

                    var newX = x + xo;
                    var newY = y + yo;

                    if (newX > 0 && newX < nWidth)
                    {
                        pt[x, y].X = (int)newX;
                    }
                    else
                    {
                        pt[x, y].X = 0;
                    }


                    if (newY > 0 && newY < nHeight)
                    {
                        pt[x, y].Y = (int)newY;
                    }
                    else
                    {
                        pt[x, y].Y = 0;
                    }
                }
            }

            Bitmap bSrc = (Bitmap)baseMap.Clone();

            BitmapData bitmapData = baseMap.LockBits(new Rectangle(0, 0, baseMap.Width, baseMap.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            BitmapData bmSrc = bSrc.LockBits(new Rectangle(0, 0, bSrc.Width, bSrc.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

            int scanline = bitmapData.Stride;

            IntPtr scan0 = bitmapData.Scan0;
            IntPtr srcScan0 = bmSrc.Scan0;

            unsafe
            {
                byte* p = (byte*)(void*)scan0;
                byte* pSrc = (byte*)(void*)srcScan0;

                int nOffset = bitmapData.Stride - baseMap.Width * 3;

                for (int y = 0; y < nHeight; ++y)
                {
                    for (int x = 0; x < nWidth; ++x)
                    {
                        var xOffset = pt[x, y].X;
                        var yOffset = pt[x, y].Y;

                        if (yOffset >= 0 && yOffset < nHeight && xOffset >= 0 && xOffset < nWidth)
                        {
                            if (pSrc != null)
                            {
                                p[0] = pSrc[yOffset * scanline + xOffset * 3];
                                p[1] = pSrc[yOffset * scanline + xOffset * 3 + 1];
                                p[2] = pSrc[yOffset * scanline + xOffset * 3 + 2];
                            }
                        }

                        p += 3;
                    }
                    p += nOffset;
                }
            }

            baseMap.UnlockBits(bitmapData);
            bSrc.UnlockBits(bmSrc);
            bSrc.Dispose();

            return baseMap;
        }
    }
}
