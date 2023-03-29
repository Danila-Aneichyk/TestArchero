using UnityEngine;

public interface IEnemyFactory
{
    public void Load();
    public void Create(EnemyType enemyType, Vector3 enemyPosition); 
}