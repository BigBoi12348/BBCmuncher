using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class CountDownTimer : MonoBehaviour
{
    public string LevelToLoad;
    public float timer = 10f;
    private Text timerSeconds;
    public Enemy enemy;


    // Use this for initialization
    void Start()
    {
        timerSeconds = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        timerSeconds.text = timer.ToString("f2");
        //Enemy.Die.Invoke(gameObject); // tell the game that our tanks should go faster
        //Debug.Log("Shrek");
        if (timer <= 0)
        {
            Application.LoadLevel(LevelToLoad);
        }

    }
    public void AddTime()
    {
        timer += 3f;
    }
    
    
}
