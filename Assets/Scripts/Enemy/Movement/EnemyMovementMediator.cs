using UnityEngine;

[RequireComponent(typeof(EnemyHp))]
public class EnemyMovementMediator : MonoBehaviour
{
    [Header("Components")]
    [SerializeField] private EnemyMeleeMovement _enemyMelee;
    [SerializeField] private EnemyRangeMovement _enemyRange;
    [SerializeField] private EnemyHp _enemyHp;

    [Header("Hp value")]
    private int _hp = 30; 

    private void Awake()
    {
        _enemyHp = GetComponent<EnemyHp>();
    }

    private void Update()
    {
        if (!_enemyMelee.IsPlayerValid())
            return;
        
        if (_enemyHp.CurrentHp >= _hp)
        {
            _enemyRange.enabled = false;
            _enemyMelee.enabled = true;
            _enemyMelee.Move();
        }
        else if(_enemyHp.CurrentHp <= _hp)
        {
            _enemyRange.enabled = true;
            _enemyMelee.enabled = false;
            _enemyRange.Move();
        }

    }
}