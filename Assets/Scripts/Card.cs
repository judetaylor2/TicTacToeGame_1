using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Card : MonoBehaviour
{
    [HideInInspector] public int cardIndex;

    public Sprite[] cardSprites;

    Animator anim;
    Player player;

    // Start is called before the first frame update
    public void Initialiaze()
    {
        Image i = GetComponent<Image>();
        i.sprite = cardSprites[cardIndex];

        anim = GetComponent<Animator>();

        player = GameObject.Find("PlayerCursor").GetComponent<Player>();
        
    }

    // Update is called once per frame
    public void PlayAnimation(bool state)
    {
        anim.SetBool("isPointerHovering", state);
    }

    public void OnClick()
    {
        player.currentCardIndex = cardIndex;

        player.currentCard = gameObject;
    }

}
