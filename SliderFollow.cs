using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class SliderFollow : MonoBehaviour
{
    private RectTransform slider;
    [SerializeField] private Transform player;
    [SerializeField] private float _offSet;

    
    void Start()
    {
      slider = gameObject.GetComponent<RectTransform>();
    }

    void Update()
    {
      Vector3 pos = Camera.main.ViewportToWorldPoint(player.position);
      slider.position = Camera.main.WorldToViewportPoint(new Vector3(pos.x ,pos.y + _offSet , pos.z));
    }
}
