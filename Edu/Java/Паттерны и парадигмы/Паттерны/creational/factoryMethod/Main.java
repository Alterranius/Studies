package creational.factoryMethod;

import java.util.ArrayList;
import java.util.List;

/**
 * @author Alterranius
 */
public class Main {
    public static void main(String[] args) {
        CandyFactory factory = new ChocolateFactory();
        List<Candy> pack = new ArrayList<>();
        pack.addAll(CandyStore.getCandyPackage(5, factory.create()));
        factory = new PieFactory();
        pack.addAll(CandyStore.getCandyPackage(3, factory.create()));

        System.out.println(pack);

        // Если ось изменений проходит по типу подкласса, неизвестно какие типы нужно будет создавать. Особенно подходит для линеек расширения
        // АНАЛОГ: покупка разных типов конфет

    }
}
