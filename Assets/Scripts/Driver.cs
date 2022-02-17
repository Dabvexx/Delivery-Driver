using UnityEngine;

public class Driver : MonoBehaviour
{
    #region Variables

    // Variables
    [SerializeField]
    [Range(.1f, 500f)]
    private float turnSpeed;

    [SerializeField]
    [Range(.1f, 50f)]
    private float moveSpeed;

    [SerializeField]
    [Range(.1f, 50f)]
    private float slowSpeed;

    [SerializeField]
    [Range(.1f, 50f)]
    private float boostSpeed;

    #endregion Variables

    #region Unity Methods
    // Built in Unity Methods

    private void Update()
    {
        HandleInput();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        moveSpeed = slowSpeed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Boost")
        {
            moveSpeed = boostSpeed;
        }
    }

    #endregion Unity Methods

    #region Private Methods

    // Private Methods.
    private void HandleInput()
    {
        var inputY = Input.GetAxis("Vertical");
        var inputX = Input.GetAxis("Horizontal");

        // Handle Rotation.
        transform.Rotate(0, 0, -inputX * turnSpeed * Time.deltaTime);

        // Handle Acceleration.
        transform.Translate(0,  inputY * moveSpeed * Time.deltaTime, 0);
    }

    #endregion Private Methods
}