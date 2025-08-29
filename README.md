# ATM

> ATM 화면 구성 (PopupBank)
<br>

> 유저 데이터 제작

Text 컴포넌트의 옵션을 통해 Bold체로 작성
정규식을 통해 천 단위마다 콤마(,) 찍기 ⇒ string.Format 활용
<br>
> 게임 매니저 제작

UserData 클래스 위에 [System.Serializable]을 통해 직렬화를 하면 GameManager 인스펙터에서 해당 변수의 정보를 볼 수 있음
<br>  
> 데이터와 UI 연동

public void Refresh() {  } 메소드를 만들어서 원할 때 새로운 데이터가 반영되도록 개선
<br>  
> 입금 UI 제작

Vertical Layout을 이용해 버튼마다 동일한 간격으로 배치하기
<br>  
> 출금 UI 제작

Vertical Layout을 이용해 버튼마다 동일한 간격으로 배치하기
<br>  

> 입출금 창 이동
> 
<br>

> 입금 기능 만들기

잔액이 부족하면 팝업 띄우기 (PopupError)
<br>  
> 출금 기능 만들기

잔액이 부족하면 팝업 띄우기 (PopupError)
<br>  
> 저장 및 로드 기능 만들기

Json을 통한 저장 및 로드

