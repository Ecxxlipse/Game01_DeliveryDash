using UnityEngine;

public class Delivery : MonoBehaviour
{

    bool hasPackage;


    void OnTriggerEnter2D(Collider2D collision)
    {
        // If (the tag is package)
        // Then (print picked up package to console)
        if (collision.CompareTag("Package"))
        {
            Debug.Log("Picked up Package");
            hasPackage = true;
        }

        if (collision.CompareTag("Customer") && hasPackage)
        {
            Debug.Log("Delivered Package");
            hasPackage = false;
        }

    }
}
