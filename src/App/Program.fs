// Learn more about F# at http://fsharp.org

open Library.LinkedList

[<EntryPoint>]
let main _ =
    printfn "Hello World from F#!"

    // Build a Linked List:
    let linkedList = Node (value = "Hey!", next = Node (value = "Ho!", next = Node (value = "Lehhhgo!", next = Empty)))
    printList linkedList
    0 // return an integer exit code
