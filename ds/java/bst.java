package ds.java;

public class bst
{
    public static void main(String[] args){
        int[] unsortedArray = {4,3,2,8,9,1,15,11,6};
        Tree tree = new Tree(unsortedArray);
        System.out.println(tree.toString());
    }
}

class Tree{
    private Node head = null;

    // takes in an array of values to instantiate as a binary search tree
    public Tree(int[] values){
        for(int value : values){
            this.head = this.insertNode(this.head, value);
        }
    }

    public Node insertNode(Node root, int currentValue){
        // set first value as head
        if(root == null){
            root = new Node(currentValue);
        } else if(currentValue < root.getValue()){
            Node node = insertNode(root.getLeft(), currentValue);
            root.setLeft(node);
        } else {
            Node node = insertNode(root.getRight(), currentValue);
            root.setRight(node);
        }
        return root;
    }

    @Override
    public String toString(){
        String output = "";
        int index = 0;
        Node currentNode = head;
        if(currentNode.getLeft() != null){
            index++;
            output += "Node " + index + ": " + currentNode.getLeft().toString() + '\n';
        }
        index++;
        output += "Node " + index + ": " + currentNode.toString() + '\n';
        if(currentNode.getRight() != null){
            index++;
            output += "Node " + index + ": " + currentNode.getRight().toString() + '\n';
        }
        return output;
    }
}

class Node{
    private Node left;
    private Node right;
    private int value;

    public Node(int value){
        this.value = value;
    }

    public int getValue(){
        return this.value;
    }

    public Node getLeft(){
        return this.left;
    }

    public Node getRight(){
        return this.right;
    }

    public void setLeft(Node node){
        this.left = node;
    }

    public void setRight(Node node){
        this.right = node;
    }

    @Override
    public String toString(){
        return value + "";
    }
}