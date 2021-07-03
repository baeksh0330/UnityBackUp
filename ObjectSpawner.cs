using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject boxPrefab; //오리지널 게임오브젝트


    private void Awake() {

        Instantiate(boxPrefab); //prefab : 오리지널 게임오브젝트를 복제하는 함수(모든게 원본과 동일)
                                //한번 호출할때마다 cloning한번해줌

        /*
        //instantiate(원본 오브젝트, 위치, 회전)
        Instantiate(boxPrefab, new Vector3(3, 3, 0), Quaternion.identity); //이 함수는 호출 위치도 선언 가능함
        Instantiate(boxPrefab, new Vector3(-1, -2, 0), Quaternion.identity);

        Quaternion rotation = Quaternion.Euler(0, 0, 45);
        Instantiate(boxPrefab, new Vector3(2, 1, 0), rotation);



        //방금 생성된 게임 오브젝트의 이름 변경
        GameObject clone = Instantiate(boxPrefab, new Vector3(5, 5, 0), rotation);
        clone.name = "box001";
        //게임 오브젝트의 색상 변경
        clone.GetComponent<SpriteRenderer>().color = Color.black;
        //게임 오브젝트의 위치 변경
        clone.transform.position = new Vector3(2, 1, 0);
        //게임 오브젝트의 크기 변경
        clone.transform.localScale = new Vector3(3, 2, 1);
        */

        for (int y = 0; y < 10; ++y)
        {
            for (int x = 0; x < 10; ++x) 
            {
                Vector3 position = new Vector3(-4.5f + x, 4.5f - y, 0);
                Instantiate(boxPrefab, position, Quaternion.identity);
            }
        }


    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
