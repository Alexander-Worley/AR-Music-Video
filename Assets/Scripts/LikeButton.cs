using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LikeButton : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI text;
    int counter = 0;
    

    void Start(){
    }
    public void OnClick(){
        // gameObject.SetActive(false);
        // text.gameObject.SetActive(!text.gameObject.active);
        counter += 1;
        text.text = counter.ToString();
        Debug.Log(counter);    
        
    }
}
