using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class LeftOrRight : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Input.GetAxis("Horizontal") * 30f * Time.deltaTime, 0f, 0f);

        Vector3 characterScale = transform.localScale;
        if (Input.GetAxis("Horizontal") < 0)
        {
            characterScale.x = -1056;
        }
        if (Input.GetAxis("Horizontal") > 0)
        {
            characterScale.x = 1056;
        }
        transform.localScale = characterScale;
    }
}