IntergralImage
==============

Solution for calculating the integral image. Also times each method based on input size and determines order of growth of each one. http://en.wikipedia.org/wiki/Summed_area_table

Sample Output:

```
Fixed Number of Columns: 128
##### Running Sum
  Rows      Time   Ratio
    16    0.0052ms   0.7
    32    0.0112ms   2.2
    64    0.0221ms     2
   128    0.0446ms     2
:: The ratio is -> 2
##### Array Access
  Rows      Time   Ratio
    16    0.0112ms   2.2
    32    0.0201ms   1.8
    64      0.04ms     2
   128    0.0804ms     2
:: The ratio is -> 2
##### Brute Force
  Rows      Time   Ratio
    16    0.8505ms   3.6
    32    3.3265ms   3.9
    64    13.004ms   3.9
:: The ratio is -> 3.9
#####
All Done. Hit enter to quit
```
