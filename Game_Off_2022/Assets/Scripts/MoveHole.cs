using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveHole : MonoBehaviour
{
    //X: -15 to 15
    //Y: -4 to 6

    float currentX = 0f;
    float currentY = 0f;
    float currentZ = 8.8f;

    private void Start()
    {
        this.gameObject.transform.position = new Vector3(currentX, currentY, currentZ);
    }


    public void changePosition()
    {
        currentX = Random.Range(-15f, 15f);
        currentY = Random.Range(-4f, 6f);
        this.gameObject.transform.position = new Vector3(currentX, currentY, currentZ);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "card")
        {
            changePosition();
        }
    }
}
