using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteController : MonoBehaviour
{
    // Start is called before the first frame update
    //하나의 노트에 대한 정보를 담는 노트(Note) 클래스를 정의
    class Note
    {
        public int noteType { get; set; }
        public int order { get; set; }
        public Note(int noteType,int order)
        {
            this.noteType = noteType;
            this.order = order;
        }
    
    }

    public GameObject[] Notes;//노트 프리펩에 담아서 떨어뜨리도록
    private List<Note> notes = new List<Note>();//실제로 떨어지게 될 노트를 담는 List
    private float beatInterval = 1.0f;  //노트간의 시간 간격 
    
    IEnumerator AwaitMakeNote(Note note)
    {//특정시간을 기다렸다가 노트가 떨어지게 (코루틴에서 쓰는 자료형) 
        int noteType = note.noteType;
        int order = note.order;
        yield return new WaitForSeconds(order * beatInterval);//유니티엔진에게 특정 명령 (몇초동안 기다린동안 아래쪽 명령어를 실행하라
        Instantiate(Notes[noteType - 1]);//인덱스가 0부터 시작하므로 -1씩 해줌 
    }
    void Start()
    {
        notes.Add(new Note(1, 1));  
        notes.Add(new Note(2, 2));
        notes.Add(new Note(3, 3));
        notes.Add(new Note(4, 4));
        notes.Add(new Note(1, 5));
        notes.Add(new Note(2, 6));
        notes.Add(new Note(3, 7));
        notes.Add(new Note(4, 8));
        //모든 노트를 정해진 시간에 출발하도록 설정
        for(int i = 0; i < notes.Count; i++)
        {
            StartCoroutine(AwaitMakeNote(notes[i]));//특정시간에 실제로 노트가 생성될수있도록 
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
