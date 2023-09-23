package behavior.interpreter;

/**
 * @author Alterranius
 */
public class FirstLetterIsLowerCase implements Expression {
    private NameNotPrimitive nameNotPrimitive = new NameNotPrimitive();
    @Override
    public String interpret(String context) {
        context = context.substring(0, 1).toLowerCase() + context.substring(1);
        return nameNotPrimitive.interpret(context);
    }
}
