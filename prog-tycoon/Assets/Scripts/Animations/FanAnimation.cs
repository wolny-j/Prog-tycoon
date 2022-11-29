using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FanAnimation : MonoBehaviour
{
    [SerializeField] GameObject fanWings;

    void FixedUpdate()
    {
        fanWings.transform.Rotate(0, 0, 8);
    }
}
