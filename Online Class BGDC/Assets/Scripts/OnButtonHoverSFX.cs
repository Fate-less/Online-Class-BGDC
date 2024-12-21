using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class OnButtonHoverSFX : MonoBehaviour, IPointerEnterHandler
{
    private AudioManager audioManager;
    private void Start()
    {
        audioManager = GameObject.Find("AudioManager").GetComponent<AudioManager>();
    }
    public void OnPointerEnter(PointerEventData eventData)
    {
        AudioSource.PlayClipAtPoint(audioManager.buttonHoverSFX, Camera.main.transform.position);
    }
}
