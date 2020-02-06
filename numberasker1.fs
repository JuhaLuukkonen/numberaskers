open System

let main() = 
    let answer = (new Random()).Next(1, 100)
    printfn "Guess the number between 1 and 100" 
    let rec TryLoop(tries) = 
        let doneWith(t) = t
        let notDoneWith(s, t) = printfn s; TryLoop(t) 
        match Console.ReadLine() with
        | "q" -> doneWith 0
        | s -> 
            match Int32.TryParse(s) with
            | true, v when v = answer -> doneWith(tries)
            | true, v when v < answer -> notDoneWith("Guess higher", tries + 1) 
            | true, v when v > answer -> notDoneWith("Guess lower", tries + 1)
            | _ -> notDoneWith("This is not a number", tries)

    match TryLoop(1) with
        | 0 -> printfn "You quit, loser!"
        | tries -> printfn "Correct! You win!\nYou guessed %d times" tries

    printfn "Hit enter to exit"
    Console.ReadLine()  |> ignore
main() 