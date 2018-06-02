using System;
using System.Security.Cryptography;
using System.Text;

namespace Bunkong.WorkLogs.Common
{
    public static class MD5Encrypt
    {
        public static string ToMD5(this string inputValue)
        {
            //32位大写
            using (var md5 = MD5.Create())
            {
                var result = md5.ComputeHash(Encoding.UTF8.GetBytes(inputValue));
                var strResult = BitConverter.ToString(result);
                return strResult.Replace("-", ""); 
            }
        }
    }
}
