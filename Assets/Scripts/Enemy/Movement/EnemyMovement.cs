using System;
using UnityEngine;

public abstract class EnemyMovement : MonoBehaviour
{
    [Header("Physic values")]
    [SerializeField] protected float _speed = 4;
    protected Transform _cachedTransform;
    private Rigidbody _rb;
    
    [HideInInspector]
    public Transform Player;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        SetPlayer(Player);
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