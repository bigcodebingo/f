let circleArea r = 
    let pi = 3.14159
    pi * r * r
 
let cylindreVolume r h =
    h * circleArea r
 
let main () =
    // суперпозиция
    printfn "Введите радиус цилиндра:"
    let radius = System.Console.ReadLine() |> float
    printfn "Введите высоту цилиндра:"
    let height = System.Console.ReadLine() |> float
    let calculateVolume = circleArea >> ((*) height)
    let volume = calculateVolume radius

    printfn "Объем цилиндра (суперпозиция): %f" volume

    // каррирование
    printfn "\nВведите радиус цилиндра:"
    let radius2 = System.Console.ReadLine() |> float
    printfn "Введите высоту цилиндра:"
    let height2 = System.Console.ReadLine() |> float

    let calculateVolume2 = cylindreVolume radius2 
    let volume2 = calculateVolume2 height2

    printfn "Объем цилиндра (каррирование): %f" volume2

    printfn "\nНажмите любую клавишу для выхода..."
    System.Console.ReadKey() |> ignore

main()