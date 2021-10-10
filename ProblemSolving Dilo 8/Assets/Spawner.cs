using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    int i = 0;
    bool spawning= true;
    public GameObject[] scores;
    int totalScores =4;
    public Vector3 Screen;
    private GameObject Squares;
    // Start is called before the first frame update
    void Start()
    {
        
        InvokeRepeating("Spawn", 3.0f, 3.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
    public void Spawn()
    {
        if(spawning == false)
        {
            StartCoroutine(WaitandSpawn(3f));
        }
        
        float RandomX = Random.Range(-3.8f, 4.2f);
            float RandomY = Random.Range(-2.7f, 3.4f);
            Instantiate(scores[i], new Vector2(RandomX, RandomY), Quaternion.identity);
        if(i<totalScores)
        {
            i++;
        }
        else
        {
            i = 0;
            
        }
        
        spawning = false;
        
    }
    private IEnumerator WaitandSpawn(float wait)
    {
        
        yield return new WaitForSeconds(wait);
        spawning=true;
    }
}
