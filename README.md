# Bowling Game
We are starting a bowling club. To help with the club, we have engaged you to program a scoring system.

The features on the system are:

* One player only
* In each frame, the bowler has 2 tries to knock down all the pins
* If in 2 tries, the bowler fails to knock down all the pins, their score is the sum of the number of pins they've knocked down in the 2 attempts

E.g, if a bowler rolls, 4,4

Their score is 8.

* If in 2 tries, the bowler knocks down all the pins, it is a spare. The scoring of a spare is the sum of the number of pins knocked down plus the number of pins knocked down in the next bowl.

E.g, if a bowler rolls, 4,6 |  5, 0

Their score is 20. So that's (4 + 6 + 5) + (5 + 0)

* If in one try, the bowler knocks down all the pins, it is a strike. The scoring of a strike is the sum of the number of pins knocked down plus the number of pins knocked down in the next two bowls.

E.g, if a bowler rolls, 10 | 5, 4

Their score is 28. So that's (10 + 5 + 4) + ( 5 + 4)

* There are 10 pins in a frame
* There are 10 frames in a match
* Don't worry about validating the number of rolls in a frame

The interface should look like this (in .net);


```.net
bowlingGame.roll(noOfPins);
bowlingGame.score();
```

OPTIONAL
--------

If time permits implement the rules for the last frame (i.e, 10th frame)

* In the last frame, if the bowler bowls a spare, they get another bowl. The score of this frame is the sum of the three bowls.
* In the last frame, if the bowler bowls a strike, they get another 2 bowls. The score of this frame is the sum of the three bowls
* If one has a strike for every roll, their score is 300

Notes on implementation:

- use **.Net or .Net Core**
- try not to spend more than 2 hours maximum. (We don't want you to lose a weekend over this!)
- don't build guis etc, we're more interested in your approach to solving the given task, not how shiny it looks
- don't worry about making a command line interface to the application
- don't use any external NuGet Packages (unless it's for testing or build/dependency injection)
# How to math score
### Cách tính điểm chơi Bowling
- Trò chơi Bowling có một vài cách tính điểm khác nhau. Sau đây mình sẽ đưa ra cách tính theo bowling phổ thông nhất. Trong đó:

- Số điểm mà bạn đạt được trong 1 frame sẽ = tổng số pin (đánh đổ) + điểm thưởng nếu bạn đạt được khi Strike (đánh đổ toàn bộ 10pin) hoặc Spare ở lượt ném trước đó.

- Trường hợp điểm (1frame) =0, đồng nghĩa với việc bạn đã ném banh ra rãnh 2 bên.

- Cụ thể cách tính điểm Bowling như sau
Open frame: là khi mà  sau các cú ném vẫn còn một vài quân Ki chưa bị hạ. Nếu người chơi có một  Open frame, số điểm bạn nhận được bằng chính số quân Ki bị  hạ.

- Strike:: Là khi bạn làm đổ tất cả các quân Ki trong lần ném đầu tiên của lượt. Ghi trên phiếu bằng chữ "X". Người chơi sẽ được thưởng 10 điểm, cộng thêm với điểm thưởng bằng số điểm sẽ đạt được ở frame tiếp theo với 2 lần ném. Có nghĩa là, số điểm của 2 lần ném ở frame tiếp theo sẽ được tính 2 lần.

### Ví dụ:

- Frame 1, lần ném thứ nhất: 10 pins (Strike).

- Frame 2, lần ném thứ nhất: 3 pins

- Frame 2, lần ném thứ hai: 6 pins

- Tổng số điểm đạt được sẽ là: 10 + (3+6) + 3 + 6 = 28



- Nếu được 2 quả Strike liên tiếp sẽ gọi là “Double” .Ba Strike liên tiếp gọi là “Turkey”. Nếu ném được nhiều Strike hơn, người ta sẽ dùng hậu tố “bagger” + số quả Strike ném được, ví dụ, như “four-bagger” (4 Strike liên tiếp – 4 in a row) hay “five-bagger” (5 strike liên tiếp – 5 in a row.

- Spare: là khi bạn hạ được tất cả các quân Ki ở lần ném thứ hai của lượt. Kí hiệu là /

#### Đạt được Spare sẽ được thưởng 10 điểm cộng với điểm thưởng bằng số điểm bất kỳ ghi được ở lần ném tiếp theo (Chỉ tính lần ném đầu tiên)

### Ví dụ:

- Frame 1, lần ném thứ nhất: 7 pins

- Frame 1, lần ném thứ hai: 3 pins (Spare)

- Frame 2, lần ném thứ nhất: 4 pins

- rame 2, lần ném thứ hai: 2 pins

 ### => Tổng điểm đạt được sẽ là : 7 + 3 + 4(điểm thưởng) + 4 + 2 = 20

- Khi đạt Spare ở frame cuối cùng, người chơi sẽ được thêm một lần ném để có thể đạt điểm thưởng.

##### Điểm tối đa có thể ghi được là 300 điểm. tương đương với 12 lần Strike liên tiếp trong 12 lượt. Lí do có 12 lượt là vì nếu người chơi đạt được Strike ở lượt cuối cùng, người chơi sẽ được thêm 1 lần ném nữa. Nếu chỉ đạt được. Nếu chỉ đạt Spare thì chỉ được 1 lần ném.
# Demo


https://github.com/Dthai16gg/Bowling-Game/assets/88380128/4843e367-9aaa-419a-87a6-4bee387f25a6

