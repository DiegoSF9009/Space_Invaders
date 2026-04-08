using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]

    private Animator damagaFade;

    public void TakeDamage()
    {
        damagaFade.Play("FadeIn", 0, 0f);
    }

}
