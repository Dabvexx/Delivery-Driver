using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField]
    private GameObject player;

    [SerializeField]
    [Range(0, 2)]
    private float easeAmount = 1f;

    [SerializeField]
    private Vector3 offset = new Vector3(0, 0, -10);

    // Update is called once per frame
    void Update()
    {
        //Vector3 velocity = CalculateCameraMovement();
        //transform.Translate(velocity);
        transform.position = player.transform.position + offset;
        transform.LookAt(player.transform);
    }

    /*
    // Tried to do camera smoothing but couldnt make it work, will come back to later.
    private float Ease(float x)
    {
        float a = easeAmount + 1;
        return Mathf.Pow(x, a) / (Mathf.Pow(x, a) + Mathf.Pow(1 - x, a));
    }

    private Vector3 CalculateCameraMovement()
    {
        float distanceFromPlayer = Vector3.Distance(transform.position, player.transform.position);
        float percetFromPlayer = Time.deltaTime / distanceFromPlayer;
        percetFromPlayer = Mathf.Clamp01(percetFromPlayer);
        float easedPercentFromPlayer = Ease(percetFromPlayer);

        return Vector3.Lerp(transform.position, player.transform.position, easedPercentFromPlayer);
    } */
}
