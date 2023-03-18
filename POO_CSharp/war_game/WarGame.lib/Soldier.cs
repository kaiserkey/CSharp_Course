﻿namespace WarGame.lib;

/* Esta clase es abstracta para que no se pueda instanciar y solo pueda ser hererada */
public abstract class Soldier
{
    protected abstract void Walk();

    protected abstract void Run();
}
