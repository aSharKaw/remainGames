using UnityEngine;
using System.Collections;
//using UnityEngine.SceneManagement;


public class titleManager : MonoBehaviour {

    //touchManager.TouchInfo Touch = touchManager.GetTouch(0);

    [SerializeField]
    private GameObject building;
    [SerializeField]
    private GameObject explosion;

    private Vector3 buildingPosition;
    private int count;

    private int transitionTime;
    private bool transition;

    //タップされればいいだけなので、細かい座標を取るのは割愛


    // Use this for initialization
    void Start()
    {
        count = 0;
        //building.transform.eulerAngles = new Vector3(90, 0, 0);
        buildingPosition = new Vector3(Random.Range(-15, 15), -3, Random.Range(-10, 10));

        transition = false;
        transitionTime = 30 * 60;
    }

    void Transition(bool _transition)
    {
        int _count = 0;
        _transition = true;
        while(_transition)
        {
            //チュートリアル確認ウインドウ表示に差し替えること
            Instantiate(explosion, new Vector3(Random.Range(-5, 5), 0, Random.Range(-5, 5)), Quaternion.Euler(Vector3.zero));

            if (_count == transitionTime)
            {
                _transition = false;
            }
            else
            { _count++; }
            break;
        }

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
            Transition(transition);
            Debug.Log("Title Taped");
        }
        else
        {
            count++;
        }

	}
}