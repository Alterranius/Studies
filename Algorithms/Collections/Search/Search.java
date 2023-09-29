package Search;

import java.util.Map;
import java.util.Optional;

/**
 * @author Alterranius
 */
@FunctionalInterface
public interface Search<T> {
    /**
     * Поиск по обощённым массивам
     * @param in Входящий массив
     * @param element Элемент для поиска
     * @return Номер-значение если найдено, либо null
     */
    Map.Entry<Integer, ? extends T> search(T[] in, T element);
}
