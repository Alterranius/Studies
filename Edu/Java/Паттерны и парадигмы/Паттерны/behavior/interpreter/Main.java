package behavior.interpreter;

/**
 * @author Alterranius
 */
public class Main {
    public static void main(String[] args) {
        String context = "_Int";
        Expression firstLetterNotUnderscore = new FirstLetterNotUnderscore();
        context = firstLetterNotUnderscore.interpret(context);
        System.out.println(context);
        // Создаёт дерево перевода, по результату прохода получается экземпляр
        // АНАЛОГ: конвеер преобзований перед выдачей
    }
}
