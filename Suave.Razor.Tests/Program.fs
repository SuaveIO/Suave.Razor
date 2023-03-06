open Suave
open Suave.Filters
open Suave.Operators
open Suave.Razor
open System.Diagnostics

type Model = { bar : string }

let dummy = typeof<NonFactors.Mvc.Grid.Grid<Model>>
// This is needed so the compiler does not strip away the reference.
Debug.WriteLine("Hold on to {0}",dummy.ToString())

type Entry = { name : string; age : int }

type Model1 = 
  { bar : string
  ; data : Entry list }

let testApp = 
  choose [ 
    path "/grid" >=> razor "grid" { bar = "World"}
    path "/test1" >=> razor "test1" { bar = "World"}
    path "/test2" >=> razor "test2" { bar = "Champion"; data = [ { name = "abel"; age = 27 }; { name = "cain"; age = 99 }]}
    Files.browseHome
    RequestErrors.NOT_FOUND "File not found."]

startWebServer defaultConfig testApp