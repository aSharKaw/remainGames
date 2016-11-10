using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class resultManager : MonoBehaviour
{

    [SerializeField]
    private Vector2 position = Vector2.zero;
    [SerializeField]
    private Vector2 size = Vector2.zero;

    //テストテキスト
    [SerializeField]
    private UnityEngine.UI.Text nameText;

    private string playerName = "";

    void OnGUI()
    {
        //playerName = GUI.TextField(new Rect(position, size), playerName, 5);
        //GUI.TextField(new Rect(10, 10, 100, 100), "TextField");
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //入力テスト
        //#if UNITY_EDITER
        if (Input.GetKeyDown(KeyCode.Return))
        {
            nameText.text = playerName;
        }
        //#endif

        if(Input.GetKeyDown(KeyCode.O))
        {
            SceneManager.LoadScene("title");
        }
    }

    public void NameSave()
    {
        nameText.text = playerName;
    }
}

