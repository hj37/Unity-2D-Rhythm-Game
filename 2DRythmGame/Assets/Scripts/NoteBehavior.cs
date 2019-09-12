using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteBehavior : MonoBehaviour
{
    // Start is called before the first frame update

    public int noteType;
   
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * GameManager.instance.noteSpeed); //노트가 정해진 스피드로 매프레임마다 내려감 
    }
}
