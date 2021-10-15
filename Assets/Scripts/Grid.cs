using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Grid : MonoBehaviour
{
    Image currentImage;
    public GridList gridList;

    public Player player;

    // Start is called before the first frame update
    void Start()
    {
        currentImage = GetComponent<Image>();
    }

    void Update()
    {

    }
    public void ChangeImage(int imageIndex)
    {
        currentImage.sprite = gridList.spriteList[imageIndex];

        player.playerMoves++;
    }

    public void UseCard()
    {
        switch (player.currentCardIndex)
        {
            case 0:
                ChangeImage(1);

                if (player.playerMoves >= 1)
                {
                    
                    DestroyCard();
                    Debug.Log(player.playerMoves);

                }
                break;
            
            case 1:
                ChangeImage(1);

                if (player.playerMoves >= 2)
                {
                    
                    DestroyCard();
                    Debug.Log(player.playerMoves);

                }
                break;

            case 2:

                if (currentImage.sprite == gridList.spriteList[2])
                {
                    ChangeImage(0);

                    if (player.playerMoves >= 1)
                    {
                        
                        DestroyCard();
                        Debug.Log(player.playerMoves);

                    }

                }

                
                
                break;

            case 3:
                if (currentImage.sprite == gridList.spriteList[2])
                {
                    ChangeImage(0);

                    if (player.playerMoves >= 2)
                    {
                        
                        DestroyCard();
                        Debug.Log(player.playerMoves);

                    }

                }
                break;

            default:

                break;
            
        }
    }

    void DestroyCard()
    {
        Destroy(player.currentCard);
        player.currentCardIndex = -1;
        player.playerMoves = 0;
    }
}
