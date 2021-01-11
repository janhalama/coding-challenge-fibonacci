# The Fibonacci Sequence

The Fibonacci sequence appears in nature all around us, in the arrangement of seeds in a sunflower and the spiral of a nautilus for example.

The Fibonacci sequence begins with Fibonacci.Calculate(0) = 1 and Fibonacci.Calculate(1) = 1 as its first and second terms. After these first two elements, each subsequent element is equal to the sum of the previous two elements.

## Programmatically:

```
Fibonacci.Calculate(0) = 1
Fibonacci.Calculate(1) = 1
Fibonacci.Calculate(n) = Fibonacci.Calculate(n - 1) + Fibonacci.Calculate(n - 2)
```

## Function Description

Complete the recursive function `Fibonacci.Calculate`. It must return the nth  element in the Fibonacci sequence.

`Fibonacci.Calculate` has the following parameter(s):

n: the integer index of the sequence to return

The input line contains a single integer, n.

Constraints
```
 0 < n <= 30 
```

Output Format

`Fibonacci.Calculate` function returns integer.

Sample Input

```
3  
```
Sample Output

```
3
```

## Explanation

The Fibonacci sequence begins as follows:

```
Fibonacci.Calculate(0) = 1
Fibonacci.Calculate(1) = 1
Fibonacci.Calculate(2) = 2
Fibonacci.Calculate(3) = 3
Fibonacci.Calculate(4) = 5
Fibonacci.Calculate(5) = 8
Fibonacci.Calculate(6) = 13
```

We want to know the value of Fibonacci.Calculate(3) In the sequence Fibonacci.Calculate(3] above, evaluates to 3.