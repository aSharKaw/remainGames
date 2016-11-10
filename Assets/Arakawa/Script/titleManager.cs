using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class titleManager : MonoBehaviour {

    [SerializeField]
    private GameObject building;

    private Vector3 buildingPosition;
    private int count;

    private int transitionTime;
    private bool transition;

    Touch touch;

    //タップされればいいだけなので、細かい座標を取るのは割愛

    void Start()
    {
        count = 0;
        buildingPosition = new Vector3(Random.Range(-15, 15), -3, Random.Range(-10, 10));

        transition = false;
        transitionTime = 0 * 60;
    }

    //シーン遷移
    void Transition(bool _transition)
    {
        int _count = 0;
        _transition = true;
        while(_transition)
        {
            //チュートリアル確認ウインドウ表示に差し替えること

            if (_count == transitionTime)
            {
                _transition = false;
                SceneManager.LoadScene("main");
            }
            else
            { _count++; }
            break;
        }
    }

	void Update () {

        if(count == 60 * 0.5)
        {
            Instantiate(building, buildingPosition, building.transform.localRotation);
            buildingPosition = new Vector3(Random.Range(-15, 15), -3, Random.Range(-10, 10));

            count = 0;
        }

#if UNITY_EDITOR
        if (Input.GetMouseButtonDown(0))
        {
            transition = true;
            Transition(transition);
            Debug.Log("Title Taped");
        }
        else
        {
            count++;
        }
#elif UNITY_IPHONE
        if (Input.touchCount > 0)
        {
            if (touch.phase == TouchPhase.Began)
            {
                Transition(transition);
                Debug.Log("Title Taped");
            }
        }
        else
        {
            count++;
        }
#endif

    }
}