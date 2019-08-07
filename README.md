Optimized HashSet

``` ini

BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.615 (1809/October2018Update/Redstone5)
Intel Core i7-7700HQ CPU 2.80GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.0.100-preview7-012821
  [Host]     : .NET Core 3.0.0-preview7-27912-14 (CoreCLR 4.700.19.32702, CoreFX 4.700.19.36209), 64bit RyuJIT
  DefaultJob : .NET Core 3.0.0-preview7-27912-14 (CoreCLR 4.700.19.32702, CoreFX 4.700.19.36209), 64bit RyuJIT


```
|            Method | Categories |      Mean |     Error |    StdDev |    Median | Ratio | RatioSD |
|------------------ |----------- |----------:|----------:|----------:|----------:|------:|--------:|
|    Get_StringDict | String,Get | 21.053 ns | 0.2522 ns | 0.2359 ns | 20.999 ns |  0.84 |    0.01 |
|     Get_StringSet | String,Get | 25.051 ns | 0.2697 ns | 0.2523 ns | 24.971 ns |  1.00 |    0.00 |
| Get_StringFastSet | String,Get | 23.986 ns | 0.1639 ns | 0.1533 ns | 23.997 ns |  0.96 |    0.01 |
|                   |            |           |           |           |           |       |         |
|       Get_IntDict |  Int32,Get |  6.596 ns | 0.0388 ns | 0.0363 ns |  6.597 ns |  0.63 |    0.01 |
|        Get_IntSet |  Int32,Get | 10.430 ns | 0.2240 ns | 0.2200 ns | 10.377 ns |  1.00 |    0.00 |
|    Get_IntFastSet |  Int32,Get |  6.632 ns | 0.0335 ns | 0.0297 ns |  6.638 ns |  0.64 |    0.01 |
|                   |            |           |           |           |           |       |         |
|       Get_ObjDict | Object,Get | 16.235 ns | 0.0976 ns | 0.0865 ns | 16.201 ns |  0.82 |    0.02 |
|        Get_ObjSet | Object,Get | 19.278 ns | 0.3845 ns | 0.7222 ns | 19.200 ns |  1.00 |    0.00 |
|    Get_ObjFastSet | Object,Get | 17.266 ns | 0.3439 ns | 0.7178 ns | 16.835 ns |  0.90 |    0.05 |
|                   |            |           |           |           |           |       |         |
|    Get_CustomDict | Custom,Get | 11.809 ns | 0.5410 ns | 0.5556 ns | 11.587 ns |  0.87 |    0.04 |
|     Get_CustomSet | Custom,Get | 13.536 ns | 0.1752 ns | 0.1638 ns | 13.540 ns |  1.00 |    0.00 |
| Get_CustomFastSet | Custom,Get | 11.547 ns | 0.1316 ns | 0.1231 ns | 11.573 ns |  0.85 |    0.01 |
|                   |            |           |           |           |           |       |         |
|    Set_StringDict | String,Set | 24.956 ns | 0.4348 ns | 0.4067 ns | 24.889 ns |  0.97 |    0.02 |
|     Set_StringSet | String,Set | 25.757 ns | 0.2293 ns | 0.2145 ns | 25.667 ns |  1.00 |    0.00 |
| Set_StringFastSet | String,Set | 25.145 ns | 0.3634 ns | 0.3399 ns | 25.057 ns |  0.98 |    0.01 |
|                   |            |           |           |           |           |       |         |
|       Set_IntDict |  Int32,Set |  8.010 ns | 0.0707 ns | 0.0661 ns |  7.988 ns |  0.76 |    0.01 |
|        Set_IntSet |  Int32,Set | 10.552 ns | 0.0894 ns | 0.0792 ns | 10.537 ns |  1.00 |    0.00 |
|    Set_IntFastSet |  Int32,Set |  8.005 ns | 0.1733 ns | 0.5109 ns |  8.203 ns |  0.66 |    0.03 |
|                   |            |           |           |           |           |       |         |
|       Set_ObjDict | Object,Set | 19.934 ns | 0.1394 ns | 0.1236 ns | 19.939 ns |  1.08 |    0.02 |
|        Set_ObjSet | Object,Set | 18.538 ns | 0.2455 ns | 0.2297 ns | 18.520 ns |  1.00 |    0.00 |
|    Set_ObjFastSet | Object,Set | 16.306 ns | 0.0373 ns | 0.0291 ns | 16.315 ns |  0.88 |    0.01 |
|                   |            |           |           |           |           |       |         |
|    Set_CustomDict | Custom,Set | 14.611 ns | 0.0883 ns | 0.0783 ns | 14.610 ns |  1.09 |    0.02 |
|     Set_CustomSet | Custom,Set | 13.434 ns | 0.2412 ns | 0.2138 ns | 13.353 ns |  1.00 |    0.00 |
| Set_CustomFastSet | Custom,Set | 11.443 ns | 0.1962 ns | 0.1835 ns | 11.479 ns |  0.85 |    0.01 |
