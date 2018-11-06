// Learn more about F# at http://fsharp.org

open Library.LinkedList
open Library.BinaryTree

type LL<'T> = LinkedList<'T>
type BT<'T> = BinaryTree<'T>

[<EntryPoint>]
let main _ =
    printfn "Hello World from F#!"

    // build a linked list:
    let linkedList = LL.Node (value = "Hey!", next = LL.Node (value = "Ho!", next = LL.Node (value = "Lehhhgo!", next = LL.Empty)))
    printList linkedList

    // build a binary tree:
    let binaryTree =
        BT.Node (
            value = 1, left = BT.Node (
                value = 2, left = Empty, right = BT.Node (
                    value = 3, left = Empty, right = Empty
                )
            ), right = Empty
        )
    printTree binaryTree
    0 // return an integer exit code
