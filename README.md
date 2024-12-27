This is the documentation for a calculator application I caded in C#.
The way the app works is that unlike most other calculator applications showcased online, this one has two fields and captures the expression as a whole. This allows the user to enter a full mathematical expression into the input field and correct mistakes or change the expression however thney see fit (even after the results of the sum are calculated).

This was done by using 4 main steps:
1. All of the numbers, parentheses and operators are entered into a textbox
2. The entire expression is captured as a string
3. Parentheses are used to create substrings and operators separate the numbers from one another
4. The input is then run through a method that converts each substring so that it can be viewed by Visual Studio as a mathematical expression which is then outputed as a double.

This was done along with basic calculator functions like a 'clear all' function which clears both the input textbox and results textbox and a backspace button which works by finding the index of the last character in the input textbox and eliminating it.
