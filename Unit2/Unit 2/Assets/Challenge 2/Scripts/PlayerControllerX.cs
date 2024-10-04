using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float fireDelay = 0.5f;

    // Update is called once per frame
    void Update()
    {
        fireDelay -= 1.0f * Time.deltaTime;
        Debug.Log("fireDelay: " + fireDelay);

        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && fireDelay <= 0.0f)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            fireDelay = 0.5f;
        }
    }
}
