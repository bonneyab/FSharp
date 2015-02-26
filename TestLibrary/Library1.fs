namespace TestLibrary
open IntegrationServices.Interfaces

type Class1() = 
  interface IIntegration with
    member this.Execute args = 
      //pull data
      //Export data
      printfn "I'm executing!"
    member this.IntegrationName = "Find"
    member this.Directions = "Magically finds a word, these directions can be updated later"

module Logger =
  let log text =
    printfn text

module Searcher = 
  open Logger
  let logFind word line fileName = 
    let test = sprintf "%s found, line %d, file name %s" word line fileName
    log test
  let findWordInDirectory directory word =
    "stuff!"

