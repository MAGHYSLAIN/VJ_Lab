using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VJ_Manager : MonoBehaviour

    
{
    public GameObject gOBJ = null;
    public Component Glitch;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("showGameObject", 2);
    }
    
       void showGameObject()
    {
        gOBJ.SetActive(true);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
