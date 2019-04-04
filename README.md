1. Why do we multiply the value from step 5 above by 4?
   
   The value calculated in step 5 represent only  a quarter of the circle and thus the estimate needs to be multiplied by 4 to cover a full circle.

2. What do you observe in the output when running your program with parameters of increasing size?
   
   The larger the parameter, the closer the π estimate is to the actual value. At 1 million, the estimate is consistently 3.14

3. If you run the program multiple times with the same parameter, does the output remain the same? Why or why not?
   
   Because I used the default constructor of the Random class, which uses the current system time as a seed, running the program with the same parameter generates different random numbers which results in a different π estimate each time.  

4. Find a parameter that requires multiple seconds of run time. What is that parameter? How accurate is the estimated value of π?
   
   With a parameter of a 100 million, the program takes several seconds to run. The estimate is now consistently 3.141 which is provides more precisions.

5. Research one other use of Monte-Carlo methods. 
   
   Monte-Carlo methods are widely used to solve various scientific problems. In electronics engineering, they are used to analyze correlated and uncorrelated variations in analog and digital integrated circuits (source: wikipedia).
