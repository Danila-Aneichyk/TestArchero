using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class EnemyRangeBehaviour : MonoBehaviour
{
    [Header("Run away values")]
    [SerializeField] private float _retreatDistance = 3f;
    
    [Header("Physics")]
    private Vector3 _cachedTransform;
    
    [Header("Components")]
    private GameObject _player;
    private NavMeshAgent _agent;
    

    void Start()
    {
        _agent = GetComponent<NavMeshAgent>();
        _player = GameObject.FindWithTag("Player");
        _cachedTransform = transform.position; 
    }

    void Update()
    {
        MoveToSafeZone();
    }

    private void MoveToSafeZone()
    {
        float distance = Vector3.Distance(_cachedTransform, _player.transform.position);

        if (distance < _retreatDistance)
        {
            Vector3 directionFromPlayer = _cachedTransform - _player.transform.position;
            Vector3 newPosition = _cachedTransform + directionFromPlayer;
            _agent.SetDestination(newPosition);
        }
    }
}