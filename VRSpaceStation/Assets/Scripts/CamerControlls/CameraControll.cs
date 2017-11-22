using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControll : MonoBehaviour
{
    //Mouse
    private Transform m_CameraTransform;
    private Transform m_Parent;

    private Vector3 m_LocalRotation;
    private float m_CamDistance = 1.5f;

    public float m_MouseSensitivity = 4f;
    public float m_KeySpeed = 40f;
    public float m_ScrollSensitivity = 2f;
    public float m_OrbitDamp = 10f;
    public float m_ScrollDamp = 6f;

    private bool m_Panning = false;

    public GameObject m_Object;
    private Vector3 m_TargetPos;

    private Camera m_Cam;

    public Vector3 m_ScreenPoint;
    public Vector3 m_Offset;
    public RaycastHit hit;
    // Use this for initialization
    void Start()
    {
        m_CameraTransform = this.transform;
        m_Parent = this.transform.parent;

        m_TargetPos = transform.position;
        m_Cam = GetComponent<Camera>();
    }

    void Update()
    {
        /*if (Input.GetMouseButtonDown(0))
        {
             Ray ray = m_Cam.ScreenPointToRay(Input.mousePosition);
           // Ray ray = GetComponent<Camera>().ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(m_Cam.ScreenPointToRay(Input.mousePosition), out hit))
            {
                print(hit);
                //Vector3 m_MousePos = Input.mousePosition;
                hit.transform.position += m_Cam.ScreenToWorldPoint(Input.mousePosition);   //new Vector3(m_MousePos.x, m_MousePos.y, hit.distance));
                //hit.transform.position += Input.mousePosition;
                //m_Object.transform.position += m_TargetPos;

            }
        }*/

        //Physics.Raycast(m_Cam.ScreenPointToRay(Input.mousePosition), out hit);

        if (Input.GetMouseButtonDown(1))
        {
            //right click was pressed    
            m_Panning = true;
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
        }
        if (Input.GetMouseButtonUp(1))
        {
            //right click was released    
            m_Panning = false;
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
        /* if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.D))
             m_Panning = true;
         if (Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.D))
             m_Panning = false;*/

    }
    // Update is called once per frame
    void LateUpdate()
    {

        if (m_Panning)//Mouse input
        {
            if (Input.GetAxis("Mouse X") != 0 || Input.GetAxis("Mouse Y") != 0)
            {
                m_LocalRotation.x += Input.GetAxis("Mouse X") * m_MouseSensitivity;
                m_LocalRotation.y -= Input.GetAxis("Mouse Y") * m_MouseSensitivity;

                m_LocalRotation.y = Mathf.Clamp(m_LocalRotation.y, -90f, 90f);
            }
        }

        //keyboard input left right up and down
        if (Input.GetKey(KeyCode.A))
            m_LocalRotation.x += Time.deltaTime * m_KeySpeed;
        if (Input.GetKey(KeyCode.D))
            m_LocalRotation.x -= Time.deltaTime * m_KeySpeed;
        if (Input.GetKey(KeyCode.W))
        {
            m_LocalRotation.y += Time.deltaTime * m_KeySpeed;
            m_LocalRotation.y = Mathf.Clamp(m_LocalRotation.y, -90f, 90f);
        }
        if (Input.GetKey(KeyCode.S))
        {
            m_LocalRotation.y -= Time.deltaTime * m_KeySpeed;
            m_LocalRotation.y = Mathf.Clamp(m_LocalRotation.y, -90f, 90f);
        }

        //Mouse zoom in and out
        if (Input.GetAxis("Mouse ScrollWheel") != 0f)
        {
            float m_ScrollAmount = Input.GetAxis("Mouse ScrollWheel") * m_ScrollSensitivity;

            m_ScrollAmount *= (m_CamDistance * 0.3f);
            m_CamDistance += m_ScrollAmount * -1f;
            m_CamDistance = Mathf.Clamp(m_CamDistance, 0.5f, 3f);
        }

        //Keyboard in and out
        if (Input.GetKey(KeyCode.Q))
        {
            float m_ScrollAmount = Time.deltaTime * m_ScrollSensitivity;

            m_ScrollAmount *= (m_CamDistance * 0.3f);
            m_CamDistance += m_ScrollAmount * -1;
            m_CamDistance = Mathf.Clamp(m_CamDistance, 0.5f, 3f);
        }
        if (Input.GetKey(KeyCode.E))
        {
            float m_ScrollAmount = Time.deltaTime * m_ScrollSensitivity;

            m_ScrollAmount *= (m_CamDistance * 0.3f);
            m_CamDistance -= m_ScrollAmount * -1;
            m_CamDistance = Mathf.Clamp(m_CamDistance, 0.5f, 3f);
        }



        Quaternion m_Qt = Quaternion.Euler(m_LocalRotation.y, m_LocalRotation.x, 0);
        m_Parent.rotation = Quaternion.Lerp(m_Parent.rotation, m_Qt, Time.deltaTime * m_OrbitDamp);

        if (m_CameraTransform.localPosition.z != m_CamDistance * -1f)
        {
            m_CameraTransform.localPosition = new Vector3(0f, 0f, Mathf.Lerp(m_CameraTransform.localPosition.z, m_CamDistance * -1f, Time.deltaTime * m_ScrollDamp));
        }
    }


    void OnMouseDown()
    {

        m_ScreenPoint = m_Cam.WorldToScreenPoint(Input.mousePosition);
        m_Offset = Input.mousePosition - m_Cam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, hit.distance));


    }
   void OnMouseDrag()
    {
        print("Hi");
        if (Physics.Raycast(m_Cam.ScreenPointToRay(Input.mousePosition), out hit))
        {
            Vector3 m_curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, hit.distance);
            Vector3 m_curPosition = m_Cam.ScreenToWorldPoint(m_curScreenPoint) + m_Offset;
            hit.transform.position = m_curPosition;
        }
    }
}
