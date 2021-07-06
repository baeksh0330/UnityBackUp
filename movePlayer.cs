//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class movePlayer : MonoBehaviour
{
  
    [SerializeField]
    private float moveSpeed = 5.0f;
    private float jumpForce = 2.0f;
    private Vector3 moveDirection;
    private Rigidbody2D rigid2D;
    
    [HideInInspector]
    public bool isLongJump = false; //낮은점프, 높은 점프 체크
    private bool isGrounded;
    // Start is called before the first frame update
    void Start()
    {}
    void Awake() {
        rigid2D = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    {
        //transform.position은 Vector3이라 moveDirection을 Vector2로 선언해주면 에러 남
        //Time delatTime없으니까 얘가 이상한데로 가서 안돌아와,,
        //이거 하면 쫌 덜그럭거리는 듯함


      //  rigid2D.velocity = new Vector3(x, y, 0)*moveSpeed;
    }

    private void FixedUpdate()
    {
        if (isLongJump && (rigid2D.velocity.y > 0))
            rigid2D.gravityScale = 1.0f;
        else
            rigid2D.gravityScale = 2.5f;

        //  Bounds bounds = rigid2D.bounds; 아 이거 캡슐일때만 됨;;
        // footPosition = new Vector2(bounds.center.x, bounds.min.y);
        //  isGrounded = Physics2D.OverlapCircle(footPosition, 0.1f, groundLayer);
    }

   public void Jump()
    {
        if (isGrounded == true) //플레이어가 바닥을 밟고 있을때만 점프 가능
            rigid2D.velocity = Vector2.up * jumpForce; //jumpForce의 크기만큼 윗쪽 방향으로 속력설정
    }

    public void Move(float x) {

        // 
        float y = Input.GetAxisRaw("Vertical");
        moveDirection = new Vector3(x, y,0);
        transform.position += moveDirection * moveSpeed * Time.deltaTime;
    }

}
