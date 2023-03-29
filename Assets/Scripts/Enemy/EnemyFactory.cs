using UnityEngine;

public class EnemyFactory : MonoBehaviour, IEnemyFactory
{
    private Object _zombiePrefab;
    
    private const string Zombie = "Zombie";
    
    public void Load()
    {
        _zombiePrefab = Resources.Load(Zombie) as GameObject;
    }

    public void Create(EnemyType enemyType, Vector3 enemyPosition)
    {
        switch (enemyType)
        {
            case EnemyType.Zombie:
                Instantiate(_zombiePrefab, enemyPosition, Quaternion.identity, null);
                break;
        }
    }
}