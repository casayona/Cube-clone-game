using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroInputController : MonoBehaviour
{
    public float horizontalValue;

    private void Start()
    {
        horizontalValue = 0;
    }


    void Update()
    {
        HandleHeroHorizontalInput();
    }

    public void HandleHeroHorizontalInput()
    {
        
            horizontalValue = Input.GetAxis("Mouse X");
            Debug.Log(horizontalValue);
        
    }
}
