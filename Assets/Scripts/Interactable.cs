using System;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    public Animator animator;
    public string animationName;
    public AudioSource audioSource;
    public string text;
    public bool isDeleted;

    private Outline outline;

    private void Awake()
    {
        outline = GetComponent<Outline>();
        animator = GetComponent<Animator>();
    }

    public void Select()
    {
        outline.enabled = true;
    }

    public void Unselect()
    {
        outline.enabled = false;
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

        if (isDeleted)
        {
            Destroy(gameObject);
        }
    }
}