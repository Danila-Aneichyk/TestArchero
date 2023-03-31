using UnityEngine;

public class DetectPlayer : MonoBehaviour
{
    [SerializeField] private EnemyMovement _enemyMovement;

    private void OnTriggerEnter(Collider col)
    {
        SetPlayer(col.gameObject.transform);
    }

    private void OnTriggerExit(Collider col)
    {
        SetPlayer(null);
    }

    private void SetPlayer(Transform player)
    {
        _enemyMovement.SetPlayer(player);
    }
}