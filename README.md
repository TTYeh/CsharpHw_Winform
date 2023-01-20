# CsharpHw_Winform
## 目前做好的部分:
- hw01 helloworld(寫開心的)
- hw02 LoanMain(了解貸款公式是甚麼，ps微軟有現成公式)
- hw03 POS(練習LinQ)
- hw04 student(練習LinQ，熟習怎麼生Data放到dataGridView)
- hw10 圈圈叉叉(事件呼叫練習，思考矩陣，可以做但還是寫死了)
- hw13 小畫家(練習color函數)
- hw14 pictureviewer(了解form.owner可關)
- hw15 GuessNumber(了解form之間如何互傳資料 答form.owner傳資料)

## 跳過的題目
- hw05 應該要跟4整合的，有bug
- hw06 和hw05太像沒意義，增加個功能就加個winform，有bug
- hw07 太亂和太簡單
- hw08 計算機
- hw09 太亂和太簡單

## 可以做的
- hw11 螢幕保護程式?
- hw12 notepad程式


## 目前待解議題:
### 1. (已解決)讓子表單(winform)可以跟著主表單大小變動:
以下是解決方法:
參考this.splitContainer1.Panel2.Controls.Add(frm);
### 2. (想不出來)讓new一個新winform可以寫成function例如

          if (_hw06 == null || IsClosed("hw06_StudentGrade_List"))
            {
                CloseOtherSubForm();
                this.splitContainer1.Panel2.Controls.Clear();
                _hw06 = new hw06_StudentGrade_List();
                var frm = _hw06;
                frm.Name = "hw06_StudentGrade_List";
                frm.Owner = this;
                frm.TopLevel = false;
                frm.Show();
                this.splitContainer1.Panel2.Controls.Add(frm);
            }

### 3. (已解決)不曉得為何我的winform一直轉圈圈好像在跑什麼?
以下是解決方法:
Form的UseWaitCursor屬性設定為true，就強制cursor只能是waiting狀態。改成false解決。
### 4. (已解決)hw14要做介面主表單叫出的多個子表單，當主表單關閉，大量的子表單要一起關閉，想用介面ISubPanel實作但失敗QQ
以下是解決方法:

            // MainPanel的按下事件發生後執行方法，將subPanel的showdDialog方法加進去
            newPictureBox.Click += delegate (Object ssender, EventArgs EE)
            {
                hw14_PictureSubPanel sub = new hw14_PictureSubPanel(ImageList[number]);
                sub.Owner= this; // 解決主表單關閉，子表單跟著關閉的問題
                var sub1 = sub as ISubPanel;
                //subpanels.Append(sub1);
                sub.Show();
            };
            
感謝AllenKuo大大提供好解法^^

