package behavior.responsibilityChain;

/**
 * @author Alterranius
 */
public class BasicAuthenticationHandler extends AuthenticationHandler {
    protected BasicAuthenticationHandler(AuthenticationHandler next) {
        super(next);
    }

    @Override
    public void handleRequest(RequestType requestType) {
        if (requestType == RequestType.BASIC) {
            System.out.println("Basic Detected");
        } else {
            next.handleRequest(requestType);
        }
    }
}
