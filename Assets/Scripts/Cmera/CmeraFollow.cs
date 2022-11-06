using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CmeraFollow : MonoBehaviour
{
    public Transform m_playerTransform;
    //public float Ahead;
    public Vector3 targetPosX;
    public Vector3 targetPosY;
    public float smooth; // 阻尼

    void Update()
    {
        // 设定追踪带有 “player” tag 的 Object
        m_playerTransform = GameObject.FindWithTag("Player").GetComponent<Transform>();
        Follow();
    }
    // 追踪
    public void Follow() 
    {
        targetPosX = new Vector3(m_playerTransform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
        targetPosY = new Vector3(gameObject.transform.position.x, m_playerTransform.position.y, gameObject.transform.position.z);
        
        //X轴追踪
        if (m_playerTransform.position.x > 0f)
        {
            targetPosX = new Vector3(m_playerTransform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
        } else {
            targetPosX = new Vector3(m_playerTransform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
        }

        //Y轴追踪
        if (m_playerTransform.position.y > 0f)
        {
            targetPosY = new Vector3(gameObject.transform.position.x, m_playerTransform.position.y, gameObject.transform.position.z);
        } else {
            targetPosY = new Vector3(gameObject.transform.position.x, m_playerTransform.position.y, gameObject.transform.position.z);
        }
        // 数据合并，实现追踪效果
        transform.position = Vector3.Lerp(transform.position, targetPosX, smooth * Time.deltaTime);
        transform.position = Vector3.Lerp(transform.position, targetPosY, smooth * Time.deltaTime);
    }

}
