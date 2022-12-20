open CyclicQueue

[<EntryPoint>]
let Test _ =
    CyclicQueue.create 8
    printfn "Queue is empty: %A" (CyclicQueue.isEmpty())
    printfn "Queue length: %A" (CyclicQueue.length())
    printfn "Dequeue: %A" (CyclicQueue.dequeue())
    for i = 0 to 7 do
        printfn "Enqueue %i: %A" i (CyclicQueue.enqueue i)
    printfn "Queue is empty: %A" (CyclicQueue.isEmpty())
    printfn "Queue length: %A" (CyclicQueue.length())
    printfn "Dequeue: %A" (CyclicQueue.dequeue())
    printfn "Queue is empty: %A" (CyclicQueue.isEmpty())
    printfn "Queue length: %A" (CyclicQueue.length())
    printfn "Dequeue: %A" (CyclicQueue.dequeue())
    printfn "Queue is empty: %A" (CyclicQueue.isEmpty())
    printfn "Queue length: %A" (CyclicQueue.length())
    printfn "Dequeue: %A" (CyclicQueue.dequeue())
    printfn "Queue is empty: %A" (CyclicQueue.isEmpty())
    printfn "Queue length: %A" (CyclicQueue.length())
    0

//test code for CyclicQueue module
