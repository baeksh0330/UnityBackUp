using UnityEngine;

public class movement2D : MonoBehaviour
{
    private float moveSpeed = 5.0f; //이동속도
    private Vector3 moveDirection = Vector3.zero; //이동방향
    private Rigidbody2D rigid2D;


    private void Awake() {  //transform 변수는 모든 함수에서 다 쓰이는거라서 소문자로 접근 가능

        rigid2D = GetComponent<Rigidbody2D>(); //transform을 제외한 다른 변수는 get함수를 통해 접근가능(private이라 그런가봄)
    
    }


    private void Update() //Update함수 : 게임이 진행될때마다 계속 실행되는 함수
    {

        //Negative left , a : -1 (asdw기능은 내장되어 있음)
        //Positive right, d : 1
        //else : 0

        float x = Input.GetAxisRaw("Horizontal"); //좌우이동 -> 유니티 단축키 함수: Input.GetAxisRaw("여기에 들어가는것만 다르게")
        //Negative down, s
        float y = Input.GetAxisRaw("Vertical"); //위아래 이동
        //Positive up, w

        moveDirection = new Vector3(x, y, 0); //x,y입력하는 만큼 object의 x,y축 움직여주기
        //새 위치= 현재 위치 +1
        //transform.position = transform.position + new Vector3(1, 0, 0) * 1; //new Vector : 벡터값 클래스 선언
        //=  transform.position += Vector3.right * 1 * Time.deltaTime; //지속시키기 위해서는 Time.deltaTime꼭 곱해주기

       // transform.position += moveDirection * moveSpeed * Time.deltaTime;

        //transform:내가 소속되어있는 게임 오브젝트의 transform component
        //transform.postion=소속된 게임 오브젝트의 위치

        rigid2D.velocity = new Vector3(x, y, 0) * moveSpeed;//기존의 transform.position대신 Rigidbody2D이용해서 움직일 수 있다는 뜻

        //rigid2D를 사용하면 좀더 부드러운 액션이 가능하고 이벤트 함수 호출 가능


    }

}
