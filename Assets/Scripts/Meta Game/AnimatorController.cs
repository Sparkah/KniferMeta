using System.Collections;
using UnityEngine;

public class AnimatorController : MonoBehaviour
{
    private Animator playerAnimator;

    private void OnEnable()
    {
        DynamicJoystick.OnPlayerMove += Walking;
        DynamicJoystick.OnPlayerStopMove += Idle;
    }

    private void OnDisable()
    {
        DynamicJoystick.OnPlayerMove -= Walking;
        DynamicJoystick.OnPlayerStopMove -= Idle;
    }

    private void Start()
    {
        playerAnimator = GetComponent<Animator>();
    }

    public void Walking()
    {
        playerAnimator.SetBool("Move", true);
    }

    public void Idle()
    {
        playerAnimator.SetBool("Move", false);
    }
}