using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    
    private static readonly int Death = Animator.StringToHash("Death");
    private static readonly int Shoot = Animator.StringToHash("Shoot");
    private static readonly int Speed = Animator.StringToHash("Speed");
    
    public void PlayDeath()
    {
        _animator.SetTrigger(Death);
    }

    public void PlayRun(float speed)
    {
        _animator.SetFloat(Speed, speed);
    } 
    
    public void PlayShoot()
    {
        _animator.SetTrigger(Shoot);
    }
}