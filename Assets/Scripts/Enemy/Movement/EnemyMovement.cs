using UnityEngine;

public abstract class EnemyMovement : MonoBehaviour
{
    [Header("Physic values")]
    [SerializeField] protected float _speed = 4;
    public Transform CachedTransform;
    private Rigidbody _rb;
    
    private float stopDistance = 4f;
    
    [HideInInspector]
    public Transform Player;

    private void Awake()
    {
        CachedTransform = transform; 
        _rb = GetComponent<Rigidbody>();
    }

    public bool IsPlayerValid()
    {
        return Player != null;
    }

    public abstract void Move();

    public void SetPlayer(Transform player)
    {
        Player = player;

        if (Player == null)
        {
            SetVelocity(Vector3.zero);
        }
    }

    public void Stop()
    {
        if (Player != null)
        {
            Vector3 direction = Player.position - CachedTransform.position;

            if (direction.magnitude > stopDistance)
            {
                transform.Translate(direction.normalized * _speed * Time.deltaTime);
            }
        }
    }
    
    public void SetVelocity(Vector3 velocity)
    {
        _rb.velocity = velocity;
        //TODO: Enemy Animation
    }

    private void RotateToPlayer()
    {
        transform.LookAt(Player, Vector3.up);
    }
}