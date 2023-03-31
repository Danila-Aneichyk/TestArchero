using UnityEngine;

public class EnemyMarker : MonoBehaviour
{
    public EnemyType EnemyType;
    private float _radius = 0.1f; 

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawSphere(transform.position, _radius);
        Gizmos.color = Color.white;        
    }
}