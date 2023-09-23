package behavior.template;

/**
 * @author Alterranius
 */
public enum Weapon {
    MELEE("Sword"),
    PISTOL("Pistol"),
    NONE("Hands");

    private final String arms;
    Weapon(String arms) {
        this.arms = arms;
    }

    public String getArms() {
        return arms;
    }
}
