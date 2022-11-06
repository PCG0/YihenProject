using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoTurn : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 当鼠标在所挂载实例右侧时，实例转到右侧，反之。
        if (transform.position.x < Camera.main.ScreenToWorldPoint(Input.mousePosition).x) 
            transform.eulerAngles = new Vector3(0, 0, 0);
        if (transform.position.x > Camera.main.ScreenToWorldPoint(Input.mousePosition).x)
            transform.eulerAngles = new Vector3(0, 180, 0);
    }
}
