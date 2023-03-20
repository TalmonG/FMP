using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dialogue : MonoBehaviour
{


    public TextMeshProUGUI textComponent;
    public float textSpeed;

    private int index;
    [TextArea(7, 10)]
    public string[] sentences;

    public Sound[] sounds;
    


    // Start is called before the first frame update
    void Start()
    {
        textComponent.text = string.Empty;
        StartDialogue();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (textComponent.text == sentences[index])
            {
                //NextLine();
            }
            else
            {
                StopAllCoroutines();
                textComponent.text = sentences[index];
            }
        }
    }

    void StartDialogue()
    {
        index = 0;
        StartCoroutine(TypeLine());
    }

    void Awake()
    {
        foreach (Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
        }
    }
    IEnumerator TypeLine()
    {
        foreach (char c in sentences[index].ToCharArray())
        {
            textComponent.text += c;
            yield return new WaitForSeconds(textSpeed);
            /*c = gameObject.AddComponent<AudioSource>();
            c.source.clip = s.clip;

            c.source.volume = s.volume;
            c.source.pitch = s.pitch;*/
        }
    }

    void NextLine()
    {
        if (index < sentences.Length - 1)
        {
            index++;
            textComponent.text = string.Empty;
            StartCoroutine(TypeLine());
        }
        else
        {
            gameObject.SetActive(false);
        }
    }

}
