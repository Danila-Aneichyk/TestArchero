using UnityEngine;

public class EnemyFactoryMediator : MonoBehaviour
{
    [SerializeField] private EnemyMarker[] _enemyMarkers;

    private EnemyFactory _enemyFactory;

    private void Start()
    {
        _enemyFactory = FindObjectOfType<EnemyFactory>(); 
        
        _enemyFactory.Load();
            
        foreach (EnemyMarker enemyMarker in _enemyMarkers)
        {
            _enemyFactory.Create(enemyMarker.EnemyType, enemyMarker.transform.position);    
        }

    }
}