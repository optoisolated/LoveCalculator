# Love Calculator

Enter two names and the app would calculate your 'love' score in the following method:

1. Add up all of the L, O, V, E and S letters in the names.
2. Merge that into a 5 digit number
3. Add each adjacent digit together
4. Repeat until you are left with a number < 100
5. That number is the percentage score.

This function can result in an endless loop, at which point it is assumed the result is 0%

## Example

Bill Gates
LOVES
Melinda Gates

* 10032
* 1+0=1, 0+0=0, 0+3=3, 3+2=5
* 1035
* 1+0=1, 0+3=3, 3+5=8
* 138
* 1+3=4, 3+8=11
* 411
* 4+1=5, 1+1=2

52%
