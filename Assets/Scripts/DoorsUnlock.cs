using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorsUnlock : MonoBehaviour
{
    public GameObject RedDoor;
    public CardSwipers CardSwipers;
    [SerializeField] private Animator animator;
    public GameObject DoorOpens;
    public bool DoorOpenStatus = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (CardSwipers.redCardSwiperUnlockStatus == true && DoorOpenStatus == false)
        {
            //RedDoor.GetComponent<Animation>().Play("RedDoorOpen");
            FindObjectOfType<AudioManager>().Play("DoorOpening");
            //DoorOpens.SetActive(true);
            animator.SetBool("RedDoorOpen", true);
            FindObjectOfType<AudioManager>().Play("Suspense");
            DoorOpenStatus = true;

        }
    }
}
