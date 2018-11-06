namespace Library

module BinaryTree =
  type BinaryTree<'T> =
  | Empty
  | Node of value: 'T * left: BinaryTree<'T> * right: BinaryTree<'T>
