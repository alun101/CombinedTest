module {:extern "dafnyModule1"} dafnyModule1
{
  class C {
    method dafnyAdd(a: int, b: int) returns (s: int)
    requires b >= 0
    ensures s >= a
    ensures s == a + b 
    {
      return a + b;
    }
  }
}