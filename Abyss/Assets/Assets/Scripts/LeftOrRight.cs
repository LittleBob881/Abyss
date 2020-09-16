using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class LeftOrRight : MonoBehaviour
{
    public float movement = 300;
    public GameObject character;

    private Rigidbody2D characterBody;
    private float ScreenWidth;
    // Start is called before the first frame update
    void Start()
    {
        //ScreenWidth = ScreenWidth;
        characterBody = character.GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        int i = 0;
        while (i < Input.touchCount)
        {
            if(Input.GetTouch(i).position.x > ScreenWidth / 2)
            {
                Walk(1.0f);
            }
            if(Input.GetTouch(i).position.x < ScreenWidth / 2)
            {
                Walk(-1.0f);
            }
            ++i;
        }
    }

    private void Walk(float horizontalInput)
    {
        characterBody.AddForce(new Vector2(horizontalInput * movement * Time.deltaTime, 0));
    }
}
