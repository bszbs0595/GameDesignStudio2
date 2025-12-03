using System;
using UnityEngine;

public class TriggerArea : MonoBehaviour
{
    public Animator animator;
    public string animationName;
    public AudioSource audioSource;
    public string text;
  

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Active();
            this.enabled = false;
            GetComponent<Collider>().enabled = false;
        }
    }
    public void Active()
    {
        if (animator != null)
        {
            animator.Play(animationName);
        }

        if (text != null)
        {
            DialogueManager.instance.showText(text);
        }
    }
}
