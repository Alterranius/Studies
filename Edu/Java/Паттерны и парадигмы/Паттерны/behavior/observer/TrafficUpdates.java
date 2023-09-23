package behavior.observer;

import java.util.ArrayList;
import java.util.List;
import java.beans.*;

/**
 * @author Alterranius
 */
public class TrafficUpdates implements PropertyChangeListener {
    private List<String> updates = new ArrayList<>();

    public List<String> getUpdates() {
        return updates;
    }

    @Override
    public void propertyChange(PropertyChangeEvent event) {
        updates.add((String) event.getNewValue());
    }
}