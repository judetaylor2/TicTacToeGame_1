using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Canvas mainCanvas;
    public GameObject currentItem;
    public GameObject[] cardSlotPositions;
    GameObject[] cardSlot;

    [HideInInspector] public int currentCardIndex;
    [HideInInspector] public bool isCardBeingUsed;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Confined;
        
        cardSlot = new GameObject[cardSlotPositions.Length];

        for (int i = 0; i < 3; i++)
        Debug.Log(cardSlot[i]);

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Input.mousePosition;
        
        if (currentItem != null)
        {
            currentItem.transform.position = transform.position;
        }

        if (isCardBeingUsed)
        {
            
        }
    }

    public void BuyCard(GameObject cardItem)
    {
        for (int i = 0; i < cardSlot.Length; i++)
        {
            if (cardSlot[i] == null)
            {
                //Debug.Log(cardSlot[i] + "   " + cardSlotPositions[i]);
                cardSlot[i] = Instantiate(cardItem, cardSlotPositions[i].transform.position, cardSlotPositions[i].transform.rotation, cardSlotPositions[i].transform);
                Debug.Log("instantiated gameobject");
                break;
            }

        }
        
    }
}
