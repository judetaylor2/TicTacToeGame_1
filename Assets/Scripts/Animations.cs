using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animations : MonoBehaviour
{
    // Start is called before the first frame update
    Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void SetBool(string name)
    {
        anim.SetBool(name, !anim.GetBool(name));
    }
}
