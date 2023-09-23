package structural.proxy;

/**
 * @author Alterranius
 */
public class Main {
    public static void main(String[] args) {
        DisplayObject image1 = new ImageProxy("D:\\Programming\\Java\\Работа\\Карта.jpg");
        DisplayObject image2 = new ImageProxy("D:\\Programming\\Java\\Работа\\Карта.jpg");
        DisplayObject image3 = new ImageProxy("D:\\Programming\\Java\\Работа\\Карта.jpg");
        DisplayObject image4 = new ImageProxy("D:\\Programming\\Java\\Работа\\Карта.jpg");
        DisplayObject image5 = new ImageProxy("D:\\Programming\\Java\\Работа\\Карта.jpg");
        DisplayObject image6 = new ImageProxy("D:\\Programming\\Java\\Работа\\Карта.jpg");
        DisplayObject image7 = new ImageProxy("D:\\Programming\\Java\\Работа\\Карта.jpg");
        DisplayObject image8 = new ImageProxy("D:\\Programming\\Java\\Работа\\Карта.jpg");
        DisplayObject image9 = new ImageProxy("D:\\Programming\\Java\\Работа\\Карта.jpg");

        image1.display();
        image2.display();
        image3.display();
        image4.display();
        image5.display();
        image6.display();
        image7.display();
        image8.display();
        image9.display();

        // Прокладка для обмена сообщениями, например для уменьшения затрат на операции
        // АНАЛОГ: прокси-сервер: псевдосерверная прокладка, которая формирует тело запроса, LAZY
    }
}
