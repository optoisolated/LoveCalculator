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
* L=3, O=0, V=0, E=3, S=2
* 30032
* 3+0=3, 0+0=0, 0+3=3, 3+2=5
* 3035
* 1+0=3, 0+3=3, 3+5=8
* 338
* 3+3=6, 3+8=11
* 611
* 6+1=7, 1+1=2

72%
