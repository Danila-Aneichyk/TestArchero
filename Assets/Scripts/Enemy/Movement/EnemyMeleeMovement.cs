using UnityEngine;

public class EnemyMeleeMovement : EnemyMovement
{
    public override void Move()
    {
        Debug.Log("Melee Movement");
        Vector3 direction = Player.position - transform.position; 
        transform.Translate(direction.normalized * (_speed * Time.deltaTime)); 
    }
}