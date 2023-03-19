namespace WarGame.lib;

public class War
{

    public War(){
        Assault(LightInfantry());
    }
    public void Assault(Soldier soldier)
    {
        soldier.Shoot();
    }
}
