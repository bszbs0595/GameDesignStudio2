using UnityEngine;
using TMPro;
using System.Text;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    public static DialogueManager instance;
    public string[] textArray;
    public TextMeshProUGUI tmpText;
    public Image bg;
    public float stayDuration;
    float timer;
    bool showing;

    private void Awake() {
        if(instance == null)
            instance = this;
        else
        Destroy(this.gameObject);
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Jump"))
        {
            showText(0);
        }

        timer += Time.deltaTime;
        if (timer >= stayDuration)
        {
            bg.enabled = false;
            tmpText.text = "";
        }
    }

    public void showText(int index)
    {
        showing = true;
        timer = 0;
        bg.enabled = true;
        tmpText.text = textArray[index];
    }
}
