using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubic : MonoBehaviour
{
    public GameObject[] objects;
    private GameObject inst_obj;


    void Start()
    {
        int rand = Random.Range(0, objects.Length - 1);
        inst_obj = Instantiate(objects[rand], new Vector3(9.64f, 16.9f, 5.93f), Quaternion.identity) as GameObject;
        inst_obj.transform.localScale = new Vector3(3f, 3f, 3f);
    }


}

