using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GridList : MonoBehaviour
{
    public Sprite[] spriteList;
    Sprite[] tileList = new Sprite[64];
    Sprite[,] tiles = new Sprite[8, 8];
    int tileCountO;
    int tileCountX;

    public GameObject winScreen;
    public Text winText;

    
    void Start()
    {
        
    }

    void Update()
    {
        //read new values each turn
        int iterationCount = 0;
        
        Image[] image = GetComponentsInChildren<Image>();
        
        for (int i = 0; i < image.Length; i++)
        {
            tileList[i] = image[i].sprite;
        }

        for (int i = 0; i < 8; i++)
        {
            for (int x = 0; x < 8; x++)
            {
                tiles[i, x] = tileList[iterationCount];
                iterationCount++;
            }
        }



        //horizontal check
        for (int i = 0; i < tiles.GetLength(0); i++)
        {
            tileCountX = 0;
            tileCountO = 0;


            for (int x = 0; x < tiles.GetLength(1); x++)
            {
                
                
                if (tiles[i, x].name == spriteList[1].name)
                {
                    //if tile is X (the index is 1)
                    tileCountX++;
                    tileCountO = 0;
                    Debug.Log("X");
                }
                else if (tiles[i, x].name == spriteList[2].name)
                {
                    //if tile is O (the index is 0)
                    tileCountX = 0;
                    tileCountO++;
                    Debug.Log("O");
                }
                else
                {
                    tileCountX = 0;
                    tileCountO = 0;
                }

                //Debug.Log(tileCountX + " " + tileCountO);

                //win conditions
                if (tileCountX == 4)
                {
                    //player X wins
                    Debug.Log("Player X wins");
                    winScreen.SetActive(true);
                    winText.text = "Player X wins!";
                }
                else if (tileCountO == 4)
                {
                    //player O wins
                    Debug.Log("Player O wins");
                    winScreen.SetActive(true);
                    winText.text = "Player X wins!";
                }
            }
        }


        //vertical check
        for (int i = 0; i < tiles.GetLength(1); i++)
        {
            tileCountX = 0;
            tileCountO = 0;


            for (int x = 0; x < tiles.GetLength(0); x++)
            {
                
                
                if (tiles[x, i].name == spriteList[1].name)
                {
                    //if tile is X (the index is 1)
                    tileCountX++;
                    tileCountO = 0;
                    Debug.Log("X");
                }
                else if (tiles[x, i].name == spriteList[2].name)
                {
                    //if tile is O (the index is 0)
                    tileCountX = 0;
                    tileCountO++;
                    Debug.Log("O");
                }
                else
                {
                    tileCountX = 0;
                    tileCountO = 0;
                }

                //Debug.Log(tileCountX + " " + tileCountO);

                //win conditions
                if (tileCountX == 4)
                {
                    //player X wins
                    Debug.Log("Player X wins");
                    winScreen.SetActive(true);
                    winText.text = "Player X wins!";
                }
                else if (tileCountO == 4)
                {
                    //player O wins
                    Debug.Log("Player O wins");
                    winScreen.SetActive(true);
                    winText.text = "Player X wins!";
                }
            }
        }

        
        //diagonal check


   
    }
}
