# Trees

### What are trees and why are they important?
Imagine you're organizing a family tree. You start with your grandparents at the top and then add branches for each of their children, and further branches for their grandchildren, and so on. This hierarchical structure is a perfect analogy for a tree data structure.

A tree is a data structure that simulates a hierarchical tree structure with a root value and subtrees of children, represented as a set of linked nodes. Each node contains a value and references to its children. Trees are essential in various applications, such as representing hierarchical data, managing sorted data, facilitating fast lookup operations, and more.

### Trees in Programming
In programming, trees are widely used in different scenarios such as file systems, databases, and managing hierarchical data. The most common types of trees include binary trees, binary search trees, AVL trees, and B-trees.

# Examples
## Creating the root
```csharp
root = Node(1);
```
## Adding child nodes
```csharp
root.left = Node(2)
root.right = Node(3)
root.left.left = Node(4)
root.left.right = Node(5)
```

## Tree Traversal
Traversal is a process to visit all the nodes of a tree. There are three main types of tree traversal:

In-order Traversal: Visit the left subtree, the root, and then the right subtree.
Pre-order Traversal: Visit the root, the left subtree, and then the right subtree.
Post-order Traversal: Visit the left subtree, the right subtree, and then the root.
### Example of In-order Traversal
```csharp
void InOrderTraversal(Node root)
{
    if (root != null)
    {
        InOrderTraversal(root.left);
        Console.Write(root.val + " ");
        InOrderTraversal(root.right);
    }
}

InOrderTraversal(root); // Output: 4 2 5 1 3
```
## Example Problems
Let's try an example.

Your task is to write a function that checks whether a binary tree is a valid binary search tree (BST). A BST is a tree where all nodes follow the below properties:

The left subtree of a node contains only nodes with keys less than the node’s key.
The right subtree of a node contains only nodes with keys greater than the node’s key.
Both the left and right subtrees must also be binary search trees.
Try the problem on your own first, then look at my solution if needed.

[Tree Solution](example_solution.cs)
