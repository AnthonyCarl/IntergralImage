IntergralImage
==============

Solution for calculating the integral image. Also times each method based on input size and determines order of growth of each one. http://en.wikipedia.org/wiki/Summed_area_table

Sample Output:

```
Running Sum has correct result -> True
Array Access has correct result -> True
Brute Force has correct result -> True
#####
Fixed Number of Columns: 128
##### Running Sum
    Rows        Time   Ratio
      16      0.0417ms   1.9
      32      0.0996ms   2.4
      64      0.1705ms   1.7
     128      0.3383ms     2
     256      0.6786ms     2
:: The ratio is -> 2
##### Array Access
    Rows        Time   Ratio
      16      0.0609ms   1.8
      32      0.1231ms     2
      64      0.2519ms     2
:: The ratio is -> 2
##### Brute Force
    Rows        Time   Ratio
      16      6.7107ms   3.8
      32     26.1965ms   3.9
      64    127.5424ms   4.9
     128    404.2672ms   3.2
     256   1610.4762ms     4
     512   6449.9451ms     4
:: The ratio is -> 4
#####
All Done. Hit enter to quit

```
