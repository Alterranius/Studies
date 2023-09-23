package behavior.responsibilityChain;

/**
 * @author Alterranius
 */
public class ClientCertificateAuthenticationHandler extends AuthenticationHandler {
    protected ClientCertificateAuthenticationHandler(AuthenticationHandler next) {
        super(next);
    }

    @Override
    public void handleRequest(RequestType requestType) {
        if (requestType == RequestType.CERTIFICATE) {
            System.out.println("Certificate Detected");
        } else {
            next.handleRequest(requestType);
        }
    }
}
