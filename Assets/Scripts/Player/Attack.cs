using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

// 玩家攻击脚本
public class Attack : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float fireInterval;
    private float nextFire; // 开火间隔
    public Transform muzzleTransform;

    // Update is called once per frame
    void Update()
    {

            
        if (Input.GetMouseButton(0) && Time.time > nextFire){
            nextFire = Time.time + fireInterval;
            GameObject bullet = Instantiate(bulletPrefab, muzzleTransform.position, muzzleTransform.rotation);
            bullet.GetComponent<Rigidbody2D>().velocity = new Vector2(-5, 0);
        }
        

        Vector2 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float rotZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;//Radius -> Degree 弧度转角度
        transform.rotation = Quaternion.Euler(0, 0, rotZ);

        
    }
}
