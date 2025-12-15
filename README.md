# 🎬 웹 미디어 플레이어 팀 프로젝트

   C# WinForms를 기반으로 한 데스크톱 미디어 스트리밍 플랫폼입니다. 사용자들은 동영상을 시청하고, 음악을 감상하며, 직접 콘텐츠를 업로드하여 다른 사람들과 공유할 수 있습니다.

<br>
# 🧑‍🤝‍🧑 팀원
이름               역할
강승진             데이터 베이스

# ✨ 주요 기능

   사용자 인증: 회원가입, 로그인, 아이디/비밀번호 찾기 기능

   미디어 스트리밍: 동영상 및 음악 실시간 재생 기능

   콘텐츠 관리: 사용자가 직접 동영상과 음악을 업로드하고 관리

   소셜 기능: 게시글에 댓글 작성 및 대댓글 기능, 사용자 간 채널 구독 기능

   사용자 맞춤: 마이페이지를 통한 개인 정보 수정 및 구독 등급 관리

   관리자 페이지: 관리자 전용 페이지에서 사용자 및 콘텐츠 통합 관리

# 🛋️ C# WinForms 가구 주문 키오스크 프로젝트

   📅 프로젝트 기간: 2025.07 ~ 2025.08


# ✨ 프로젝트 구조 
 <br>
📁 TpMain/ <br>
│ <br>
├── 📄 Program.cs <br>
├── 📄 TpMain.csproj <br>
│ <br>
├── 📁 Models/ <br>
│   ├── 📄 UserSession.cs <br>
│   └── 📄 VideoInfo.cs <br>
│ <br>
├── 📁 Properties/ <br>
│   └── 📄 AssemblyInfo.cs <br>
│ <br>
├── 📁 Resources/ <br>
│   └── ... (이미지, 아이콘 등 리소스 파일) <br>
│ <br>
├── 📁 Services/ <br>
│   └── 📄 Class1.cs (DB 연결 및 공통 함수) <br>
│ <br>
└── 📁 Views/ <br>
    │ <br>
    ├── 📁 00_Main/ <br>
    │   ├── 📄 MainForm1.cs <br>
    │   ├── 📄 VideoView.cs <br>
    │   └── 📄 MusicPlay.cs <br>
    │ <br>
    ├── 📁 01_User/ <br>
    │   ├── 📄 Login.cs <br>
    │   ├── 📄 NewMember.cs <br>
    │   ├── 📄 IDfnd.cs <br>
    │   ├── 📄 PWfind.cs <br>
    │   └── 📄 MyPage.cs <br>
    │ <br>
    ├── 📁 02_Content/ <br>
    │   ├── 📄 Upload.cs <br>
    │   └── 📄 UpSub.cs <br>
    │ <br>
    └── 📁 03_Admin/ <br>
        └── 📄 ManagerForm.cs <br>
         <br>
# 🛠️ 기술 스택 (Tech Stack)

Language: C#

Framework: .NET Framework

UI Platform: Windows Forms

DBMS : MySQL


# 순서도

![순서도](./picture/순서도.png)


# 테이블 구조
## EER다이어그램
![EER](./picture/eer.png)
## 🧑‍💻 Users 테이블 구조
![유저 데이터](./picture/user.png)
## 📺 Subscriptions 테이블 구조
![구독 데이터](./picture/subscription.png)
## 📝 Posts (게시글 정보) 테이블 구조(썸네일 픽쳐 추가 예정)
![게시글 데이터](./picture/post.png)
## 💬 Comments (댓글 정보) 테이블 구조
![댓글 데이터](./picture/comment.png)
## 🎶 Music (음악 정보) 테이블 구조
![음악 데이터](./picture/music.png)
## ⭐ Favorites (즐겨찾기) 테이블 구조
![즐찾 데이터](./picture/favorite.png) 

# 시연 영상
[![시연 영상 썸네일](./picture/main.png)](https://youtu.be/nmizB-60_aw)
