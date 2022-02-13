using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    #region Variables

    #endregion

    #region Unity Methods

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collided");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Triggered");
    }
    #endregion

    #region Private Methods

    #endregion

    #region Public Methods

    #endregion
}
