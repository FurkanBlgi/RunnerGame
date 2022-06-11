using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Karakter : MonoBehaviour
{
    float _lastFingerPos;
    float move_x;
    [SerializeField] float move_x_guc;
    [SerializeField] float sinirx;
    public GameObject GameOverPanel;
    void Start()
    {
        
    }


    void Update()
    {
        kontrol();
    }
    public void kontrol()
    {
        
        if (Input.GetMouseButtonDown(0))
        {
            _lastFingerPos = Input.mousePosition.x;
        }else if (Input.GetMouseButton(0))
        {
            move_x = _lastFingerPos - Input.mousePosition.x;
            _lastFingerPos = Input.mousePosition.x;
        }else if (Input.GetMouseButtonUp(0))
        {
            move_x = 0;
        }
        float sinir = Mathf.Clamp(value: transform.position.x, min: -sinirx, max: sinirx);
        transform.position = new Vector3(sinir, transform.position.y,transform.position.z);
        transform.Translate(new Vector3(move_x, 0, -5f)*Time.fixedDeltaTime*0.5f*move_x_guc);
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("dusman"))
        {
            Time.timeScale = 0;
            
            GameOverPanel.SetActive(true);
        }
    }
}
