namespace WarGame.lib;

public class War
{
    public void Assault(Soldier soldier)
    {
        soldier.Shoot();
        soldier.Walk();
        soldier.Run();
    }
}
