using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
   [Header("Components")]
   [SerializeField] private Rigidbody _rb;
   [SerializeField] private FixedJoystick _joystick;
   
   [Header("Physics")]
   [SerializeField] private float _speed = 3f;

   private void FixedUpdate()
   {
      Move();
      Rotate();
   }

   private void Rotate()
   {
      if (_joystick.Horizontal != 0 || _joystick.Vertical != 0)
      {
         transform.rotation = Quaternion.LookRotation(_rb.velocity);
      }
   }

   private void Move()
   {
      _rb.velocity = new Vector3(_joystick.Horizontal * _speed, _rb.velocity.y, _joystick.Vertical * _speed);
   }
}
