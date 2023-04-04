using UnityEngine;

[RequireComponent(typeof(EnemyHp))]
public class EnemyMovementMediator : MonoBehaviour
{
    [Header("Components")]
    [SerializeField] private EnemyMeleeMovement _enemyMelee;
    [SerializeField] private EnemyRangeMovement _enemyRange;
    [SerializeField] private EnemyHp _enemyHp;
    private EnemyMovement _currentMovement; 

    [Header("Hp value")]
    private int _hp = 30; 

    private void Awake()
    {
        _enemyHp = GetComponent<EnemyHp>();
        _enemyMelee.enabled = false;
        _enemyRange.enabled = false;
    }

    private void Update()
    {
        if (!_enemyMelee.IsPlayerValid())
            return;
        
        if (_enemyHp.CurrentHp >= _hp)
        {
            _currentMovement = _enemyMelee;
            _currentMovement.Move();
            _currentMovement.Stop();
        }
        else if(_enemyHp.CurrentHp <= _hp)
        {
            _currentMovement = _enemyRange;
            _currentMovement.Move();
            _currentMovement.Stop();
            
        }

    }
}