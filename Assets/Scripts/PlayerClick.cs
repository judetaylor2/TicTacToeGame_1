using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerClick : MonoBehaviour
{
    public int cardIndex;
    // Start is called before the first frame update

    public void UseCard()
    {
        Player player = GameObject.Find("PlayerCursor").GetComponent<Player>();
        player.isCardBeingUsed = true;
        player.currentCardIndex = 0;
    }
}
