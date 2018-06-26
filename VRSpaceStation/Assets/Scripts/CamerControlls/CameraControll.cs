using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControll : MonoBehaviour
{
    //Mouse
    private Transform m_CameraTransform;
    private Transform m_Parent;

    private Vector3 m_LocalRotation;
    private Vector3 m_vec;
    private float m_CamDistance = 1.5f;

    public float m_MouseSensitivity = 4f;
    public float m_KeySpeed = 40f;
    public float m_ScrollSensitivity = 2f;
    public float m_OrbitDamp = 10f;
    public float m_ScrollDamp = 6f;
    public float m_MoveSpeed = 0.1f;

    private bool m_Panning = false;
    private bool m_Moving;
    private bool m_Debug;
    private bool m_ObjectSelect;
    private bool m_MenuScroll;

    public GameObject m_Object;
    public Module.ModuleMenu m_ModuleMenu;
    private Vector3 m_TargetPos;

    private Camera m_Cam;

    public Vector3 m_ScreenPoint;
    public Vector3 m_Offset;
    public RaycastHit hit;
    public float m_distance;

    public LayerMask m_LayerMask;

    // Use this for initialization
    void OnEnable()
    {
        m_CameraTransform = this.transform;
        m_Parent = this.transform.parent;

        m_TargetPos = transform.position;
        m_Cam = GetComponent<Camera>();
        m_Moving = false;
        m_Debug = false;
        m_ObjectSelect = false;
        m_Object = null;
        m_ModuleMenu = null;
    }



    void Update()
    {

        m_ScreenPoint = m_Cam.WorldToScreenPoint(Input.mousePosition);
        m_Offset = m_ScreenPoint - m_Cam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, hit.distance));


        //Moving objects
        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(m_Cam.ScreenPointToRay(Input.mousePosition), out hit))
            {

                if (!(hit.transform.gameObject.GetComponent<Module.BasicModuleInfo>() && hit.transform.gameObject.GetComponent<Module.ModuleMenu>()))
                {
                    //if the cursor is not over a module then it has clicked empty space
                    return;
                }
                else if (hit.transform.gameObject.GetComponent<Module.BasicModuleInfo>() && hit.transform.gameObject.GetComponent<Module.ModuleMenu>())
                {
                    m_ObjectSelect = true;
                    m_Object = hit.transform.gameObject;
                    m_ModuleMenu = hit.transform.gameObject.GetComponent<Module.ModuleMenu>();
                }
                /* Vector3 m_math = hit.transform.position - hit.point;//Vector3.Lerp(hit.transform.position, hit.point, 1f);
                float m_mathf = Mathf.Sqrt((m_math.x * m_math.x) + (m_math.y * m_math.y) + (m_math.z * m_math.z));
                m_distance = hit.distance + (m_mathf);//(hit.transform.localScale.z / 2);
                //print(m_mathf);*/
            }
            else
            {
                m_ObjectSelect = false;
                m_Object = null;
                m_ModuleMenu = null;
            }
            if (enabled)
            {
                print(m_ObjectSelect);
                print(m_Object.name);
            }
        }
        /*else if (Input.GetMouseButton(0))
        {
            if (!(hit.transform.gameObject.GetComponent<Module.BasicModuleInfo>() && hit.transform.gameObject.GetComponent<Module.ModuleMenu>()))
            {
                m_ObjectSelect = false;
            }
        }*/
        // once selected a module, st9re its module info into a variable



        if (m_Moving)
        {
<<<<<<< HEAD


=======
>>>>>>> afe2765ea66a6975a513f894dd432071dfece337
            if (!hit.transform.gameObject.GetComponent<Module.BasicModuleInfo>())
            {
                //if the cursor is not over a module then it has clicked empty space
                return;
            }
            else if (hit.transform.gameObject.GetComponent<Module.BasicModuleInfo>().GetMove())
            {
                //if returns true then move object
                /*
             /* the mouse movement relative to the camera's position then add GPIE2-24VNX-5XT68to the module   */

                // hit.transform.position += //m_Cam.ScreenToViewportPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, hit.distance));
                // if (Input.GetAxis("Mouse X") != 0 || Input.GetAxis("Mouse Y") != 0)
                // {
                //Vector3 m_vec = new Vector3();
                // m_vec.x = Input.GetAxis("Mouse X"); //* m_MouseSensitivity;
                // m_vec.y = Input.GetAxis("Mouse Y");// * m_MouseSensitivity;
                // m_vec.z = hit.distance;

                //print("X: " + Input.GetAxis("Mouse X") * m_MouseSensitivity + " Y: " + Input.GetAxis("Mouse Y"));

                //hit.transform.localPosition += m_vec;

                // hit.transform.localPosition += m_Cam.ScreenToWorldPoint(m_vec);


                /* THERE IS A PROBLEM, THIS WORKS OFF OF THE RAY, WHEN THE OBJECT MOVES THE RAY ISNT HITTIN IT ANYMORE*/
                // }
                m_vec = new Vector3(Input.mousePosition.x, Input.mousePosition.y, m_distance);
                hit.transform.position = Vector3.Lerp(hit.transform.position, m_Cam.ScreenToWorldPoint(m_vec), m_MoveSpeed);


            }
            /* else if (hit.transform.GetComponent<Moveable>().GetMove())
             {
                 Vector3 m_curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, m_ScreenPoint.z);
                 Vector3 m_curPosition = m_Cam.ScreenToWorldPoint(m_curScreenPoint) + m_Offset;
                 hit.transform.position = m_curPosition;
             }*/


            //Vector3 m_MousePos = Input.mousePosition;
            // hit.transform.position += m_Cam.ScreenToWorldPoint(Input.mousePosition);   //new Vector3(m_MousePos.x, m_MousePos.y, hit.distance));
            //hit.transform.position += Input.mousePosition;
            //m_Object.transform.position += m_TargetPos;

            //When hit, returns an objects, if moveable start the transform.

            // }
        }

        if (m_ModuleMenu == null)
        {
            
            m_MenuScroll = false;
        }
        else if (m_ModuleMenu != null)
        {
            m_MenuScroll = m_ModuleMenu.GetMouseOver();
            if(m_MenuScroll)
            {
                m_ModuleMenu.SetShowMenu(true);
            }
            
        }

        //when input getmousebuttonup is released then remove the movable script;

        if (Input.GetMouseButtonDown(1))
        {
            //right click was pressed, set panning to be true, hide the cursor and lock it to the centre of the screen
            m_Panning = true;
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
        }
        if (Input.GetMouseButtonUp(1))
        {
            //right click was released, panning becomes false, show the cursor and unlock it.    
            m_Panning = false;
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
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
        if (Input.GetAxis("Mouse ScrollWheel") != 0f && !m_MenuScroll)
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
    public bool GetDebug()
    {
        return m_Debug;
    }

}
