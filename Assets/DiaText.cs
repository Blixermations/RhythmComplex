using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiaText : MonoBehaviour
{
    //public Text npcName;
    //public Text npcText;
    
    //public  dialogue;

    //public KeyCode end;

    public string[] sentences = new string[] {  };

    void Start()
    {
        StartDialog();
    }

    public void StartDialog () {
        
        
        //npcName.text = dia.name;    // shows the npc name!
        DisplayNextSentence();
    }

    public void DisplayNextSentence() {
        


        string number = sentences[Random.Range(0, sentences.Length)];


        print(number.ToString());
    }
}
