package behavior.responsibilityChain;

/**
 * @author Alterranius
 */
public class Main {
    public static void main(String[] args) {
        Client client = new Client();
        AuthenticationHandler handler = new BasicAuthenticationHandler(new DigestAuthenticationHandler(new ClientCertificateAuthenticationHandler(null)));
        client.sendBasicRequest(handler);
        client.sendDigestRequest(handler);
        // Цепочка проходит в заданном порядке обработку
        // Можно сделать конечный узел

        // АНАЛОГ: сервис-колл центры
    }
}
