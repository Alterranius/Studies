package behavior.template;

/**
 * @author Alterranius
 */
public abstract class Unit {
    protected final Weapon weapon;

    protected Unit(Weapon weapon) {
        this.weapon = weapon;
    }

    public void defend() {
        pickUp();
        getReady();
    }

    public final void pickUp() {
        System.out.println("Pick up " + weapon.getArms());
    }

    public final void getReady() {
        System.out.println("Defend with " + weapon.getArms());
    }
}
