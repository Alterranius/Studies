package behavior.template;

/**
 * @author Alterranius
 */
public class Troll extends Unit {
    protected Troll() {
        super(Weapon.MELEE);
    }

    @Override
    public void defend() {
        super.defend();
        goBack();
    }

    public void goBack() {
        System.out.println("Return to the mountain");
    }
}
