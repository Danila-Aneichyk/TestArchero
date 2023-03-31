using UnityEngine;

public abstract class EnemyMovement : MonoBehaviour
{
    [Header("Physic values")]
    [SerializeField] protected float _speed = 4;
    private Transform _cachedTransform;
    private Rigidbody _rb;

    [Header("Player values")]
    [SerializeField] private Transform _player;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (!IsPlayerValid())
            return;
        
        Move();
        RotateToPlayer();
    }

    public abstract bool IsPlayerValid();

    public abstract void Move();

    public void SetPlayer(Transform player)
    {
        _player = player;

        if (_player == null)
        {
            SetVelocity(Vector3.zero);
        }
    }
    
    private void RotateToPlayer()
    {
        transform.LookAt(_player, Vector3.up);
    }

    private void SetVelocity(Vector3 velocity)
    {
        _rb.velocity = velocity;
        //TODO: Enemy Animation
    }
}