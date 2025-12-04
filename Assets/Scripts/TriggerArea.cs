using System;
using UnityEngine;

public class TriggerArea : MonoBehaviour
{
    public Animation animation;
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
    public virtual void Active()
    {
        if (animation != null)
        {
            animation.Play();
        }

        if (text != null)
        {
            DialogueManager.instance.showText(text);
        }
    }
}
