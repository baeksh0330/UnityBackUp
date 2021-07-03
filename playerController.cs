//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{

    private movement2D movement2D;

    // Start is called before the first frame update
   private void Awake()
    {
        movement2D = GetComponent<movement2D>();
    }

    // Update is called once per frame
    private void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        movement2D.Move(x);

        if (Input.GetKeyDown(KeyCode.Space)) //space키 눌렀을때 받아주는 함수 : space키 누르면 점프하도록
            movement2D.Jump();

        if (Input.GetKey(KeyCode.Space))
            movement2D.isLongJump = true;

        else if (Input.GetKeyUp(KeyCode.Space))
            movement2D.isLongJump = false;

    }
}
