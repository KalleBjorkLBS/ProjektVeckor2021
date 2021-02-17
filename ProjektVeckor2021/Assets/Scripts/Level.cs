using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{

    public Transform player = null;
    public Camera cam = null;
    private float startpos, length;
    
    [SerializeField]
    private GameObject[] platforms = new GameObject[10]; 
    private void Awake() {

        startpos = player.position.x; //Vart starten börjar
        length = platforms[1].transform.localScale.x;
        
    }
    
    void Update()
    {
        int random;
        random = Random.Range(0,platforms.Length); 
      
        if (player.transform.position.x > startpos + length){
            startpos += length; 
            Instantiate(platforms[random],new Vector2(player.position.x +(length-1),0), Quaternion.identity);
        }
    }
}