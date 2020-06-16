open Suave
open Suave.Filters
open Suave.Operators
open Suave.Razor

type Model = { bar : string }

let testApp = 
  choose [ 
    path "/test1" >=> razor "test1" { bar = "World"}
    path "/test2" >=> razor "test2" null
    RequestErrors.NOT_FOUND "File not found."]

startWebServer defaultConfig testApp