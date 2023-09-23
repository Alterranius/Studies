package behavior.responsibilityChain;

/**
 * @author Alterranius
 */
public class Client {
    public void sendBasicRequest(AuthenticationHandler authenticationHandler) {
        authenticationHandler.handleRequest(RequestType.BASIC);
    }

    public void sendDigestRequest(AuthenticationHandler authenticationHandler) {
        authenticationHandler.handleRequest(RequestType.DIGEST);
    }
}
