using UnityEngine;


public class CollisionEvent : MonoBehaviour
{
    [SerializeField]
    private Color color;
        private SpriteRenderer spriteRenderer;

        private void Awake()
        {
            spriteRenderer = GetComponent<SpriteRenderer>();
        }
        private void OnCollisionEnter2D(Collision2D collision) //충돌했을때 1회 호출되는 함수
        {
            spriteRenderer.color = color;
        }
    

    private void OnCollisionStay2D(Collision2D collsion) //있어도 상관은 없으나 알림 자꾸 떠서 주석처리함
    {
  //      Debug.Log(gameObject.name + " : OnCollisionStay2D() method executes");
  //충돌할때마다 log를 남겨줌
    }

        private void OnCollisionExit2D(Collision2D collision)
        {
            spriteRenderer.color = Color.white;
        }
   

    // Update is called once per frame
    void Update()
    {
        
    }
}
