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
  
[<Test>]
let ``Problem 6 should return 2640 for 10``() = 
  Assert.AreEqual(2640, Problem6.sumSquaresSquareSumsDifference 10)

[<Test>]
let ``Problem 7 should return 104743 for 10001``() = 
  //Assert.AreEqual(13, Problem7.getSpecificPrime 6)
  Assert.AreEqual(104743, Problem7.getSpecificPrime 10001)

[<Test>]
let ``Problem 8 should return 40824 for Ginourmous number``() =
  Assert.AreEqual(40824, Problem8.getMaxMultipleFromStringNumber "7316717653133062491922511967442657474235534919493496983520312774506326239578318016984801869478851843858615607891129494954595017379583319528532088055111254069874715852386305071569329096329522744304355766896648950445244523161731856403098711121722383113622298934233803081353362766142828064444866452387493035890729629049156044077239071381051585930796086670172427121883998797908792274921901699720888093776657273330010533678812202354218097512545405947522435258490771167055601360483958644670632441572215539753697817977846174064955149290862569321978468622482839722413756570560574902614079729686524145351004748216637048440319989000889524345065854122758866688116427171479924442928230863465674813919123162824586178664583591245665294765456828489128831426076900422421902267105562632111110937054421750694165896040807198403850962455444362981230987879927244284909188845801561660979191338754992005240636899125607176060588611646710940507754100225698315520005593572972571636269561882670428252483600823257530420752963450")
