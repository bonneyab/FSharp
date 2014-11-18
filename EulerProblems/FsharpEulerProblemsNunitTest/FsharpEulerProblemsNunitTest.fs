module FsharpEulerProblemsNunitTest

// https://github.com/fsharp/FsCheck/blob/master/Docs/Documentation.md
// https://github.com/fsharp/FsUnit
// https://code.google.com/p/unquote/

open FsUnit
open FsCheck
open NUnit.Framework
open Swensen.Unquote
open FSharpEulerProblems

[<Test>]
let ``Problem 1 should return 23 for 10``() = 
    let multiples = [3; 5]
    Assert.AreEqual(23, Problem1.GetSumOfMultiplesBelowNumber multiples 10)

[<Test>]
let ``Problem 1 should return 233168 for 1000``() = 
    let multiples = [3; 5]
    Assert.AreEqual(233168, Problem1.GetSumOfMultiplesBelowNumber multiples 1000)

[<Test>]
let ``Problem 2 should return 44 for 100``() = 
  Assert.AreEqual(44, Problem2.FibonacciGetSumBelowMax 100)
  
[<Test>]
let ``Problem 2 should return 44 for 4000000``() = 
  Assert.AreEqual(4613732, Problem2.FibonacciGetSumBelowMax 4000000)
  
[<Test>]
let ``Problem 3 should return 29 for 13195``() = 
  Assert.AreEqual(29, Problem3.GetLargetPrimeFactor 13195)

[<Test>]
let ``Problem 4 should return 9009 for 99``() = 
  Assert.AreEqual(9009, Problem4.GetLargestPalindromeProduct 99)

[<Test>]
let ``Problem 5 should return 2520 for 10``() = 
  Assert.AreEqual(2520, Problem5.getSmallestNumberDivisibleByNumbers 10)