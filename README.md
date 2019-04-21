# verify-is-letter-or-digit-benchmark
Verify is letter or digit (Benchmark in c#)


### Verify Is Letter
 - WithRegEx: The famous regular expression of whether or not it is in the range of A-Z or a-z
 - WithCharIsLetter with the [char.IsLetter](https://docs.microsoft.com/en-us/dotnet/api/system.char.isletter) method
 - WithForCompareAsciiValue: traversing char by char and verifying if the ascii value of it is what we need
 
                     Method     |       Mean |      Error |     StdDev | Ratio | Allocated| 
                     WithRegEx  | 468.929 ns | 18.4859 ns | 53.6309 ns |  1.00 |    104 B |
               WithCharIsLetter |  97.563 ns |  3.3264 ns |  9.4904 ns |  0.21 |     96 B |
       WithForCompareAsciiValue |   9.019 ns |  0.2194 ns |  0.4997 ns |  0.02 |        - |

 
 ### Verify Is Digit
 soon...