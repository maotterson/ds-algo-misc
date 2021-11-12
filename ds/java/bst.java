package ds.java;

public class bst
{
    public static void main(String[] args){
        Node head = new Node(1);

        System.out.println(head);
    }
}

class Node{
    private Node left;
    private Node right;
    private int value;

    public Node(int value){
        this.value = value;
    }

    @Override
    public String toString(){
        return value + "";
    }
}