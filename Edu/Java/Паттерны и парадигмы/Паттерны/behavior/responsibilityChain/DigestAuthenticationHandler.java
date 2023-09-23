package behavior.responsibilityChain;

/**
 * @author Alterranius
 */
public class DigestAuthenticationHandler extends AuthenticationHandler {
    protected DigestAuthenticationHandler(AuthenticationHandler next) {
        super(next);
    }

    @Override
    public void handleRequest(RequestType requestType) {
        if (requestType == RequestType.DIGEST) {
            System.out.println("Digest Detected");
        } else {
            next.handleRequest(requestType);
        }
    }
}
