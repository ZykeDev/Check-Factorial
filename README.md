# Inverse Factorial
A dumb algorithm in C# I came up with while falling asleep. Given an int, it returns its inverse factorial.

`IsFact(n)` will return `True` if there exists an `m` so that `m! = n`.

`InverseFact(n)` will instead return `m` itself if it exists. `-1` otherwise.


## Time
In the worst case scenario, `m` exists and each of its factorial components needs to pass through the for-loop. (`1, 2, ..., m-1, m`).
Funnily enough this means `InverseFact(n)` has a time complexity of **O(InverseFact(n))**.
