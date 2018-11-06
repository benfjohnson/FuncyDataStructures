namespace Library

module LinkedList =
    type LinkedList<'T> =
        | Empty
        | Node of value: 'T * next: LinkedList<'T>

    let rec append el list =
        match list with
            | Empty -> Node (value = el, next = Empty)
            | Node (value, next) -> Node (value = value, next = (append el next))

    let prepend el list = Node (value = el, next = list)

    let rec printList l =
        match l with
            | Empty -> printfn "No more?!"
            | Node (value, next) ->
                printfn "We eatin'!! %O" value
                printList next
