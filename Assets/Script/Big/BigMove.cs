using UnityEngine;

public class BigMove: MonoBehaviour
{
    [SerializeField] private FixedJoystick joystick;

    private float speed;

    void Start()
    {
        speed = 5.0f;
    }

    void FixedUpdate()
    {
        float translationY = joystick.Vertical * speed * Time.deltaTime;
        float translationX = joystick.Horizontal * speed * Time.deltaTime;

        transform.Translate(translationX, 0, 0);
        transform.Translate(0, translationY, 0);
    }
}
