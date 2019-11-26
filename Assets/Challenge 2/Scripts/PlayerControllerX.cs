using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    private bool canShoot = true;
    
    public GameObject dogPrefab;
    private float coolDown = 1.0f;
    private float nextFire = 0.0f;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && Time.time > nextFire)
        {
            nextFire = Time.time + coolDown;
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
    }
}
