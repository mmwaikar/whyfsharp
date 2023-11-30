# Why F#

> Notebooks explaining why one should embrace :hugs: F#.

Before we look into some of the features of F#, let's dive into why to use Functional Programming (FP) languages.

---

## Functional Programming

Functional programming is a programming paradigm in which we try to bind everything in **pure** mathematical functions style. It is a ***declarative*** type of programming style. Its main focus is on ***what to solve*** in contrast to an imperative style where the main focus is ***how to solve***.

## Advantages of FP -

| # | Highlight | Which means | Which implies |
|-- |-----------|----------------|---------------|
| 1 | Functions | Classes not required | Less code |
| 2 | Pure functions | no side effects (but there are ways to minimize / handle it) | Easier to understand and test |
| 3 | Referential transparency | You can replace the function call with the value (*only possible because of 2*) | Easier to understand |
| 4 | Immutable data structures | Can't modify existing collections / data | Less shared state, so easier concurrency, parallelism |

### FP languages which I've used

I've used 3 FP languages, out of which 2 are on JVM and 1 on DotNet.

- JVM
  - [Clojure](https://clojure.org/) - dynamic
  - [Scala](https://www.scala-lang.org/) - typed (mixed FP / OO)

- DotNet
  - [F#](https://fsharp.org/) - typed (mixed FP / OO)

## Features unique to each programming language

| Language | Feature | Used for |
|----------|---------|----------|
| Clojure | Macros | Allows the compiler to be extended by user code |
|  | **Only immutable** data structures | |
| Scala | Effect systems ([Cats Effect](https://typelevel.org/cats-effect/)) | The pure asynchronous runtime for Scala |
|  | Effect systems ([ZIO](https://zio.dev/)) | Type-safe, composable asynchronous and concurrent programming for Scala |
| F# | Type Providers | Provides types, properties, and methods for use in your program, generated by the compiler, based on an external data source |
| | Units of Measure | Allow programmers to annotate floats and integers with statically-typed unit metadata |

# So why F#?

- F# is a modern functional first, mixed FP-OO language from the ML family
- Cross platform
- Strong type inference
- Ability to compile to [multiple targets](https://fable.io/docs/#available-targets) (through [Fable](https://fable.io/), JS, Rust, Python, Dart)

## Static vs. Dynamic

F# completely *side steps* the static vs. dynamic debate and is at the **golden middle sweet-spot**. The compiler is strong enough to `infer types` in most cases, so write your code in a dynamic fashion to your heart's content, but if you want intellisense and other advantages, specify types only for the things (parameters) you need, **or** when the compiler can't infer types for you.
