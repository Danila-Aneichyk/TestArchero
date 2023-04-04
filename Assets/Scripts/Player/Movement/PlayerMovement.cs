using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class PlayerMovement : MonoBehaviour
{
   [Header("Components")]
   [SerializeField] private FixedJoystick _joystick;
   private NavMeshAgent _agent;

   [Header("Animation")]
   [SerializeField] private PlayerAnimation _animation;
   
   [Header("Physics")]
   private Vector3 _direction; 

   private void Awake()
   {
      _agent = GetComponent<NavMeshAgent>();
   }

   private void FixedUpdate()
   {
      Move();
      //Rotate();
   }

   /*private void Rotate()
   {
      if (_joystick.Horizontal != 0 || _joystick.Vertical != 0)
      {
         transform.rotation = Quaternion.LookRotation(_rb.velocity);
      }
   }*/

   private void Move()
   {
      _direction.Set(_joystick.Horizontal, 0f, _joystick.Vertical);
      
      _agent.Move(_direction * (Time.deltaTime * _agent.speed));
      _agent.SetDestination(transform.position + _direction);
      //_animation.PlayRun(ve);
   }
}
