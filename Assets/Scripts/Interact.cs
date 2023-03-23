using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact : MonoBehaviour
{
    // Referencing
    public KeyCards KeyCards;

    // Red Key Card
    public GameObject RedInteractEImage;
    public GameObject RedE;
    public bool RedKeyCardCollectable;
    public GameObject RedKeyCard;
    public GameObject RedKeyCardCollected;



    // Start is called before the first frame update
    void Start()
    {
        RedInteractEImage.SetActive(false);
        RedKeyCardCollected.SetActive(false);
        RedE.SetActive(false);
        RedKeyCardCollectable = false;
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.E) && RedKeyCardCollectable == true)
        {
            FindObjectOfType<AudioManager>().Play("Click");
            RedKeyCardCollected.SetActive(true);
            KeyCards.redKeyCard = true;
            Destroy(RedKeyCard);
        }
    }

    void OnTriggerEnter(Collider player)
    {
        if (player.gameObject.tag == "Player")
        {
            RedInteractEImage.SetActive(true);
            RedE.SetActive(true);
            RedKeyCardCollectable = true;
        }
    }

    void OnTriggerExit(Collider player)
    {
        if (player.gameObject.tag == "Player")
        {
            RedInteractEImage.SetActive(false);
            RedE.SetActive(false);
            RedKeyCardCollectable = false;
        }
    }

}
