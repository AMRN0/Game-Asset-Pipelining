using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnHit : MonoBehaviour
{
    public Object PS;
    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

    void OnTriggerEnter()
    {
        Instantiate(PS, gameObject.transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
