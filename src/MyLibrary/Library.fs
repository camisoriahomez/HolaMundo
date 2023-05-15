namespace MyLibrary

module Say =
    let hello name =
        printfn "Hello %s" name

    let imprimeFloat (x:float) =
        printfn $"El float es %f{x}"