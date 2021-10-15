using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public Canvas mainCanvas;
    public GameObject currentItem;
    public GameObject[] cardSlotPositions;
    [HideInInspector] public GameObject[] cardSlot;
    [HideInInspector] public bool isCardBeingUsed;

    public GameObject cardItem;

    public int currentCardIndex;
    [HideInInspector] public int playerMoves;

    [HideInInspector] public GameObject currentCard;

    int playerCoins = 5;

    public Text coinsUI;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Confined;
        
        cardSlot = new GameObject[cardSlotPositions.Length];

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Input.mousePosition;
        
        if (currentItem != null)
        {
            currentItem.transform.position = transform.position;
        }

        //Debug.Log(currentCardIndex);

        coinsUI.text = "Coins: " + playerCoins;
    }

    public void BuyCard(string s) //each input is seperated by a comma
    {

        string[] s1 = s.Split(',');
        
        int card = int.Parse(s1[0]);
        int cost = int.Parse(s1[1]);


        if (playerCoins >= cost)
        {
            playerCoins -= cost;
            for (int i = 0; i < cardSlot.Length; i++)
            {
                if (cardSlot[i] == null)
                {
                    //Debug.Log(cardSlot[i] + "   " + cardSlotPositions[i]);
                    cardSlot[i] = Instantiate(cardItem, cardSlotPositions[i].transform.position, cardSlotPositions[i].transform.rotation, cardSlotPositions[i].transform);

                    cardSlot[i].GetComponent<Card>().cardIndex = card;
                    cardSlot[i].GetComponent<Card>().Initialiaze();
                    Debug.Log("instantiated gameobject");


                    break;
                }

            }

        }
        
    }
}
