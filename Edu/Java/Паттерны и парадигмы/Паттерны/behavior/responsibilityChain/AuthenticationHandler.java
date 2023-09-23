package behavior.responsibilityChain;

/**
 * @author Alterranius
 */
public abstract class AuthenticationHandler {
    protected AuthenticationHandler next;

    protected AuthenticationHandler(AuthenticationHandler next) {
        this.next = next;
    }
    public abstract void handleRequest(RequestType requestType);
}
