using UnityEngine;
using UnityEngine.AI;

public class EnemyRangeBehaviour : MonoBehaviour
{
    [SerializeField] private float _retreatDistance = 3f;
    private Vector3 _cachedTransform; 
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
        float distance = Vector3.Distance( _cachedTransform, _player.transform.position);

        if (distance < _retreatDistance)
        {
            Vector3 directionFromPlayer =  _cachedTransform - _player.transform.position;
            Vector3 newPosition =  _cachedTransform + directionFromPlayer;
            _agent.SetDestination(newPosition); 
        }
    }
}