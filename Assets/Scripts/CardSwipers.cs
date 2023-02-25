using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardSwipers : MonoBehaviour
{
    public KeyCards KeyCards;

    [Header("Card Swipers")]
    public GameObject redCardSwiper_StatusDenied;
    public GameObject redCardSwiper_StatusGranted;

    [Header("Card Swipers Unlocked")]
    public bool redCardSwiperUnlockStatus = false;

    public bool redCardSwiperUsable;

    public GameObject redCardSwiperE;

    private void Awake()
    {
        redCardSwiperUsable = false;
        redCardSwiper_StatusDenied.SetActive(true);
        redCardSwiper_StatusGranted.SetActive(false);
        redCardSwiperE.SetActive(false);

    }

    void Update()
    {
        if (Input.GetKey(KeyCode.E) && KeyCards.redKeyCard == true)
        {
            /*if (Input.GetKey(KeyCode.E) && KeyCards.redKeyCard == true)
            {
                Debug.Log("Red KeyCard Accepted!");
                FindObjectOfType<AudioManager>().Play("Click");
                redCardSwiper_StatusDenied.SetActive(false);
                redCardSwiper_StatusGranted.SetActive(true);
                KeyCards.redKeyCard = false;
                Destroy(redCardSwiper_StatusDenied);
            }*/
        }
    }

    void OnTriggerStay(Collider player)
    {
        if (Input.GetKey(KeyCode.E) && KeyCards.redKeyCard == true)
        {
            FindObjectOfType<AudioManager>().Play("Click");
            redCardSwiper_StatusDenied.SetActive(false);
            redCardSwiper_StatusGranted.SetActive(true);
            redCardSwiperUnlockStatus = true;
            KeyCards.redKeyCard = false;
            Destroy(redCardSwiper_StatusDenied);
            Destroy(redCardSwiperE);

        }
    }

    void OnTriggerEnter(Collider player)
    {
        if (player.gameObject.tag == "Player" && redCardSwiperUnlockStatus == false)
        {
            /*if (Input.GetKey(KeyCode.E) && KeyCards.redKeyCard == true)
            {
                Debug.Log("Red KeyCard Accepted!");
                FindObjectOfType<AudioManager>().Play("Click");
                redCardSwiper_StatusDenied.SetActive(false);
                redCardSwiper_StatusGranted.SetActive(true);
                KeyCards.redKeyCard = false;
                Destroy(redCardSwiper_StatusDenied);
            }*/
            redCardSwiperE.SetActive(true);
            redCardSwiperUsable = true;
        }
    }

    void OnTriggerExit(Collider player)
    {
        if (player.gameObject.tag == "Player" && redCardSwiperUnlockStatus == false)
        {
            redCardSwiperE.SetActive(false);
            redCardSwiperUsable = false;
        }
    }
}
