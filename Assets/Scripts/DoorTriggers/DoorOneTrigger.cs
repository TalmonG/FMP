using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOneTrigger : MonoBehaviour
{
    [SerializeField] private Animator animator;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider player)
    {
        if (player.gameObject.tag == "Player")
        {
            //GetComponent<Animator>().Play("DoorOneClose");
            animator.SetBool("DoorOneClose", true);
            Debug.Log("Animation was played");
        }
    }
}
