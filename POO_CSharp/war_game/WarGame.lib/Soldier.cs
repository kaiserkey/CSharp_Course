namespace WarGame.lib;

/* Esta clase es abstracta para que no se pueda instanciar y solo pueda ser heredada */
public abstract class Soldier
{
    /* Le decimos a los metodos que sean protected para que  puedan ser accedidos por
        la clase que heredan y abstract para que no se puedan instanciar indicando
        que se deben reescribir
    */
    protected abstract void Walk();

    protected abstract void Run();
}

/* 
    Otra manera de abstraer un concepto 
 */
