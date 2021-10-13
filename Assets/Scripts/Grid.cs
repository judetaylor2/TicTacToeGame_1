using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Grid : MonoBehaviour
{
    Image currentImage;
    public Image[] colourList;
    // Start is called before the first frame update
    void Start()
    {
        currentImage = GetComponent<Image>();
    }
    public void ChangeImage(int imageIndex)
    {
        currentImage = colourList[imageIndex];
    }
}
