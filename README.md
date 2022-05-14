## 문화 공유 프로젝트

#### 사용자가 음악, 영화, 책 등을 자유롭게 추천 하는 기능이 있음
#### 크게 회원과 음악, 영화, 책, 추천 list 로 구분

* 회원
   - 이름
   - 성별
   - 연락처
   - ID
   - PW

* 음악 
   - 노래 제목
   - MusicNum
   - 앨범
   - 아티스트

* 영화 
   - 제목
   - MovieNum
   - 장르
   - 국적
   - 시간
   - 년도

* 책 
   - 제목
   - BookNum
   - 분류

* 추천
   - 회원.ID
   - Num
   - 추천 수
   - 추천 날짜


#### 요구 사항 명세서

1.	프로그램에 <u>사용자</u> 로 가입하려면 아이디, 비밀번호, 이름, 성별, 연락처를 입력해야 한다.
1.	사용자는 아이디로 식별한다.
3.	음악에 대한 넘버, 제목, 앨범명, 아티스트, 발매일, 장르, 작곡, 작사, 편곡 정보를 유지해야 한다.
4.	영화에 대한 넘버, 제목, 개봉일, 등급, 장르, 국가, 러닝타임, 배급 정보를 유지해야 한다.
5.	책에 대한 넘버, 제목, 분류, 저자, 출판, 출간, 평점, 리뷰 정보를 유지해야 한다.
6.	사용자는 여러 음악, 영화, 책을 추천할 수 있고 하나의 음악, 영화, 책을 여러 사용자가 추천할 수 있다. 
7.	사용자가 음악, 영화, 책을 추천하면 추천에 대한 추천 넘버, 추천 수, 추천 날짜 정보를 유지해야 한다.
8.	사용자는 게시글을 여러 개 작성할 수 있고, 게시글 하나는 한 명의 회원만 작성할 수 있다.
9.	게시글에 대한 글 넘버, 글 제목, 글 내용, 작성일자 정보를 유지해야 한다.
10.	게시글은 글 넘버로 식별한다.


