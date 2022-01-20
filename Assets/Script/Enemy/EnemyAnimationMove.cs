using UnityEngine;
using UnityEngine.AI;

public class EnemyAnimationMove : MonoBehaviour
{
    [SerializeField] private Transform transforms;
    [SerializeField] private Animator animator;

    [SerializeField] private Transform pigTransforms;

    [SerializeField] private NavMeshAgent agent;


    private const float distanceAngry = 3.0f; 

    void Update()
    {

        PlayAnimation(((Vector2)pigTransforms.position - (Vector2)transforms.position).normalized,
        Vector3.Distance(transforms.position, pigTransforms.position));
    }

    private void PlayAnimation(Vector2 forward, float distance)
    {
        if (forward.x < -0.7f && distance > distanceAngry)
        {
            animator.Play("AnimationWalkLeft");
            agent.speed = 2f;
        }
        if (forward.x < -0.7f && distance < distanceAngry)
        {
            animator.Play("AngryAnimationWalkLeft");
             agent.speed = 2.5f;
        }
        if (forward.x > 0.7f && distance > distanceAngry)
        {
            animator.Play("AnimationWalkRight");
            agent.speed = 2f;
        }
        if (forward.x > 0.7f && distance < distanceAngry)
        {
            animator.Play("AngryAnimationWalkRight");
            agent.speed = 2.5f;
        }
        if (forward.y > 0.7f && distance > distanceAngry)
        {
            animator.Play("AnimationWalkUp");
            agent.speed = 2f;
        }
        if (forward.y > 0.7f  && distance < distanceAngry)
        {
            animator.Play("AngryAnimationWalkUp");
            agent.speed = 2.5f;
        }
        if (forward.y < -0.7f  && distance > distanceAngry)
        {
            animator.Play("AnimationWalkDown");
            agent.speed = 2f;
        }
        if (forward.y < -0.7f  && distance < distanceAngry)
        {
            animator.Play("AngryAnimationWalkDown");
            agent.speed = 2.5f;
        }
    }
}
