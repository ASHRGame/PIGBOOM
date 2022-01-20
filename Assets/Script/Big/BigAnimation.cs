using UnityEngine;

public class BigAnimation : MonoBehaviour
{
    [SerializeField] private Animator animator;

    [SerializeField] private FixedJoystick joystick;

    void Update()
    {
        if (joystick.Horizontal < 0 && joystick.Horizontal > joystick.Vertical)
        {
            animator.Play("BigAnimationWalkLeft");
        }
        if (joystick.Horizontal > 0 && joystick.Horizontal > joystick.Vertical)
        {
            animator.Play("BigAnimationWalkRight");
        }
        if (joystick.Vertical < 0 && joystick.Horizontal < joystick.Vertical)
        {
            animator.Play("BigAnimationWalkDown");
        }
        if (joystick.Vertical > 0 && joystick.Horizontal < joystick.Vertical)
        {
            animator.Play("BigAnimationWalkUp");
        }
    }
}
