using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class HeroMovementController : MonoBehaviour
{
    [SerializeField] private HeroInputController heroInputController;
    [SerializeField] private float forwardMovementSpeed;
    [SerializeField] private float horizontalSpeed;
    [SerializeField] private float horizontalLimitValue;

    private float newPoitionX;

    private void FixedUpdate()
    {
        SetHeroForward();
        SetHeroHorizontal();
    }


    private void SetHeroForward()
    {
        transform.Translate(Vector3.down * forwardMovementSpeed * Time.fixedDeltaTime);
    }

    private void SetHeroHorizontal()
    {
        newPoitionX = transform.position.x + heroInputController.horizontalValue * horizontalSpeed * Time.fixedDeltaTime;
        newPoitionX = Mathf.Clamp(newPoitionX, -horizontalLimitValue, horizontalLimitValue);
        transform.position = new Vector3(newPoitionX, this.transform.position.y, this.transform.position.z);
    }
}
