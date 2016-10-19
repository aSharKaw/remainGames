using UnityEngine;
using System.Collections;
//using UnityEngine.SceneManagement;


public class titleManager : MonoBehaviour {

    touchManager.TouchInfo Touch = touchManager.GetTouch(0);

    [SerializeField]
    private GameObject building;

    private Vector3 buildingPosition = new Vector3(Random.Range(60 / -2, 60 / 2), -2, Random.Range(25 / -2, 25 / 2));
    private Quaternion buildingQuat = new Quaternion(-90, 0, 0, 0);

    private int count;

    //タップされればいいだけなので、細かい座標を取るのは割愛
    // Use this for initialization
    void Start () {
        count = 0;
	}
	
	// Update is called once per frame
	void Update () {

        if(count == 60 * 0.5)
        {
            Instantiate(building, buildingPosition, buildingQuat);
            buildingPosition = new Vector3(Random.Range(60 / -2, 60 / 2), -2, Random.Range(25 / -2, 25 / 2));
            count = 0;
        }

        if (Input.GetMouseButtonDown(0) || Touch == touchManager.TouchInfo.Began)
        {
            Debug.Log("Title Taped");
            //チュートリアル確認ウインドウ表示に差し替えること

            UnityEngine.SceneManagement.SceneManager.LoadScene("main");
        }
        else
        {
            count++;
        }

	}
}