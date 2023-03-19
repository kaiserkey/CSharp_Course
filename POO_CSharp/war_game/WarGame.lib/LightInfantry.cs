namespace WarGame.lib;

public class LightInfantry : Soldier
{
    /* Encapsulamos el comportamiento de nuestros metodos
        public, private, protected, internal
     */
    // aqui encapsulamos el comportamiento disparar
    public override void Shoot()
    {
        base.Shoot();
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
