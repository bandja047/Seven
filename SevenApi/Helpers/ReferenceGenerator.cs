using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography;
using System.Text;

namespace SevenApi.NewFolder
{
    public class ReferenceGenerator
    {
        private static readonly Random random = new Random();

        public static string GenerateAlphanumericReference()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, 11).Select(x => x[random.Next(x.Length)]).ToArray());
        }

        public static string GenerateGuidedBasedReference() { 
        
            Guid guid = Guid.NewGuid();
            string hash = Convert.ToBase64String(guid.ToByteArray());
            hash = hash.Replace("-", "").Replace("/", "").Replace("+", "");
            return hash.Substring(0, 11);
        }

        public static string GenerateTimeStampedReference()
        {
            long ticks = DateTime.UtcNow.Ticks;
            string base36 = Base36Encode(ticks);
            return base36.PadLeft(11, '0').Substring(0, 11);
        }

        public static string GenerateHashWithCounterReference(int counter)
        {
            using (var sha256 = SHA256.Create()) {

                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(Guid.NewGuid().ToString()));
                string hash = BitConverter.ToString(bytes).Replace("-","").Substring(0,5);
                return $"{hash}{counter.ToString().PadLeft(6, '0')}";
            }
            
        
        }
        private static string Base36Encode(long input)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var result = new StringBuilder();
            while (input > 0)
            {
                int index = (int)(input%36);

                result.Insert(0, chars[Math.Abs(index)]);

                input /= 36;
            }

            return result.ToString();
        }
    }
}
