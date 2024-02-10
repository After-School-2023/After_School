# After School; 3D choorigame
2023 Winter MadCamp Final Project

## Outline
<img src="https://github.com/After-School-2023/MadCamp_Week4/assets/113894257/e5f0e4e8-7e2c-4cc8-8478-b02a90f96df2" width="200"></img>

<br/>

**방과후; 3D 추리게임**은 일본의 유명 소설가 히가시노 게이고의 데뷔작 [방과후]를 원작으로 하고 있는 unity로 구현한 3D 추리게임입니다. 단서를 획득해 밀실의 비밀을 알아내고 범인을 찾아내세요!

<br/>

## Team
**나지연**  <a href="https://github.com/najiyeon" target="_blank"><img src="https://img.shields.io/badge/GitHub-181717?style=flat-square&logo=github&logoColor=white"></a>

**박강태** <a href="https://github.com/ParkGangtae" target="_blank"><img src="https://img.shields.io/badge/GitHub-181717?style=flat-square&logo=github&logoColor=white"></a>

<br/>

## Tech Stack
Unity (C#)

<br/>

## Story
### Scene1

목표: 사건현장 발견하기

- Main Camera를 1인칭 시점으로 구현
- 손만 보이게 설정 후 애니메이션 추가

<img src="https://github.com/After-School-2023/MadCamp_Week4/assets/113894257/f9b5ba11-eee5-4e0c-b4df-c473fcb76d41" width="700"></img>

- AI Navigation을 이용해 player를 따라다니는 npc 구현

<img src="https://github.com/After-School-2023/MadCamp_Week4/assets/113894257/c739cc12-9d2e-469d-a906-631e8a0289dd" width="700"></img>

- RaycastHit을 이용해 물체와 상호작용하는 기능 구현

<img src="https://github.com/After-School-2023/MadCamp_Week4/assets/113894257/2576ab1f-a41a-4362-9360-db429826b608" width="700"></img>

- 애니메이션으로 문을 부수는 장면 구현

<img src="https://github.com/After-School-2023/MadCamp_Week4/assets/113894257/aca293de-dc50-4b89-a7b3-fb419a11be98" width="700"></img>

- 시체를 발견하면 다음 scene으로 전환

### Scene2

목표: 단서 5개 수집하기

- 1인칭 시점

<img src="https://github.com/After-School-2023/MadCamp_Week4/assets/113894257/05ad5da0-c80a-4adb-b193-878ee73aa370" width="700"></img>

- AI Navigation을 이용해 맵을 랜덤으로 돌아다니는 npc 구현

<img src="https://github.com/After-School-2023/MadCamp_Week4/assets/113894257/be2d2359-e936-4ec6-bf65-e521dcab2aaf" width="700"></img>

- 단서로 보이는 object에 화면을 갖다 대면 “press <E>”라는 문구 표시

<img src="https://github.com/After-School-2023/MadCamp_Week4/assets/113894257/c88f16f5-452d-43f7-af18-e1e0864ed83f" width="700"></img>

- 단서를 획득하면 C키를 눌러서 획득한 단서 확인

<img src="https://github.com/After-School-2023/MadCamp_Week4/assets/113894257/5ae7be51-1a53-4e4b-975a-1051c25afe4d" width="700"></img>

- 단서 5개를 찾으면 다음 scene으로 전환

### Scene3

- npc와의 대화를 통해 추리

<img src="https://github.com/After-School-2023/MadCamp_Week4/assets/113894257/71c06e43-d20b-40a3-8a2c-2f8f6cb85e1a" width="700"></img>

