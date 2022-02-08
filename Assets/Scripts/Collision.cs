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
    #endregion

    #region Private Methods

    #endregion

    #region Public Methods

    #endregion
}
