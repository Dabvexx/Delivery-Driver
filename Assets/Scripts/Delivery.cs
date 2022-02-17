using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    #region Variables
    private bool hasPackage = false;
    #endregion

    #region Unity Methods

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collided");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Package")
        {
            Debug.Log("Picked up package");
            hasPackage = true;
        }

        if (collision.tag == "Customer" && hasPackage)
        {
            Debug.Log("Delivered Package");
        }
    }
    #endregion

    #region Private Methods

    #endregion

    #region Public Methods

    #endregion
}
