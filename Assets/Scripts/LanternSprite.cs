using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LanternSprite : MonoBehaviour
{
    //reference to UI image that has the lantern sprites
    public Image lanternImage;
    
    //reference to regular lantern sprite
    public Sprite regularLanternSprite;
    
    //reference to golden lantern sprite for once the golden spirit is clicked
    public Sprite goldenLanternSprite;

    void Start()
    {
        //starts with the regular lantern sprite
        if (lanternImage != null && regularLanternSprite != null)
        {
            lanternImage.sprite = regularLanternSprite;
        }
    }

    //called when the golden spirit is clicked
    public void ChangeLantern()
    {
        //starts coroutine to change the lantern sprite to the golden lantern sprite
        StartCoroutine(ChangeLanternSprite());

        IEnumerator ChangeLanternSprite()
        {
            //changes to the golden lantern sprite
            lanternImage.sprite = goldenLanternSprite;
            
            //keep the golden lantern sprite for 5 seconds
            yield return new WaitForSeconds(5f);
            
            //after 5 seconds, return the sprite to the regular lantern sprite
            lanternImage.sprite = regularLanternSprite;

        }
    }
}
