using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventsManager : MonoBehaviour
{
    GameObject _pop_up;
    public GameObject _magic_poof;
    public Canvas canvas;
    public float timer = 0;
    bool spawned = false;
    private void Awake()
    {
        _pop_up = GameObject.FindGameObjectWithTag("PopUpWindow");
    }
    

    private void Update()
    {
        timer = Time.time;
        if (timer >= 3.2f && spawned == false)
        {
            Instantiate(_magic_poof, canvas.transform.position, transform.rotation);
            spawned = true;
            Destroy(_pop_up);
        }
    }
}
