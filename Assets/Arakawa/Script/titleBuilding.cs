using UnityEngine;
using System.Collections;

public class titleBuilding : MonoBehaviour {

    public GameObject break_Building;
    [SerializeField]
    private GameObject building;

    //private buildPos = building.transform;
    //transform.Translate( transform.up* 0.1f );
    private Quaternion buildingQuat;

    //ビルの耐久度(とりあえず)
    [SerializeField]
    private int durability;

    void Start()
    {
        //buildingQuat
    }


    void Update()
    {

        //building.transform.localPosition += new Vector3(0, (60.0f / 1.0f), 0);
       
        building.transform.eulerAngles = new Vector3(-90, 0, 0);

        if (building.transform.position.y >= 0)
        {     
            durability--;
        }
        else
        {
            building.transform.Translate(transform.up * -0.1f);
        }
       

        //耐久度が0なら差し替え
        if (durability <= 0)
        {
            Instantiate(break_Building,
            building.transform.localPosition,
                        Quaternion.identity);

            //元のオブジェクト消去
            Destroy(this.gameObject);
        }
    }
}
