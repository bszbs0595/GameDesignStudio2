using System;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    public int state;
    public Animation[] animations;
    public Interactable[] others;
    public int[] states;
    public AudioSource audioSource;
    public string[] text;
    public bool[] isDeleted;

    private Outline outline;

    private void Awake()
    {
        outline = GetComponent<Outline>();
    }

    public void Select()
    {
        outline.enabled = true;
    }

    public void Unselect()
    {
        outline.enabled = false;
    }

    public virtual void Active()
    {
        if (text != null && state <= text.Length - 1 && text[state] != null)
        {
            DialogueManager.instance.showText(text[state]);
        }

        if (animations != null && state <= animations.Length - 1 && animations[state] != null)
        {
            animations[state].Play();
        }

        if (others != null && state <= others.Length - 1 && others[state] != null)
        {
            others[state].state = states[state];
        }

        if (state <= isDeleted.Length - 1 && isDeleted[state])
        {
            gameObject.SetActive(false);
        }
    }
}