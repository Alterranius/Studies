package behavior.template;

/**
 * @author Alterranius
 */
public class Pirate extends Unit {

    protected Pirate() {
        super(Weapon.PISTOL);
    }

    @Override
    public void defend() {
        super.defend();
        after();
    }

    public void after() {
        System.out.println("Aggrhhh");
    }
}
