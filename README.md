## 문화 공유 프로젝트

#### 크리에이터는 음악과 책을 추천할 수 있음
#### 구독자는 추천받은 음악으로 플레이리스트를 만들거나 책을 구매하고, 학원에 등록함
#### 크리에이터와 구독자는 관리자에게 문의할 수 있고 관리자는 응답할 수 있으며 공지사항을 작성할 수 있음
#### 개체에는 회원, 크리에이터, 구독자, 관리자, 음악, 책, 문의사항, 공지사항, 학원, 플레이리스트, 서점이 있음
#### 속성에는 설정, 구독, 작성, 응답, 추천, 등록, 구매가 있음

* 회원
   - 이름
   - 성별
   - 연락처
   - ID
   - PW
   - 생년월일
   - 나이

* 크리에이터
   - 이름
   - 성별
   - 연락처
   - ID(회원)
   - PW
   - 생년월일
   - 나이

* 구독자
   - 이름
   - 성별
   - 연락처
   - ID(회원)
   - PW
   - 생년월일
   - 나이

* 관리자
   - 이름
   - 성별
   - 연락처
   - ID
   - PW
   - 생년월일
   - 나이
   - 부서

* 음악 
   - 음악 번호
   - 노래 제목
   - 아티스트
   - 앨범
   - 발매일
   - 장르
   - 작곡
   - 작사
   - 편곡

* 책 
   - 책번호
   - 책제목
   - 분류
   - 저자
   - 출판
   - 출간
   - 평점
   - 가격
   - 할인율
   - 판매가

* 문의사항
   - 문의글번호
   - 문희사항제목
   - 문의유형
   - 문의내용
   - 등록일시
   - ID(크리에이터, 구독자)

* 공지사항
   - 공지글번호
   - 공지사항제목
   - 공지내용
   - 등록일시
   - ID(관리자)

* 학원
   - 학원번호
   - 학원명
   - 분류
   - 위치
   - 연락처
   - 수강생수
   - 선생님수
   - 총 인원수
   - ID(구독자)

* 플레이리스트
   - 플레이리스트번호
   - 플레이리스트제목
   - 설명
   - 총 곡 수
   - 총 플레이 시간
   - ID(구독자)




  

#### 요구 사항 명세서

1.	1.	프로그램에 회원으로 가입하려면 아이디, 비밀번호, 이름, 성별, 연락처, 생년월일, 나이를 입력해야 한다.
2.	회원은 아이디로 식별한다.
3.	한 명의 회원은 하나의 크리에이터나 구독자 계정으로 설정할 수 있다. (일대일 관계)
4.	크리에이터에 대한 아이디(회원), 비밀번호, 이름, 성별, 연락처, 생년월일, 나이를 입력해야 한다.
5.	구독자에 대한 아이디(회원), 비밀번호, 이름, 성별, 연락처, 생년월일, 나이를 입력해야 한다.
6.	구독자는 여러 크리에이터를 구독할 수 있고 한 명의 크리에이터는 여러 구독자와 관계를 맺을 수 있다. (다대다 관계) 
7.	구독자가 구독하면 구독에 대한 구독일자, 크리에이터ID, 구독자ID 정보를 유지해야 한다.
8.	음악에 대한 음악번호, 노래제목, 아티스트, 앨범, 발매일, 장르, 작곡, 작사, 편곡 정보를 유지해야 한다.
9.	책에 대한 책번호, 책제목, 분류, 저자, 출판, 출간, 평점, 가격, 할인율, 판매가격 정보를 유지해야 한다.
10.	음악, 책은 번호로 식별한다.
11.	크리에이터는 여러 음악, 책을 추천할 수 있고 하나의 음악, 책을 여러 크리에이터가 추천할 수 있다. (다대다 관계)
12.	크리에이터는 책과 음악을 추천하면 추천에 대한 아이디(크리에이터), 추천 번호, 추천 이유, 추천 점수, 추천 날짜 정보를 유지해야 한다. 
13.	플레이리스트에 대한 플레이리스트번호, 플레이리스트제목, 설명, 총 곡 수, 총 플레이 시간, ID(구독자) 정보를 유지해야 한다.
14.	학원에 대한 학원번호, 학원이름, 분류, 위치, 연락처, 수강생 수, 선생님 수, 총 인원 수, ID(구독자) 정보를 유지해야 한다.
15.	플레이리스트, 학원은 번호로 식별한다.
16.	구독자는 여러 학원에 등록할 수 있고 하나의 학원은 여러 구독자를 받을 수 있다. (다대다 관계)
17.	구독자가 학원에 등록하면 등록에 대한 등록자ID(구독자ID), 등록일자, 결제방식 정보를 유지해야 한다.
18.	한 명의 구독자가 여러 플레이리스트를 작성할 수 있지만 여러 명이 하나의 플레이리스트를 작성할 수 없다. (일대다 관계)
19.	구독자가 플레이리스트를 작성하면 작성에 대한 작성자ID(구독자ID), 작성 일자 정보를 유지해야 한다.
20.	관리자에 대한 이름, 성별, 연락처, ID, PW, 생년월일, 나이, 부서에 대한 정보를 유지해야 한다. 
21.	문의사항에 대한 문의글번호, 문의사항 제목, 문의 유형, 문의 내용, 등록일시, ID(크리에이터 혹은 구독자ID) 정보를 유지해야 한다.
22.	공지사항에 대한 공지글번호, 공지사항 제목, 공지 내용, 등록일시, ID(관리자) 정보를 유지해야 한다.
23.	관리자는 ID로 식별하고 문의사항과 공지사항은 번호로 식별한다.
24.	크리에이터는 여러 문의사항을 작성할 수 있지만 하나의 문의사항을 여러 크리에이터가 작성할 수 없다. (일대다 관계)
25.	구독자는 여러 문의사항을 작성할 수 있지만 하나의 문의사항을 여러 구독자가 작성할 수 없다. (일대다 관계)
26.	크리에이터, 구독자가 문의사항을 작성하면 작성에 대한 작성자ID(구독자 혹은 크리에이터ID), 작성 일자 정보를 유지해야 한다.
27.	관리자는 여러 문의사항에 응답할 수 있지만 하나의 문의사항을 여러 관리자가 응답할 수 없다. (일대다 관계)
28.	관리자가 문의사항에 응답하면 응답에 대한 문의글번호, 문의사항 제목, 문의 내용, 답변, 등록일시, ID(관리자) 정보를 유지해야 한다.
29.	관리자는 여러 공지사항을 작성할 수 있지만 하나의 공지사항을 여러 관리자가 작성할 수 없다. (일대다 관계)


