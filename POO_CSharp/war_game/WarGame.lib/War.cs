namespace WarGame.lib;

public class War
{

    public War(){
        Assault(new LightInfantry());
    }
    public void Assault(Soldier soldier)
    {
        soldier.Shoot();
    }
}
