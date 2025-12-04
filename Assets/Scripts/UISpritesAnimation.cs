using UnityEngine;
using UnityEngine.UI;

public class UISpritesAnimation : MonoBehaviour
{
    public float duration;

    [SerializeField] private Sprite[] sprites;

    private Image image;
    private int index = 0;
    private float timer = 0;
    bool playing = false;

    void Start()
    {
        image = GetComponent<Image>();
    }

    private void Update()
    {
        if (!playing)
            return;
        if ((timer += Time.deltaTime) >= (duration / sprites.Length))
        {
            timer = 0;
            image.sprite = sprites[index];
            if (index + 1 >= sprites.Length)
                playing = false;
            index = (index + 1) % sprites.Length;
        }
    }

    public void Play()
    {
        playing = true;
        timer = 0;
    }
}