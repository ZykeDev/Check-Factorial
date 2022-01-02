# Inverse Factorial
A dumb algorithm in C# I came up with while falling asleep. Given an int, it returns its inverse factorial.

`IsFact(n)` will return `True` if there exists an `m` so that `m! = n`.

`InverseFact(n)` will instead return `m` itself if it exists. `-1` otherwise.


## Time Complexity
In the worst case scenario `m` exists, and each of its factorial components needs to pass through the for-loop (`1, 2, ..., m-1, m`).
Funnily enough this means `InverseFact(n)` has a time complexity of **O(n¡)**, where I have taken the liberty of using the upside-down exlamation point as a symbol for the inverted factorial.

Less jokingly, I believe the inverse of the [Gamma function](https://en.wikipedia.org/wiki/Gamma) is usually employed when talking about inverse factorials, so a more appropriate limit could be written as **O(Γ^-1(n))**.
