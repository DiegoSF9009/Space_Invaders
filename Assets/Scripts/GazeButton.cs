using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class GazeButton : MonoBehaviour
{
    [SerializeField]
    private UnityEvent onPointerEnter;
    [SerializeField]
    private UnityEvent onPointExit;
    [SerializeField]
    private UnityEvent onPointerClick;
    [SerializeField] 
    private string onPointerEnterAnimationName;
    [SerializeField]
    private string onPointerExitAnimationName;
    [SerializeField]
    private string onPointerClickAnimationName;
    [SerializeField]
    private Animator animator;

    public void OnPointerEnter()
    {   
        animator.Play(onPointerEnterAnimationName);
        onPointerEnter.Invoke();
    }

    public void OnPointerExit()
    {
        animator.Play(onPointerExitAnimationName);
        onPointExit.Invoke();
    }

    public void OnPointerClick()
    {
        animator.Play(onPointerClickAnimationName);
        onPointerClick.Invoke();
    }

}
