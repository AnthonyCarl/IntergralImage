IntergralImage
==============

Solution for calculating the integral image. Also times each method based on input size and determines order of growth of each one. http://en.wikipedia.org/wiki/Summed_area_table

Sample Output:

```
Fixed Number of Columns: 128
#####
  Rows      Time   Ratio
    16    0.0056ms   0.7
    32    0.0105ms   1.9
    64    0.0211ms     2
   128     0.043ms     2
:: The ratio is -> 2
#####
  Rows      Time   Ratio
    16    0.0102ms     2
    32    0.0211ms   2.1
    64    0.0417ms     2
   128     0.086ms   2.1
   256     0.189ms   2.2
   512    0.3535ms   1.9
  1024     0.725ms   2.1
  2048    1.0663ms   1.5
  4096    3.7722ms   3.5
  8192     8.714ms   2.3
 16384   13.3172ms   1.5
 32768   38.6288ms   2.9
 65536   79.4701ms   2.1
131072  136.4912ms   1.7
262144  244.4197ms   1.8
524288  488.9265ms     2
1048576 1046.2847ms   2.1
Stopping the madness before all memory are belong to us.
:: The ratio is -> 2
#####
  Rows      Time   Ratio
    16    0.8554ms   3.6
    32    3.2732ms   3.8
    64   12.8812ms   3.9
   128   50.9455ms     4
   256  202.1753ms     4
:: The ratio is -> 4
#####
All Done. Hit enter to quit
```
