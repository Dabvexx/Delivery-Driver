using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    #region Variables
    // Variables.
    // You can set the color through script but dont torture yourself like that.
    // Please I beg you just use the inspector.
    [SerializeField]
    private Color hasPackageColor;

    [SerializeField]
    private Color baseColor;

    private bool hasPackage = false;

    // Dunno why we are adding a delay to destroying the package but alright.
    [SerializeField]
    private float destroyDelay = .5f;

    private SpriteRenderer sr;
    #endregion

    #region Unity Methods

    private void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    // Currently useless function call.
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collided");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Package")
        {
            HandlePackageLogic(collision);

        }

        if (collision.tag == "Customer" && hasPackage)
        {
            HandleCustomerLogic(collision);
        }
    }
    #endregion

    #region Private Methods
    private void HandleCustomerLogic(Collider2D collision)
    {
        Debug.Log("Delivered Package");
        sr.color = baseColor;
        hasPackage = false;
        Destroy(collision.gameObject, destroyDelay);
    }

    private void HandlePackageLogic(Collider2D collision)
    {
        Debug.Log("Picked up package");
        hasPackage = true;
        sr.color = hasPackageColor;
        Destroy(collision.gameObject, destroyDelay);
    }
    #endregion

    #region Public Methods

    #endregion
}
