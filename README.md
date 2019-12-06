# Unit Testing Assignment- Burr

<h2> Purpose </h2>
The Loan Calculator allows the user to input new or existing loan info and calculate payments based on different time durations, as well as other features. This branch serves to show my unit tests.

<h3> Testing Information </h3>

I used MSTestV2 to provide my unit testing framework. I tested two functions within Schedule.cs: setDuration and roundTotal. 
To test setDuration, I passed a value of "1" as a string into setDuration, set an expected value of 13, and compared the return value of the function with what was expected via an Assert.Equals. 


To test roundTotal, I passed a value of 1.3333 into roundTotal, set an expected value of 1.33, and compared the return value of the function with what was expected via an Assert.Equals.

The tests passed, which means the functions validated input as expected. 
