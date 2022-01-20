using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform firePoint;
    public GameObject tennisBallPrefab;
    public GameObject baseBallPrefab;
    public GameObject dodgeBallPrefab;
    public GameObject basketBallPrefab;
    public GameObject soccerBallPrefab;
    float tennisBallForce = -9f;
    float baseBallForce = -8f;
    float dodgeBallForce = -7f;
    float basketBallForce = -6f;
    float soccerBallForce = -5f;
    string currentObject = "tennisBall";
    
    
    void Update()
    {
        // check what object is currently selected
        if (Input.GetButtonDown("tennisBallKey")) {
            currentObject = "tennisBall";
        } else if (Input.GetButtonDown("baseBallKey")) {
            currentObject = "baseBall";
        } else if (Input.GetButtonDown("dodgeBallKey")) {
            currentObject = "dodgeBall";
        } else if (Input.GetButtonDown("basketBallKey")) {
            currentObject = "basketBall";
        } else if (Input.GetButtonDown("soccerBallKey")) {
            currentObject = "soccerBall";
        }
        
        // if fire is pressed, call the appropriate function
        if (Input.GetButtonDown("Fire1")) {
            if (currentObject == "tennisBall") {
                ShootTennisBall();
            } else if (currentObject == "baseBall") {
                ShootBaseBall();
            } else if (currentObject == "dodgeBall") {
                ShootDodgeBall();
            } else if (currentObject == "basketBall") {
                ShootBasketBall();
            } else if (currentObject == "soccerBall") {
                ShootSoccerBall();
            }
        }
    }
    
    
    
    void ShootTennisBall() {
        GameObject tennisBall = Instantiate(tennisBallPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = tennisBall.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up * tennisBallForce, ForceMode2D.Impulse);
    }
    
    void ShootBaseBall() {
        GameObject baseBall = Instantiate(baseBallPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = baseBall.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up * baseBallForce, ForceMode2D.Impulse);
    }
    void ShootDodgeBall() {
        GameObject dodgeBall = Instantiate(dodgeBallPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = dodgeBall.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up * dodgeBallForce, ForceMode2D.Impulse);
    }
    void ShootBasketBall() {
        GameObject basketBall = Instantiate(basketBallPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = basketBall.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up * basketBallForce, ForceMode2D.Impulse);
    }
    void ShootSoccerBall() {
        GameObject soccerBall = Instantiate(soccerBallPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = soccerBall.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up * soccerBallForce, ForceMode2D.Impulse);
    }
    
}
