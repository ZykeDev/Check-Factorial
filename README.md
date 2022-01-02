# Inverse Factorial
A dumb algorithm in C# I came up with while falling asleep. Given an int, it returns its inverse factorial.

`IsFact(n)` returns `True` if there exists an `m` so that `m! = n`.

`InverseFact(n)` returns `m` itself if it exists. `-1` otherwise.


## Time Complexity
In the worst case scenario `m` exists, and each of its factorial components needs to pass through the for-loop (`1, 2, ..., m-1, m`).
Funnily enough this means the time complexity of `InverseFact(n)` can be found by applying the function itself: **O(InverseFact(n))**.
By using the [inverted exclamation mark](https://en.wikipedia.org/wiki/Inverted_question_and_exclamation_marks) as a symbol for the inverted factorial, I jockingly write it as **O(n¡)**.

On a more serious note, I believe the inverse of the [Gamma function](https://en.wikipedia.org/wiki/Gamma) is typically used when talking about inverse factorials, so a more appropriate limit could be written as **O(Γ^-1(n))**.
