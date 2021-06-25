using UnityEngine;

public class TriggerEvent : MonoBehaviour
{
    [SerializeField]
    private GameObject moveObject;

    [SerializeField] //왜 따로 선언하는거지??
    private Vector3 moveDirection;
    private float moveSpeed;


    private void OnTriggerEnter2D(Collider2D collision) { //moveObject의 색상을 검은색으로 선언한다
        moveObject.GetComponent<SpriteRenderer>().color = Color.black;
    }

    private void OnTriggerStay2D(Collider2D collision) { //moveObject를 moveDirection방향으로 움직인다
        moveObject.transform.position += moveDirection * moveSpeed * Time.deltaTime;
    }

    private void OnTriggerExit2D(Collider2D collision) { //충돌 종료되는 순간 1회 호출 : 
        moveObject.GetComponent<SpriteRenderer>().color = Color.white;
        moveObject.transform.position = new Vector3(0, 4, 0); //충돌 종료되는 순간 색 바꾸고 0,4,0으로 이동시킴
    
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
