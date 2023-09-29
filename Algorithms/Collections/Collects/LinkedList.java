package Collects;

/**
 * @author Alterranius
 */
public class LinkedList<E> {
    private int size;
    private Node<E> first;
    private Node<E> last;

    public void add(E e) { last.next = new Node<>(e, null, last); size++; }

    public int size() { return size; }

    public void remove(E e) {
        Node<E> actual = first;
        while (actual.value != e) {
            actual = actual.next;
            if (actual == last) return;
        }
        actual.previous.next = actual.next;
        actual.next.previous = actual.previous;
        actual.next = null;
        actual.previous = null;
        size--;
    }

    private static class Node<E> {
        private E value;
        private Node<E> next;
        private Node<E> previous;

        public Node(E value, Node<E> next, Node<E> previous) {
            this.value = value;
            this.next = next;
            this.previous = previous;
        }
    }
}
