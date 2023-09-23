package behavior.interpreter;

/**
 * @author Alterranius
 */
public class NameNotPrimitive implements Expression {
    @Override
    public String interpret(String context) {
        if (context.equals("int") || context.equals("boolean")) {
            context = context + "1";
        }
        return context;
    }
}
