// Dafny program dafnyFile.dfy compiled into C#
// To recompile, you will need the libraries
//     System.Runtime.Numerics.dll System.Collections.Immutable.dll
// but the 'dotnet' tool in net6.0 should pick those up automatically.
// Optionally, you may want to include compiler switches like
//     /debug /nowarn:162,164,168,183,219,436,1717,1718

using System;
using System.Numerics;
using System.Collections;
/*[assembly: DafnyAssembly.DafnySourceAttribute(@"// dafny 4.7.0.0
// Command-line arguments: translate cs c:\Users\alunm\Documents\Alun\Programming\CombinedTest\DafnyLib1\dafnyFile.dfy
// dafnyFile.dfy


module {:extern ""dafnyModule1""} dafnyModule1 {
  class C {
    method dafnyAdd(a: int, b: int) returns (s: int)
      requires b >= 0
      ensures s >= a
      ensures s == a + b
      decreases a, b
    {
      return a + b;
    }
  }
}
")]
*/
namespace Dafny {
  internal class ArrayHelpers {
    public static T[] InitNewArray1<T>(T z, BigInteger size0) {
      int s0 = (int)size0;
      T[] a = new T[s0];
      for (int i0 = 0; i0 < s0; i0++) {
        a[i0] = z;
      }
      return a;
    }
  }
} // end of namespace Dafny
internal static class FuncExtensions {
  public static Func<U, UResult> DowncastClone<T, TResult, U, UResult>(this Func<T, TResult> F, Func<U, T> ArgConv, Func<TResult, UResult> ResConv) {
    return arg => ResConv(F(ArgConv(arg)));
  }
  public static Func<UResult> DowncastClone<TResult, UResult>(this Func<TResult> F, Func<TResult, UResult> ResConv) {
    return () => ResConv(F());
  }
}
namespace dafnyModule1 {


  public partial class C {
    public C() {
    }
    public BigInteger dafnyAdd(BigInteger a, BigInteger b)
    {
      BigInteger s = BigInteger.Zero;
      s = (a) + (b);
      return s;
      //return s;
    }
  }
} // end of namespace dafnyModule1
namespace _module {

} // end of namespace _module
