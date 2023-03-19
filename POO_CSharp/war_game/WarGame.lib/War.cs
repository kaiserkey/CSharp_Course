namespace WarGame.lib;

public class War
{
    public void Assault(Soldier soldier)
    {
        soldier.Walk();
        soldier.Run();
        soldier.Shoot();
    }
}
