using System.Security.Cryptography.X509Certificates;

namespace CodeSmell_StaticMethod
{
    public class UtilityMethod
    {
        public static int Max(int a, int b)
        {
            return a > b ? a : b;
        }
    }

    public class Max : Number {
      private readonly int a;
      private readonly int b;
      public Max(int x, int y) {
        this.a = x;
        this.b = y;
      }
  
      public int intValue() {
        return this.a > this.b ? this.a : this.b;
      }
    }

    public interface Number
    {
        int intValue();
    }

    public class process
    {
        public void Call()
        {
            var maxProcess = UtilityMethod.Max(1,3);
            var maxOO = new Max(1,3).intValue();
        }
    }
}