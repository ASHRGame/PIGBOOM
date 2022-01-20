using UnityEngine;

public class EnemyAnimationMove : MonoBehaviour
{
    [SerializeField] private Transform transforms;
    [SerializeField] private Animator animator;

    [SerializeField] private Transform bigTransforms;
    private float lastPositionX;
    private float lastPositionY;

    private const float distanceAngry = 5.0f; 

    private const float angle = 25.0f; 

    void Start()
    {
        lastPositionX = transforms.position.x;
        lastPositionY = transforms.position.y;
    }

    void Update()
    {
        switch (animator.name)
        {
            case "dog_0":
                PlayAnimationDog();
                break;
            case "farmer_0":
                PlayAnimationFarmer();
                break;
        }
        lastPositionX = transforms.position.x;
        lastPositionY = transforms.position.y;
    }


    private void PlayAnimationDog()
    {
        var distance = Vector3.Distance(transforms.position, bigTransforms.position);
        if (lastPositionX > transforms.position.x && transforms.position.sqrMagnitude < angle && distance > distanceAngry)
        {
            animator.Play("DogAnimationWalkLeft");
        }
        if (lastPositionX > transforms.position.x && transforms.position.sqrMagnitude < angle && distance < distanceAngry)
        {
            animator.Play("DogAngryAnimationWalkLeft");
        }
        if (lastPositionX < transforms.position.x && transforms.position.sqrMagnitude < angle && distance > distanceAngry)
        {
            animator.Play("DogAnimationWalkRight");
        }
        if (lastPositionX < transforms.position.x && transforms.position.sqrMagnitude < angle && distance < distanceAngry)
        {
            animator.Play("DogAnimationWalkRight");
        }
        if (lastPositionY > transforms.position.y && transforms.position.sqrMagnitude > angle && distance > distanceAngry)
        {
            animator.Play("DogAnimationWalkUp");
        }
        if (lastPositionY > transforms.position.y && transforms.position.sqrMagnitude > angle && distance < distanceAngry)
        {
            animator.Play("DogAngryAnimationWalkUp");
        }
        if (lastPositionY < transforms.position.y && transforms.position.sqrMagnitude > angle && distance > distanceAngry)
        {
            animator.Play("DogAnimationWalkDown");
        }
        if (lastPositionY < transforms.position.y && transforms.position.sqrMagnitude > angle && distance < distanceAngry)
        {
            animator.Play("DogAngryAnimationWalkDown");
        }
    }

    private void PlayAnimationFarmer()
    {
        var distance = Vector3.Distance(transforms.position, bigTransforms.position);
        if (lastPositionX > transforms.position.x && transforms.position.sqrMagnitude < angle && distance > distanceAngry)
        {
            animator.Play("FarmerAnimationWalkLeft");
        }
        if(lastPositionX > transforms.position.x && transforms.position.sqrMagnitude < angle && distance < distanceAngry)
        {
            animator.Play("FarmerAngryAnimationWalkLeft");
        }
        if (lastPositionX < transforms.position.x && transforms.position.sqrMagnitude < angle && distance > distanceAngry)
        {
            animator.Play("FarmerAnimationWalkRight");
        }
        if (lastPositionX < transforms.position.x && transforms.position.sqrMagnitude < angle && distance < distanceAngry)
        {
            animator.Play("FarmerAnimationWalkRight");
        }
        if (lastPositionY > transforms.position.y && transforms.position.sqrMagnitude > angle && distance > distanceAngry)
        {
            animator.Play("FarmerAnimationWalkUp");
        }
        if (lastPositionY > transforms.position.y && transforms.position.sqrMagnitude > angle && distance < distanceAngry)
        {
            animator.Play("FarmerAngryAnimationWalkUp");
        }
        if (lastPositionY < transforms.position.y && transforms.position.sqrMagnitude > angle && distance > distanceAngry)
        {
            animator.Play("FarmerAnimationWalkDown");
        }
        if (lastPositionY < transforms.position.y && transforms.position.sqrMagnitude > angle && distance < distanceAngry)
        {
            animator.Play("FarmerAngryAnimationWalkDown");
        }
    }
}
