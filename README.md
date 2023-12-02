# DBP_MessengerApp


| 작품 이름 | 개발기간 | 엔진 | 개발인원 | 장르 |
| --- | --- | --- | --- | --- |
| 윈폼톡 | 2022.11 | 윈폼 / C# | 6명 | 사내 채팅 프로그램 |

- 2022년 2학기 팀 프로젝트입니다.
- Framwork : WinformC#
- Database : MySQL
- Chatting : TCP/IP Socket
- Media (이모티콘, 사진, 파일) : FTP

---

### 구현 기능

1. 회원 가입 기능
2. 회원 정보 변경 기능
3. 로그인 기능
4. 대화 상대 관리 기능 (부서 별, 검색, 즐겨찾기 등)
5. 1:1 채팅 기능
6. 진행중인 대화 목록 리스트
7. 관리자 기능
8. 이모티콘, 사진, 파일 기능

---

### DB 구조

![ChatDB](https://github.com/Falcon5077/DBP_MessengerApp/assets/32628758/43a7a359-7b98-4cc5-ba6a-3c840a9fe52b)


---

### 채팅 알림

새로운 채팅이 올 때까지 소켓스레드가 대기합니다.

스레드로 돌아가고 있는 리스닝, 다른 클라이언트가 보낸 메세지 알림을 수신합니다.

```csharp
private void connectThread()
{
    while (true)
    {
        // 데이터를 수신한다.
        var data = new byte[1024];
        conn_socket.Receive(data, data.Length, SocketFlags.None);

        // 새로온 톡 그리기 호출
        ChatForm.BeginInvoke(new Action(() => ChatForm.instance.ChatLoad()));
        ChatForm.BeginInvoke(new Action(() => ChatForm.RecieveMsg()));

        MessageBox.Show("메세지가 왔습니다.");
    }
}
```

---

### 사진 전송

```csharp
private void SendPhotoBtnClick(object sender, EventArgs e)
{
  // 사진 전송 스트림에 새로 연결합니다.
  Client.GetInstance().PhotoConnect();
  
  string time = ConfigManager.GetInstance().GetTimeNow();
  string newFileName =  time + ".jpg";
  
  // 메세지를 DB에 저장
  Query.GetInstance().RunQuery("INSERT INTO `talk`.`ChatMsg` (`room_ID`, `sender_ID`, `recv_ID`, `data`,`send_time`,`isImg`) " +
      "VALUES ('" + roomID + "', '" + myID + "', '" + yourID + "', '" + newFileName + "','" + time + "','1');");
  
  // TCP를 통해 수신자에게 알림
  SendToSignal();
  
  // 파일 이름 먼저 전송
  var data = Encoding.UTF8.GetBytes(newFileName);
  Client.GetInstance().SendByte(data);
  
  // 파일 스트림으로 서버에 사진 전송
  using (FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read))
  {
      byte[] buf = new byte[1024];
      int c;
      while ((c = fs.Read(buf, 0, buf.Length)) > 0)
      {
          Client.GetInstance().SendByte(buf);
      }
  }
  
  // 메세지를 폼에 등록 및 초기화
  Message msg = SendJpg(chatId, newFileName, time);
  
  // 소켓 종료
  Client.GetInstance().PhotoClose();
}
```

---


<img width="671" alt="TodoList_1" src="https://github.com/EunBinee/DBP_MessengerApp/assets/32628758/85907def-3d60-4957-b22d-5cb1bae71a80">
<img width="698" alt="TodoList_2" src="https://github.com/EunBinee/DBP_MessengerApp/assets/32628758/d5cf0c5c-d321-4287-9022-780f4ad911e5">
<img width="703" alt="TodoList_3" src="https://github.com/EunBinee/DBP_MessengerApp/assets/32628758/a1ee1113-9937-45b1-95ea-20551fc5d0f2">
