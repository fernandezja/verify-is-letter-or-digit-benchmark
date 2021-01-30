# verify-is-letter-or-digit-benchmark
Verify is letter or digit (Benchmark in c#)


### Verify Is Letter
 - **WithRegEx**: The famous regular expression of whether or not it is in the range of A-Z or a-z
 - **WithCharIsLetter** with the [char.IsLetter](https://docs.microsoft.com/en-us/dotnet/api/system.char.isletter) method
 - **WithForCompareAsciiValue**: traversing char by char and verifying if the ascii value of it is what we need
 
 
 ### Verify Is Digit
 soon...


 ### Benchmark Results 

##### NET Core 2.2


                     Method     |       Mean |      Error |     StdDev | Ratio | Allocated| 
                     WithRegEx  | 468.929 ns | 18.4859 ns | 53.6309 ns |  1.00 |    104 B |
               WithCharIsLetter |  97.563 ns |  3.3264 ns |  9.4904 ns |  0.21 |     96 B |
       WithForCompareAsciiValue |   9.019 ns |  0.2194 ns |  0.4997 ns |  0.02 |        - |

 ##### NET 5 (5.0.2)

```
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i7-8550U CPU 1.80GHz (Kaby Lake R), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=5.0.200-preview.20614.14
  [Host]     : .NET Core 5.0.2 (CoreCLR 5.0.220.61120, CoreFX 5.0.220.61120), X64 RyuJIT  [AttachedDebugger]
  DefaultJob : .NET Core 5.0.2 (CoreCLR 5.0.220.61120, CoreFX 5.0.220.61120), X64 RyuJIT
```


|                   Method |       Mean |     Error |    StdDev | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|------------------------- |-----------:|----------:|----------:|------:|--------:|-------:|------:|------:|----------:|
|                WithRegEx | 268.075 ns | 16.196 ns | 46.988 ns |  1.00 |    0.00 |      - |     - |     - |         - |
|         WithCharIsLetter | 115.251 ns |  7.529 ns | 21.482 ns |  0.44 |    0.10 | 0.0229 |     - |     - |      96 B |
| WithForCompareAsciiValue |   9.169 ns |  1.097 ns |  3.166 ns |  0.04 |    0.01 |      - |     - |     - |         - |