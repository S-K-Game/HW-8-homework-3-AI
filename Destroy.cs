using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    [Tooltip("Every object tagged with this tag will trigger the destruction of this object")]
    [SerializeField] string triggeringTag;

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == triggeringTag && enabled)
        {
            Debug.Log("Its is Destroy the object0");
            Destroy(gameObject);
        }
    }
}
