using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorsUnlock : MonoBehaviour
{
    public GameObject RedDoor;
    public CardSwipers CardSwipers;
    [SerializeField] private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (CardSwipers.redCardSwiperUnlockStatus == true)
        {
            //RedDoor.GetComponent<Animation>().Play("RedDoorOpen");
            animator.SetBool("RedDoorOpen", true);
        }
    }
}
