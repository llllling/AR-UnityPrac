# VR/AR with Unity

절대강좌! 유니티 VR/AR 책의 프로젝트를 진행하면서 배운 것들 정리

_유니티 버전 : 2022.3.14_

# AR

- AR 콘텐츠를 제작할 때 특별히 하늘 또는 우주와 같은 배경이 필요한 경우를 제외하고는 유니티의 기본으로 설정된 Skyboxs는 미리 제거하고 진행함.

## SolarSystem

AR 콘텐츠를 개발하려면 AR SDK가 필요함.

해당 프로젝트에선 퀄컴에서 개발한 Vuforia AR SDK 사용함

그래서 아래 정리한 내용들에 해당 패키지 사용법에 관한 설명이 많음.([vf]라고 표기함)

이 프로젝트 진행하면서 Vuforia AR SDK 정리한 내용 => https://www.notion.so/Vuforia-AR-SDK-613e3bf3c5c641a99ba2b4dec6254206

### 개념적

- Trail Renderer 컴포넌트 : 움직이는 게임 오브젝트 뒤에 폴리곤 트레일을 렌더링함
  - width 속성 : 커브 에디터를 사용해 시작 부분과 끝 부분의 너비를 설정함.

* 마커(Marker)[https://www.notion.so/2ff654186fca4e718887606d7eb610b6]
  - 마커 : 현실 세계에서 카메라가 특정 객체를 인식하기 위한 식별자 역할을 하며 단순한 이미지, 3D 오브젝트, 텍스트 등이 마커가 될 수 있다.
  - 증강현실 콘텐츠의 개발 방식은 좁은 의미로 본다면 마커를 사용하는 방식과 마커를 사용하지 않는 마커리스 방식으로 구분함.
* [vf] AR Camera 프리팹 : Vuforia는 별도의 카메라 프리팹을 제공하고 있기 때문에 Main Camera는 삭제하고 Game Object(하이어라키 창에서 +) > Vuforia Engine > AR Camera 선택하여 카메라 프리팹 추가
* [vf] Image Target : Single Image 마커를 인식해 특정 객체를 활성화하는 역할
  - Game Object > Vuforia Engine > Image Target

### 스크립트

### 기타

# 프로젝트 이외의 꿀팁

- **개발 시 필수 단축키**
  - Alt + 마우스 왼쪽 버튼 드래그 : 씬 뷰에 있는 가상의 중심점을 기준으로 회전한다.
  - Ctrl + Alt + 마우스 왼쪽 버튼 드래그 : 씬 뷰의 화면을 상하좌우로 이동한다.
  - 마우스 오른쪽 버튼을 클릭한 상태에서 마우스 움직임 : 씬의 시야각을 변경한다.
  - 마우스 오른쪽 버튼을 클릭한 상태에서 W, S, A, D 키 : 전진, 후진, 좌, 우로 이동한다.

* 게임 뷰에 있는 컨트롤 바에서 해상도를 선택하면 다양한 해상도로 볼 수 있음
  - ios, 안드로이드 플랫폼별 해상도 설정은 프로젝트를 해당 플랫폼으로 변경한 후에 적용할 수 있다. (File > Build Settings > 변경하려는 플랫폼 선택 > Switch Platform)
  * <span style="background-color: yellow; color: black;">플랫폼을 전환하는데 걸리는 시간은 프로젝트의 리소스 크기에 따라 결정되므로 가급적 프로젝트를 생성하고 나서 가장 먼저 플랫폼을 전환하고, 작업하는 편을 추천</span>
