using UnityEngine;

public class AnimationHandler : MonoBehaviour
{
    [SerializeField] private Animator animator;


    private void Update()
    {
        AnimationController();    
    }

    private void AnimationController()
    {
        if (Input.GetMouseButton(0))
        {
            animator.SetBool("IsRunning", true);
        }

        else
        {
            animator.SetBool("IsRunning", false);
        }
    }
}
