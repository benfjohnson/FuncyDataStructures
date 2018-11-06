namespace Library

module LinkedList =
    type LinkedList<'T> =
        | Empty
        | Node of value: 'T * next: LinkedList<'T>

    let rec printList l =
        match l with
            | Empty -> printfn "No more?!"
            | Node (value, next) ->
                printfn "We eatin'!! %O" value
                printList next
