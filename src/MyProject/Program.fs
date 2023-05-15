// For more information see https://aka.ms/fsharp-console-apps
// printfn "Hello from F#"


// 1. Agrego la biblioteca a este proyecto con
// dotnet add reference ../../src/MyLibrary/MyLibrary.fsproj
// estando en el directorio del proyecto

open MyLibrary
// o
// importo el modulo con
// open MyLibrary.Say

[<EntryPoint>]

let main args =
    Say.hello "Camila"
    //printfn "Hello World from F#!"
    MyLibrary.Math.imprimeAdd 2 3
    0 // return an integer exit code
