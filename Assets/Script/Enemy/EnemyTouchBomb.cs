using UnityEngine;
using UnityEngine.AI;


public class EnemyTouchBomb : MonoBehaviour
{
    [SerializeField] private Transform transforms;

    [SerializeField] private NavMeshAgent agent;

    [SerializeField] private Animator animator;

    [SerializeField] private Bomb pigBomb;

    void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(other.gameObject);
        agent.enabled = false;
        switch (animator.name)
        {
            case "dog_0":
                PlayAnimationDogDirty();
                break;
            case "farmer_0":
                PlayAnimationFarmerDirty();
                break;
        }
        pigBomb.isCheck = true;
    }


    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name == "pig_0")
        {
            other.gameObject.SetActive(false);
        }
    }
    private void PlayAnimationDogDirty()
    {
        foreach (var state in animator.runtimeAnimatorController.animationClips)
        {
            Debug.Log(state.name);
            if (state.name == "DogAnimationWalkLeft" || state.name == "DogAngryAnimationWalkLeft")
            {
                animator.Play("DogDirtyAnimationWalkLeft");
            }
            if (state.name == "DogAnimationWalkRight" || state.name == "DogAngryAnimationWalkLeft")
            {
                animator.Play("DogDirtyAnimationWalkRight");
            }
            if (state.name == "DogAnimationWalkUp" || state.name == "DogAngryAnimationWalkUp")
            {
                animator.Play("DogDirtyAnimationWalkUp");
            }
            if (state.name == "DogAnimationWalkDown" || state.name == "DogAngryAnimationWalkDown")
            {
                animator.Play("DogDirtyAnimationWalkDown");
            }
        }
    }

    private void PlayAnimationFarmerDirty()
    {
        foreach (var state in animator.runtimeAnimatorController.animationClips)
        {
            Debug.Log(state.name);
            if (state.name == "FarmerAnimationWalkLeft" || state.name == "FarmerAngryAnimationWalkLeft")
            {
                animator.Play("FarmerDirtyAnimationWalkLeft");
            }
            if (state.name == "FarmerAnimationWalkRight" || state.name == "FarmerAngryAnimationWalkLeft")
            {
                animator.Play("FarmerDirtyAnimationWalkRight");
            }
            if (state.name == "FarmerAnimationWalkUp" || state.name == "FarmerAngryAnimationWalkUp")
            {
                animator.Play("FarmerDirtyAnimationWalkUp");
            }
            if (state.name == "FarmerAnimationWalkDown" || state.name == "FarmerAngryAnimationWalkDown")
            {
                animator.Play("FarmerDirtyAnimationWalkDown");
            }
        }
    }
}
