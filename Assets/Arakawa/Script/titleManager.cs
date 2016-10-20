using UnityEngine;
using System.Collections;
//using UnityEngine.SceneManagement;


public class titleManager : MonoBehaviour {

    //touchManager.TouchInfo Touch = touchManager.GetTouch(0);

    [SerializeField]
    private GameObject building;

    private Vector3 buildingPosition;

    private int count;

    //タップされればいいだけなので、細かい座標を取るのは割愛
    // Use this for initialization
    void Start () {
        count = 0;
        //building.transform.eulerAngles = new Vector3(90, 0, 0);
        buildingPosition = new Vector3(Random.Range(-15, 15), -3, Random.Range(-10, 10));
    }
	
	// Update is called once per frame
	void Update () {

        if(count == 60 * 0.5)
        {
            Instantiate(building, buildingPosition, building.transform.localRotation);
            buildingPosition = new Vector3(Random.Range(-15, 15), -3, Random.Range(-10, 10));
            count = 0;
        }

        if (Input.GetMouseButtonDown(0))
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