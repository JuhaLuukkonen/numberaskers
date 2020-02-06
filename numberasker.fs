open System

let main() = 
    let answer = (new Random()).Next(1, 100)
    printfn "Guess the number between 1 and 100" 
    let rec dummyWhileTrue(tries) = 
        let v = Console.ReadLine() 
        if v = "q" then 
            printfn "you have quit"
            0
        else
            printfn "blah" 
            let mutable n = 0
            let b = Int32.TryParse(v, &n) 
            if b = false then 
                printfn "This is not a number"
                dummyWhileTrue(tries)
            elif n = answer then 
                printfn "Correct! You win!"
                tries
            elif n < answer then 
                printfn "Guess higher"
                dummyWhileTrue(tries+1) 
            else // n>answer
                printfn "Guess lower"
                dummyWhileTrue(tries+1) 
    let tries = dummyWhileTrue(1) 
    printfn "You guess %d times" tries
    printfn "Press enter to exit"
    Console.ReadLine()  |> ignore
main() 