namespace WarGame.lib;

/* Esta clase es abstracta para que no se pueda instanciar y solo pueda ser heredada */
public abstract class Soldier
{
    /* Le decimos a los metodos que sean protected para que  puedan ser accedidos por
        la clase que heredan 
    */
    protected abstract void Walk();

    protected abstract void Run();
}
