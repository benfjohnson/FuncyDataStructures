namespace Library

module BinaryTree =
    type BinaryTree<'T> =
        | Empty
        | Node of value: 'T * left: BinaryTree<'T> * right: BinaryTree<'T>

    let rec printTree tree =
        match tree with
            | Empty -> printfn "Nothing in thishur shrubbery!"
            | Node (value,left, right) ->
                printfn "Found a thing: %O" value
                printTree left
                printTree right
