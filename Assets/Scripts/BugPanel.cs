using UnityEngine;

public class BugPanel : Interactable
{
    public Animation anim;
    public string specialText;
    public int specialIndex;
    public UISpritesAnimation uiSprites;
    bool played;

  

  

    public override void Active()
    {
        if (state == specialIndex && !played)
        {
            played = true;
            anim.Play();
            state = 2;
            uiSprites.Play();
            return;
        }
        base.Active();
    }

    public void sendText()
    {
        DialogueManager.instance.showText(specialText);
    }
}