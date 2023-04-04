using System;
using UnityEngine;

public class DetectPlayer : MonoBehaviour
{
    [Header("Components")]
    //[SerializeField] private EnemyMovement _enemyMovement;
    private Transform _player;

    private void Awake()
    {
        _player = GameObject.FindWithTag("Player").transform;
        SetPlayer(_player);
    }

    private void SetPlayer(Transform player)
    {
       // _enemyMovement.SetPlayer(player);
    }
}