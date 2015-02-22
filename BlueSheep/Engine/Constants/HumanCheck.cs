﻿using BlueSheep.Common.IO;
using BlueSheep.Interface;
using BlueSheep.Interface.Text;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace BlueSheep.Engine.Constants
{
    public class HumanCheck
    {
      private const string BASE64_CHARS = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789+/=";

      private int _SWHXWLEXWG;

      private int _SOOOWEGIDD;

      private int _SEDHIDLXEXM;

      private int _SEHEMWXGXHW;

      private int _SEXXHHHDHIX;

      private int _SEGWEMEWXX;

      private int _SOMIIWEEMX;

      private int _SWXDEXMDOO;

      private int _SDXLGILGDWX;

      private int _SEOEDHDIEHD;

      private int _SEXMHWXLLDO;

      private int _SWHHWELMIL;

      private int _SEDHEXWXXDE;

      private int _SEMGDDOXMEW;

      private int _SEWXMXDLXMH;

      private int _SGLXGIDWHE;

        public byte[] _hashKey;

        public HumanCheck(AccountUC account)
        {
            //init
            //this._SWHXWLEXWG = -((438 + 167 ^ 1242 % 846) % (1060 >> 1 ^ 404 + 22));
            //this._SOOOWEGIDD = 2050 % 1413 + (140 + 152) ^ (1785 + 874) % (318 + 1435);
            //this._SEDHIDLXEXM = (2464 >> 1) % (367 + 396) % (2495 % 1618 ^ 156 + 604);
            //this._SEHEMWXGXHW = -((224 % 204 >> 1) + ((441 ^ 443) + (8 >> 1)));
            //this._SEXXHHHDHIX = (90 >> 1) + (10 >> 1) + (152 >> 1 ^ 87 + 32);
            //this._SEGWEMEWXX = -((32 ^ 276 ^ 1959 % 1105) % (985 % 614 ^ 177 + 634));
            //this._SOMIIWEEMX = -(122 >> 1 ^ 374 >> 1 ^ 54 + 416 ^ 744 >> 1);
            //this._SWXDEXMDOO = -(((36 >> 1) + 869 % 801) % ((718 ^ 584) >> 1));
            //this._SDXLGILGDWX = -((1236 >> 1) + (130 + 67) ^ 696 >> 1 ^ 934 ^ 448);
            //this._SEOEDHDIEHD = 705 % 660 + (732 ^ 727) >> 1;
            //this._SEXMHWXLLDO = (900 >> 1 ^ 1396 >> 1) % ((703 ^ 851) + (690 >> 1));
            //this._SWHHWELMIL = (936 >> 1 ^ 575 % 536) % (1091 % 828 ^ 24 + 134);
            //this._SEDHEXWXXDE = (590 >> 1 ^ 1524 % 1109) >> 1;
            //this._SEMGDDOXMEW = -((1097 ^ 207) % (366 + 650) >> 1);
            //this._SEWXMXDLXMH = -((12 >> 1) + 435 % 427 + (636 >> 1 ^ 1104 % 790));
            //this._SGLXGIDWHE = -((3316 >> 1) % (1824 >> 1) ^ 11 + 21 + (1322 >> 1));
            //end init

            this._hashKey = hashKey_Gen(account);

            //this._SEDHEXWXXDE = this._SEDHEXWXXDE ^ -12;
            //this._SOOOWEGIDD = this._SOOOWEGIDD ^ -79;
            //this._SEXXHHHDHIX = this._SEXXHHHDHIX ^ 78;
            //this._SEGWEMEWXX = this._SEGWEMEWXX ^ -44;
            //this._SOMIIWEEMX = this._SOMIIWEEMX ^ -113;
            //this._SEMGDDOXMEW = this._SEMGDDOXMEW ^ 105;
            //this._SEHEMWXGXHW = this._SEHEMWXGXHW ^ -54;
            //this._SDXLGILGDWX = this._SDXLGILGDWX ^ 58;
            //this._SEXMHWXLLDO = this._SEXMHWXLLDO ^ 119;
            //this._SWXDEXMDOO = this._SWXDEXMDOO ^ -78;
            //this._SGLXGIDWHE = this._SGLXGIDWHE ^ 2;
            //this._SEDHIDLXEXM = this._SEDHIDLXEXM ^ 17;
            //this._SWHXWLEXWG = this._SWHXWLEXWG ^ -120;
            //this._SWHHWELMIL = this._SWHHWELMIL ^ -18;
            //this._SEOEDHDIEHD = this._SEOEDHDIEHD ^ -74;
            //this._SEWXMXDLXMH = this._SEWXMXDLXMH ^ 110;

            ////lfc then
            //byte[] dataToDecrypt = null;
            //     //C933045837 pad = null;
            //     //C1025315654 mode = null;
            //     byte[] hashKey = null;
            //     //var dofusInstance:Sprite = null;
            //     //var swfSigData:Object = null;
            //     byte[] rawSignature = null;
            //     byte[] swfContent = null;
            //     string pem = null;
            //     //C676129505 rsaKey = null;
            //     string ANKAMA_SIGNED_FILE_HEADER = null;
            //     string SIGNATURE_HEADER = null;
            //     int headerPosition = 0;
            //     string header = null;
            //     int signedDataLenght = 0;
            //     byte[] cryptedData = null;
            //     byte[] sigData = null;
            //     uint tsDecrypt = 0;
            //     string sigHeader = null;
            //     uint _decoyXorKeyPart2_ = 0;
            //     uint sigVersion = 0;
            //     uint sigFileLenght = 0;
            //     uint _decoyXorKeyPart3_ = 0;
            //     uint hashType = 0;
            //     string sigHash = null;
            //     uint tsHash = 0;
            //     string contentHash = null;
            //     DateTime sigDate;
            //    uint _decoyXorKeyPart4_ = 0;
            //     uint _decoyXorKeyPart7_ = 0;
            //    uint _decoyXorKeyPart8_ = 0;
            //     uint _decoyXorKeyPart9_ = 0;
            //     int n = 0;
            //     //var e = param1;
            //     int decoyXorKey = ((384>>1)+(1122>>1))%(1914%1287+1204%1078);

        }

        public byte[] hash_function(byte[] packet)
        {
            object _loc5_ = null;
            byte[] _loc6_ = null;
            if (this._hashKey == null)
                return packet;
            using (BigEndianWriter writer = new BigEndianWriter())
            {
                writer.WriteBytes(packet);
                BigEndianWriter writer2 = new BigEndianWriter();
                writer2.WriteBytes(this.hash(packet));
                using (RijndaelManaged myRijndael = new RijndaelManaged())
                {
                    myRijndael.GenerateIV();
                    // Encrypt the string to an array of bytes. 
                    byte[] encrypted = EncryptStringToBytes(writer2.Content.ToString(), this._hashKey, myRijndael.IV);
                }
                writer.WriteBytes(writer2.Content);
                return writer.Content;
            }
        }

#region AES
        static byte[] EncryptStringToBytes(string plainText, byte[] Key, byte[] IV)
        {
            // Check arguments. 
            if (plainText == null || plainText.Length <= 0)
                throw new ArgumentNullException("plainText");
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("Key");
            byte[] encrypted;
            // Create an RijndaelManaged object 
            // with the specified key and IV. 
            using (RijndaelManaged rijAlg = new RijndaelManaged())
            {
                rijAlg.KeySize = 128;
                rijAlg.Key = Key;
                rijAlg.IV = IV;

                // Create a decrytor to perform the stream transform.
                ICryptoTransform encryptor = rijAlg.CreateEncryptor(rijAlg.Key, rijAlg.IV);

                // Create the streams used for encryption. 
                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {

                            //Write all data to the stream.
                            swEncrypt.Write(plainText);
                        }
                        encrypted = msEncrypt.ToArray();
                    }
                }
            }


            // Return the encrypted bytes from the memory stream. 
            return encrypted;

        }
#endregion

        private byte[] hash(byte[] src)
        {
            uint _loc2_ = Convert.ToUInt32(src.Length * 8);
            //string _loc3_ = src.endian;
            while (src.Length % 4 != 0)
            {
                //src[src.Length] = 0;
                List<byte> list = src.ToList();
                list.RemoveAt(src.Length - 1);
                src = list.ToArray();
            }
            List<uint> _loc4_ = new List<uint>();
            uint _loc5_ = 0;
            
            //while (_loc5_ < src.Length)
            //{
            //    _loc4_.Add(reader.ReadUInt32());
            //    _loc5_ = _loc5_ + 4;
            //}
            byte[] _loc6_;
            using (MD5 md5Hash = MD5.Create())
            {
                _loc6_ = md5Hash.ComputeHash(src.ToArray());
            }
            BinaryReader reader = new BinaryReader(new MemoryStream(_loc6_), Encoding.UTF8);
            //uint[] _loc6_ = core_md5(_loc4_.ToArray(), _loc2_);
            while (_loc5_ < _loc6_.Length)
            {
                _loc4_.Add(reader.ReadUInt32());
                _loc5_ = _loc5_ + 4;
            }
            BinaryWriter writer = new BinaryWriter(new MemoryStream(), Encoding.Default);
            _loc5_ = 0;
            while (_loc5_ < 4)
            {
                writer.Write(_loc4_.ToArray()[_loc5_]);
                _loc5_++;
            }
            //src.length=_loc2_/8;
            byte[] content = new byte[writer.BaseStream.Length];

            writer.BaseStream.Position = 0;
            writer.BaseStream.Read(content, 0, (int)writer.BaseStream.Length);

            return content;
        }

        private uint[] core_md5(uint[] x, uint len)
        {
            x[len >> 5] |= (uint)(128) << ((int)(len) % 32);
            x[(len + 64 >> 9 << 4) + 14] = len;
            uint a = 0x67452301; // 1732584193;
            uint b = 0xEFCDAB89; //-271733879;
            uint c = 0x98BADCFE; //-1732584194;
            uint d = 0x10325476; // 271733878;
            for (uint i = 0; i < x.Length; i += 16)
            {
                //x[i] = (x[i]) || (0);
                //x[i + 1] = (x[i + 1]) || (0);
                //x[i + 2] = (x[i + 2]) || (0);
                //x[i + 3] = (x[i + 3]) || (0);
                //x[i + 4] = (x[i + 4]) || (0);
                //x[i + 5] = (x[i + 5]) || (0);
                //x[i + 6] = (x[i + 6]) || (0);
                //x[i + 7] = (x[i + 7]) || (0);
                //x[i + 8] = (x[i + 8]) || (0);
                //x[i + 9] = (x[i + 9]) || (0);
                //x[i + 10] = (x[i + 10]) || (0);
                //x[i + 11] = (x[i + 11]) || (0);
                //x[i + 12] = (x[i + 12]) || (0);
                //x[i + 13] = (x[i + 13]) || (0);
                //x[i + 14] = (x[i + 14]) || (0);
                //x[i + 15] = (x[i + 15]) || (0);
                uint olda = a;
                uint oldb = b;
                uint oldc = c;
                uint oldd = d;
                a = ff(a, b, c, d, x[i + 0], 7, 0xD76AA478);
                d = ff(d, a, b, c, x[i + 1], 12, 0xE8C7B756);
                c = ff(c, d, a, b, x[i + 2], 17, 0x242070DB);
                b = ff(b, c, d, a, x[i + 3], 22, 0xC1BDCEEE);
                a = ff(a, b, c, d, x[i + 4], 7, 0xF57C0FAF);
                d = ff(d, a, b, c, x[i + 5], 12, 0x4787C62A);
                c = ff(c, d, a, b, x[i + 6], 17, 0xA8304613);
                b = ff(b, c, d, a, x[i + 7], 22, 0xFD469501);
                a = ff(a, b, c, d, x[i + 8], 7, 0x698098D8);
                d = ff(d, a, b, c, x[i + 9], 12, 0x8B44F7AF);
                c = ff(c, d, a, b, x[i + 10], 17, 0xFFFF5BB1);
                b = ff(b, c, d, a, x[i + 11], 22, 0x895CD7BE);
                a = ff(a, b, c, d, x[i + 12], 7, 0x6B901122);
                d = ff(d, a, b, c, x[i + 13], 12, 0xFD987193);
                c = ff(c, d, a, b, x[i + 14], 17, 0xA679438E);
                b = ff(b, c, d, a, x[i + 15], 22, 0x49B40821);
                a = gg(a, b, c, d, x[i + 1], 5, 0xf61e2562);
                d = gg(d, a, b, c, x[i + 6], 9, 0xc040b340);
                c = gg(c, d, a, b, x[i + 11], 14, 0x265e5a51);
                b = gg(b, c, d, a, x[i + 0], 20, 0xe9b6c7aa);
                a = gg(a, b, c, d, x[i + 5], 5, 0xd62f105d);
                d = gg(d, a, b, c, x[i + 10], 9, 0x2441453);
                c = gg(c, d, a, b, x[i + 15], 14, 0xd8a1e681);
                b = gg(b, c, d, a, x[i + 4], 20, 0xe7d3fbc8);
                a = gg(a, b, c, d, x[i + 9], 5, 0x21e1cde6);
                d = gg(d, a, b, c, x[i + 14], 9, 0xc33707d6);
                c = gg(c, d, a, b, x[i + 3], 14, 0xf4d50d87);
                b = gg(b, c, d, a, x[i + 8], 20, 0x455a14ed);
                a = gg(a, b, c, d, x[i + 13], 5, 0xa9e3e905);
                d = gg(d, a, b, c, x[i + 2], 9, 0xfcefa3f8);
                c = gg(c, d, a, b, x[i + 7], 14, 0x676f02d9);
                b = gg(b, c, d, a, x[i + 12], 20, 0x8d2a4c8a);
                a = hh(a, b, c, d, x[i + 5], 4, 0xfffa3942);
                d = hh(d, a, b, c, x[i + 8], 11, 0x8771f681);
                c = hh(c, d, a, b, x[i + 11], 16, 0x6d9d6122);
                b = hh(b, c, d, a, x[i + 14], 23, 0xfde5380c);
                a = hh(a, b, c, d, x[i + 1], 4, 0xa4beea44);
                d = hh(d, a, b, c, x[i + 4], 11, 0x4bdecfa9);
                c = hh(c, d, a, b, x[i + 7], 16, 0xf6bb4b60);
                b = hh(b, c, d, a, x[i + 10], 23, 0xbebfbc70);
                a = hh(a, b, c, d, x[i + 13], 4, 0x289b7ec6);
                d = hh(d, a, b, c, x[i + 0], 11, 0xeaa127fa);
                c = hh(c, d, a, b, x[i + 3], 16, 0xd4ef3085);
                b = hh(b, c, d, a, x[i + 6], 23, 0x4881d05);
                a = hh(a, b, c, d, x[i + 9], 4, 0xd9d4d039);
                d = hh(d, a, b, c, x[i + 12], 11, 0xe6db99e5);
                c = hh(c, d, a, b, x[i + 15], 16, 0x1fa27cf8);
                b = hh(b, c, d, a, x[i + 2], 23, 0xc4ac5665);
                a = ii(a, b, c, d, x[i + 0], 6, 0xf4292244);
                d = ii(d, a, b, c, x[i + 7], 10, 0x432aff97);
                c = ii(c, d, a, b, x[i + 14], 15, 0xab9423a7);
                b = ii(b, c, d, a, x[i + 5], 21, 0xfc93a039);
                a = ii(a, b, c, d, x[i + 12], 6, 0x655b59c3);
                d = ii(d, a, b, c, x[i + 3], 10, 0x8f0ccc92);
                c = ii(c, d, a, b, x[i + 10], 15, 0xffeff47d);
                b = ii(b, c, d, a, x[i + 1], 21, 0x85845dd1);
                a = ii(a, b, c, d, x[i + 8], 6, 0x6fa87e4f);
                d = ii(d, a, b, c, x[i + 15], 10, 0xfe2ce6e0);
                c = ii(c, d, a, b, x[i + 6], 15, 0xa3014314);
                b = ii(b, c, d, a, x[i + 13], 21, 0x4e0811a1);
                a = ii(a, b, c, d, x[i + 4], 6, 0xf7537e82);
                d = ii(d, a, b, c, x[i + 11], 10, 0xbd3af235);
                c = ii(c, d, a, b, x[i + 2], 15, 0x2ad7d2bb);
                b = ii(b, c, d, a, x[i + 9], 21, 0xeb86d391);
                a += olda;
                b += oldb;
                c += oldc;
                d += oldd;
            }
            return new uint[4] { a, b, c, d };
        }

        //Bitwise rotate a 32-bit number to the left.
        private uint rol(uint num, uint cnt)
        {
            return Convert.ToUInt32(((int)num << (int)cnt) | (num >> (int)(32 - cnt)));
        }
        //These functions implement the four basic operations the algorithm uses.
        private uint cmn(uint param1, uint param2, uint param3, uint param4, uint param5, uint param6)
        {
            return rol(param2 + param1 + param4 + param6, param5) + param3;
        }

        private uint ff(uint param1, uint param2, uint param3, uint param4, uint param5, uint param6, uint param7)
        {
            return cmn(param2 & param3 | ~param2 & param4, param1, param2, param5, param6, param7);
        }

        private uint gg(uint param1, uint param2, uint param3, uint param4, uint param5, uint param6, uint param7)
        {
            return cmn(param2 & param4 | param3 & ~param4, param1, param2, param5, param6, param7);
        }

        private uint hh(uint param1, uint param2, uint param3, uint param4, uint param5, uint param6, uint param7)
        {
            return cmn(param2 ^ param3 ^ param4, param1, param2, param5, param6, param7);
        }

        private uint ii(uint param1, uint param2, uint param3, uint param4, uint param5, uint param6, uint param7)
        {
            return cmn(param3 ^ (param2 | ~param4), param1, param2, param5, param6, param7);
        }
   

        private byte[] hashKey_Gen(AccountUC account)
        {
        //    uint keyLen = 190 % 174 + (22 >> 1) + (672 ^ 145 ^ 933 ^ 497); //128
        //    using (BigEndianWriter hashKey = new BigEndianWriter())
        //    {
        //        int i = 0;
        //        while (i < keyLen / 8)
        //        {
        //            hashKey.WriteByte((byte)(i % 4));
        //            i++;
        //        }
        //        return hashKey.Content;
        //    }   
            try
            {
                using (BigEndianWriter writer = new BigEndianWriter())
                {
                    writer.WriteUTF(account.Ticket);
                    byte[] key = hash(writer.Content);
                    return key;
                }
            }
            catch (Exception ex)
            {
                account.Log(new ErrorTextInformation(ex.Message + ex.InnerException), 0);
                return null;
            }
        }

        #region Private Methods
        private string dec(string param1, string param2)
        {
            byte[] _loc3_ = this.decodeToByteArray(param1);
            byte[] _loc4_ = this.decodeToByteArray(param2);
            uint _loc5_ = 0;
            while (_loc5_ < _loc3_.Length)
            {
                _loc3_[_loc5_] = Convert.ToByte(_loc3_[_loc5_] ^ _loc4_[_loc5_ % _loc4_.Length]);
                _loc5_++;
            }
            return _loc3_.ToString(); ;
        }

        private byte[] decodeToByteArray(string param1)
        {
            uint _loc6_ = 0;
            uint _loc7_ = 0;
            List<byte> _loc2_ = new List<byte>();
            uint[] _loc3_ = new uint[4];
            uint[] _loc4_ = new uint[3];
            uint _loc5_ = 0;
            while (_loc5_ < param1.Length)
            {
                _loc6_ = 0;
                while (_loc6_ < 4 && _loc5_ + _loc6_ < param1.Length)
                {
                    _loc3_[_loc6_] = (uint)BASE64_CHARS.IndexOf(param1[(int)_loc5_ + (int)_loc6_]);
                    _loc6_++;
                }
                _loc4_[0] = (_loc3_[0] << 2) + ((_loc3_[1] & 48) >> 4);
                _loc4_[1] = ((_loc3_[1] & 15) << 4) + ((_loc3_[2] & 60) >> 2);
                _loc4_[2] = ((_loc3_[2] & 3) << 6) + _loc3_[3];
                _loc7_ = 0;
                while (_loc7_ < _loc4_.Length)
                {
                    if (_loc3_[_loc7_ + 1] == 64)
                    {
                        break;
                    }
                    _loc2_.Add(Convert.ToByte(_loc4_[_loc7_]));
                    _loc7_++;
                }
                _loc5_ = _loc5_ + 4;
            }
            return _loc2_.ToArray();
        }
        #endregion

//        #region Needed class

//        class C933045837
//        {

//            public C933045837(uint param1 = 0)
//            {
//                this.blockSize = param1;
//                return;
//            }


//            public uint blockSize;

//            public void pad(byte[] param1)
//            {
//                uint _loc2_ = Convert.ToUInt32(this.blockSize - param1.Length % this.blockSize);
//                uint _loc3_ = 0;
//                while (_loc3_ < _loc2_)
//                {
//                    param1[param1.Length] = Convert.ToByte(_loc2_);
//                    _loc3_++;
//                }
//                return;
//            }

//            public void unpad(byte[] param1)
//            {
//                uint _loc4_ = 0;
//                uint _loc2_ = Convert.ToUInt32(param1.Length % this.blockSize);
//                if (_loc2_ != 0)
//                {
//                    throw new Exception("PKCS#5::unpad: ByteArray.length isn\'t a multiple of the blockSize");
//                }
//                else
//                {
//                    _loc2_ = param1[param1.Length - 1];
//                    uint _loc3_ = _loc2_;
//                    while (_loc3_ > 0)
//                    {
//                        _loc4_ = param1[_loc2_];
//                        _loc2_--;
//                        if (_loc2_ != _loc4_)
//                        {
//                            throw new Exception("PKCS#5:unpad: Invalid padding value. expected [" + _loc2_ + "], found [" + _loc4_ + "]");
//                        }
//                        else
//                        {
//                            _loc3_--;
//                            continue;
//                        }
//                    }
//                    return;
//                }
//            }

//            public void setBlockSize(uint param1)
//            {
//                this.blockSize = param1;
//                return;
//            }
//        }

//        class C1025315654
//   {
//      public C1025315654(IVMode param1) 
//        {
//         this.mode =param1;
//         this.cipher= param1 as C1025315654;
//         return;
//      }

//      protected IVMode mode;

//      protected C1025315654 cipher;

//      public uint getBlockSize() 
//      {
//         return this.mode.getBlockSize();
//      }

//      public void dispose() 
//      {
//         this.mode.dispose();
//         this.mode=null;
//         this.cipher=null;
//         C1025315654.gc();
//         return;
//      }

//      public void encrypt(byte[] param1)
//      {
//         List<byte> list = param1.ToList();
//         this.cipher.encrypt(param1);
//         List<byte> _loc2_ = new List<byte>();
//         _loc2_.Add(this.mode.IV);
//         _loc2_.AddRange(param1);
//         list.AddRange(_loc2_);
//         param1 = list.ToArray();
//         return;
//      }

//      public void decrypt(byte[] param1)
//      {
//        using (BigEndianWriter writer = new BigEndianWriter())
//        {
//            for (int i = 0; i > this.getBlockSize();i++)
//            {
//                writer.WriteByte(param1[i]);
//            }
//            this.mode.IV =writer.Content;
//        }

//        using (BigEndianWriter writer = new BigEndianWriter())
//        {
//            for (int i = 0; i > this.getBlockSize();i++)
//            {
//                writer.WriteByte(param1[i]);
//            }
//                     this.cipher.decrypt(writer.Content);
//            param1 = writer.Content;
//        }
//         return;
//      }

//      public string toString()
//      {
//         return "simple-"+ this.cipher.toString();
//      }
//        }

//   class IVMode
//   {
//      public IVMode(object param1, C933045837 param2 = null) 
//{
//         this.key=param1;
//         this.blockSize=param1.getBlockSize();
         
//          if(param2==null)
//         {
//            param2=new C933045837(this.blockSize);
//         }
//         else
//         {
//            param2.setBlockSize(this.blockSize);
//         }
//         this.padding=param2;
//         this.prng=new Random();
//         this.iv=null;
//         this.lastIV=new byte[1];
//         return;
//      }

//      protected object key;

//      protected IPad padding;

//      protected Random prng;

//      protected byte[] iv;

//      protected byte[] lastIV;

//      protected uint blockSize;

//      public uint getBlockSize()
//      {
//         return this.key.getBlockSize();
//      }

//      public void dispose()
//      {
//         uint _loc1_ = 0;
//         if(this.iv!=null)
//         {
//            _loc1_=0;
//            while(_loc1_<this.iv.length)
//            {
//               this.iv[_loc1_]=this.prng.nextByte();
//               _loc1_++;
//            }
//            this.iv.length=0;
//            this.iv=null;
//         }
//         if(this.lastIV!=null)
//         {
//            _loc1_=0;
//            while(_loc1_<this.iv.length)
//            {
//               this.lastIV[_loc1_]=this.prng.nextByte();
//               _loc1_++;
//            }
//            this.lastIV.length=0;
//            this.lastIV=null;
//         }
//         this.key.dispose();
//         this.key=null;
//         this.padding=null;
//         this.prng.dispose();
//         this.prng=null;
//         IVMode.gc();
//         return;
//      }

//      public void setIV(byte[] param1)
//     {
//         this.iv=param1;
//          List<byte> list = new List<byte>();
//          list.AddRange(this.iv);
//         this.lastIV = list.ToArray();
//         return;
//      }

//      public byte[] getIV()
//      {
//         return this.lastIV;
//      }

//      protected byte[] getIV4e()
//      {
//          List<byte> _loc1_ = new List<byte>();
//         if(this.iv != null)
//         {
//            _loc1_.AddRange(this.iv);
//         }
//         else
//         {
//            this.prng.NextBytes(_loc1_,this.blockSize);
//         }
//         this.lastIV = (_loc1_.ToArray());
//         return _loc1_.ToArray(); ;
//      }

//      protected byte[] getIV4d() 
//{
//         List<byte> list = new List<byte>();
//         if(this.iv != null)
//         {
//            list.AddRange(this.iv);
//            return list.ToArray();
//         }
//         throw new Exception("an IV must be set before calling decrypt()");
//      }
//   }


//        class Random
//   {
//      public Random(object param1 = null) 
//        {
//         uint _loc2_ = 0;
//         if(param1==null)
//         {
//            param1= this;
//         }
//         this.state=new Random() as Random;
//         this.psize=this.state.getPoolSize();
//         this.pool=new byte[1];
//         this.pptr=0;
//         while(this.pptr<this.psize)
//         {
//            _loc2_= Convert.ToUInt32(65536 * new System.Random().NextDouble());
//            this.pool[this.pptr++]=_loc2_>>>8;
//            this.pool[this.pptr++]=_loc2_&255;
//         }
//         this.pptr=0;
//         this.seed();
//         return;
//      }

//      private IPNRG state;

//      private bool ready = false;

//      private byte[] pool;

//      private int psize;

//      private int pptr;

//      private bool seeded = false;

//      public void seed(int param1)
//        {
//         if(param1==0)
//         {
//            param1= new DateTime().getTime();
//         }
//         object _loc2_ = this.pptr++;
//         this.pool[_loc2_]=this.pool[_loc2_]^param1&255;
//         this.pool[this.pptr++]=this.pool[_loc3_]^param1>>8&255;
//         this.pool[this.pptr++]=this.pool[this.pptr++]^param1>>16&255;
//         this.pool[this.pptr++]=this.pool[this.pptr++]^param1>>24&255;
//         this.pptr=this.pptr%this.psize;
//         this.seeded=true;
//         return;
//      }

//      public void autoSeed()
//{
//         Font _loc3_= null;
//         var _loc1_:ByteArray = new ByteArray();
//         _loc1_.writeUnsignedInt(System.totalMemory);
//         _loc1_.writeUTF(Capabilities.serverString);
//         _loc1_.writeUnsignedInt(getTimer());
//         _loc1_.writeUnsignedInt(new Date().getTime());
//         var _loc2_:Array = Font(true);
//         foreach (_loc3_ in _loc2_)
//         {
//            _loc1_.writeUTF(_loc3_.fontName);
//            _loc1_.writeUTF(_loc3_.fontStyle);
//            _loc1_.writeUTF(_loc3_.fontType);
//         }
//         _loc1_.position=0;
//         while(_loc1_.bytesAvailable>=4)
//         {
//            this.seed(_loc1_.readUnsignedInt());
//         }
//         return;
//      }

//      public void nextBytes(byte[] param1, int param2)
//      {
//         while(param2--)
//         {
//            param1.writeByte(this.nextByte());
//         }
//         return;
//      }

//      public int nextByte()
//      {
//         if(!this.ready)
//         {
//            if(!this.seeded)
//            {
//               this.autoSeed();
//            }
//            this.state.init(this.pool);
//            this.pool.length=0;
//            this.pptr=0;
//            this.ready=true;
//         }
//         return this.state.next();
//      }

//      public void dispose()
//{
//         var _loc1_:uint = 0;
//         while(_loc1_<this.pool.length)
//         {
//            this.pool[_loc1_]= Math.random()*256;
//            _loc1_++;
//         }
//         this.pool.length=0;
//         this.pool=null;
//         this.state.dispose();
//         this.state=null;
//         this.psize=0;
//         this.pptr=0;
//         Random.gc();
//         return;
//      }

//      public string toString()
//      {
//         return "random-"+this.state.toString();
//      }
//   }
//        #endregion
    }
}