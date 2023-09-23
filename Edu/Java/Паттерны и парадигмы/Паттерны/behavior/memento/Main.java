package behavior.memento;

/**
 * @author Alterranius
 */
public class Main {
    public static void main(String[] args) {
        Adder adder = new Adder();
        adder.add(50);
        System.out.println(adder.getResult());
        adder.save();
        adder.add(50);
        System.out.println(adder.getResult());
        adder.undo();
        System.out.println(adder.getResult());

        // "Запоминает" состояния объектов с защитой от потерь
        // АНАЛОГ: "активная" сериализация Externalizable/ кэширование
    }
}
