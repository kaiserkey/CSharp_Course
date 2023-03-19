namespace WarGame.lib;

public class HeavyInfantry : Soldier
{
    // aqui encapsulamos el comportamiento disparar, 
    //el cual sera un poco distinto del de la clase LightInfantry
    protected override void Shoot()
    {
        base.Shoot(); // usar un comportamiento por d
    }

    protected override void Walk()
    {
        throw new System.NotImplementedException();
    }

    protected override void Run()
    {
        throw new System.NotImplementedException();
    }
}
