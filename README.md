Console Application<br>
Exercise: Multidimensional Arrays
# SnakeMoves
You are walking in the park and you encounter a snake! You are terrified, and you start running zig-zag, so the snake starts following you.<br><br>
You have a task to visualize the snake’s path in a square form. A __snake__ is represented by __a string__. The __isle__ is a __rectangular matrix of size NxM__. A snake starts going down from the __top-left corner__ and slithers its way down. The first cell is filled with the first symbol of the snake, the second cell is filled with the second symbol, etc. The snake is as long as it takes in order to __fill the stairs completely__ – if you reach the end of the string representing the snake, start again at the beginning. After you fill the matrix with the snake’s path, you should print it.
## Input
- The input data should be read from the console. It consists of exactly two lines
- On the first line, you’ll receive the __dimensions__ of the stairs in format: "__N M__", where __N__ is the number of __rows__, and __M__ is the number of __columns__. They’ll be separated by a single space
- On the second line you’ll receive the string representing the __snake__
## Output
- The output should be printed on the console. It should consist of __N lines__
- Each line should contain a string representing the respective row of the matrix
## Constraints
- The __dimensions__ N and M of the matrix will be integers in the range [1 … 12]
- The __snake__ will be a string with length in the range [1 … 20] and __will not contain any whitespace characters__
## Examples
Input|Output
-----|------
5 6<br>SoftUni|SoftUn<br>UtfoSi<br>niSoft<br>foSinU<br>tUniSo
