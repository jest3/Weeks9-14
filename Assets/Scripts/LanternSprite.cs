using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LanternSprite : MonoBehaviour
{
    //reference to lantern image
    public Image lanternImage;
    //reference to regular lantern sprite
    public Sprite regularLanternSprite;
    //reference to lantern sprite once golden spirit is clicked
    public Sprite goldenLanternSprite;

    // Start is called before the first frame update
    void Start()
    {
        if (lanternImage != null && regularLanternSprite != null)
        {
            lanternImage.sprite = regularLanternSprite;
        }
    }

    public void ChangeLantern()
    {
        StartCoroutine(ChangeLanternSprite());

        IEnumerator ChangeLanternSprite()
        {
            lanternImage.sprite = goldenLanternSprite;
            yield return new WaitForSeconds(5f);
            lanternImage.sprite = regularLanternSprite;

        }
    }
}
