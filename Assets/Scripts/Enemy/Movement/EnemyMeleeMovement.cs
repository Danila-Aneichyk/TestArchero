using UnityEngine;

public class EnemyMeleeMovement : EnemyMovement
{
    public override void Move()
    {
        Vector3 direction = (Player.position - _cachedTransform.position).normalized;
        SetVelocity(direction * _speed);
    }
}