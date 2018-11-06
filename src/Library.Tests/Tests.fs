namespace Library.Tests

open System
open Microsoft.VisualStudio.TestTools.UnitTesting
open Library.LinkedList

type LL<'T> = LinkedList<'T>

[<TestClass>]
type TestClass () =
    member this.BaseList =
        LL.Node (value = 1, next =
            LL.Node (value = 2, next =
                LL.Node (value = 3, next = Empty)))

    [<TestMethod>]
    member this.LinkedListAppend () =
        let appendedList = append 4 this.BaseList
        let expectedList =
            LL.Node (value = 1, next =
                LL.Node (value = 2, next =
                    LL.Node (value = 3, next =
                        LL.Node (value = 4, next = Empty))))
        Assert.AreEqual(expectedList, appendedList)

    [<TestMethod>]
    member this.LinkedListPrepend () =
        let prependedList = prepend 4 this.BaseList
        let expectedList =
            LL.Node (value = 4, next =
                LL.Node (value = 1, next =
                    LL.Node (value = 2, next =
                        LL.Node (value = 3, next = Empty))))
        Assert.AreEqual(expectedList, prependedList)
