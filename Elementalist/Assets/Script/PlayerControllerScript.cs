using UnityEngine;

public class PlayerControllerScript : MonoBehaviour
{
	public JoyStick joystick;   //조이스틱 스크립트
	public float MoveSpeed;     //플레이어 이동속도

	private Vector3 _moveVector; //플레이어 이동벡터
	private Transform _transform;

	int stop = 1; // 1위 2아래 3오른쪽 4왼쪽

	public Animator anima;
	void Start()
	{
		_transform = transform;      //Transform 캐싱
		_moveVector = Vector3.zero;  //플레이어 이동벡터 초기화
	}

	void Update()
	{
		//터치패드 입력 받기
		HandleInput();
	}

	void FixedUpdate()
	{
		//플레이어 이동
		Move();
	}

	public void HandleInput()
	{
		_moveVector = PoolInput();
	}

	public Vector3 PoolInput()
	{
		float h = joystick.GetHorizontalValue();
		float v = joystick.GetVerticalValue();
		//	Debug.Log ("h = " + h + "v = " + v);
		if (h > 0 && v < 0.9 && v > -0.9) {
			anima.Play ("Right");
			stop = 3;
		}
		else if (h < 0 && h != 0 && v < 0.9 && v > -0.9) {
			anima.Play ("Left");
			stop = 4;
		} 
		else if (h < 0.8 && h > -0.8 && v > 0.9) {
			anima.Play ("Back");
			stop = 2;
		}
		else if (h < 0.8 && h > -0.8 && v < -0.9) {
			anima.Play ("Front");
			stop = 1;
		}
		if (h == 0 && v == 0) {
			switch (stop) {
			case 1:
				{
					anima.Play ("Front_stop");
					break;
				}
			case 2:
				{
					anima.Play ("Back_stop");
					break;
				}
			case 3:
				{
					anima.Play ("Right_stop");
					break;
				}
			case 4:
				{
					anima.Play ("Left_stop");
					break;
				}
			}
		}
		Vector3 moveDir = new Vector3(h, v, 0).normalized;

		return moveDir;
	}

	public void Move()
	{
		_transform.Translate(_moveVector * MoveSpeed * Time.deltaTime);
	}
}
