using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{//싱글톤 기법으로 구현함
    public static GameManager instance { get; set; }
    private void Awake()
    {
        if (instance == null) instance = this;
        else if (instance != this) Destroy(gameObject);//오류발견시 파괴
    }

    public float noteSpeed;
    // Start is called before the first frame update
    /*
     * BAD : 1
     * GOOD : 2
     * PERFECT : 3
     * MISS : 4
     */

    public enum judges { NONE = 0, BAD, GOOD, PERFECT, MISS};//판정값 초기에는 0, BAD라는 문자는 1 

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
