using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class O_Turn : MonoBehaviour
{
    public GameObject PlayerOImage;

    public GridList gridList;

    public int lastGridPosition;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayerOTurn()
    {
        PlayerOImage.SetActive(true);
        

        StartCoroutine(waitForTurn());
    }

    IEnumerator waitForTurn()
    {
        yield return new WaitForSeconds(Random.Range(1,2));
        
        Image image = gridList.GetComponentsInChildren<Image>()[0];
        
        if(lastGridPosition != 0)
        {
            image = gridList.GetComponentsInChildren<Image>()[lastGridPosition + 1];

            if (image.sprite != gridList.spriteList[0])
            {
                image = gridList.GetComponentsInChildren<Image>()[lastGridPosition - 1];
            }
        }
        else
        {
            image = gridList.GetComponentsInChildren<Image>()[Random.Range(0, 63)];
        }

        while (image.sprite != gridList.spriteList[0])
        {
            image = gridList.GetComponentsInChildren<Image>()[Random.Range(0, 63)];
        }

        image.sprite = gridList.spriteList[2];

        Player p = GameObject.Find("PlayerCursor").GetComponent<Player>();
        p.playerCoins += 2;


        PlayerOImage.SetActive(false);
    }
}
