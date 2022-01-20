using UnityEngine;
using UnityEngine.AI;


public class EnemyTouchBomb : MonoBehaviour
{
    [SerializeField] private Transform transforms;

    [SerializeField] private NavMeshAgent agent;

    [SerializeField] private Animator animator;

    [SerializeField] private Bomb pigBomb;
    [SerializeField] private Transform pigTransforms;


    void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(other.gameObject);
        agent.enabled = false;
        agent.gameObject.GetComponent<CircleCollider2D>().enabled = false;
        agent.gameObject.GetComponent<EnemyAnimationMove>().enabled = false;
        PlayAnimationDirty(((Vector2)pigTransforms.position - (Vector2)transforms.position).normalized,
        Vector3.Distance(transforms.position, pigTransforms.position));
        pigBomb.isCheck = true;
    }


    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name == "pig_0")
        {
            other.gameObject.SetActive(false);
        }
    }
    private void PlayAnimationDirty(Vector2 forward, float distance)
    {
        if (forward.x < -0.7f)
        {
            animator.Play("DirtyAnimationWalkLeft");
        }
        if (forward.x > 0.7f)
        {
            animator.Play("DirtyAnimationWalkRight");
        }
        if (forward.y > 0.7f)
        {
            animator.Play("DirtyAnimationWalkUp");
        }
        if (forward.y < -0.7f)
        {
            animator.Play("DirtyAnimationWalkDown");
        }
    }

    private bool IsAnimation(string name)
    {
        return animator.GetCurrentAnimatorStateInfo(0).IsName(name);
    }
}
