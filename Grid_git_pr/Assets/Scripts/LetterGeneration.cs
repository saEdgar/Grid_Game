using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LetterGeneration : MonoBehaviour
{
    string st = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    private TextMeshProUGUI myTextElement;
    

    
    
    
    // Start is called before the first frame update
    void Start()
    {
        myTextElement = GetComponent<TextMeshProUGUI>();
        char c = st[Random.Range(0,st.Length)];

         myTextElement.text = c.ToString();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
