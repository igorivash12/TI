using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Lab3
{
    public class RSA
    {
        public long P { get; set; }
        public long Q { get; set; }
        public long N { get; set; }
        public long Phi { get; set; }
        public long KO { get; set; } // РћС‚РєСЂС‹С‚Р°СЏ СЌРєСЃРїРѕРЅРµРЅС‚Р° e
        public long KC { get; set; } // Р—Р°РєСЂС‹С‚Р°СЏ СЌРєСЃРїРѕРЅРµРЅС‚Р° d

        // РРЅРёС†РёР°Р»РёР·Р°С†РёСЏ РїР°СЂР°РјРµС‚СЂРѕРІ
        public bool Initialize(long p, long q, long ko)
        {
            P = p;
            Q = q;
            N = P * Q;
            Phi = (P - 1) * (Q - 1);
            KO = ko;

            // РџСЂРѕРІРµСЂРєР° РЅР° РІР·Р°РёРјРЅСѓСЋ РїСЂРѕСЃС‚РѕС‚Сѓ KO Рё Phi
            if (!MathTools.IsRelativelyPrime(KO, Phi))
            {
                MessageBox.Show("РћС‚РєСЂС‹С‚С‹Р№ РєР»СЋС‡ KO РґРѕР»Р¶РµРЅ Р±С‹С‚СЊ РІР·Р°РёРјРЅРѕ РїСЂРѕСЃС‚С‹Рј СЃ П†(n)!", "РћС€РёР±РєР°", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Р’С‹С‡РёСЃР»РµРЅРёРµ Р·Р°РєСЂС‹С‚РѕРіРѕ РєР»СЋС‡Р° KC (d)
            // d * e в‰Ў 1 (mod Phi) => d = e^(-1) mod Phi
            KC = MathTools.ModInverse(KO, Phi);

            // Р”РѕРї. РїСЂРѕРІРµСЂРєР°: РµСЃР»Рё KC < 0, РїСЂРёРІРѕРґРёРј Рє РїРѕР»РѕР¶РёС‚РµР»СЊРЅРѕРјСѓ
            if (KC < 0) KC += Phi;

            return true;
        }

        // РЁРёС„СЂРѕРІР°РЅРёРµ Р±Р°Р№С‚Р°
        private ushort EncryptByte(byte data)
        {
            // C = M^KO mod N
            // РўР°Рє РєР°Рє N РјРѕР¶РµС‚ Р±С‹С‚СЊ Р±РѕР»СЊС€РёРј, РёСЃРїРѕР»СЊР·СѓРµРј long
            return (ushort)MathTools.FastExp(data, KO, N);
        }

        // Р Р°СЃС€РёС„СЂРѕРІР°РЅРёРµ ushort РІ Р±Р°Р№С‚
        private byte DecryptUshort(ushort data)
        {
            // M = C^KC mod N
            return (byte)MathTools.FastExp(data, KC, N);
        }

        // РџРѕР±Р°Р№С‚РѕРІРѕРµ С€РёС„СЂРѕРІР°РЅРёРµ С„Р°Р№Р»Р°
        public byte[] EncryptData(byte[] srcData)
        {
            if (srcData == null) return null;

            // Р РµР·СѓР»СЊС‚Р°С‚ Р±СѓРґРµС‚ РІ 2 СЂР°Р·Р° Р±РѕР»СЊС€Рµ РїРѕ СЂР°Р·РјРµСЂСѓ, С‚.Рє. Р±Р°Р№С‚ -> ushort (2 Р±Р°Р№С‚Р°)
            byte[] result = new byte[srcData.Length * 2];

            for (int i = 0; i < srcData.Length; i++)
            {
                ushort encryptedValue = EncryptByte(srcData[i]);
                byte[] bytes = BitConverter.GetBytes(encryptedValue);

                result[2 * i] = bytes[0];
                result[2 * i + 1] = bytes[1];
            }

            return result;
        }

        // Р Р°СЃС€РёС„СЂРѕРІР°РЅРёРµ С„Р°Р№Р»Р° (Р±Р»РѕРєР°РјРё РїРѕ 16 Р±РёС‚)
        public byte[] DecryptData(byte[] srcData)
        {
            if (srcData == null || srcData.Length % 2 != 0)
            {
                MessageBox.Show("Р¤Р°Р№Р» РїРѕРІСЂРµР¶РґРµРЅ РёР»Рё РёРјРµРµС‚ РЅРµС‡РµС‚РЅС‹Р№ СЂР°Р·РјРµСЂ!", "РћС€РёР±РєР°", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            byte[] result = new byte[srcData.Length / 2];

            for (int i = 0; i < result.Length; i++)
            {
                ushort encryptedValue = BitConverter.ToUInt16(srcData, 2 * i);
                result[i] = DecryptUshort(encryptedValue);
            }

            return result;
        }
    }
}
