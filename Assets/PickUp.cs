using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public GameObject camera;
    public float distance = 15f;
    GameObject currentWeapon;
    bool canPickUp;

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)) PickUpp();
        if (Input.GetKeyDown(KeyCode.Q)) Drop();
    }

    void PickUpp()
    {
        RaycastHit hit;

        if (Physics.Raycast(camera.transform.position, camera.transform.forward, out hit, distance))
        {
            if (hit.transform.tag == "food")
            {
                if (canPickUp) Drop();

                currentWeapon = hit.transform.gameObject;
                currentWeapon.GetComponent<Rigidbody>().isKinematic = true;
                currentWeapon.transform.parent = transform;
                currentWeapon.transform.localPosition = Vector3.zero;
                canPickUp = true;
            }
        }
    }

    void Drop ()
    {
        currentWeapon.transform.parent = null;
        currentWeapon.GetComponent<Rigidbody>().isKinematic = false;
        canPickUp = false;
        currentWeapon = null;
    }
}
