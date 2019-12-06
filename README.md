# Software Design Pattern Assignment- Burr

## Purpose
The Loan Calculator allows the user to input new or existing loan info and calculate payments based on different time durations, as well as other features. This branch serves to show my implication of the singleton design pattern.

<h2> Design Pattern Information <h2> 
I chose to implement the singleton design pattern. This design pattern is characterized by running a single instance of a program, and by a "trickle-down" of information. I applied this pattern in the Schedule.cs file. The file takes information from PayOptions, the class above it, which also takes info from the class above that. The design of the program allows only one instance of each form to be open, which means that it is single instance, also per the design pattern rules.
