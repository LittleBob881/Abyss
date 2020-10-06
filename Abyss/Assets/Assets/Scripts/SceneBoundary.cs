using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneBoundary : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, 68f, 101f), transform.position.y, transform.position.z);
    }
}
