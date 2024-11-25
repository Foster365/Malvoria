using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("Player movement variables")]
    [SerializeField] LayerMask nodeMask;
    bool collisionWithNode, isMoving = true;
    Vector2 nodePosition;
    float speed = 5f;
    Vector3 target;

    [Header("Player stats")]
    [SerializeField] int maxHealth, maxOxygen;
    int health, oxygen;

    Animator anim;

    public int Health { get => health; set => health = value; }
    public int Oxygen { get => oxygen; set => oxygen = value; }
    public bool IsMoving { get => isMoving; set => isMoving = value; }

    private void Awake()
    {
        anim = GetComponent<Animator>();
    }

    void Start()
    {
        target = transform.position;
        health = maxHealth;
        oxygen = maxOxygen;
    }

    void Update()
    {
        if (IsMoving)
        {
            anim.enabled = true;
            CheckInputs();
            RotateTowardsMousePosition();
        }
        else anim.enabled = false;
    }

    void CheckInputs()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 worldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(worldPosition, Vector2.zero, 1, nodeMask);
            if (hit && !hit.collider.gameObject.GetComponent<Node>().IsVisited)
            {
                target = hit.collider.transform.position;
                target.z = transform.position.z;

            }

        }
        if (target != null) transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
    }


    void RotateTowardsMousePosition()
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos = Camera.main.ScreenToWorldPoint(mousePos);
        
        Vector2 direction = new Vector2(mousePos.x - transform.position.x, mousePos.y - transform.position.y);

        transform.up = direction;
    }
}