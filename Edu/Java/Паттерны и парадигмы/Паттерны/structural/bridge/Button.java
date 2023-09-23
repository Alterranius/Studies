package structural.bridge;

/**
 * @author Alterranius
 */
public abstract class Button implements Size {
    ButtonSizes size;

    public Button(ButtonSizes size) {
        this.size = size;
    }

    @Override
    public ButtonSizes getSize() {
        return size;
    }
}
