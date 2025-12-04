using UnityEngine;
using TMPro;
using System.Text;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    public static DialogueManager instance;
    public TextMeshProUGUI tmpText;
    public Image bg;
    public float stayDuration;
    float timer;
    bool showing;

    private void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= stayDuration)
        {
            bg.enabled = false;
            tmpText.text = "";
        }
    }

    public void showText(string text)
    {
        showing = true;
        timer = 0;
        bg.enabled = true;
        tmpText.text = text;
    }
}