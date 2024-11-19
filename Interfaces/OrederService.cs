namespace Interfaces;

public class OrederService
{

    private BaseLogger logger;

    // Das hier ist ein konkretes Beispiel für das Designpattersn Dependency-Injection
    //Mit DI lassen sich Abhängigkeit aus einer Klasse heraus extrahieren und auf den Caller
    // Nutzer der klasse übertragen.
    public OrederService(BaseLogger logger)
    {
        this.logger = logger;
    }

    public void ProcessOrder(string orderID)
    {
        /*Hier den Logger zu instanziieren macht diese Klasse abhängig von der
        spezifischen Logge-implementation
        Wenn die Logger-Implementation ausgetauscht werden soll, kann dies zu viel
        Arbeit führen, je nach Größe der Klasse. !Abhängigkeit */
       // var logger = new Logger();

        logger.Log($"Order {orderID} is being processed...");
        Thread.Sleep(1000);
        logger.Log($"Order {orderID} processed succesfully");
        Thread.Sleep(1000);
        logger.Log($"Order {orderID} processin complete!");
    }
}
 